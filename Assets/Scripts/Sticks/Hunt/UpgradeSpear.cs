using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSpear : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool upgradedSpear = false;
    public GameObject upgradeSpear;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void upgradeTheSpear()
    {
        if (GatherSticks.stickCount >= 15 && HarvestAnimal.toothCount >= 10 && HarvestAnimal.peltCount >= 5)
        {
            GatherSticks.stickCount -= 15;
            HarvestAnimal.toothCount -= 10;
            HarvestAnimal.peltCount -= 5;
            upgradedSpear = true;
            upgradeSpear.SetActive(false);

        }
    }
}
