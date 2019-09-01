using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGlow : MonoBehaviour
{
    public float waver;
    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject box4;
    public GameObject box5;
    public GameObject box6;
    public GameObject box7;
    public GameObject box8;
    public GameObject box9;
    public GameObject box10;
    public GameObject box11;
    public GameObject box12;
    public GameObject box13;
    public GameObject box14;
    public GameObject box15;
    public GameObject box16;
    public GameObject box17;
    public GameObject box18;
    public int desiredSize = 100;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waver = Random.Range(-25f, 25f);
        if (FireTimer.fireSize > 0)
        {
            box1.GetComponent<RectTransform>().sizeDelta = new Vector2(desiredSize + waver, desiredSize + waver);
            box2.GetComponent<RectTransform>().sizeDelta = new Vector2(desiredSize + waver, desiredSize + waver);
            box3.GetComponent<RectTransform>().sizeDelta = new Vector2(desiredSize + waver, desiredSize + waver);
            box4.GetComponent<RectTransform>().sizeDelta = new Vector2(desiredSize + waver, desiredSize + waver);
            box5.GetComponent<RectTransform>().sizeDelta = new Vector2(desiredSize + waver, desiredSize + waver);
            box6.GetComponent<RectTransform>().sizeDelta = new Vector2(desiredSize + waver, desiredSize + waver);
            box7.GetComponent<RectTransform>().sizeDelta = new Vector2(desiredSize + waver, desiredSize + waver);
            box8.GetComponent<RectTransform>().sizeDelta = new Vector2(desiredSize + waver, desiredSize + waver);
            box9.GetComponent<RectTransform>().sizeDelta = new Vector2(desiredSize + waver, desiredSize + waver);
            box10.GetComponent<RectTransform>().sizeDelta = new Vector2(desiredSize + waver, desiredSize + waver);
            box11.GetComponent<RectTransform>().sizeDelta = new Vector2(desiredSize + waver, desiredSize + waver);
            box12.GetComponent<RectTransform>().sizeDelta = new Vector2(desiredSize + waver, desiredSize + waver);
            box13.GetComponent<RectTransform>().sizeDelta = new Vector2(desiredSize + waver, desiredSize + waver);
            box14.GetComponent<RectTransform>().sizeDelta = new Vector2(desiredSize + waver, desiredSize + waver);
            box15.GetComponent<RectTransform>().sizeDelta = new Vector2(desiredSize + waver, desiredSize + waver);
            box16.GetComponent<RectTransform>().sizeDelta = new Vector2(desiredSize + waver, desiredSize + waver);
            box17.GetComponent<RectTransform>().sizeDelta = new Vector2(desiredSize + waver, desiredSize + waver);
            box18.GetComponent<RectTransform>().sizeDelta = new Vector2(desiredSize + waver, desiredSize + waver);
        }
        if (FireTimer.fireSize == 0)
        {
            box1.GetComponent<RectTransform>().sizeDelta = new Vector2(0,0);
            box2.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
            box3.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
            box4.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
            box5.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
            box6.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
            box7.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
            box8.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
            box9.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
            box10.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
            box11.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
            box12.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
            box13.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
            box14.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
            box15.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
            box16.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
            box17.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
            box18.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
        }
        if (FireTimer.fireSize == 1)
        {
            desiredSize = 100;

        }
        if (FireTimer.fireSize == 2)
        {
            desiredSize = 175;
        }
        if (FireTimer.fireSize == 3)
        {
            desiredSize = 250;
        }


    }
}
