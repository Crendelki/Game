using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmithWin : MonoBehaviour
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
            MainText.text = "Gloria: Just look at my perfectly even tan.";
            count++;
        }
        else if (count == 1)
        {
            MainText.text = "Eugene: In other countries, there are a lot of different interesting flora and fauna, which gives me great pleasure... Even despite our disputes with my wife. Thank you, doctor.";
            TextB.text = "Not at all. This is my job.";
            Choise.SetActive(true);
            Choise2.SetActive(false);
            NextButton.SetActive(false);
        }
    }

    public void Choisen()
    {
        Application.LoadLevel("WIN2");
    }
}
