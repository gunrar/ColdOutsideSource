using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuildHut : MonoBehaviour
{
    public GameObject buildHutButton;
    public GameObject hut;
    public GameObject fishingPole;
    public GameObject torch;
    public int hutCount = 0;
    public GameObject hut2;
    public GameObject hut3;
    public GameObject hut4;
    public GameObject bridge;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuildTheHut()
    {
        if (GatherSticks.stickCount >= 120 && Hunt.meatCount >=30)
        {
            GatherSticks.stickCount -= 120;
            Hunt.meatCount -= 30;
            hutCount += 1;
            hut.SetActive(true);
            GatherSticks.personCount += 1;
            if (hutCount == 1)
            {

                hut.GetComponent<Animation>().Play("HutFadeIn");
                RandomEventsOne.eventLog = 2;
                fishingPole.SetActive(true);
                fishingPole.GetComponent<Animation>().Play("BuildHutButtonFadeIn");
                torch.SetActive(true);
                torch.GetComponent<Animation>().Play("BuildHutButtonFadeIn");
                bridge.SetActive(true);
                bridge.GetComponent<Animation>().Play("TanneryFadeInBigBoi");
                
                

            }
            if (hutCount == 2)
            {
                hut2.SetActive(true);
                hut2.GetComponent<Animation>().Play("HutFadeIn");
                
            }
            if (hutCount == 3 )
            {
                hut3.SetActive(true);
                hut3.GetComponent<Animation>().Play("HutFadeIn");

            }
            if (hutCount == 4)
            {
                hut4.SetActive(true);
                hut4.GetComponent<Animation>().Play("HutFadeIn");
                buildHutButton.SetActive(false);

            }

        }
    }
}
