using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHamster : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] GameObject celery;

    public void FeedHamster()
    {
        anim.SetTrigger("Move");
        celery.SetActive(true);
    }
}
