using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remote : MonoBehaviour
{
    [SerializeField] Trigger remoteTrigger;
    int batCount = 0;
    public void AddBattery()
    {
        batCount++;
        if (batCount >= 2)
        {
            remoteTrigger.Unlock();
        }
    }

    
}
