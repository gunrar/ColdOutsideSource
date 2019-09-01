using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AManApproaches : MonoBehaviour
{
    public bool hasApproached = false;
    public GameObject info;
    public GameObject buildHutButton;
    public GameObject man;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(manTalk());
    }

    IEnumerator manTalk()
    {
        if (hasApproached == false && CraftSpear.hasSpear == true && Hunger.hungerCount > 18)
        {
            
                hasApproached = true;
                yield return new WaitForSeconds(3);             
                info.GetComponent<InfoText>().InfoTextReturn("A man approaches the fire");
                GatherSticks.personCount += 1;
                man.SetActive(true);
                yield return new WaitForSeconds(3);
                info.GetComponent<InfoText>().InfoTextReturn("The man introduces himself as 'Thomas' ");
                yield return new WaitForSeconds(15);
                info.GetComponent<InfoText>().InfoTextReturn("Thomas offers to help build shelter");
                buildHutButton.SetActive(true);
                buildHutButton.GetComponent<Animation>().Play("BuildHutButtonFadeIn");
            


        }
    }
}
