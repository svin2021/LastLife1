using UnityEngine;
using System.Collections.Generic;

public class Wave
{
    public GameObject MiliObj;
    public GameObject RangerObj;
    public int Mili;
    public int Ranger;

    private List<GameObject> EnemyPool = new List<GameObject>();
    public Wave(int MiliCount, int RangerCount, GameObject MiliObj, GameObject RangerObj)
    {
        Mili = MiliCount;
        Ranger = RangerCount;
        this.MiliObj = MiliObj;
        this.RangerObj = RangerObj;
    }
    public void Initialise()
    {
        // —юда писать пор€док спавна врагов во врме€ волны и.т.п.
        for (int i = 0;i<Mili;i++)
        {
            EnemyPool.Add(Object.Instantiate(MiliObj, new Vector3(0, -4, 0), Quaternion.Euler(0, 0, 0)));
        }

        for (int i = 0; i < Ranger; i++)
        {
            EnemyPool.Add(Object.Instantiate(RangerObj, new Vector3(0, -4, 0), Quaternion.Euler(0, 0, 0)));
        }
    }
    public void Spawn(int i)
    {
        if(i < EnemyPool.Count)
            EnemyPool[i].SetActive(true);
    }

    public override string ToString()
    {
        return string.Format("Mili: {0}, Ranger: {1}, {2}, {3}",Mili,Ranger, MiliObj,RangerObj);
    }
}
    
public class EnemySpawner : MonoBehaviour
{
    Wave[] waves = new Wave[3];
    [SerializeField] public GameObject MiliObj;
    [SerializeField] public GameObject RangerObj;
    void InitialiseWaves()
    {
        //TODO: Ќаписать логику на бесконечные раунды
        waves[0] = new Wave(1, 2, MiliObj, RangerObj);
        waves[1] = new Wave(2, 3, MiliObj, RangerObj);
        waves[2] = new Wave(3, 4, MiliObj, RangerObj);
    }
    void Start()
    {   
        InitialiseWaves();
        waves[0].Initialise();
        InvokeRepeating("Spawn", 1, 1);
        for (int i = 0; i < 3; i++)
        {
            
            //Debug.Log(waves[i].ToString());
        }
    }
    int i = 0;
    void Spawn()
    {
        waves[0].Spawn(i);
        i++;
    }
}
