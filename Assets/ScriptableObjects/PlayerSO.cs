using UnityEngine;

[CreateAssetMenu(fileName = "Player Info", menuName = "SO/Player")]
public class PlayerSO : ScriptableObject
{
    [Header("Basic Info")]
    public string playerName;
    public int level;
    public int gold;

    [Header("Stats Info")]
    public int atk;
    public int def;
    public int maxHP;
    public int maxMP;
    public int maxSP;
    public int luk;
}