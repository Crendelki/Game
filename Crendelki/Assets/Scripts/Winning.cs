using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    public GameObject Back;
    public GameObject Quitting;

    public void BackToMenu(){
        Application.LoadLevel("Menu");
    }

    public void QuittingGame(){
        Application.Quit();
    }
}
