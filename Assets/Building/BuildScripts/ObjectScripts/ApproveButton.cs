using UnityEngine;

public class ApproveButton : MonoBehaviour
{
    private Grid move;
    private Transform ParentObj;
    private void Start()
    {
        ParentObj = transform.parent.parent;
        move = transform.parent.GetComponentInParent<Grid>();
    }
    private void OnMouseDown()
    {
        int xScale = (int)ParentObj.GetComponent<Renderer>().bounds.size.x;//Amount of cells that object takes

        RaycastHit2D[] hitArray = new RaycastHit2D[xScale];//List of cells that object takes
        RaycastHit2D solidObj = FindGridObject(Physics2D.RaycastAll(new Vector2(ParentObj.position.x, ParentObj.position.y - 1), new Vector2(0, 0)));//Cell beneath the object

        if (solidObj.transform.GetComponent<SectorMode>().Solid)
        {
            for (int i = 0; i < xScale; i++)//Going throught all cells that object takes
            {
                if (FindGridObject(Physics2D.RaycastAll(new Vector2(ParentObj.position.x - xScale / 2 + i, ParentObj.position.y), new Vector2(0, 0))).transform.GetComponent<SectorMode>().Enable)
                {
                    hitArray[i] = FindGridObject(Physics2D.RaycastAll(new Vector2(ParentObj.position.x - xScale / 2 + i, ParentObj.position.y), new Vector2(0, 0)));
                    hitArray[i].transform.GetComponent<SectorMode>().ChangeSectorMode();

                    if(i == xScale - 1)//Actually placing object
                    {
                        move.CanMove = false;
                        transform.parent.parent.GetComponent<Grid>().enabled = false;
                        transform.parent.gameObject.SetActive(false);
                    }
                    continue;
                }
                break;
            }
        }
    }
    private RaycastHit2D FindGridObject(RaycastHit2D[] hitArray)
    {
        foreach(RaycastHit2D hit in hitArray)
        {
            if(hit.transform.parent != null && hit.transform.parent.tag == "Grid")
            {
                return hit;
            }
        }
        throw new System.NullReferenceException("Луч не попадает ни на один сектор сетки");
    }
}
