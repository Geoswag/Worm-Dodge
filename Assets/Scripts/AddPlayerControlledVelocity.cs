using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//OLD MOVEMENT, CURRENTLY UNUSED

public class AddPlayerControlledVelocity : MonoBehaviour
{
    [SerializeField] Vector3 v3Force;
    [SerializeField] Vector3 v3ForceMax;
    [SerializeField] Vector3 v3BoostForce;
    [SerializeField] Vector3 v3BounceForce;
    [SerializeField] KeyCode keyPositive;
    [SerializeField] KeyCode keyNegative;
    private Rigidbody playerBody;

    // Start is called before the first frame update

    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
        Time.timeScale = 1f;
    }
    // Update is called once per physics update
    void FixedUpdate()
    {
        if (BoostonTouch.boolBoosted)
            playerBody.velocity = v3BoostForce;
        BoostonTouch.boolBoosted = false;

        if (BounceOnTouch.boolBounced)
            playerBody.velocity += v3BounceForce;
        BounceOnTouch.boolBounced = false;

        if (playerBody.velocity.x < v3ForceMax.x && playerBody.velocity.z < v3ForceMax.z)
            if (Input.GetKey(keyPositive))
                playerBody.velocity += v3Force;

            if (Input.GetKey(keyNegative))
                playerBody.velocity -= v3Force;
    }
}
