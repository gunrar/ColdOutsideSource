using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoText : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject info1;
    public GameObject info2;
    public GameObject info3;
    public int infoCounter = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InfoTextReturn(string text)
    {
        if (infoCounter == 1)
        {
            info1.GetComponent<Animation>().Play("Reset");
            info1.GetComponent<Text>().text = text;
            info1.GetComponent<Animation>().Play("InfoFade");
            infoCounter = 2;
            return;

        }
        if (infoCounter == 2)
        {
            info2.GetComponent<Animation>().Play("Reset");
            info2.GetComponent<Text>().text = text;
            info2.GetComponent<Animation>().Play("InfoFade");
            infoCounter = 3;
            return;

        }
        if (infoCounter == 3)
        {
            info3.GetComponent<Animation>().Play("Reset");
            info3.GetComponent<Text>().text = text;
            info3.GetComponent<Animation>().Play("InfoFade");
            infoCounter = 1;
            return;
        }
    }

}
