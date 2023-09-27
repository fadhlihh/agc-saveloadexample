using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryList", menuName = "Inventory List", order = 1)]
public class InventoryList : ScriptableObject
{
    public List<Inventory> Inventory;
}
