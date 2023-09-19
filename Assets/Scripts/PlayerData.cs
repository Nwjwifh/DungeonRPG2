using System;

[Serializable]
public class PlayerData
{
    public string playerName;
    public int playerLevel;
    public string playerClass;
    public int health;
    public int attackDamage;
    public int defense;

    public PlayerData(string name, int level, string playerClass, int health, int attackDamage, int defense)
    {
        this.playerName = name;
        this.playerLevel = level;
        this.playerClass = playerClass;
        this.health = health;
        this.attackDamage = attackDamage;
        this.defense = defense;
    }
}
