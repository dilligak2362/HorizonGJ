using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    public bool OneTimeUse = false;
    public bool Locked = false;
    bool hasBeenUsed = false;
    [SerializeField] TriggerEvent OnTrigger;
    [System.Serializable] public class TriggerEvent : UnityEvent { }

    public void OnMouseDown()
    {
        if (Locked)
            return;
        if (OneTimeUse && hasBeenUsed)
            return;

        OnTrigger.Invoke();
        hasBeenUsed = true;
    }

    public void Lock()
    {
        Locked = true;
    }

    public void Unlock()
    {
        Locked = false;
    }

    public void ToggleLock()
    {
        Locked = !Locked;
    }

}
