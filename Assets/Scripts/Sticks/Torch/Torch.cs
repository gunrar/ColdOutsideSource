using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mineCover;
    public GameObject explore;
    public GameObject torch;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buildTorch()
    {
        if (GatherSticks.stickCount>=10 && HarvestAnimal.peltCount >= 5 && Fish.oilCount >= 10)
        {
            GatherSticks.stickCount -= 10;
            HarvestAnimal.peltCount -= 5;
            Fish.oilCount -= 10;
            mineCover.GetComponent<Animation>().Play("MineFadeIn");
            explore.SetActive(true);
            explore.GetComponent<Animation>().Play("ExploreFadeIn");
            torch.SetActive(false);
            

        }
    }
}
