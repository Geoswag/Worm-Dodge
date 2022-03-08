using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormMoveSpin : MonoBehaviour
{
    [SerializeField] float floatRotation;

    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = new Vector3(0, floatRotation, 0);
    }
}
