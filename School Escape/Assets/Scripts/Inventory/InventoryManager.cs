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
    public InventorySlot ActiveSlot;
    public List<Item> Items;
    public List<GameObject> Slots;

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
        if (Items.Count == 5)
            return;
        Items.Add(i);
        AdjustInventory();
    }

    // Removes an item from the list
    public void RemoveItem(Item i)
    {
        if (!Items.Contains(i))
        {
            return;
        }
        ActiveSlot = null;
        Items.Remove(i);
        AdjustInventory();
    }

    // Adjust the inventory items
    void AdjustInventory()
    {
        // Disable all inactive inventory slots
        for (int i = Items.Count; i < 5; i++)
        {
            Slots[i].SetActive(false);
        }
        
        // Enable and update all inventory slots that are in use
        int index = 0;
        for (int i = 0; i < Items.Count; i++)
        {
            if (Items[i] == null)
                continue;
            Slots[index].SetActive(true);
            Slots[index].GetComponent<InventorySlot>().SetItem(Items[i]);
            index++;
        }
    }

    public InventorySlot GetActiveSlot()
    {
        return ActiveSlot;
    }

    public void SetActiveSlot(InventorySlot slot)
    {
        if (ActiveSlot == slot)
        {
            ActiveSlot = null;
        }
        else
        {
            ActiveSlot = slot;
        }

        foreach (GameObject o in Slots) {
            if (o.activeSelf == false)
                continue;
            InventorySlot s = o.GetComponent<InventorySlot>();
            if (s == ActiveSlot)
            {
                s.HighlightItem(true);
            }
            else
            {
                s.HighlightItem(false);
            }
        }
    }
}
