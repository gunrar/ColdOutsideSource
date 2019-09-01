using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireTimer : MonoBehaviour
{
    public static bool fireBurning= false;
    public GameObject fireTimer;
    public static int fireTime = 50;
    public static int fireSize = 0;
    public GameObject title;
    
    void Start()
    {
        InvokeRepeating("burnOut", 0.5f, 1.0f);

    }

    // Update is called once per frame
    void Update()
    {
        if (fireBurning == true)
        {
            if (fireTime >= 0)
            {
                fireTimer.GetComponent<RectTransform>().sizeDelta = new Vector2(fireTime, 100);
            }
            if (fireSize == 1)
            {
                title.GetComponent<Text>().text = "You are outside, the fire is smouldering";
            }
            if (fireSize == 2)
            {
                title.GetComponent<Text>().text = "You are outside, the fire is burning warmly";
            }
            if (fireSize == 3)
            {
                title.GetComponent<Text>().text = "You are outside, the fire is roaring";
            }
            if (fireSize == 0)
            {
                title.GetComponent<Text>().text = "You are outside, it is cold";
            }
        }
        if (fireSize == 0)
        {
            fireBurning = false;
            fireTimer.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 100);
        }

    }

    public void burnOut()
    {
        fireTime -= 3;

    }
    
}
