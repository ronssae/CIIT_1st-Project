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
    public GameObject Stats, Main_Menu, Level1Choices, Level2Choices, BackButton, schoolboy_image, black_image, school_image, badDay_image, sleeping_image, hallway_image;


    // Start is called before the first frame update
    void Start()
    {
        schoolboy_image.SetActive(true);

        storyText = "THE SCHOOL BOY";
        Stats.SetActive(false);
        Main_Menu.SetActive(true);
        Level1Choices.SetActive(false);
        Level2Choices.SetActive(false);
        BackButton.SetActive(false);
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
        schoolboy_image.SetActive(false);
        school_image.SetActive(true);

        storyText = "As I'm walking to school, a little boy suddenly threw an empty tin can on my head and ran to his house.";

        HPvalue = 10;
        STAvalue = 10;

        Stats.SetActive(true);
        Main_Menu.SetActive(false);
        Level1Choices.SetActive(true);
    }
    public void LetItGo()
    {
        school_image.SetActive(false);
        badDay_image.SetActive(true);

        storyText = "I made it to school on time,but I had a bad day.";
        STAvalue -= 5;

        Level1Choices.SetActive(false);
        BackButton.SetActive(true);
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
        sleeping_image.SetActive(false);
        badDay_image.SetActive(false);
        school_image.SetActive(false);
        black_image.SetActive(true);

        storyText = "The dad killed me.";
        HPvalue -= 10;
        STAvalue -= 10;

        Level1Choices.SetActive(false);
        BackButton.SetActive(true);
    }

    public void GoHome()
    {
        badDay_image.SetActive(false);
        school_image.SetActive(false);
        sleeping_image.SetActive(true);

        storyText = "I went home, eat some cereal, and went to sleep for recovery.";
        HPvalue += 2;
        STAvalue += 2;

        Level2Choices.SetActive(false);
        BackButton.SetActive(true);
    }

    public void GoToSchool()
    {
        sleeping_image.SetActive(false);
        black_image.SetActive(false);
        badDay_image.SetActive(false);
        school_image.SetActive(false);
        hallway_image.SetActive(true);

        storyText = "The classes are over. I went home really tired.";
        STAvalue-= 5;

        Level2Choices.SetActive(false);
        BackButton.SetActive(true);
    }

    public void FightDad()
    {
        sleeping_image.SetActive(false);
        badDay_image.SetActive(false);
        school_image.SetActive(false);
        black_image.SetActive(true);

        storyText = "The dad beat me to death.";
        HPvalue -= 5;
        STAvalue -= 7;

        Level2Choices.SetActive(false);
        BackButton.SetActive(true);
    }

    public void ExitGame() 
    {
        Application.Quit();
    }

    public void Back_Button()
    {
        Start();
    }
}
