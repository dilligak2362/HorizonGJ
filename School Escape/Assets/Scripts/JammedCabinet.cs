using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JammedCabinet : MonoBehaviour
{
    [SerializeField] AudioClip jammedOpen;
    [SerializeField] AudioClip unjam;
    [SerializeField] AudioSource cabinetSource;
    [SerializeField] Animator anim;
    bool jammed;
    bool open;

    private void Start()
    {
        jammed = true;
        open = false;
    }
    public void TryToOpen()
    {
        if (jammed)
        {
            cabinetSource.PlayOneShot(jammedOpen);
        }
        else if (!open)
        {
            open = true;
            anim.SetTrigger("OpenCabinet");
        }
    }

    public void Unjam()
    {
        jammed = false;
        cabinetSource.PlayOneShot(unjam);
    }
}
