using UnityEngine;

public class GridSize : MonoBehaviour
{
    public GameObject grid;
    void Start()
    {
        //Getting actual size of smth only for debuging
        Debug.Log(grid.GetComponent<Renderer>().bounds.size);
        Debug.Log(GetComponent<Renderer>().bounds.size);
    }
}
