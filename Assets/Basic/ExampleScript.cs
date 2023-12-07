using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _cube;
    [SerializeField]
    private Transform cubeTransform;

    private void Start()
    {
        cubeTransform.position = new Vector3(2, 5, 1);
        cubeTransform.rotation = Quaternion.Euler(45, 0, 0);
        cubeTransform.localScale = new Vector3(2, 3, 4);
        Debug.Log(cubeTransform.localScale);
    }
}
