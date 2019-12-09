using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class warningEngine : MonoBehaviour
{
    public static warningEngine instance;

    public bool trigger = false;

    public float timer = 10f;

    public Text timerText;

    public GameObject uiArt;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (trigger)
        {
            timer -= Time.deltaTime;
            timerText.text = timer.ToString("F1"); 

            if(timer <= 0)
            {
                print("Dead");
                trigger = false;
            }
        }  
    }

    public void enterArea()
    {
        uiArt.SetActive(true);
        trigger = true;
    }

    public void exitArea()
    {
        trigger = false;
        uiArt.SetActive(false);
        timer = 10f;
    }
}
