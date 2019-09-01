using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColdGeneration : MonoBehaviour
{
    public static int coldTotal = 1;
    public GameObject coldBar;
    public bool coldCooldown = false;
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(GenerateCold());
    }

    IEnumerator GenerateCold()
    {
        if (coldCooldown == false)
        {
            if (FireTimer.fireSize == 0)
            {
                coldCooldown = true;
                coldBar.GetComponent<RectTransform>().sizeDelta = new Vector2(3, coldTotal);
                yield return new WaitForSeconds(3);
                coldTotal += 2;
                coldCooldown = false;
            }
            if (FireTimer.fireSize == 1)
            {
                coldCooldown = true;
                coldBar.GetComponent<RectTransform>().sizeDelta = new Vector2(3, coldTotal);
                yield return new WaitForSeconds(3);
                coldTotal += 1;
                coldCooldown = false;
            }
            if (FireTimer.fireSize == 2)
            {
                coldCooldown = true;
                coldBar.GetComponent<RectTransform>().sizeDelta = new Vector2(3, coldTotal);
                yield return new WaitForSeconds(3);
                coldTotal += 0;
                coldCooldown = false;
            }
            if (FireTimer.fireSize == 3 && coldTotal >= 0)
            {
                coldCooldown = true;
                coldBar.GetComponent<RectTransform>().sizeDelta = new Vector2(3, coldTotal);
                yield return new WaitForSeconds(3);
                coldTotal -= 1;
                coldCooldown = false;
            }
        }
    }

  



}
