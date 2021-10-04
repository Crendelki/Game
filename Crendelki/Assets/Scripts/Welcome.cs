using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Welcome : MonoBehaviour
{
    public Button StartButton;

    public void StartTheGame(){
        Application.LoadLevel("NerdInfo");
    }
}
