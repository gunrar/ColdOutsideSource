using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveIdle : MonoBehaviour
{
    public static bool isInIdle = true;
    public bool loopIdle = true;
    public GameObject Passive1;
    public GameObject Passive2;
    public GameObject Passive3;
    public static bool needsFadeOut = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInIdle == true)
        {
            Passive1.SetActive(true);
            Passive2.SetActive(true);
            Passive3.SetActive(true);
            if (needsFadeOut == false)
            {
                Passive1.GetComponent<Animation>().Play("PassiveFadeIn");
                Passive2.GetComponent<Animation>().Play("PassiveFadeIn");
                Passive3.GetComponent<Animation>().Play("PassiveFadeIn");
                needsFadeOut = true;
            }
            StartCoroutine(PlayIdle());

        }
        if (isInIdle == false)
        {
            /*
            Passive1.SetActive(false);
            Passive2.SetActive(false);
            Passive3.SetActive(false);
            */
            if (needsFadeOut == true)
            {
                Passive1.GetComponent<Animation>().Play("PassiveFadeOut");
                Passive2.GetComponent<Animation>().Play("PassiveFadeOut");
                Passive3.GetComponent<Animation>().Play("PassiveFadeOut");
                needsFadeOut = false;
            }
            
        }
    }

    IEnumerator PlayIdle()
    {
        if (loopIdle == true)
        {
            loopIdle = false;
            Passive1.GetComponent<Animation>().Play("PassiveIdle");
            yield return new WaitForSeconds(0.66f);
            Passive2.GetComponent<Animation>().Play("PassiveIdle");
            yield return new WaitForSeconds(0.66f);
            Passive3.GetComponent<Animation>().Play("PassiveIdle");
            yield return new WaitForSeconds(0.66f);
            loopIdle = true;
        }
    }
}
