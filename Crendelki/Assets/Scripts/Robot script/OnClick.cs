using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    public GameObject NextButton;
    public Text MainText;
    public int count = 0;
    public GameObject Choise;
    public GameObject Choise2;
    public Text TextB;
    public Text TextB2;
    public AudioSource RoboTalk;
    public AudioSource RoboProblem;
    public AudioSource ManTalk;


    public void Next()
    {
        if (count == 0){
            MainText.text = "Alice: H-e-l-l-o";
            Choise.SetActive(true);
            NextButton.SetActive(false);
            RoboTalk.Play();
        }
        else if (count == 1){
            MainText.text = "Alice: He is j-us-t a fri-end!";
            count++;
            RoboTalk.Play();

        }
        else if (count == 2){
            MainText.text = "Ethan: See? She denies everything. It seems to me that she is lying, but I did not create a lie function when created her.";
            count++;
            ManTalk.Play();
        }
        else if (count == 3){
            MainText.text = "Alice: Th-e \"lie\" fun-cti-on n-ot fou-nd.";
            count++;
            RoboProblem.Play();
        }
        else if (count == 4){
            MainText.text = "Ethan: Doctor, so what should we do?";
            TextB.text = "Turn off the lawn mowing function";
            TextB2.text = "Try to find errors in her system";
            Choise.SetActive(true);
            Choise2.SetActive(true);
            NextButton.SetActive(false);
            ManTalk.Play();
        }
    }

    public void Choisen()
    {   
        if (count == 0){
            Choise.SetActive(false);
            NextButton.SetActive(true);
            MainText.text = "Ethan: My wife started going out too often to mow the lawn. One day I saw her flirting with a neighbor. We talked about it, but she...";
            count++;
            ManTalk.Play();
        }
        else if (count == 4){
            Application.LoadLevel("Level2.1");
            ManTalk.Play();
        }
    }

    public void Choisen2()
    {
        Application.LoadLevel("Level2.2");
    }

}
