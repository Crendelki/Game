using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick21 : MonoBehaviour
{
    public GameObject NextButton;
    public Text MainText;
    public int count = 0;
    public GameObject Choise;
    public GameObject Choise2;
    public Text TextB;
    public Text TextB2;
    public AudioSource RoboTalk;
    public AudioSource ManTalk;

    public void Next()
    {
        if (count == 0){
            MainText.text = "Alice: Th-at TV is ju-st a de-vic-e, Do-ctor!";
            TextB.text = "TV?..";
            Choise.SetActive(true);
            NextButton.SetActive(false);
            RoboTalk.Play();
        }
    }

    public void Choisen()
    {
        if (count == 0){
            MainText.text = "Ethan: I saw the way she looked at it! It wasn't just a look!";
            TextB.text = "Do robots have emotions?..";
            count++;
            ManTalk.Play();
        }
        else if (count == 1){
            MainText.text = "Ethan: It doesn't matter! Doctor, help us!";
            TextB.text = "Disable her vision function";
            TextB2.text = "Go and look at the TV for yourself. It's just a device";
            Choise2.SetActive(true);
            count++;
        }
        else if (count == 2){
            Application.LoadLevel("Level3.1");
        }
    }

    public void Choisen2()
    {
        Application.LoadLevel("WinRobot");
    }

}
