using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button StartButton;
    public Button Families;
    public Button Exit;

    public void Starting(){
        Application.LoadLevel("NerdInfo");
    }

    public void Family(){
        Application.LoadLevel("Families");
    }

    public void Exiting(){
        Application.Quit();
    }
}
