/*
 * Created by: Krieger
 * Created on: 2/25/2023
 * 
 * Description: Manages the inventory UI, holds a list of items stored in the inventory UI
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public InventoryItem activeItem;

    public List<InventoryItem> items;

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

    // Start is called before the first frame update
    void Start()
    {
        CheckManagerIsInScene();
        items = new List<InventoryItem>();
    }

    // Adds a new item to the list
    public void AddItem(InventoryItem i)
    {
        if(items.Contains(i))
        {
            return;
        }

        items.Add(i);
        GameObject iGO = i.gameObject;
        iGO.SetActive(true);
        Vector3 rectPos = iGO.GetComponent<RectTransform>().position;
        rectPos.x = 120 * (items.Count-1);
        iGO.GetComponent<RectTransform>().position = rectPos;
        i.itemNum = items.Count;
    }

    // Removes an item from the list
    public void RemoveItem(InventoryItem i)
    {
        int index = items.IndexOf(i);
        if(index == -1)
        {
            return;
        }

        // Remove the item
        items.Remove(i);
        i.RemoveItem();

        // Adjust the remaining inventory items
        for(int x = index; x < items.Count; x++)
        {
            Vector3 pos = items[x].GetComponent<RectTransform>().position;
            pos.x -= 120;
            items[x].GetComponent<RectTransform>().position = pos;

            items[x].itemNum--;
            items[x].UpdateText();
        }
    }

    // Removes an item at an index

    // Activates an item from the list from an index
    public void SetActiveItem(int index)
    {
        if(index < items.Count)
        {
            activeItem = items[index];
        }
        else
        {
            activeItem = null;
        }
    }
}
