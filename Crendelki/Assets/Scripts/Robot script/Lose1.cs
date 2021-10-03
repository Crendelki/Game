using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lose1 : MonoBehaviour
{
    public GameObject NextButton;
    public Text MainText;
    public int count = 0;
    public GameObject Choise;
    public GameObject Choise2;
    public Text TextB;
    public Text TextB2;

    void Start(){
        TextB.text = "Why are you alone?";
    }

    public void Next()
    {
        if (count == 0){
            MainText.text = "Alice: I re-all-y lo-ve y-ou!";
            count++;
        }
        else if (count == 1){
            MainText.text = "Ethan: She says it 200 times a day. I already have a headache. Help!";
            TextB.text = "Let her continue to communicate with neighbor";
            TextB2.text = "Buy her a robot dog";
            Choise.SetActive(true);
            Choise2.SetActive(true);
            NextButton.SetActive(false);
        }
    }

    public void Choisen()
    {
        if (count == 0){
            MainText.text = "Ethan: I had to take her apart. She stopped doing the simplest things. I don't need your help anymore. Goodbye!";
            TextB.text = "I'm sorry...";
        }
    }

    public void Choisen2()
    {
        Application.LoadLevel("WinRobot");
    }
}
