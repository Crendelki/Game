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
    public AudioSource ManTalk;

    void Start(){
        TextB.text = "Why are you alone?";
        Choise.SetActive(true);
        NextButton.SetActive(false);

    }

    public void Choisen()
    {
        if (count == 0){
            MainText.text = "Ethan: I had to take her apart. She stopped doing the simplest things. I don't need your help anymore. Goodbye!";
            TextB.text = "I'm sorry...";
            count++;
            ManTalk.Play();
        }
        else if (count == 1){
            Application.LoadLevel("LOSE");
        }
    }
}
