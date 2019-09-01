using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildBridge : MonoBehaviour
{

    public GameObject bridge;
    public GameObject tannery;
    public GameObject blacksmithy;
    public GameObject bridgeButton;
    public GameObject info;
    public GameObject townHall;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BuildTheBridge()
    {
        if (GatherSticks.stickCount>=500 && Explore.ironCount >=25 && Fish.oilCount >= 25)
        {
            GatherSticks.stickCount -= 500;
            Explore.ironCount -= 25;
            Fish.oilCount -= 25;
            StartCoroutine(bridgeCutscene());
            bridge.SetActive(true);
            bridge.GetComponent<Animation>().Play("BridgeFadeIn");
            tannery.SetActive(true);
            tannery.GetComponent<Animation>().Play("TanneryFadeInBigBoi");
            blacksmithy.SetActive(true);
            blacksmithy.GetComponent<Animation>().Play("BlacksmithyFadeIn");
            bridgeButton.SetActive(false);
            townHall.SetActive(true);
            townHall.GetComponent<Animation>().Play("BlacksmithyFadeIn");
        }
    }

    IEnumerator bridgeCutscene()
    {
        yield return new WaitForSeconds(5);
        info.GetComponent<InfoText>().InfoTextReturn("A small group of men approach the bridge");
        yield return new WaitForSeconds(5);
        info.GetComponent<InfoText>().InfoTextReturn("As they approach, you notice the men are wielding metal weapons");
        yield return new WaitForSeconds(5);
        info.GetComponent<InfoText>().InfoTextReturn("The men yell across the waters in a foreign toung");
        yield return new WaitForSeconds(5);
        info.GetComponent<InfoText>().InfoTextReturn("One of the men gestures at his sword, and then at the settlement");
        yield return new WaitForSeconds(5);
        info.GetComponent<InfoText>().InfoTextReturn("Eventually the men leave");
    }
}
