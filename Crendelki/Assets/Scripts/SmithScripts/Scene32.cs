using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene32 : MonoBehaviour
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
            MainText.text = "Gloria: God, you are not helping, but only aggravating everything with your advice!";
            count++;
            WomanTalk.Play();
        }
        else if (count == 1)
        {
            MainText.text = "Eugene: How could I not have known for twenty years that my wife is allergic to garden flowers?";
            TextB.text = "Keep looking for hobbies";
            TextB2.text = "Try to cure your allergies";
            Choise.SetActive(true);
            Choise2.SetActive(true);
            NextButton.SetActive(false);
            ManTalk.Play();
        }
    }

    public void Choisen()
    {
        Application.LoadLevel("SmithWin");
    }

    public void Choisen2()
    {
        Application.LoadLevel("SmithLose");
    }
}
