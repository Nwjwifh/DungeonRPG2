using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private string itemName;
    [SerializeField] private Sprite itemSprite;
    [SerializeField] private string itemDescription;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            InventoryManager.instance.AddItemToInventory(itemName, itemSprite, itemDescription);
            Destroy(gameObject);
        }
    }
}
