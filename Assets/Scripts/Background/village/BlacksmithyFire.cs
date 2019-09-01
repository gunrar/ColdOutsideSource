using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlacksmithyFire : MonoBehaviour
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
        void Update()
        {
            waver = Random.Range(-25f, 25f);
            
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
    }

