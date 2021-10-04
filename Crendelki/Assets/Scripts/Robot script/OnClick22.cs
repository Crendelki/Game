using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick22 : MonoBehaviour
{
    public GameObject NextButton;
    public Text MainText;
    public int count = 0;
    public GameObject Choise;
    public GameObject Choise2;
    public Text TextB;
    public Text TextB2;

    public void Next()
    {
        if (count == 0){
            MainText.text = "Alice: Flo-wers in the g-ard-en. They're so be-auti-ful.";
            count++;
        }
        else if (count == 1){
            MainText.text = "Ethan: We have only moles stealing potatoes in our garden, no flowers. Doctor, I think the neighbor has a bad influence on her, what should I do?";
            TextB.text = "Let her love flowers, it's not forbidden";
            TextB2.text = "Forbid her to go outside!";
            Choise.SetActive(true);
            Choise2.SetActive(true);
            NextButton.SetActive(false);
        }
    }

    public void Choisen()
    {
        Application.LoadLevel("LoseRobot2");
    }

    public void Choisen2()
    {
        Application.LoadLevel("Level3.2");
    }
}
