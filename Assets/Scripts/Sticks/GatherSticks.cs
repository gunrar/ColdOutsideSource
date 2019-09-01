using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatherSticks : MonoBehaviour
{
    public int sticksGathered;
    public static int stickCount = 0;
    public GameObject otherButton;
    public GameObject thisButton;
    public GameObject gatherButton;
    public GameObject stickCounter;
    public bool delayed = false;
    public GameObject startFire;
    public GameObject craftSpear;
    public GameObject craftPen;
    public bool craftSpearEnabled = false;
    public GameObject info;
    public GameObject inventory;
    public GameObject coldCounter;
    public static int personCount = 1;

    void Start()
    {
        
    }

    // is constantly updating stick count
    void Update()
    {
        stickCounter.GetComponent<Text>().text = "Stick: " + stickCount;
        if (FireTimer.fireSize == 3)
        {
            StartCoroutine(EnableCraftSpear());
        }
    }

    IEnumerator EnableCraftSpear()
    {
        if (craftSpearEnabled == false)
        {
            craftSpearEnabled = true;
            yield return new WaitForSeconds(5);
            craftSpear.SetActive(true);
            craftSpear.GetComponent<Animation>().Play("CraftASpearFadeIn");
            craftPen.SetActive(true);
            craftPen.GetComponent<Animation>().Play("CraftAPenFadeIn");
        }
      

    }

    //chooses stickPath over applePath and opens up sub decisions for stick path
    public void chooseStick()
    {
        StartCoroutine(fadeButton());  
        thisButton.SetActive(false);
        gatherButton.SetActive(true);
        stickCounter.SetActive(true);
        startFire.SetActive(true);
        startFire.GetComponent<Animation>().Play("StartAFireFadeIn");
        inventory.SetActive(true);
        coldCounter.SetActive(true);
    }
    //Adds 5 sticks to stick count
    public void gatherSticks()
    {

        
        StartCoroutine(gatherDelay());
        
    }

    IEnumerator gatherDelay()
    {
        if (delayed == false)
        {
            delayed = true;
            sticksGathered = Random.Range(1, 10);
            stickCount += sticksGathered * personCount;
            if (ColdGeneration.coldTotal <= 1)
            {
                stickCount += 2;
            }
            if (Hunger.hungerCount >= 20)
            {
                stickCount += 3;
            }
            gatherButton.GetComponent<Animation>().Play("GatherStickTimer");
            yield return new WaitForSeconds(10);
            delayed = false;
        }

    }

    IEnumerator fadeButton()
    {
        otherButton.GetComponent<Animation>().Play("InitialAppleButtonFade");
        yield return new WaitForSeconds(3);
        otherButton.SetActive(false);
    }
}
