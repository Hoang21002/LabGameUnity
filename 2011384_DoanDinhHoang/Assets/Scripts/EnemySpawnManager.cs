using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject _enemyToSpawn;

    public float _spawnDelay = 4.0f;

    float _nextSpawnTime = -1.0f;

    void Update()
    {
        if (Time.time >= _nextSpawnTime)
        {
            Vector3 edgeOfScreen = new Vector3(6.0f, 4.5f, 4.0f);
            Vector3 placeToSpawn = Camera.main.ViewportToWorldPoint(edgeOfScreen);
            Quaternion directionToFace = Quaternion.identity;
            Instantiate(_enemyToSpawn, placeToSpawn,directionToFace);
            _nextSpawnTime = Time.time + _spawnDelay;
        }
    }

}