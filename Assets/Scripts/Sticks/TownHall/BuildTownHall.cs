using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildTownHall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject THBttn;
    public GameObject THCvr;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buildHall()
    {
        if (GatherSticks.stickCount>=500 && HarvestAnimal.peltCount>=25 && Fish.oilCount >= 25)
        {
            GatherSticks.stickCount -= 500;
            HarvestAnimal.peltCount -= 25;
            Fish.oilCount -= 25;
            THCvr.GetComponent<Animation>().Play("BlacksmithyFadeIn");
            THBttn.SetActive(false);


        }
    }
}
