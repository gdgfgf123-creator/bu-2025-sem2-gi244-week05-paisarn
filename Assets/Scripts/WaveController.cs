using UnityEngine;

public class WaveController : MonoBehaviour
{
    public Transform[] spawnPoints;

    public Wave wave;
    private int spawnedEnemies = 0;
    private float nextSpawnTime = 0;
    public void ChangeWave(Wave wave)
    {
        this.wave = wave;
    }
    public bool IsCompleted()
    {
        return spawnedEnemies >= wave.enemyCout;
    }
    void Update()
    {
        float t = Time.time;

        if (spawnedEnemies < wave.enemyCout && t > nextSpawnTime)
        {
            Spawn();
            spawnedEnemies++;
            nextSpawnTime =t+wave.spawnInterval;
        }
    }
    void Spawn()
    {
        int enemyIndex = Random.Range(0 , wave.enemyPrefabs.Length);
        int pointIndex = Random.Range(0 , spawnPoints.Length);

        var prefad = wave.enemyPrefabs[enemyIndex];
        var point = spawnPoints[pointIndex];
        Instantiate(prefad,
            point.position,
            Quaternion.Euler(0,180,0)
            );
    }
}
