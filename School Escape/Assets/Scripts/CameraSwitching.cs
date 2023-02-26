using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitching : MonoBehaviour
{
    int noClick = 0;
    int noClickzoom = 0;
    public GameObject[] cameras;
    public GameObject[] zoom;
    
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

            noClick--;

            if ((noClick) < 0)
            {
                noClick = cameras.Length - 1;
            }

            cameras[noClick].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            zoom[noClickzoom].SetActive(false);

            noClickzoom++;

            if ((noClickzoom) >= cameras.Length)
            {
                noClickzoom = 0;
            }

            zoom[noClickzoom].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            zoom[noClickzoom].SetActive(false);

            noClickzoom--;

            if ((noClick) < 0)
            {
                noClickzoom = cameras.Length - 1;
            }

            zoom[noClickzoom].SetActive(true);
        }
    }
}
