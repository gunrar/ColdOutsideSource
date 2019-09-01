using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class smith : MonoBehaviour
{
    public GameObject swordCounter;
    public GameObject armorCounter;
    public GameObject hauberkCounter;
    public static int swordCount;
    public static int armorCount;
    public static int hauberkCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        swordCounter.GetComponent<Text>().text = "Swords: " + swordCount;
        armorCounter.GetComponent<Text>().text = "Armor: " + armorCount;
        hauberkCounter.GetComponent<Text>().text = "Hauberk: " + hauberkCount;
    }
    public void makeSword()
    {
        if (Explore.ironCount >=10 && Explore.coalCount>= 5)
        {
            swordCounter.SetActive(true);
            Explore.ironCount -= 10;
            Explore.coalCount -= 5;
            swordCount += 1;
        }
    }
    public void makeArmor()
    {
        if (Explore.ironCount >= 20 && Explore.coalCount >= 5)
        {
            armorCounter.SetActive(true);
            Explore.ironCount -= 20;
            Explore.coalCount -= 5;
            armorCount += 1;
        }
    }
    public void makeHauberk()
    {
        if (HarvestAnimal.peltCount >= 15 && Fish.oilCount >= 5)
        {
            hauberkCounter.SetActive(true);
            HarvestAnimal.peltCount -= 15;
            Fish.oilCount -= 5;
            hauberkCount += 1;
        }
    }
}
