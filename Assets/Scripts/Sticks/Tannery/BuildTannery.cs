using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildTannery : MonoBehaviour
{
    public GameObject cover;
    public GameObject tanneryButton;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void buildTannery()
    {
        if (GatherSticks.stickCount>=200 && Fish.oilCount>=10 && HarvestAnimal.toothCount >= 25)
        {
            GatherSticks.stickCount -= 200;
            Fish.oilCount -= 10;
            HarvestAnimal.toothCount -= 25;
            cover.GetComponent<Animation>().Play("BlacksmithyFadeIn");
            tanneryButton.SetActive(false);
        }
        
    }
}
