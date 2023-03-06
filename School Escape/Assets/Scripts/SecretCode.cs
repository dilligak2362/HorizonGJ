using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SecretCode : MonoBehaviour
{
    char[] sequence = new char[4];
    public string correctSequence;
    [SerializeField] TMP_Text[] chars = new TMP_Text[4];


    private void Start()
    {
        for (int i = 0; i < sequence.Length; i++)
        {
            sequence[i] = 'A';
        }
    }

    public void IncrementChar(int index)
    {
        sequence[index]++;
        if (sequence[index] > 71)
        {
            sequence[index] = 'A';
        }
        chars[index].text = sequence[index].ToString();
        CheckSolution();
    }

    public void CheckSolution()
    {
        for (int i = 0; i < 4; i++)
        {
            if (sequence[i] != correctSequence.ToCharArray()[i])
            {
                return;
            }
        }
        SceneManager.LoadScene(1);
    }

}
