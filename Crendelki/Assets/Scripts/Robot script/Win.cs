using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public GameObject NextButton;
    public Text MainText;
    public int count = 0;
    public GameObject Choise;
    public GameObject Choise2;
    public Text TextB;
    public Text TextB2;

    void Start(){
        TextB.text = "I'm glad I could help you. Bye!";
        Choise.SetActive(true);
        NextButton.SetActive(false);

    }

    public void Choisen()
    {
        Application.LoadLevel("WIN");
    }
}
