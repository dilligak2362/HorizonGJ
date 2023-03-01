using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Placement : MonoBehaviour
{
    [SerializeField] Item Item;
    [SerializeField] bool HasBeenPlaced = false;
    [SerializeField] PlacementEvent OnPlace;
    [SerializeField] bool CanRemove = false;
    [SerializeField] PlacementEvent OnRemove;
    [System.Serializable] public class PlacementEvent : UnityEvent { }

    private void OnMouseDown()
    {
        if (HasBeenPlaced && CanRemove)
        {
            PickupItem();
        }
        else if (!HasBeenPlaced)
        {
            PlaceItem();
        }
    }

    private void PlaceItem()
    {
        // If nothing is selected, return
        if (InventoryManager.Instance.GetActiveSlot() == null)
            return;

        if (InventoryManager.Instance.GetActiveSlot().Item == Item)
        {
            OnPlace.Invoke();
            InventoryManager.Instance.RemoveItem(Item);
            HasBeenPlaced = true;
        }
    }

    private void PickupItem()
    {
        InventoryManager.Instance.AddItem(Item);
        OnRemove.Invoke();
        HasBeenPlaced = false;
    }
}
