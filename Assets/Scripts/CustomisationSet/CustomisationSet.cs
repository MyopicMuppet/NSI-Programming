﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//you will need to change Scenes
public class CustomisationSet : MonoBehaviour
{

    #region Variables
    [Header("Texture List")]
    //Texture2D List for skin,hair, mouth, eyes
    public List<Texture2D> skin = new List<Texture2D>();
    public List<Texture2D> hair = new List<Texture2D>();
    public List<Texture2D> mouth = new List<Texture2D>();
    public List<Texture2D> eyes = new List<Texture2D>();
    public List<Texture2D> armour = new List<Texture2D>();
    public List<Texture2D> clothes = new List<Texture2D>();
    [Header("Index")]
    //index numbers for our current skin, hair, mouth, eyes textures
    public int skinIndex;
    public int hairIndex, mouthIndex, eyeIndex, armourIndex, clothesIndex;
    [Header("Renderer")]
    //renderer for our character mesh so we can reference a material list
    public Renderer character;
    [Header("Max Index")]
    //max amount of skin, hair, mouth, eyes textures that our lists are filling with
    public int skinMax;
    public int hairMax, mouthMax, eyeMax, armourMax, clothesMax;
    [Header("Character Name")]
    //name of our character that the user is making
    public string charName = "Adventurer";
    [Header("Stats")]
    //class

    public string[] statArray = new string[6];
    public int[] stats = new int[6];
    public int[] tempStats = new int[6];
    public int points = 10;

    public CharacterClass characterClass = CharacterClass.Barbarian;
    public string[] selectedClass = new string[8];
    public int selectedIndex = 0;
    public string[] statName;
    public int[] statData;
    #endregion


    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        statArray = new string[] { "Strength", "Dexterity", "Constitution", "Wisdom", "Intelligence", "Charisma" };
        selectedClass = new string[] { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard", };



        #region for loop to pull textures from file
        //for loop looping from 0 to less than the max amount of skin textures we need
        for (int i = 0; i < skinMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Skin_#
            Texture2D temp = Resources.Load("Character/Skin_" + i.ToString()) as Texture2D;
            //add our temp texture that we just found to the skin List
            skin.Add(temp);
        }

        for (int i = 0; i < hairMax; i++)
        {

            Texture2D temp = Resources.Load("Character/Hair_" + i.ToString()) as Texture2D;

            hair.Add(temp);
        }

        for (int i = 0; i < eyeMax; i++)
        {

            Texture2D temp = Resources.Load("Character/Eyes_" + i.ToString()) as Texture2D;

            eyes.Add(temp);
        }

        for (int i = 0; i < mouthMax; i++)
        {

            Texture2D temp = Resources.Load("Character/Mouth_" + i.ToString()) as Texture2D;

            mouth.Add(temp);
        }

        for (int i = 0; i < clothesMax; i++)
        {

            Texture2D temp = Resources.Load("Character/Clothes_" + i.ToString()) as Texture2D;

            clothes.Add(temp);
        }

        for (int i = 0; i < armourMax; i++)
        {

            Texture2D temp = Resources.Load("Character/Armour_" + i.ToString()) as Texture2D;

            armour.Add(temp);
        }


        #endregion
        character = GameObject.Find("Mesh").GetComponent<SkinnedMeshRenderer>();
        SetTexture("Skin", skinIndex = 0);
        SetTexture("Eyes", eyeIndex = 0);
        SetTexture("Hair", hairIndex = 0);
        SetTexture("Armour", armourIndex = 0);
        SetTexture("Mouth", mouthIndex = 0);
        SetTexture("Clothes", clothesIndex = 0);

        ChooseClass(selectedIndex);


    }




    #region SetTexture

    void SetTexture(string type, int dir)
    {
        int index = 0, max = 0, matIndex = 0;
        Texture2D[] textures = new Texture2D[0];

        #region Switch Material

        switch (type)
        {
            case "Skin":
                index = skinIndex;
                max = skinMax;
                textures = skin.ToArray();
                matIndex = 1;
                break;

            case "Eyes":
                index = eyeIndex;
                max = eyeMax;
                textures = eyes.ToArray();
                matIndex = 2;
                break;

            case "Hair":
                index = hairIndex;
                max = hairMax;
                textures = hair.ToArray();
                matIndex = 3;
                break;

            case "Armour":
                index = armourIndex;
                max = armourMax;
                textures = armour.ToArray();
                matIndex = 4;
                break;

            case "Mouth":
                index = mouthIndex;
                max = mouthMax;
                textures = mouth.ToArray();
                matIndex = 5;
                break;

            case "Clothes":
                index = clothesIndex;
                max = clothesMax;
                textures = clothes.ToArray();
                matIndex = 6;
                break;
        }



        #endregion

        index += dir;
        if (index < 0)
        {
            index = max - 1;
        }

        if (index > max - 1)
        {
            index = 0;
        }
        #region OutSide Switch
        Material[] mat = character.materials;
        mat[matIndex].mainTexture = textures[index];
        character.materials = mat;
        #endregion
        #region Set Material Switch
        switch (type)
        {
            case "Skin":
                skinIndex = index;
                break;

            case "Eyes":
                eyeIndex = index;
                break;

            case "Hair":
                hairIndex = index;
                break;

            case "Armour":
                armourIndex = index;
                break;

            case "Mouth":
                mouthIndex = index;
                break;

            case "Clothes":
                clothesIndex = index;
                break;
        }

        #endregion


    }


