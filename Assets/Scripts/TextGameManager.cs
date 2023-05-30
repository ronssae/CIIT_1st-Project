using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro,HPtextMeshPro,StaminatextMeshPro;
    public string storyText;
    public int HPValue,StaminaValue;
    public GameObject Level_1_Choices, Level_2_Choices;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText;
        HPtextMeshPro.text = HPValue.ToString();
        StaminatextMeshPro.text = StaminaValue.ToString();
    }


    public void LetItGo()
    {
        storyText = "I made it to school on time, but I had a bad day.";
        StaminaValue -= 5;

        Level_1_Choices.SetActive(false);
    }

    public void ScoldHim()
    {
        storyText = "The dad punched me in the face and I fell asleep. I missed the school.";
        HPValue -= 5;
        StaminaValue -= 3;

        Level_1_Choices.SetActive(false);
        Level_2_Choices.SetActive(true);
    }

    public void AssaultHim()
    {
        storyText = "The dad killed me.";
        HPValue -= 10;
        StaminaValue -= 10;

        Level_1_Choices.SetActive(false);
    }

    public void GoHome() 
    {
        storyText = "I went home, eat some cereal, and went to sleep for recovery.";
        HPValue += 2;
        StaminaValue += 2;

        Level_2_Choices.SetActive(false);
    }

    public void GoToSchool()
    {
        storyText = "The classes are over. I went home really tired.";
        StaminaValue -= 5;

        Level_2_Choices.SetActive(false);
    }
    public void FightDad()
    {
        storyText = "The dad beat me to death.";
        HPValue -= 5;
        StaminaValue -= 7;

        Level_2_Choices.SetActive(false);
    }
}
