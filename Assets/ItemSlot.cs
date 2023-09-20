using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public Image iconImage; // 슬롯에 아이템 이미지를 표시하는 UI 이미지
    public Text itemNameText; // 슬롯에 아이템 이름을 표시하는 UI 텍스트

    private ItemSO item; // 슬롯에 있는 아이템 정보

    public void AddItem(ItemSO newItem)
    {
        item = newItem;
        iconImage.sprite = newItem.icon; // 아이템의 아이콘을 UI 이미지에 설정
        itemNameText.text = newItem.itemName; // 아이템 이름을 UI 텍스트에 설정
    }

    public void ClearSlot()
    {
        item = null;
        iconImage.sprite = null;
        itemNameText.text = "";
    }
}
