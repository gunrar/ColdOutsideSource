using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fish : MonoBehaviour
{
    public GameObject fishButton;
    public static int oilCount;
    public GameObject oilCounter;
    public int random;
    public GameObject info;
    public bool delay = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        oilCounter.GetComponent<Text>().text = "Oil: " + oilCount;
    }
    IEnumerator CatchFish()
    {
        if (delay == false)
        {
            delay = true;
            oilCounter.SetActive(true);
            random = Random.Range(0, 10);
            fishButton.GetComponent<Animation>().Play("FishCooldown");
            if (random < 2)
            {
                info.GetComponent<InfoText>().InfoTextReturn("You attempt to fish, and catch a large fish");
                oilCount += 4;
                Hunt.meatCount += 5;
            }
            if (random >= 2 && random < 5)
            {
                info.GetComponent<InfoText>().InfoTextReturn("You attempt to fish, and catch a small fish");     
                oilCount += 2;
                Hunt.meatCount += 2;

            }
            if (random >= 5)
            {
                info.GetComponent<InfoText>().InfoTextReturn("You attempt to fish, and catch nothing");
            }
            yield return new WaitForSeconds(20);
            delay = false;
        }
    }

    public void AttemptCatch()
    {
        StartCoroutine(CatchFish());
    }
    
   


}
