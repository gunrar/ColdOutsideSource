using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Hunt : MonoBehaviour
{ 
    public bool hasHunted = false;
    public float huntChance;
    public GameObject meatCounter;
    public static int meatCount = 0;
    public GameObject info;
    public GameObject huntButton;
    public GameObject spearButton;
    public InfoText infoTextScript;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        meatCounter.GetComponent<Text>().text = "Meat: " + meatCount;
    }

    IEnumerator attemptHunt()
    {
        if (hasHunted == false && UpgradeSpear.upgradedSpear == false)
        {
            hasHunted = true;
            PassiveIdle.needsFadeOut = true;
            PassiveIdle.isInIdle = false;
            huntButton.GetComponent<Animation>().Play("HuntTimer");
            huntChance = Random.Range(0.0f, 10.0f);
            
            if (huntChance >= 6.0)
            {
                meatCount += 3;
                meatCounter.GetComponent<Text>().text = "Meat: " + meatCount;                
                info.GetComponent<InfoText>().InfoTextReturn("You manage to kill a small creature");
            }
            if (huntChance <6.0)
            {               
                info.GetComponent<InfoText>().InfoTextReturn("You attempt to hunt but find nothing");
            }
           
            yield return new WaitForSeconds(10);
            PassiveIdle.isInIdle = true;
            PassiveIdle.needsFadeOut = false; 
            yield return new WaitForSeconds(5);
            hasHunted = false;
            
        }
        if (hasHunted == false && UpgradeSpear.upgradedSpear == true)
        {
            hasHunted = true;
            PassiveIdle.needsFadeOut = true;
            PassiveIdle.isInIdle = false;
            huntButton.GetComponent<Animation>().Play("HuntTimer");
            huntChance = Random.Range(0.0f, 10.0f);

            if (huntChance >= 7.0)
            {
                meatCount += 3;
                meatCounter.GetComponent<Text>().text = "Meat: " + meatCount;              
                info.GetComponent<InfoText>().InfoTextReturn("You manage to kill a small creature");
            }
            if (huntChance < 7.0 && huntChance >=5 )
            {
                meatCounter.GetComponent<Text>().text = "Meat: " + meatCount;
                meatCount += 10;
                HarvestAnimal.toothCount += 3;
                HarvestAnimal.peltCount += 2;
                info.GetComponent<InfoText>().InfoTextReturn("You manage to kill a large creature");
            }
            if (huntChance < 5.0)
            {               
                info.GetComponent<InfoText>().InfoTextReturn("You attempt to hunt but find nothing");
            }

            yield return new WaitForSeconds(10);
            PassiveIdle.isInIdle = true;
            PassiveIdle.needsFadeOut = false;
            yield return new WaitForSeconds(5);
            hasHunted = false;

        }
    }

    public void tryHunt()
    {
        StartCoroutine(attemptHunt());
    }
    
}
