using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerJumpForce : MonoBehaviour
{
    [SerializeField] Vector3 v3Force;
    [SerializeField] KeyCode keyJump;
    [SerializeField] private LayerMask layerCollide;
    [SerializeField] private Transform transformCheckGrounded;
    private bool boolJump;

    void Update()
    {
        if (Input.GetKeyDown(keyJump))
            boolJump = true;
    }
    private void FixedUpdate()
    { 
        if (boolJump && Physics.OverlapSphere(transformCheckGrounded.position, 0.3f, layerCollide).Length != 0)
            GetComponent<Rigidbody>().AddForce(v3Force, ForceMode.VelocityChange);
            boolJump = false;
    }
}