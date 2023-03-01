using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public bool Locked;
    [SerializeField] InventoryItem Item;
    private void OnMouseDown()
    {
        if (Locked)
            return;
        InventoryManager.Instance.AddItem(Item);
    }

    public void Unlock()
    {
        Locked = false;
    }

    public void Lock()
    {
        Locked = true;
    }

    public void ToggleLock()
    {
        Locked = !Locked;
    }
}
