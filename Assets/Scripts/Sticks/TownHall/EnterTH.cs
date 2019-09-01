using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnterTH : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject townHallScreen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnterTownhall()
    {
        townHallScreen.SetActive(true);
        
    }
    public void LeaveTownhall()
    {
        townHallScreen.SetActive(false);
    }
}
