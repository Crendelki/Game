using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene31 : MonoBehaviour
{
    public GameObject NextButton;
    public Text MainText;
    public int count = 0;
    public GameObject Choise;
    public GameObject Choise2;
    public Text TextB;
    public Text TextB2;
    public AudioSource ManTalk;
    public AudioSource WomanTalk;

    public void Next()
    {
        if (count == 0)
        {
            MainText.text = "Gloria: This idiot now sees nothing but his flowers. And what did he find there?";
            count++;
            WomanTalk.Play();
        }
        else if (count == 1)
        {
            MainText.text = "Eugene: She doesn't want to accept and understand my interests.";
            count++;
            ManTalk.Play();
        }
        else if (count == 2)
        {
            MainText.text = "Eugene: What to do?";
            TextB.text = "You need to go to an unusual place together. ";
            TextB2.text = "Why do you need flowers?  Plant something else";
            Choise.SetActive(true);
            Choise2.SetActive(true);
            NextButton.SetActive(false);
            ManTalk.Play();
        }
    }

    public void Choisen()
    {
        Application.LoadLevel("SmithLose");
    }

    public void Choisen2()
    {
        Application.LoadLevel("SmithWin");
    }
}
