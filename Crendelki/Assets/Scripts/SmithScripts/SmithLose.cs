using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmithLose : MonoBehaviour
{
    public GameObject NextButton;
    public Text MainText;
    public int count = 0;
    public GameObject Choise;
    public GameObject Choise2;
    public Text TextB;
    public Text TextB2;

    void Start()
    {
        TextB.text = "What happening?";
        Choise.SetActive(true);
        NextButton.SetActive(false);

    }

    public void Choisen()
    {
        if (count == 0)
        {
            MainText.text = "Gloria: YOU DO NOT IMAGINE WHAT YOU DID .... After twenty years of living together, he decided to exchange me for this worthless robo-lover of garden flowers, and in the end he said that he could not live without the beauty of plants!  All is not good for you!  And by the way!  Your shoes were out of fashion 10 years ago!  Bye!";
            TextB.text = "I'm sorry...";
            count++;
        }
        else if (count == 1)
        {
            Application.LoadLevel("LOSE Smiths");
        }
    }
}
