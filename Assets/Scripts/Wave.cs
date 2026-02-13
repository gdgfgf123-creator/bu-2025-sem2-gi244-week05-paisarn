using System;
using UnityEngine;

[Serializable]
public class Wave
{
    public GameObject[] enemyPrefabs;
    public int enemyCout;
    public float spawnInterval = 1f; 
    public float waveInterval= 5f ;
}