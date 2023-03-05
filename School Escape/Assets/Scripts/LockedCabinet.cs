using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using TMPro;

public class LockedCabinet : MonoBehaviour
{
    int[] combo = new int[4];
    [SerializeField] string combination;
    [SerializeField] AudioSource audioS;
    [SerializeField] AudioClip lockedDoor;
    [SerializeField] TMP_Text[] numbers;
    [SerializeField] Animator anim;

    public void CheckCombination()
    {
        int[] answerArr = Array.ConvertAll(combination.ToCharArray(), c => (int)Char.GetNumericValue(c));
        for (int i = 0; i < 4; i++)
        {
            if (combo[i] != answerArr[i])
            {
                audioS.PlayOneShot(lockedDoor);
                return;
            }
        }
        //OPEN CABINET
        anim.SetTrigger("OpenCabinet");
    }

    public void IncrementNumber(int index)
    {
        combo[index] = combo[index] + 1 > 9 ? 0 : combo[index] + 1;
        numbers[index].text = combo[index].ToString();
    }

}
