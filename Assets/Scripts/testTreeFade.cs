using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testTreeFade : MonoBehaviour
{
    public GameObject tree;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void fadeIn()
    {
        tree.GetComponent<Animation>().Play("Tree1FadeIn");
    }
}
