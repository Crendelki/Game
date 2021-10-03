using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick31 : MonoBehaviour
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
            MainText.text = "Alice: ??? I Lik-e.. Can't se-e hi-m!!";
            count++;
        }
        else if (count == 1){
            MainText.text = "Alice: I re-all-y lo-ve y-ou!";
            count++;
        }
        else if (count == 2){
            MainText.text = "Ethan: She says it 200 times a day. I already have a headache. Help!";
            TextB.text = "Everything will get better with time, just wait";
            TextB2.text = "Turn on the vision function and try to trust her more";
            Choise.SetActive(true);
            Choise2.SetActive(true);
            NextButton.SetActive(false);
        }
    }

    public void Choisen()
    {
        if (count == 1){
            Application.LoadLevel("WinRobot");
        }
    }

    public void Choisen2()
    {
        Application.LoadLevel("LoseRobot1");
    }
}
