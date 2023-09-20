using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public Image iconImage; // ���Կ� ������ �̹����� ǥ���ϴ� UI �̹���
    public Text itemNameText; // ���Կ� ������ �̸��� ǥ���ϴ� UI �ؽ�Ʈ

    private ItemSO item; // ���Կ� �ִ� ������ ����

    public void AddItem(ItemSO newItem)
    {
        item = newItem;
        iconImage.sprite = newItem.icon; // �������� �������� UI �̹����� ����
        itemNameText.text = newItem.itemName; // ������ �̸��� UI �ؽ�Ʈ�� ����
    }

    public void ClearSlot()
    {
        item = null;
        iconImage.sprite = null;
        itemNameText.text = "";
    }
}
