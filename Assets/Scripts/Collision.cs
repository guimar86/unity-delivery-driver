using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Car collision");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Trigger car collision");
    }
}
