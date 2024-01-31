using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0f,0.3f,0f);
    }
    void OnTriggerEnter(Collider col)
    {
        Destroy(this.gameObject);
    }
}
