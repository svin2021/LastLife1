using UnityEngine;

public class GridSize : MonoBehaviour
{
    public GameObject grid;
    void Start()
    {
        Debug.Log(grid.GetComponent<Renderer>().bounds.size);
        Debug.Log(GetComponent<Renderer>().bounds.size);
    }
}
