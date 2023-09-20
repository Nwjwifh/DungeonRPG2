using UnityEngine;

[CreateAssetMenu(fileName = "Item Info", menuName = "SO/Item")]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public ItemType itemType;

    public int itemDamage;
    public int itemArmor;

    public Sprite itemImage;

    public enum ItemType
    {
        Weapon,
        Armor,
        Consumable
    }
}
