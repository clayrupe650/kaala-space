﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMove : MonoBehaviour
{

    public Rigidbody body;

    // Start is called before the first frame update
    //void Start()
    //{
    //    body.AddForce(Random.Range(-10000.0f, 10000.0f), Random.Range(-10000.0f, 10000.0f), Random.Range(0.0f, -100000.0f));
    //}

    void OnBecameInvisible()
    {
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        gameObject.SetActive(false);
    }

}
