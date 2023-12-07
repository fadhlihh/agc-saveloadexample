using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _cube;
    [SerializeField]
    private List<Transform> _spawnPosition = new List<Transform>();

    private void Start()
    {
        int index = Random.Range(0, _spawnPosition.Count);
        Vector3 spawnPosition = _spawnPosition[index].position;
        Instantiate(_cube, spawnPosition, Quaternion.Euler(0, 0, 0));
    }
}
