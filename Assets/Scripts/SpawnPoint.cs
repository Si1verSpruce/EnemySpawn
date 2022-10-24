using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject _creature;

    public void Spawn()
    {
        Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y + _creature.transform.localScale.y, transform.position.z);

        Instantiate(_creature, spawnPosition, Quaternion.identity);
    }
}
