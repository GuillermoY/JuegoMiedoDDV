using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveL : MonoBehaviour
{
    [SerializeField] float vel = 20;
    [SerializeField] float leftLimit = -10;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * vel);
    }
}
