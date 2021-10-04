using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene1 : MonoBehaviour
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
        if (count == 0)
        {
            MainText.text = "Eugene: Hello, mr. Doctor.";
            Choise.SetActive(true);
            NextButton.SetActive(false);
        }
        else if (count == 1)
        {
            MainText.text = "Eugene: Because of my business, we have the opportunity to buy a dress for you from the new collection!";
            count++;
        }
        else if (count == 2)
        {
            MainText.text = "Gloria: Don't interrupt me! Doctor, he began to devote less time to me and bring less money to the family. My husband constantly disappears somewhere and now he pays too little attention to me.";
            count++;
        }

        else if (count == 3)
        {
            MainText.text = "Gloria: What can you advise us in this case?";
            TextB.text = "I think you need to spend more time together.";
            TextB2.text = "For this, you can find a new hobby.";
            Choise.SetActive(true);
            Choise2.SetActive(true);
            NextButton.SetActive(false);
        }
    }

    public void Choisen()
    {
        if (count == 0)
        {
            Choise.SetActive(false);
            NextButton.SetActive(true);
            MainText.text = "Gloria: We have problems with my husband. Due to the fact that he is all the time busy, our relationship has become unstable...";
            count++;
        }
        else if (count == 3)
        {
            Application.LoadLevel("Couple2.1");
        }
    }

    public void Choisen2()
    {
        Application.LoadLevel("Couple2.2");
    }


}