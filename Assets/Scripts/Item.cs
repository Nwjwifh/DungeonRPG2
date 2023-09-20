using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private ItemSO itemData;

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.CompareTag("Player"))
        {
            InventoryManager.instance.AddItemToInventory(itemData);
            Destroy(gameObject);
        }
    }
}
