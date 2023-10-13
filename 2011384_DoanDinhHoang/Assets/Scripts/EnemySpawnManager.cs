using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject _enemyToSpawn;

    public float _spawnDelay = 1.0f;

    float _nextSpawnTime = -1.0f;

    void Update()
    {
        if (Time.time >= _nextSpawnTime)
        {
            Vector3 edgeOfScreen = new Vector3(1.0f, 0.5f, 8.0f);
            Vector3 placeToSpawn = Camera.main.ViewportToWorldPoint(edgeOfScreen);
            Quaternion directionToFace = Quaternion.identity;
            Instantiate(_enemyToSpawn, placeToSpawn,directionToFace);
            _nextSpawnTime = Time.time + _spawnDelay;
        }
    }

}



