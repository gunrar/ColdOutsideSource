using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveSticks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GiveAllSticks()
    {
        GatherSticks.stickCount = 10000;
        HarvestAnimal.toothCount = 1000;
        HarvestAnimal.peltCount = 1000;
        Hunt.meatCount = 1000;
        Fish.oilCount = 1000;
        Explore.coalCount = 1000;

        Explore.ironCount = 1000;
    }
}
