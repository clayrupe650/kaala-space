﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardForce = 200f;
    public float sidewaysForce = 50f;
    public float upwardsForce = 50f;
    public float acceleration = 4f;
    private Quaternion target, pitch;

    private float activeForwardsSpeed, activeStrafeSpeed, activeHoverSpeed;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        activeForwardsSpeed = Mathf.Lerp(activeForwardsSpeed, forwardForce, acceleration * Time.deltaTime);
        activeStrafeSpeed = Mathf.Lerp(activeStrafeSpeed, Input.GetAxisRaw("Horizontal") * sidewaysForce, acceleration * Time.deltaTime);
        activeHoverSpeed = Mathf.Lerp(activeHoverSpeed, Input.GetAxisRaw("Vertical") * upwardsForce, acceleration * Time.deltaTime);

        target = Quaternion.Euler(0, 0, -Input.GetAxisRaw("Horizontal") * 90);
        pitch = Quaternion.Euler(-Input.GetAxisRaw("Vertical") * 90, 0, 0);

        transform.rotation = Quaternion.Lerp(transform.rotation, target, acceleration * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, pitch, acceleration * Time.deltaTime);


        transform.position += transform.forward * activeForwardsSpeed * Time.deltaTime;
        transform.position += (Vector3.right * activeStrafeSpeed * Time.deltaTime);
        transform.position += (Vector3.up * activeHoverSpeed * Time.deltaTime);
    }

    public float zPosition()
    {
        return transform.position.z;
    }
}
