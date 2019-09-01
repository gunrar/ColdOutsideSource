using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatchAnimal : MonoBehaviour
{
    public bool hasCaught = false;
    public float catchChance;
    public GameObject catchButton;
    public GameObject rabbitCount;
    public GameObject deerCount;
    public GameObject squirrelCount;
    public GameObject wolfCount;
    public GameObject bearCount;
    public GameObject peopleCount;
    public GameObject bigfootCount;
    public static int rabbitCounter =0;
    public static int deerCounter =0;
    public static int squirrelCounter =0;
    public static int wolfCounter =0;
    public static int bearCounter =0;
    public static int peopleCounter =0;
    public static int bigfootCounter =0;
    public GameObject info;


    IEnumerator CatchAnAnimal()
    {
        if (hasCaught == false)
        {
            hasCaught = true;
            PassiveIdle.needsFadeOut = true;
            PassiveIdle.isInIdle = false;
            catchButton.GetComponent<Animation>().Play("CatchAnimalDelay");
            catchChance = Random.Range(0.0f, 100.0f);
            if (catchChance < 15.0)
            {
                rabbitCount.SetActive(true);
                rabbitCounter += 1;              
                info.GetComponent<InfoText>().InfoTextReturn("You go into the woods looking for animals, and catch a rabbit");
                rabbitCount.GetComponent<Text>().text = "Rabbits: " + rabbitCounter;
            }
            if (catchChance >= 15.0 && catchChance<30 )
            {
                squirrelCount.SetActive(true);
                squirrelCounter += 1;
                squirrelCount.GetComponent<Text>().text = "Squirrels: " + squirrelCounter;
                info.GetComponent<InfoText>().InfoTextReturn("You go into the woods looking for animals, and catch a squirrel");
            }
            if (catchChance >= 30 && catchChance < 37)
            {
                deerCount.SetActive(true);
                deerCounter += 1;
                deerCount.GetComponent<Text>().text = "Deer: " + deerCounter;
                info.GetComponent<InfoText>().InfoTextReturn("You go into the woods looking for animals, and capture a deer");
            }
            if (catchChance >= 37 && catchChance < 40)
            {
                wolfCount.SetActive(true);
                wolfCounter += 1;
                info.GetComponent<InfoText>().InfoTextReturn("You go into the woods looking for animals, and capture a wolf");
                wolfCount.GetComponent<Text>().text = "Wolves: " + wolfCounter;
            }
            if (catchChance >= 40 && catchChance < 41)
            {
                bearCount.SetActive(true);
                bearCounter += 1;
                info.GetComponent<InfoText>().InfoTextReturn("You go into the woods looking for animals, and capture a bear");
                bearCount.GetComponent<Text>().text = "Bears: " + bearCounter;
            }
            if (catchChance >= 41 && catchChance < 41.2)
            {
                peopleCount.SetActive(true);
                peopleCounter += 1;
                info.GetComponent<InfoText>().InfoTextReturn("You go into the woods looking for animals, and capture a lost child in the woods");
                peopleCount.GetComponent<Text>().text = "Slaves: " + peopleCounter;
            }
            if (catchChance >= 41.2 && catchChance < 41.4f)
            {
                bigfootCount.SetActive(true);
                bigfootCounter += 1;
                info.GetComponent<InfoText>().InfoTextReturn("You go into the woods looking for animals, and capture a strange looking ape");
                bigfootCount.GetComponent<Text>().text = "Bigfeet: " + bigfootCounter;
            }
            if (catchChance >= 29.4)
            {
                info.GetComponent<InfoText>().InfoTextReturn("You go into the woods looking for animals, and find nothing");
            }

            yield return new WaitForSeconds(10);
            PassiveIdle.needsFadeOut = false;
            PassiveIdle.isInIdle = true;
            yield return new WaitForSeconds(5);
            hasCaught = false;
        }
    }

    public void Update()
    {
        rabbitCount.GetComponent<Text>().text = "Rabbits: " + rabbitCounter;
        deerCount.GetComponent<Text>().text = "Deer: " + deerCounter;
        squirrelCount.GetComponent<Text>().text = "Squirrels: " + squirrelCounter;
        wolfCount.GetComponent<Text>().text = "Wolves: " + wolfCounter;
        bearCount.GetComponent<Text>().text = "Bear: " + bearCounter;
    }

   

   
    public void tryToCatch()
    {
        StartCoroutine(CatchAnAnimal());
    }

}
