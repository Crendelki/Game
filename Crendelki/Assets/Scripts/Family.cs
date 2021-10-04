using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Family : MonoBehaviour
{
    public Button Level1;
    public Button Couple1;
    public Button Back;

    public void Family1(){
        Application.LoadLevel("Level1");
    }

    public void Family2(){
        Application.LoadLevel("Couple1");
    }

    public void BackToMenu(){
        Application.LoadLevel("Menu");
    }

}
