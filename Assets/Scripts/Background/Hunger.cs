using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hunger : MonoBehaviour
{
    public GameObject hunger1;
    public GameObject hunger2;
    public GameObject hunger3;
    public GameObject hunger4;
    public GameObject hunger5;
    public GameObject hunger6;
    public GameObject hunger7;
    public GameObject hunger8;
    public GameObject hunger9;
    public GameObject hunger10;
    public GameObject hunger11;
    public GameObject hunger12;
    public GameObject hunger13;
    public GameObject hunger14;
    public GameObject hunger15;
    public GameObject hunger16;
    public GameObject hunger17;
    public GameObject hunger18;
    public GameObject hunger19;
    public GameObject hunger20;
    public GameObject hunger21;
    public static int hungerCount = 15;
    public bool delay = false;
    public GameObject hungerCover;
    public GameObject info;
        
    void Start()
    {
        hungerCover.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(getHungry());
    }

    IEnumerator getHungry()
    {
        if (delay == false && hungerCount >= 1)
        {
            delay = true;
            if (hungerCount == 21)
            {
                hunger21.SetActive(false);
            }
            if (hungerCount == 20)
            {
                hunger20.SetActive(false);
            }
            if (hungerCount == 19)
            {
                hunger19.SetActive(false);
            }
            if (hungerCount == 18)
            {
                hunger18.SetActive(false);
            }
            if (hungerCount == 17)
            {
                hunger17.SetActive(false);
            }
            if (hungerCount == 16)
            {
                hunger16.SetActive(false);
            }
            if (hungerCount == 15)
            {
                hunger15.SetActive(false);
            }
            if (hungerCount == 14)
            {
                hunger14.SetActive(false);
            }
            if (hungerCount == 13)
            {
                hunger13.SetActive(false);
            }
            if (hungerCount == 12)
            {
                hunger12.SetActive(false);
            }
            if (hungerCount == 11)
            {
                hunger11.SetActive(false);
            }
            if (hungerCount == 10)
            {
                hunger10.SetActive(false);
            }
            if (hungerCount == 9)
            {
                hunger9.SetActive(false);
            }
            if (hungerCount == 8)
            {
                hunger8.SetActive(false);
            }
            if (hungerCount == 7)
            {
                hunger7.SetActive(false);
            }
            if (hungerCount == 6)
            {
                hunger6.SetActive(false);
            }
            if (hungerCount == 5)
            {
                hunger5.SetActive(false);
            }
            if (hungerCount == 4)
            {
                hunger4.SetActive(false);
            }
            if (hungerCount == 3)
            {
                hunger3.SetActive(false);
            }
            if (hungerCount == 2)
            {
                hunger2.SetActive(false);
            }
            if (hungerCount == 1)
            {
                hunger1.SetActive(false);
                SceneManager.LoadScene(2);
            }
            
            hungerCount -= 1;
            yield return new WaitForSeconds(11);
            delay = false;
        }
    }
    public void eat()
    {
        if (Hunt.meatCount >= 1 && hungerCount < 21 && FireTimer.fireSize > 0)
        {
            Hunt.meatCount -= 1;
            hungerCount += 1;
            info.GetComponent<InfoText>().InfoTextReturn("You roast some meat over the fire");
            if (hungerCount == 21)
            {
                hunger21.SetActive(true);
            }
            if (hungerCount == 20)
            {
                hunger20.SetActive(true);
            }
            if (hungerCount == 19)
            {
                hunger19.SetActive(true);
            }
            if (hungerCount == 18)
            {
                hunger18.SetActive(true);
            }
            if (hungerCount == 17)
            {
                hunger17.SetActive(true);
            }
            if (hungerCount == 16)
            {
                hunger16.SetActive(true);
            }
            if (hungerCount == 15)
            {
                hunger15.SetActive(true);
            }
            if (hungerCount == 14)
            {
                hunger14.SetActive(true);
            }
            if (hungerCount == 13)
            {
                hunger13.SetActive(true);
            }
            if (hungerCount == 12)
            {
                hunger12.SetActive(true);
            }
            if (hungerCount == 11)
            {
                hunger11.SetActive(true);
            }
            if (hungerCount == 10)
            {
                hunger10.SetActive(true);
            }
            if (hungerCount == 9)
            {
                hunger9.SetActive(true);
            }
            if (hungerCount == 8)
            {
                hunger8.SetActive(true);
            }
            if (hungerCount == 7)
            {
                hunger7.SetActive(true);
            }
            if (hungerCount == 6)
            {
                hunger6.SetActive(true);
            }
            if (hungerCount == 5)
            {
                hunger5.SetActive(true);
            }
            if (hungerCount == 4)
            {
                hunger4.SetActive(true);
            }
            if (hungerCount == 3)
            {
                hunger3.SetActive(true);
            }
            if (hungerCount == 2)
            {
                hunger2.SetActive(true);
            }
            if (hungerCount == 1)
            {
                hunger1.SetActive(true);
            }
        }
    }
}
