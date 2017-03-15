using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverPlattform : MonoBehaviour
{

    Text winText;
    Image winBG;
    Image winBirdWin;
    // Use this for initialization

    void Awake()
    {
        winText = GameObject.Find("TextWin").GetComponent<Text>();
        winBG = GameObject.Find("ImageWinBG").GetComponent<Image>();
        winBirdWin = GameObject.Find("ImageBirdWin").GetComponent<Image>();
        winText.enabled = false;
        winBG.enabled = false;
        winBirdWin.enabled = false;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
         Debug.Log("collWincheck");
            if (coll.gameObject.tag == "Player")
        {
            winText.enabled = true;
            winBG.enabled = true;
            winBirdWin.enabled = true;
        }
    }
}
