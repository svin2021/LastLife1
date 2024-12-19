using UnityEngine;
using UnityEngine.Tilemaps;

public class SectorMode : MonoBehaviour
{
    public bool Enable;
    public bool Solid;
    private Tilemap color;
    private void Start()
    {
        color = GetComponent<Tilemap>();
    }
    public void ChangeSectorMode()
    {
        Enable = false;
        Solid = true;

        color.color = Color.red;
    }
}
