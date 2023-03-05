using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitching : MonoBehaviour
{
    int index = 0;
    public GameObject[] cameras;


    private void Start()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            if (i == index) continue;
            cameras[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            cameras[index].SetActive(false);

            index++;

            if ((index) >= cameras.Length)
            {
                index = 0;
            }

            cameras[index].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            cameras[index].SetActive(false);

            index--;

            if ((index) < 0)
            {
                index = cameras.Length - 1;
            }

            cameras[index].SetActive(true);
        }
    }
}
