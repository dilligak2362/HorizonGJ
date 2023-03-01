/*
 * Created by: Krieger
 * Created on: 2/25/2023
 * 
 * Description: Holds information for an item added to the inventory
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySlot : MonoBehaviour
{
    public TMP_Text nameText;
    public Image Image;
    public Item Item;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Called when the item is inspected (probably will pull up a larger sprite in the UI)
    void Inspect()
    {

    }

    // Apply new item to this inventory slot
    public void SetItem(Item i)
    {
        Item = i;
        nameText.text = i.Name;
        Image.sprite = i.Sprite;
    }

    public void HighlightItem(bool Highlight)
    {

    }
    public void OnClick()
    {
        InventoryManager.Instance.SetActiveSlot(this);
    }
}
