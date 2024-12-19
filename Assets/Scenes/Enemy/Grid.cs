using UnityEngine;

public class Grid : MonoBehaviour
{
    public int GridScale = 2;
    public bool CanMove = true;

    [SerializeField] ApproveButton approveButton;
    private void OnMouseDrag()
    {
        if (CanMove)
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(MousePos);

            transform.position = new Vector3((float)(int)(MousePos.x * GridScale) / GridScale, (float)(int)(MousePos.y * GridScale) / GridScale, 0);
            Debug.Log(new Vector3((float)(int)(MousePos.x * GridScale) / GridScale, (float)(int)(MousePos.y * GridScale) / GridScale, 0));
        }
    }
}
