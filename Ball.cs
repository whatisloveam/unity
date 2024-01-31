using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal"); //<-->
        float vAxis = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(hAxis, 0f, vAxis);
        GetComponent<Rigidbody>().AddForce(move * 80f);
    }
}
