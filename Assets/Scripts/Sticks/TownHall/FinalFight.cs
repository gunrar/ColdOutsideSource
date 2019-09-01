using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalFight : MonoBehaviour
{
    public GameObject you1;
    public GameObject you2;
    public GameObject you3;
    public GameObject you4;
    public GameObject you5;
    public GameObject you6;
    public GameObject you7;
    public GameObject you8;
    public GameObject you9;
    public GameObject you10;
    public GameObject you11;
    public GameObject you12;
    public GameObject you13;
    public GameObject you14;
    public GameObject you15;
    public GameObject you16;
    public GameObject you17;
    public GameObject you18;
    public GameObject you19;
    public GameObject you20;
    public int youCount =21;
    public int themCount = 21;
    public GameObject them1;
    public GameObject them2;
    public GameObject them3;
    public GameObject them4;
    public GameObject them5;
    public GameObject them6;
    public GameObject them7;
    public GameObject them8;
    public GameObject them9;
    public GameObject them10;
    public GameObject them11;
    public GameObject them12;
    public GameObject them13;
    public GameObject them14;
    public GameObject them15;
    public GameObject them16;
    public GameObject them17;
    public GameObject them18;
    public GameObject them19;
    public GameObject them20;
    public bool delay = false;
    public bool fight;
    public int youStrength;
    public int themStrength = 15;
    public int youRandom;
    public int themRandom;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator FinalFighter()
    {
        if (!delay)
        {
            youStrength = smith.swordCount + smith.armorCount + smith.hauberkCount + GatherSticks.personCount + CatchAnimal.wolfCounter + CatchAnimal.bearCounter + CatchAnimal.bigfootCounter;
            youRandom = Random.Range(0, youStrength + 1);
            themRandom = Random.Range(0, 15);
            delay = true;
            if (youRandom >= themRandom)
            {
                themCount -= 1;
            }
            if (youRandom < themRandom)
            {
                youCount -= 1;
            }
            if (youCount == 20)
            {
                you20.SetActive(false);
            }
            if (youCount == 19)
            {
                you19.SetActive(false);
            }
            if (youCount == 18)
            {
                you18.SetActive(false);
            }
            if (youCount == 17)
            {
                you17.SetActive(false);
            }
            if (youCount == 16)
            {
                you16.SetActive(false);
            }
            if (youCount == 15)
            {
                you15.SetActive(false);
            }
            if (youCount == 14)
            {
                you14.SetActive(false);
            }
            if (youCount == 13)
            {
                you13.SetActive(false);
            }
            if (youCount == 12)
            {
                you12.SetActive(false);
            }
            if (youCount == 11)
            {
                you11.SetActive(false);
            }
            if (youCount == 10)
            {
                you10.SetActive(false);
            }
            if (youCount == 9)
            {
                you9.SetActive(false);
            }
            if (youCount == 8)
            {
                you8.SetActive(false);
            }
            if (youCount == 7)
            {
                you7.SetActive(false);
            }
            if (youCount == 6)
            {
                you6.SetActive(false);
            }
            if (youCount == 5)
            {
                you5.SetActive(false);
            }
            if (youCount == 4)
            {
                you4.SetActive(false);
            }
            if (youCount == 3)
            {
                you3.SetActive(false);
            }
            if (youCount == 2)
            {
                you2.SetActive(false);
            }
            if (youCount == 1)
            {
                you1.SetActive(false);

            }

            if (themCount == 20)
            {
                them20.SetActive(false);
            }
            if (themCount == 19)
            {
                them19.SetActive(false);
            }
            if (themCount == 18)
            {
                them18.SetActive(false);
            }
            if (themCount == 17)
            {
                them17.SetActive(false);
            }
            if (themCount == 16)
            {
                them16.SetActive(false);
            }
            if (themCount == 15)
            {
                them15.SetActive(false);
            }
            if (themCount == 14)
            {
                them14.SetActive(false);
            }
            if (themCount == 13)
            {
                them13.SetActive(false);
            }
            if (themCount == 12)
            {
                them12.SetActive(false);
            }
            if (themCount == 11)
            {
                them11.SetActive(false);
            }
            if (themCount == 10)
            {
                them10.SetActive(false);
            }
            if (themCount == 9)
            {
                them9.SetActive(false);
            }
            if (themCount == 8)
            {
                them8.SetActive(false);
            }
            if (themCount == 7)
            {
                them7.SetActive(false);
            }
            if (themCount == 6)
            {
                them6.SetActive(false);
            }
            if (themCount == 5)
            {
                them5.SetActive(false);
            }
            if (themCount == 4)
            {
                them4.SetActive(false);
            }
            if (themCount == 3)
            {
                them3.SetActive(false);
            }
            if (themCount == 2)
            {
                them2.SetActive(false);
            }
            if (themCount == 1)
            {
                them1.SetActive(false);

            }
            yield return new WaitForSeconds(.1f);
            Debug.Log("godhelpme");
            delay = false;
        }
    }
    public void beginFight()
    {
        Debug.Log("buttonispressed");
        StartCoroutine(FinalFighter());
        
    }

}

