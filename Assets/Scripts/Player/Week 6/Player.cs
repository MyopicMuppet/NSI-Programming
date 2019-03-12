using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    #region Key Variables for the player
    //health, level, exp, mana, stamina, position, name, customisation
    public int level;
    public new string name;
    public float maxHealth, curHealth;
    public HealthBar health;
    #endregion

    public void SaveFunction()
    {
        maxHealth = health.maxHealth;
        curHealth = health.curHealth;
        Save.SaveData(this);
    }


    public void LoadData()
    {
        Data data = Save.LoadData();
        level = data.level;
        name = data.playerName;
        curHealth = data.curHP;
        health.curHealth = curHealth;
        maxHealth = data.maxHP;
        health.maxHealth = maxHealth;


      
    }

    private void Awake()
    {
        LoadData();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F12))
        {
            SaveFunction();
        }
    }
}
