using System.Collections.Generic;
using UnityEngine;

public class Wave
{
    public GameObject MiliObj;
    public GameObject RangerObj;
    public int Mili;
    public int Ranger;

    public List<GameObject> EnemyPool = new List<GameObject>();

    public Wave(int MiliCount, int RangerCount, GameObject MiliObj, GameObject RangerObj)
    {
        this.Mili = MiliCount;
        this.Ranger = RangerCount;
        this.MiliObj = MiliObj;
        this.RangerObj = RangerObj;
    }
    public void Initialise()
    {
        //Pre-Creating enemies
        for (int i = 0; i < Mili; i++)
        {
            EnemyPool.Add(Object.Instantiate(MiliObj, new Vector3(0, -4, 0), Quaternion.Euler(0, 0, 0)));
        }

        for (int i = 0; i < Ranger; i++)
        {
            EnemyPool.Add(Object.Instantiate(RangerObj, new Vector3(0, -4, 0), Quaternion.Euler(0, 0, 0)));
        }
    }

    public override string ToString()
    {
        return string.Format("Mili: {0}, Ranger: {1}, {2}, {3}", Mili, Ranger, MiliObj, RangerObj);
    }
}
