using UnityEngine;

public class Grid : MonoBehaviour
{
    public bool CanMove = true;

    [SerializeField] ApproveButton approveButton;
    private bool Hold = false;
    private void OnMouseDrag()
    {
        if (CanMove)
        {
            Hold = true;
        }
    }
    private void OnMouseUp()
    {
        Hold = false;
    }
    private void FixedUpdate()
    {
        if(Hold)
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            transform.position = new Vector3(Mathf.Round(MousePos.x), Mathf.Round(MousePos.y), 0);
        }
    }
}
