using UnityEngine;

[CreateAssetMenu(fileName = "Item Info", menuName = "SO/Item")]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public ItemType itemType;
    public int itemValue;

    public enum ItemType
    {
        Weapon,
        Armor,
        Consumable
    }
}
