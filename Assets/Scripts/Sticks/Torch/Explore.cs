using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Explore : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explore;
    public bool delay = false;
    public float random;
    public int random2;
    public static int coalCount;
    public static int ironCount;
    public GameObject info;
    public GameObject ironCounter;
    public GameObject coalCounter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ironCounter.GetComponent<Text>().text = "Iron: " + ironCount;
        coalCounter.GetComponent<Text>().text = "Coal: " + coalCount;
    }

    public void exploreMine()
    {
        SceneManager.LoadScene(1);
    }
    public void leaveMine()
    {
        SceneManager.LoadScene(0);
    }

    public void gatherMinerals()
    {
        StartCoroutine(getMinerals());
    }
    IEnumerator getMinerals()
    {
        if (delay == false)
        {
            random = Random.Range(0f, 10f);
            random2 = Random.Range(1, 6);
            delay = true;
            ironCounter.SetActive(true);
            coalCounter.SetActive(true);
            explore.GetComponent<Animation>().Play("ExploreDelay");
            if (random < 3)
            {
                info.GetComponent<InfoText>().InfoTextReturn("You search the mine, and discover some coal");
                coalCount += random2;
            }
            if (random < 5 && random >= 3)
            {
                info.GetComponent<InfoText>().InfoTextReturn("You search the mine, and discover some iron");
                ironCount += random2;
            }
            if (random < 6 && random >=5)
            {
                info.GetComponent<InfoText>().InfoTextReturn("You search the mine, and discover some coal and iron");
                coalCount += random2*random2;
                ironCount += random2;
            }
            if (random < 7 && random >= 6)
            {
                info.GetComponent<InfoText>().InfoTextReturn("You search the mine, and discover some coal and iron");
                coalCount += random2 ;
                ironCount += random2 * random2;
            }
            if (random >= 7)
            {
                info.GetComponent<InfoText>().InfoTextReturn("You search the mine, but find nothing");
                
            }

            yield return new WaitForSeconds(20);
            delay = false;
        }
    }
}
