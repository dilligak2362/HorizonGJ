/*
 * Created by: Krieger
 * Created on: 2/25/2023
 * 
 * Description: Manages the inventory UI, holds a list of items stored in the inventory UI
 * 
 * Edited by: Coleton
 * Edited on: 3/1/2023
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public InventorySlot activeItem;

    // HARD CODED INVENTORY SIZE = BAD. BUT QUICK AND EASY!! :D ~Coleton
    public List<Item> items;
    public List<GameObject> UIItems;

    #region InventoryManager Singleton
    static private InventoryManager instance;
    static public InventoryManager Instance { get { return instance; } }

    void CheckManagerIsInScene()
    {

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    #endregion

    void Start()
    {
        CheckManagerIsInScene();
        AdjustInventory();
    }

    // Adds a new item to the list
    public void AddItem(Item i)
    {
        // HARD CODED GARBAGE YAY ~Coleton
        if (items.Count == 5)
            return;
        items.Add(i);
        AdjustInventory();
    }

    // Removes an item from the list
    public void RemoveItem(Item i)
    {
        if (!items.Contains(i))
        {
            return;
        }
        items.Remove(i);
        AdjustInventory();
    }

    // Adjust the inventory items
    void AdjustInventory()
    {
        int index = 0;

        // Disable all inactive inventory slots
        for (int i = 5 - items.Count; i < 5; i++)
        {
            Debug.Log(i);
            UIItems[i].SetActive(false);
        }

        // Enable and update all inventory slots that are in use
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] == null)
                continue;
            UIItems[index].SetActive(true);
            UIItems[index].GetComponent<InventorySlot>().SetItem(items[i]);
            index++;
        }
    }

    // Activates an item from the list from an index
    //public void SetActiveItem(int index)
    //{
    //    if(index < UIItems.Count)
    //    {
    //        activeItem = UIItems[index];
    //    }
    //    else
    //    {
    //        activeItem = null;
    //    }
    //}
}
