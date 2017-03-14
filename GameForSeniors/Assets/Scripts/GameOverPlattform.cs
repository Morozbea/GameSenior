using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverPlattform : MonoBehaviour
{

    public Text winText;
    // Use this for initialization

    void Awake()
    {
        winText = GameObject.Find("Text").GetComponent<Text>();
        winText.enabled = false;
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
           // Time.timeScale = 0; 
           
        }
    }
}
