using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lunchbox : MonoBehaviour
{
    Animator anim;
    bool open = false;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void ToggleLunchbox()
    {
        open = !open;
        if (open)
        {
            anim.SetTrigger("OpenBox");
        }
        else
        {
            anim.SetTrigger("CloseBox");
        }
        
    }
}
