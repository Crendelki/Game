using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene21 : MonoBehaviour
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
            MainText.text = "After your advice, we began to spend more time together, but you have no idea how tired I am...";
            TextB.text = "Tired?..";
            Choise.SetActive(true);
            NextButton.SetActive(false);
        }
    }

    public void Choisen()
    {
        if (count == 0)
        {
            MainText.text = "Gloria: What is it about going to the malls with your beloved wife and buying me new things?";
            TextB.text = "Stop interrupting each other.";
            count++;
            WomanTalk.Play();
        }
        else if (count == 1)
        {
            MainText.text = "Eugene: That's not how I imagined it. What should we do?";
            TextB.text = "Discover a new joint venture";
            TextB2.text = "Take a break in your relationship";
            Choise2.SetActive(true);
            count++;
            ManTalk.Play();
        }
        else if (count == 2)
        {
            Application.LoadLevel("SmithWin");
        }
    }

    public void Choisen2()
    {
        Application.LoadLevel("Couple3.1");
    }

}