using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitching : MonoBehaviour
{
    int noClick = 0;
    public GameObject[] cameras;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            cameras[noClick].SetActive(false);

            noClick++;

            if ((noClick) >= cameras.Length)
            {
                noClick = 0;
            }

            cameras[noClick].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            cameras[noClick].SetActive(false);

            noClick++;

            if ((noClick) >= -cameras.Length)
            {
                noClick = 0;
            }

            cameras[noClick].SetActive(true);
        }
    }
}
