using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingPole : MonoBehaviour
{
    public GameObject riverCover;
    public GameObject fishingPole;
    public GameObject fishButton;
    

    void Start()
    {

    }
    void Update()
    {

    }
    public void CraftFishingPole()
    {
        if (GatherSticks.stickCount >= 25 && HarvestAnimal.toothCount >= 10)
        {
            GatherSticks.stickCount -= 25;
            HarvestAnimal.toothCount -= 10;
            riverCover.GetComponent<Animation>().Play("RiverFadeIn");
            fishingPole.SetActive(false);
            fishButton.SetActive(true);
            fishButton.GetComponent<Animation>().Play("FishButtonFadeIn");

        }
    }
}