    #endregion

    #region Save
    void Save()
    {
        SaveSystem.SavePlayer(this);
    }
    #endregion

    #region OnGUI
    private void OnGUI()
    {
        float scrW = Screen.width / 16;
        float scrH = Screen.height / 9;

        int i = 0;
        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            SetTexture("Skin", -1);
        }
        GUI.Box(new Rect(0.75f * scrW, scrH + i * (0.5f * scrH), 1f * scrW, 0.5f * scrH), "Skin");
        if (GUI.Button(new Rect(1.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), ">"))
        {
            SetTexture("Skin", 1);
        }
        i++;

        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            SetTexture("Eyes", -1);
        }
        GUI.Box(new Rect(0.75f * scrW, scrH + i * (0.5f * scrH), 1f * scrW, 0.5f * scrH), "Eyes");
        if (GUI.Button(new Rect(1.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), ">"))
        {
            SetTexture("Eyes", 1);
        }
        i++;

        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            SetTexture("Hair", -1);
        }
        GUI.Box(new Rect(0.75f * scrW, scrH + i * (0.5f * scrH), 1f * scrW, 0.5f * scrH), "Hair");
        if (GUI.Button(new Rect(1.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), ">"))
        {
            SetTexture("Hair", 1);
        }
        i++;

        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            SetTexture("Armour", -1);
        }
        GUI.Box(new Rect(0.75f * scrW, scrH + i * (0.5f * scrH), 1f * scrW, 0.5f * scrH), "Armour");
        if (GUI.Button(new Rect(1.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), ">"))
        {
            SetTexture("Armour", 1);
        }
        i++;

        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            SetTexture("Mouth", -1);
        }
        GUI.Box(new Rect(0.75f * scrW, scrH + i * (0.5f * scrH), 1f * scrW, 0.5f * scrH), "Mouth");
        if (GUI.Button(new Rect(1.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), ">"))
        {
            SetTexture("Mouth", 1);
        }
        i++;

        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            SetTexture("Clothes", -1);
        }
        GUI.Box(new Rect(0.75f * scrW, scrH + i * (0.5f * scrH), 1f * scrW, 0.5f * scrH), "Clothes");
        if (GUI.Button(new Rect(1.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), ">"))
        {
            SetTexture("Clothes", 1);
        }
        i++;

        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), scrW, 0.5f * scrH), "Reset"))
        {
            SetTexture("Skin", skinIndex = 0);
            SetTexture("Eyes", eyeIndex = 0);
            SetTexture("Hair", hairIndex = 0);
            SetTexture("Armour", armourIndex = 0);
            SetTexture("Mouth", mouthIndex = 0);
            SetTexture("Clothes", clothesIndex = 0);
        }

        if (GUI.Button(new Rect(1.25f * scrW, scrH + i * (0.5f * scrH), scrW, 0.5f * scrH), "Random"))
        {
            SetTexture("Skin", Random.Range(0, skinMax - 1));
            SetTexture("Eyes", Random.Range(0, eyeMax - 1));
            SetTexture("Hair", Random.Range(0, hairMax - 1));
            SetTexture("Armour", Random.Range(0, armourMax - 1));
            SetTexture("Mouth", Random.Range(0, mouthMax - 1));
            SetTexture("Clothes", Random.Range(0, clothesMax - 1));
        }
        i++;

        charName = GUI.TextField(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 2 * scrW, 0.5f * scrH), charName, 16);
        i++;
        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 2 * scrW, 0.5f * scrH), "Save and Play"))
        {
            Save();
            SceneManager.LoadScene(2);
        }
        i = 0;
        GUI.Box(new Rect(3.75f * scrW, scrH + i * (0.5f * scrH), 2 * scrW, 0.5f * scrH), "Class");
        i++;

        if (GUI.Button(new Rect(3.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            selectedIndex--;
            if (selectedIndex < 0)
            {
                selectedIndex = selectedClass.Length - 1;
            }
            ChooseClass(selectedIndex);
        }

        GUI.Box(new Rect(3.75f * scrW, scrH + i * (0.5f * scrH), 2 * scrW, 0.5f * scrH), selectedClass[selectedIndex]);

        if (GUI.Button(new Rect(5.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), ">"))
        {
            selectedIndex++;
            if (selectedIndex > selectedClass.Length)
            {
                selectedIndex = 0;
            }
            ChooseClass(selectedIndex);
        }
       
        GUI.Box(new Rect(3.75f * scrW, 2f * scrH, 2f * scrW, 0.5f * scrH), "Points: " + points);
        i++;
        for (int s = 0; s < 6; s++)
        {
            if (points > 0)
            {
                if (GUI.Button(new Rect(5.75f * scrW, 2.5f * scrH + s * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "+"))
                {
                    points--;
                    tempStats[s]++;
                }
            }
        
            GUI.Box(new Rect(3.75f * scrW, 2.5f * scrH + s * (0.5f * scrH), 2f * scrW, 0.5f * scrH), statArray[s] + ": " + (tempStats[s] + stats[s]));
            if (points < 10 && tempStats[s] > 0)
            {
                if (GUI.Button(new Rect(3.25f * scrW, 2.5f * scrH + s * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "-"))
                {
                    points++;
                    tempStats[s]--;
                }
            }

        }



        #endregion

    }

    void ChooseClass(int className)
    {
        switch (className)
        {
            case 0:
                stats[0] = 15;
                stats[1] = 10;
                stats[2] = 10;
                stats[3] = 10;
                stats[4] = 10;
                stats[5] = 5;
                characterClass = CharacterClass.Barbarian;
                break;

            case 1:
                stats[0] = 5;
                stats[1] = 10;
                stats[2] = 10;
                stats[3] = 10;
                stats[4] = 10;
                stats[5] = 15;
                characterClass = CharacterClass.Bard;
                break;

            case 2:
                stats[0] = 10;
                stats[1] = 5;
                stats[2] = 10;
                stats[3] = 15;
                stats[4] = 10;
                stats[5] = 5;
                characterClass = CharacterClass.Cleric;
                break;

            case 3:
                stats[0] = 5;
                stats[1] = 10;
                stats[2] = 10;
                stats[3] = 15;
                stats[4] = 10;
                stats[5] = 10;
                characterClass = CharacterClass.Druid;
                break;

            case 4:
                stats[0] = 15;
                stats[1] = 10;
                stats[2] = 10;
                stats[3] = 10;
                stats[4] = 5;
                stats[5] = 10;
                characterClass = CharacterClass.Fighter;
                break;

            case 5:
                stats[0] = 10;
                stats[1] = 10;
                stats[2] = 5;
                stats[3] = 15;
                stats[4] = 10;
                stats[5] = 10;
                characterClass = CharacterClass.Monk;
                break;

            case 6:
                stats[0] = 10;
                stats[1] = 10;
                stats[2] = 10;
                stats[3] = 10;
                stats[4] = 5;
                stats[5] = 15;
                characterClass = CharacterClass.Paladin;
                break;

            case 7:
                stats[0] = 10;
                stats[1] = 10;
                stats[2] = 5;
                stats[3] = 15;
                stats[4] = 10;
                stats[5] = 10;
                characterClass = CharacterClass.Ranger;
                break;

            case 8:
                stats[0] = 5;
                stats[1] = 15;
                stats[2] = 10;
                stats[3] = 10;
                stats[4] = 10;
                stats[5] = 10;
                characterClass = CharacterClass.Rogue;
                break;

            case 9:
                stats[0] = 10;
                stats[1] = 10;
                stats[2] = 10;
                stats[3] = 5;
                stats[4] = 10;
                stats[5] = 15;
                characterClass = CharacterClass.Sorcerer;
                break;

            case 10:
                stats[0] = 10;
                stats[1] = 10;
                stats[2] = 5;
                stats[3] = 10;
                stats[4] = 10;
                stats[5] = 15;
                characterClass = CharacterClass.Warlock;
                break;

            case 11:
                stats[0] = 5;
                stats[1] = 10;
                stats[2] = 10;
                stats[3] = 10;
                stats[4] = 15;
                stats[5] = 10;
                characterClass = CharacterClass.Wizard;
                break;
        }
    }


}


public enum CharacterClass
{
    Barbarian,
    Bard,
    Cleric,
    Druid,
    Fighter,
    Monk,
    Paladin,
    Ranger,
    Rogue,
    Sorcerer,
    Warlock,
    Wizard,
}
