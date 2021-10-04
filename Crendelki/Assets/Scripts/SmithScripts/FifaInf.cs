using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FifaInf : MonoBehaviour
{
    public GameObject Button;
    public GameObject Next;
    public GameObject Panel;
    public GameObject Inf;
    public GameObject Background;

    public void LetsGo(){
        Panel.SetActive(false);
        Inf.SetActive(true);
        Background.SetActive(true);
    }

    public void toLevel1(){
        Application.LoadLevel("Couple1");
    }
}
