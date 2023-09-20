using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject statusPanel;
    public GameObject inventoryPanel;

    public Button statusButton;
    public Button inventoryButton;

    private void Start()
    {
        statusButton.onClick.AddListener(ShowStatusPanel);
        inventoryButton.onClick.AddListener(ShowInventoryPanel);
    }

    void ShowStatusPanel()
    {
        statusPanel.SetActive(true);
        inventoryPanel.SetActive(false);
    }

    void ShowInventoryPanel()
    {
        statusPanel.SetActive(false);
        inventoryPanel.SetActive(true);
    }
}
