using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]

public class QuestUI
{
    public PlayerQuest player;
    public GameObject questWindow;

    public Text nameText;
    public Text descriptionText;
    public Text experienceText;
    public Text goldText;
}

public class QuestGiver : MonoBehaviour
{

    public Quest quest;
    public QuestUI uI;

    public void OpenQuestWindow()
    {
        uI.questWindow.SetActive(true);

        uI.nameText.text = quest.name;
        uI.descriptionText.text = quest.name;
        uI.experienceText.text = quest.name;
        uI.goldText.text = quest.name;
        
    }
    public void AcceptQuest()
    {
        uI.questWindow.SetActive(false);
        if(quest.state == QuestState.New)
        {
            quest.state = QuestState.Accepted;
            uI.player.quests.Add(quest);
        }
    }
   
   
}
