using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelOnHit : MonoBehaviour
{
    public string tag;
    public string sceneName;
    void OnCollisionEnter(Collision col)
    {
        if(col.collider.tag == tag)
            SceneManager.LoadScene(sceneName);
    }
}
