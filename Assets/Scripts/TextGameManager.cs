using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro;
    public string storyText;
    public TextMeshProUGUI HPtextMeshPro;
    public int HPvalue;
    public TextMeshProUGUI STAtextMeshPro;
    public int STAvalue;
    public GameObject Stats, Main_Menu, Level1Choices, Level2Choices;


    // Start is called before the first frame update
    void Start()
    {
        storyText = "THE SCHOOL BOY";
        Stats.SetActive(false);
        Level1Choices.SetActive(false);
        Level2Choices.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText;
        HPtextMeshPro.text = HPvalue.ToString();
        STAtextMeshPro.text = STAvalue.ToString();
    }
    public void StartGame()
    {
        storyText = "As I'm walking to school, a little boy suddenly threw an empty tin can on my head and ran to his house.";

        HPvalue = 10;
        STAvalue = 10;

        Stats.SetActive(true);
        Main_Menu.SetActive(false);
        Level1Choices.SetActive(true);
    }
    public void LetItGo()
    {
        storyText = "I made it to school on time,but I had a bad day.";
        STAvalue -= 5;

        Level1Choices.SetActive(false);
    }

    public void ScoldHim()
    {
        storyText = "The dad punched me in the face and I fell asleep. I missed the school.";
        HPvalue -= 5;
        STAvalue -= 3;

        Level1Choices.SetActive(false);
        Level2Choices.SetActive(true);
    }

    public void AssaultHim()
    {
        storyText = "The dad killed me.";
        HPvalue -= 10;
        STAvalue -= 10;

        Level1Choices.SetActive(false);
    }

    public void GoHome()
    {
        storyText = "I went home, eat some cereal, and went to sleep for recovery.";
        HPvalue += 2;
        STAvalue += 2;

        Level2Choices.SetActive(false);
    }

    public void GoToSchool()
    {
        storyText = "The classes are over. I went home really tired.";
        STAvalue-= 5;

        Level2Choices.SetActive(false);
    }

    public void FightDad()
    {
        storyText = "The dad beat me to death.";
        HPvalue -= 5;
        STAvalue -= 7;

        Level2Choices.SetActive(false);
    }

    public void ExitGame() 
    {
        Application.Quit();
    }
}
