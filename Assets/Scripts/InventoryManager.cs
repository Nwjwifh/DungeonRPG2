using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private bool isMenuActive;

    [SerializeField] private GameObject menu;
    [SerializeField] private ItemSlot[] itemSlots;

    public static InventoryManager instance;

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

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu(!isMenuActive);
        }
    }

    public void AddItemToInventory(ItemSO itemData)
    {
        for (int i = 0; i < itemSlots.Length; i++)
        {
            if (itemSlots[i].isFull == false)
            {
                itemSlots[i].AddItem(itemData);
                return;
            }
        }
    }

    private void ToggleMenu(bool showMenu)
    {
        menu.SetActive(showMenu);
        isMenuActive = showMenu;
    }
}
