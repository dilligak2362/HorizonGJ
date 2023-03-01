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
    [SerializeField] Item Item;
    public bool Locked;
    public bool DestroyOnPickup = true;

    private void OnMouseDown()
    {
        if (Locked)
            return;
        InventoryManager.Instance.AddItem(Item);
        if (DestroyOnPickup)
            gameObject.SetActive(false);
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
