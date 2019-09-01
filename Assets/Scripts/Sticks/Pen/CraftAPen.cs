using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftAPen : MonoBehaviour
{

    public GameObject craftAPen;
    public GameObject pen;
    public GameObject catchButton;
   public void craftPen()
    {
        if (GatherSticks.stickCount>= 70)
        {
            GatherSticks.stickCount -= 70;
            craftAPen.SetActive(false);
            pen.SetActive(true);
            pen.GetComponent<Animation>().Play("PenFadeIn");
            catchButton.SetActive(true);
            catchButton.GetComponent<Animation>().Play("CatchAnimalFadeIn");

        }
    }

}
