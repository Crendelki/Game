using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick32 : MonoBehaviour
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
            MainText.text = "Alice: I re-all-y lo-ve y-ou!";
            count++;
        }
        else if (count == 1){
            MainText.text = "Ethan: She says it two hundred times a day. I already have a headache. Help!";
            TextB.text = "Let her continue to communicate with neighbor";
            TextB2.text = "Buy her a robot dog";
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
        Application.LoadLevel("WinRobot");
    }
}
