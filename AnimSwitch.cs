using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSwitch : MonoBehaviour
{
    public Animator anim;
    [Range(0, 2)]
    public int currentAnim = 0;
    [Range(0f, 10f)]
    public float speed = 1f;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) currentAnim--;
        if(Input.GetKeyDown(KeyCode.D)) currentAnim++;
        if(Input.GetKeyDown(KeyCode.Z)) speed *= 0.9f;
        if(Input.GetKeyDown(KeyCode.X)) speed *= 1.1f;
        anim.speed = speed;
        if(currentAnim == 3) currentAnim = 0;
        if(currentAnim == -1) currentAnim = 2;
        if(currentAnim == 0) anim.Play("Dancing Twerk");
        if(currentAnim == 1) anim.Play("Hip Hop Dancing");
        if(currentAnim == 2) anim.Play("Zombie Scream");
        Debug.Log(currentAnim);
    }
}
