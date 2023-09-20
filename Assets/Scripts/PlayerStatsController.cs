using UnityEngine;

public class PlayerStatsController : MonoBehaviour
{
    [SerializeField] private PlayerSO playerData;
    private int originalAtk;

    public static PlayerStatsController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        originalAtk = playerData.atk;
    }

    public void EquipItem(ItemSO item)
    {
        if (item.itemType == ItemSO.ItemType.Weapon)
        {
            playerData.atk += item.itemDamage;
        }
    }

    public void UnequipItem(ItemSO item)
    {
        if (item.itemType == ItemSO.ItemType.Weapon)
        {
            playerData.atk -= item.itemDamage;
        }
    }
}
