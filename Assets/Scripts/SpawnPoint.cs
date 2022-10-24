using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Creature _spawningCreature;

    public void Spawn()
    {
        Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y + _spawningCreature.transform.localScale.y, transform.position.z);

        Instantiate(_spawningCreature, spawnPosition, Quaternion.identity);
    }
}
