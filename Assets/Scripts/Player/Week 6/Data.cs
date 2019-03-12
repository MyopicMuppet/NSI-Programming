using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data 
{
    public int level;
    public string playerName;
    public float curHP, maxHP;
    public float health;

    public Data (Player player)
    {
        level = player.level;
        playerName = player.name;
        maxHP = player.maxHealth;
        curHP = player.curHealth; 
    }

    
    



}
