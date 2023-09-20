using UnityEngine;
using TMPro;

public class PlayerStatsUI : MonoBehaviour
{
    public TMP_Text playerNameText;
    public TMP_Text playerLevelText;
    public TMP_Text playerGoldText;
    public TMP_Text playerAttackText;
    public TMP_Text playerDefenseText;
    public TMP_Text playerMaxHPText;
    public TMP_Text playerMaxMPText;
    public TMP_Text playerMaxSPText;
    public TMP_Text playerLuckText;

    public PlayerSO playerData;
    
    private void Update()
    {
        UpdatePlayerStatsUI();
    }

    void UpdatePlayerStatsUI()
    {
        playerNameText.text = playerData.playerName;
        playerLevelText.text = "LV. " + playerData.level.ToString();
        playerGoldText.text = playerData.gold.ToString();
        playerAttackText.text = "ATK: " + playerData.atk.ToString();
        playerDefenseText.text = "DEF: " + playerData.def.ToString();
        playerMaxHPText.text = "HP: " + playerData.maxHP.ToString();
        playerMaxMPText.text = "MP: " + playerData.maxMP.ToString();
        playerMaxSPText.text = "SP: " + playerData.maxSP.ToString();
        playerLuckText.text = "LUK: " + playerData.luk.ToString();
    }
}
