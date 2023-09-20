using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class UIManager : MonoBehaviour
{
    [SerializeField] private List<Button> buttons;
    [SerializeField] private List<GameObject> panels;

    private Dictionary<Button, GameObject> buttonToPanel = new Dictionary<Button, GameObject>();

    private void Start()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            Button button = buttons[i];
            GameObject panel = panels[i];

            buttonToPanel.Add(button, panel);

            panel.SetActive(false);
            button.onClick.AddListener(() => OnButtonClick(button));
        }

        OnButtonClick(buttons[0]);
    }

    private void OnButtonClick(Button clickedButton)
    {
        foreach (var pair in buttonToPanel)
        {
            Button button = pair.Key;
            GameObject panel = pair.Value;

            panel.SetActive(button == clickedButton);
        }
    }
}
