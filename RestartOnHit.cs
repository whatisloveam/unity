using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnHit : MonoBehaviour
{
    public string tag;
    void OnCollisionEnter(Collision col)
    {
        if(col.collider.tag == tag)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
