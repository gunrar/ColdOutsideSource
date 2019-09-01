using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectFood : MonoBehaviour
{
    public static int appleCount = 0;
    public GameObject stickButton;
    public GameObject thisButton;
    public GameObject gatherButton;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Choose ApplePath over StickPath

    public void chooseApple()
    {
        stickButton.GetComponent<Animation>().Play("FadeOut");
        stickButton.SetActive(false);
       // thisButton.SetActive(false);
       // gatherButton.SetActive(true);
    }
}
