using UnityEngine;

public enum InventoryType
{
    Consumable,
    Weapon,
    Armor
}

[CreateAssetMenu(fileName = "Inventory", menuName = "Inventory", order = 2)]
public class Inventory : ScriptableObject
{
    public int ID;
    public string Name;
    public InventoryType InventoryType;
}
