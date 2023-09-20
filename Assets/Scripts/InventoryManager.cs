using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject inventoryMenu;
    private bool isMenuActive;

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
            ToggleInventoryMenu(!isMenuActive);
        }
    }

    public void AddItemToInventory(string itemName, Sprite itemSprite, string itemDescription)
    {
        for (int i = 0; i < itemSlots.Length; i++)
        {
            if (itemSlots[i].isFull == false)
            {
                itemSlots[i].AddItem(itemName, itemSprite, itemDescription);
                return;
            }
        }
    }

    public void DeselectAllItemSlots()
    {
        for (int i = 0; i < itemSlots.Length; i++)
        {
            itemSlots[i].DeselectSlot();
        }
    }

    private void ToggleInventoryMenu(bool showMenu)
    {
        inventoryMenu.SetActive(showMenu);
        isMenuActive = showMenu;
    }
}
