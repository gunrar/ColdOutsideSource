using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColdMessage : MonoBehaviour
{
    public GameObject info;
    public bool delay = false;
    public bool repeatOne = false;
    public bool repeatTwo = false;
    public bool repeatThree = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ColdGeneration.coldTotal >= 50)
        {
            SceneManager.LoadScene(2);
        }

        StartCoroutine(coldScript());
    }

    IEnumerator coldScript()
    {
        if (delay == false)
        {
            delay = true;
      
            if (ColdGeneration.coldTotal >= 20 && ColdGeneration.coldTotal < 30)
            {   

                info.GetComponent<Animation>().Play("Reset");
                info.GetComponent<Text>().text = "You start to lose feeling in your hands";
                info.GetComponent<Animation>().Play("InfoFade");
            }
            if (ColdGeneration.coldTotal >= 30 && ColdGeneration.coldTotal < 40)
            {
                info.GetComponent<Animation>().Play("Reset");
                info.GetComponent<Text>().text = "You can feel your extremities developing frostbite";
                info.GetComponent<Animation>().Play("InfoFade");
            }
            if (ColdGeneration.coldTotal >= 40 && ColdGeneration.coldTotal <1000)
            {
                info.GetComponent<Animation>().Play("Reset");
                info.GetComponent<Text>().text = "You look down and see your hands are black with frostbite";
                info.GetComponent<Animation>().Play("InfoFade");
            }
            yield return new WaitForSeconds(25);
            delay = false;
        }
     }
}
