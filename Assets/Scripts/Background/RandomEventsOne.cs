using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RandomEventsOne : MonoBehaviour
{
    public GameObject info;
    public bool genRandom = false;
    public int random = 10;
    public static int eventLog = 1;
    public GameObject wolf;
    public GameObject night;
    public bool isDay = true;
    public bool nightDelay = false;
    void Update()
    {
        StartCoroutine(DayNight());
        StartCoroutine(generateRandom());
        
    }
    IEnumerator generateRandom()
    {
        
        if (genRandom == false && eventLog == 1)
        {
            genRandom = true;
            
            if (random <= 1)
            {          
                info.GetComponent<InfoText>().InfoTextReturn("You hear a rustling in the forest");
            }
            if (random > 1 && random <= 2)
            {
                info.GetComponent<InfoText>().InfoTextReturn("A wolf howls in the distance");
            }
            if (random > 2 && random <= 3)
            {
                info.GetComponent<InfoText>().InfoTextReturn("the Wind chills you to the bone");
                ColdGeneration.coldTotal += 5;
            }
            if (random > 3 && random <= 4 && FireTimer.fireBurning == true)
            {
                info.GetComponent<InfoText>().InfoTextReturn("the Fire kicks up some sparks");
                if (FireTimer.fireSize >= 1)
                {
                    FireTimer.fireSize -= 1;
                }
            }

            yield return new WaitForSeconds(25);
            genRandom = false;
            random = Random.Range(0, 10);
        }



        if (genRandom == false && eventLog == 2)
        {
            genRandom = true;

            if (random <= 1)
            {
                info.GetComponent<InfoText>().InfoTextReturn("A Wolf runs through the camp");
                wolf.SetActive(true);
                wolf.GetComponent<Animation>().Play("WolfRun");
                yield return new WaitForSeconds(10);
                wolf.SetActive(false);
            }
            if (random > 1 && random <= 2)
            {
                info.GetComponent<InfoText>().InfoTextReturn("Some dogs steal meat in the night");
                if (Hunt.meatCount > 2) {
                    Hunt.meatCount -= 2;
                }
                else
                {
                    Hunt.meatCount = 0;
                }
                
            }
            if (random > 2 && random <= 3)
            {
                info.GetComponent<InfoText>().InfoTextReturn("Shouting can be heard in the distance");

            }
            if (random > 3 && random <= 4 && FireTimer.fireBurning == true)
            {
                info.GetComponent<InfoText>().InfoTextReturn("Moonlight illuminates the campsite");
                if (FireTimer.fireSize > 1)
                {
                    FireTimer.fireSize -= 1;
                }
            }

            yield return new WaitForSeconds(25);
            genRandom = false;
            random = Random.Range(0, 10);
        }
       
        

    }
    // enables the day/night cycle
    IEnumerator DayNight()
    {

        //night.SetActive(false);
        if (nightDelay == false)
        {
            nightDelay = true;
            yield return new WaitForSeconds(60);
            night.GetComponent<Animation>().Play("Sunset");
            yield return new WaitForSeconds(30);
            night.GetComponent<Animation>().Play("Sunrise");
            nightDelay = false;
        }
    }
}
