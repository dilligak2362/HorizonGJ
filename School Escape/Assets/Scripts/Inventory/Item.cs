/*
 * Created by: Coleton
 * Created on: 3/1/2023
 * 
 * Description: Item data for inventory system
 * 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Asset/Item")]
public class Item : ScriptableObject
{
    public string Name;
    public Sprite Sprite;
}
