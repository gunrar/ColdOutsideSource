using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlacksmithyBuild : MonoBehaviour
{
    public GameObject cover;
    public GameObject blacksmithyButton;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buildBlacksmithy()
    {
        if (GatherSticks.stickCount >= 200 && Fish.oilCount >= 25 && HarvestAnimal.peltCount >= 10)
        {
            GatherSticks.stickCount -= 200;
            Fish.oilCount -= 25;
            HarvestAnimal.peltCount -= 10;
            cover.GetComponent<Animation>().Play("BlacksmithyFadeIn");
            blacksmithyButton.SetActive(false);
        }
    }
}
