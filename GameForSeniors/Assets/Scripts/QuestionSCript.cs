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
    Vector3 picPos;
    public Image questionImage;
    public Text questionText;
    public Image answerImage;

    public Image boll4;
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

        pic = GameObject.Find("SolvedImage");
        
        picPos = pic.transform.position;
        boll4.enabled = false;

        questionImage.enabled = false;
        questionText.enabled = false;
        answerImage.enabled = false;
        Abutton1.SetActive(false);
        Abutton2.SetActive(false);
        Abutton3.SetActive(false);
        Abutton4.SetActive(false);
        Debug.Log(picPos);

    }

    // Update is called once per frame
    void Update()
    {
        //QuestionPressed();
    }

    public void Question1Pressed()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
       
        pic.transform.localScale -= new Vector3(0.5f, 0.5f, 1);
        Debug.Log("button pressed");
        questionImage.enabled = true;
        questionText.enabled = true;
        answerImage.enabled = true;
        Abutton1.SetActive(true);
        Abutton2.SetActive(true);
        Abutton3.SetActive(true);
        Abutton4.SetActive(true);
        //}
        picPos = new Vector3(pic.transform.position.x + 125f, pic.transform.position.y + 125f, pic.transform.position.z);
    }

    public void Question2Pressed()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        picPos = new Vector3(pic.transform.position.x + 2f, pic.transform.position.y + 2f, pic.transform.position.z);
        pic.transform.localScale -= new Vector3(0.5f, 0.5f, 1);
        Debug.Log("button pressed");
        questionImage.enabled = true;
        questionText.enabled = true;
        answerImage.enabled = true;
        Abutton1.SetActive(true);
        Abutton2.SetActive(true);
        Abutton3.SetActive(true);
        Abutton4.SetActive(true);
        Debug.Log(picPos);
        //}
    }

    public void Question3Pressed()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        picPos = new Vector3(pic.transform.position.x + 2f, pic.transform.position.y + 2f, pic.transform.position.z);
        pic.transform.localScale -= new Vector3(0.5f, 0.5f, 1);
        Debug.Log("button pressed");
        questionImage.enabled = true;
        questionText.enabled = true;
        answerImage.enabled = true;
        Abutton1.SetActive(true);
        Abutton2.SetActive(true);
        Abutton3.SetActive(true);
        Abutton4.SetActive(true);
        //}
    }

    public void Question4Pressed()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        picPos = new Vector3(pic.transform.position.x + 2f, pic.transform.position.y + 2f, pic.transform.position.z);
        pic.transform.localScale -= new Vector3(0.5f, 0.5f, 1);
        Debug.Log("button pressed");
        questionImage.enabled = true;
        questionText.enabled = true;
        answerImage.enabled = true;
        Abutton1.SetActive(true);
        Abutton2.SetActive(true);
        Abutton3.SetActive(true);
        Abutton4.SetActive(true);
        //}
    }

    public void CheckAnswer()
    {

    }
}
