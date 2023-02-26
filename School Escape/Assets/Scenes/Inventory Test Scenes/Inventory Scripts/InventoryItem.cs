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

public class InventoryItem : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text numberText;
    public int itemNum = 0;
    public string itemName = "unnamed";

    //public int itemID

    // Start is called before the first frame update
    void Start()
    {
        UpdateText();
        gameObject.SetActive(false);
    }

    // Called when the item is inspected (probably will pull up a larger sprite in the UI)
    void Inspect()
    {

    }

    // Called when the item is used
    void UseItem()
    {

    }

    // Called when the item is removed from the inventory
    public void RemoveItem()
    {
        gameObject.SetActive(false);
    }

    // Updates the textboxes to mimmic the name and number fields
    public void UpdateText()
    {
        nameText.text = itemName;
        numberText.text = itemNum.ToString();
    }
}
