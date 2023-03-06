using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remote : MonoBehaviour
{
    [SerializeField] Trigger remoteTrigger;
    [SerializeField] GameObject[] batteries;
    [SerializeField] GameObject remoteLight;
    [SerializeField] Material onLight;
    [SerializeField] Chalkboard chalkboard;
    int batCount = 0;
    public void AddBattery()
    {
        batCount++;
        for (int i = 0; i < batCount; i++)
        {
            if (i > batteries.Length) continue;
            batteries[i].SetActive(true);
        }
        if (batCount >= 2)
        {
            remoteTrigger.Unlock();
        }
    }

    public void TurnOn()
    {
        remoteLight.GetComponent<MeshRenderer>().material = onLight;
        chalkboard.RevealLetters();
    }
}
