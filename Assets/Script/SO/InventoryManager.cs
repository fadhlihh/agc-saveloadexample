using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private List<Inventory> _inventory;

    private void Start()
    {
        LoadData();
    }

    public void LoadData()
    {
        InventoryList inventoryList = Resources.Load<InventoryList>("InventoryList");
        _inventory = inventoryList.Inventory;
        Debug.Log(_inventory[0].InventoryType);
    }
}
