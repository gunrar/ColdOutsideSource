using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//test
public class HarvestAnimal : MonoBehaviour
{
    public GameObject meatCounter;
    public static int peltCount = 0;
    public static int toothCount = 0;
    public GameObject peltCounter;
    public GameObject toothCounter;
    public GameObject info;

    void Start()
    {
           
    }
   
    void Update()
    {
        peltCounter.GetComponent<Text>().text = "Pelt: " + peltCount;
        toothCounter.GetComponent<Text>().text = "Teeth: " + toothCount;
    }

    public void HarvestRabbit()
    {
        if (CatchAnimal.rabbitCounter > 0)
        {
            peltCount += 1;
            Hunt.meatCount += 2;
            CatchAnimal.rabbitCounter -= 1;
            meatCounter.SetActive(true);
            info.GetComponent<InfoText>().InfoTextReturn("You harvest a rabbit, yielding some pelt and meat");
        }
    }
    public void HarvestDeer()
    {
        if (CatchAnimal.deerCounter > 0)
        {
            peltCount += 4;
            CatchAnimal.deerCounter -= 1;
            Hunt.meatCount += 5;
            meatCounter.SetActive(true);
            info.GetComponent<InfoText>().InfoTextReturn("You harvest a deer, yielding some pelt and meat");
        }
    }
    public void HarvestSquirrel()
    {
        if (CatchAnimal.squirrelCounter > 0)
        {
            toothCount += 3;
            CatchAnimal.squirrelCounter -= 1;
            Hunt.meatCount += 1;
            meatCounter.SetActive(true);
            info.GetComponent<InfoText>().InfoTextReturn("You harvest a squirrel, yielding some teeth and meat");
        }
    }

    public void HarvestWolf()
    {
        if (CatchAnimal.wolfCounter > 0)
        {
            peltCount += 3;
            CatchAnimal.wolfCounter -= 1;
            toothCount += 15;
            info.GetComponent<InfoText>().InfoTextReturn("You harvest a wolf, yielding some pelt and teeth");
        }
    }
    public void HarvestBear()
    {
        if (CatchAnimal.bearCounter > 0)
        {
            peltCount += 5;
            CatchAnimal.bearCounter -= 1;
            Hunt.meatCount += 15;
            toothCount += 10;
            info.GetComponent<InfoText>().InfoTextReturn("You harvest a bear, yielding some pelt, teeth and meat");
        }
    }

}
