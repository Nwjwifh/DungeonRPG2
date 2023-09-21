using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class PlayerStatsUI : MonoBehaviour
{
    public List<TMP_Text> statTexts;
    public PlayerSO playerData;

    private void Update()
    {
        UpdatePlayerStatsUI();
    }

    void UpdatePlayerStatsUI()
    {
        if (statTexts.Count == 0)
        {
            return;
        }

        statTexts[0].text = playerData.playerName;
        statTexts[1].text = "LV. " + playerData.level.ToString();
        statTexts[2].text = playerData.gold.ToString();
        statTexts[3].text = "ATK: " + playerData.atk.ToString();
        statTexts[4].text = "DEF: " + playerData.def.ToString();
        statTexts[5].text = "HP: " + playerData.maxHP.ToString();
        statTexts[6].text = "MP: " + playerData.maxMP.ToString();
        statTexts[7].text = "SP: " + playerData.maxSP.ToString();
        statTexts[8].text = "LUK: " + playerData.luk.ToString();
    }
}
