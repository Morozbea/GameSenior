using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionSCript : MonoBehaviour
{
    GameObject Qbutton1;
    GameObject Qbutton2;
    GameObject Qbutton3;
    GameObject Qbutton4;

    GameObject Abutton1;
    GameObject Abutton2;
    GameObject Abutton3;
    GameObject Abutton4;

    GameObject pic;
    
    public Image questionImage;
    public Text questionText;

    
    // Use this for initialization
    void Start()
    {
        Qbutton1 = GameObject.Find("Button1");
        Qbutton2 = GameObject.Find("Button2");
        Qbutton3 = GameObject.Find("Button3");
        Qbutton4 = GameObject.Find("Button4");

        Abutton1 = GameObject.Find("AButton1");
        Abutton2 = GameObject.Find("AButton2");
        Abutton3 = GameObject.Find("AButton3");
        Abutton4 = GameObject.Find("AButton4");

        questionImage.enabled = false;
        questionText.enabled = false;
        Abutton1.SetActive(false);
        Abutton2.SetActive(false);
        Abutton3.SetActive(false);
        Abutton4.SetActive(false);
       

    }

    // Update is called once per frame
    void Update()
    {

    }

    //bottom skåne
    public void Question1Pressed()
    {
        questionImage.enabled = true;
        questionText.enabled = true;
        Abutton1.SetActive(true);
        Abutton2.SetActive(true);
        Abutton3.SetActive(true);
        Abutton4.SetActive(true);
    }

    //mid mitten av sverige
    public void Question2Pressed()
    {
        questionImage.enabled = true;
        questionText.enabled = true;
        Abutton1.SetActive(true);
        Abutton2.SetActive(true);
        Abutton3.SetActive(true);
        Abutton4.SetActive(true);
    }


    //top norra av sverige
    public void Question3Pressed()
    {
        questionImage.enabled = true;
        questionText.enabled = true;
        Abutton1.SetActive(true);
        Abutton2.SetActive(true);
        Abutton3.SetActive(true);
        Abutton4.SetActive(true);
    }


    public void CheckAnswer()
    {

    }
}
