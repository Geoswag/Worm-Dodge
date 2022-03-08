using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceOnTouch : MonoBehaviour
{
    [SerializeField] string strTag;
    public static bool boolBounced;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
            boolBounced = true;
    }
}

