using UnityEngine;
  
public class EnemySpawner : MonoBehaviour
{
    Wave[] waves = new Wave[3];
    [SerializeField] public GameObject MiliObj;
    [SerializeField] public GameObject RangerObj;

    private int CurentlyWaveNumber = 0;
    private int CurrentlyEnemy = 0;
    void InitialiseWaves()
    {
        //TODO: Infinity waves
        //Waves structure: new Wave(FirstType amount, SecondType amount, FirstType, SecondType);
        waves[0] = new Wave(1, 2, MiliObj, RangerObj);
        waves[1] = new Wave(2, 3, MiliObj, RangerObj);
        waves[2] = new Wave(3, 4, MiliObj, RangerObj);
    }
    void Start()
    {
        InitialiseWaves();

        waves[0].Initialise();//pre-create enemies

        SpawnWave();
    }
    private void SpawnWave()
    {
        InvokeRepeating("Spawn", 1, 1);
    }
    private void Spawn()
    {
        if (CurrentlyEnemy == waves[CurentlyWaveNumber].EnemyPool.Count - 1)
            CancelInvoke();

        waves[CurentlyWaveNumber].EnemyPool[CurrentlyEnemy].SetActive(true);
        CurrentlyEnemy++;
    }
}
