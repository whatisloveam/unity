using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnKey : MonoBehaviour
{
    public KeyCode restartKey;
    void Update()
    {
        if(Input.GetKey(restartKey))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
