using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAxis : MonoBehaviour
{
    public KeyCode k_pos;
    public KeyCode k_neg;
    public Vector3 force;
    void Update()
    {
        if(Input.GetKey(k_pos))
            GetComponent<Rigidbody>().velocity += force;
        if(Input.GetKey(k_neg))
            GetComponent<Rigidbody>().velocity -= force;
    }
}
