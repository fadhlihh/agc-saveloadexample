using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField]
    private GameObject _cube;

    private void Start()
    {
        Destroy(_cube);
    }
}
