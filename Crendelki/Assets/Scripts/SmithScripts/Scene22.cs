using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene22 : MonoBehaviour
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

    public void Start()
    {
        Choise.SetActive(true);
        TextB.text = "You can make sure by looking at the wall...";
        NextButton.SetActive(false);
    }

    public void Next()
    {
        if (count == 1)
        {
            MainText.text = "Gloria: Of all the things in this world, I only like to go shopping, but this way we will run out of all our savings.  Well, I just can't find a hobby, and because of your advice, I hardly see my husband.  What I should do?";
            TextB.text = "Help your husband in the garden";
            TextB2.text = "Instead of flowers, put a pool in your yard and go swimming";
            Choise.SetActive(true);
            Choise2.SetActive(true);
            count++;
            WomanTalk.Play();
        }
    }

    public void Choisen()
    {
      
        if (count == 0)
        {
            MainText.text = "Eugene: Sorry.  I don't understand what doesn't suit her. I've been having a great time in the garden lately.";
            Choise.SetActive(false);
            NextButton.SetActive(true);
            count++;
            ManTalk.Play();
        }
        else if (count == 2)
        {
            Application.LoadLevel("Couple3.2");
        }
    }

    public void Choisen2()
    {
        Application.LoadLevel("SmithLose");
    }

}
