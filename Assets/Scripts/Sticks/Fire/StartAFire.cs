using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartAFire : MonoBehaviour
{
    public int internalStickCount;
    public GameObject fireButton;
    public GameObject thisButton;
    public GameObject title;
    public void Update()
    {
        internalStickCount = GatherSticks.stickCount;
    }

    public void StartFire()
    {
        if (internalStickCount >= 5)
        {
            FireTimer.fireSize = 1;
            thisButton.SetActive(false);
            fireButton.SetActive(true);
            //fireButton.GetComponent<Animation>().Play("FireFadeIn");
            GatherSticks.stickCount -= 5;
            title.GetComponent<Text>().text = "You are outside, the fire is smouldering";
            FireTimer.fireTime = 100;
            FireTimer.fireBurning = true;
        }
    }




}
