using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftSpear : MonoBehaviour
{
    
    public bool hasCrafted = false;
    public static GameObject spearButton;
    public GameObject meatCount;
    public GameObject huntButton;
    public static bool isBroken = false;
    public GameObject spearTest;
    public static bool hasSpear = false;
    public GameObject forestCover;
    public GameObject spearText;
    public GameObject hungerMaster;
    public GameObject cookButton;
    public GameObject upgradeSpear;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spearButton = spearTest;
        hasSpear = hasCrafted;
    }

    public void CraftTheSpear()
    {
        if (GatherSticks.stickCount >= 30 && hasCrafted == false)
        {
            hungerMaster.SetActive(true);
            cookButton.SetActive(true);
            cookButton.GetComponent<Animation>().Play("FireFadeIn");
            GatherSticks.stickCount -= 30;                                              
            spearText.SetActive(false);
            hasCrafted = true;
            meatCount.SetActive(true);
            huntButton.SetActive(true);
            upgradeSpear.SetActive(true);
            upgradeSpear.GetComponent<Animation>().Play("CraftASpearFadeIn");
            huntButton.GetComponent<Animation>().Play("HuntFadeIn");
            forestCover.GetComponent<Animation>().Play("ForestFadeIn");
            
        }
        if (isBroken == true && GatherSticks.stickCount >= 10)
        {
            GatherSticks.stickCount -= 10;
            
            spearButton.GetComponent<Text>().text = "Wooden Spear";
            isBroken = false;


        }
        
    }

    public void CraftSpearDebug()
    {
        spearButton.GetComponent<Text>().text = "Wooden Spear";
    }

}
