using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class ItemSlot : MonoBehaviour, IPointerClickHandler
{
    private ItemSO itemData;
    public bool isFull;
    private bool isEquipped = false;

    [SerializeField] private Image itemImage;
    [SerializeField] private GameObject selectedSlot;
    [SerializeField] private GameObject equippedImage;
    [SerializeField] private bool isSelected;

    [SerializeField] private Image itemDescriptionImage;
    [SerializeField] private TMP_Text itemDescriptionNameText;
    [SerializeField] private TMP_Text itemDescriptionText;

    public void AddItem(ItemSO itemData)
    {
        this.itemData = itemData;
        isEquipped = false;
        isFull = true;

        itemImage.sprite = itemData.itemImage;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (itemData != null)
            {
                selectedSlot.SetActive(true);
                isSelected = true;
                itemDescriptionNameText.text = itemData.itemName;
                itemDescriptionText.text = itemData.itemDescription;
                itemDescriptionImage.sprite = itemData.itemImage;
            }
        }
        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (itemData != null)
            {
                ToggleItemEquip();
            }
        }
    }

    public void ToggleItemEquip()
    {
        isEquipped = !isEquipped;

        if (isEquipped)
        {
            PlayerStatsController.instance.EquipItem(itemData);
            equippedImage.SetActive(true);
        }
        else
        {
            PlayerStatsController.instance.UnequipItem(itemData);
            equippedImage.SetActive(false);
        }
    }
}
