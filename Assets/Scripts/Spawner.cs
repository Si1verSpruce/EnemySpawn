using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _spawnInterval;
    [SerializeField] private bool _isSpawning;

    private SpawnPoint[] _spawnPoints;

    private void Awake()
    {
        _spawnPoints = GetComponentsInChildren<SpawnPoint>();

        StartCoroutine(SpawnAtInterval());
    }

    private IEnumerator SpawnAtInterval()
    {
        while (_isSpawning)
        {
            var waitForSeconds = new WaitForSeconds(_spawnInterval);

            foreach (SpawnPoint spawnPoint in _spawnPoints)
            {
                yield return waitForSeconds;

                spawnPoint.Spawn();
            }
        }
    }
}
