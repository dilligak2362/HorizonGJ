using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chalkboard : MonoBehaviour
{
    [SerializeField] GameObject[] highlights = new GameObject[4];

    public void RevealLetters()
    {
        foreach (GameObject go in highlights)
        {
            go.SetActive(true);
        }
    }
}
