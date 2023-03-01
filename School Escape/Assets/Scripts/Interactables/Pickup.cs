/*
 * Created by: Coleton
 * Created on: 2/25/2023
 * 
 * Description: Allows picking up an item from the word and storing it in the inventory
 * 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public bool Locked;
    [SerializeField] Item Item;
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
