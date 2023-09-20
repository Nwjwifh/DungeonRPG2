using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class ItemSlot : MonoBehaviour, IPointerClickHandler
{
    private string itemName;
    private Sprite itemSprite;
    private string itemDescription;
    public bool isFull;

    [SerializeField] private Image itemImage;
    [SerializeField] private GameObject selectedSlot;
    [SerializeField] private bool isSelected;

    [SerializeField] private Image itemDescriptionImage;
    [SerializeField] private TMP_Text itemDescriptionNameText;
    [SerializeField] private TMP_Text itemDescriptionText;

    public void AddItem(string itemName, Sprite itemSprite, string itemDescription)
    {
        this.itemName = itemName;
        this.itemSprite = itemSprite;
        this.itemDescription = itemDescription;
        isFull = true;

        itemImage.sprite = itemSprite;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            InventoryManager.instance.DeselectAllItemSlots();
            selectedSlot.SetActive(true);
            isSelected = true;
            itemDescriptionNameText.text = itemName;
            itemDescriptionText.text = itemDescription;
            itemDescriptionImage.sprite = itemSprite;
        }
    }

    public void DeselectSlot()
    {
        selectedSlot.SetActive(false);
        isSelected = false;
    }
}
