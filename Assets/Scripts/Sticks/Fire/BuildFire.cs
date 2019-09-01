using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildFire : MonoBehaviour
{
    public int internalStickCount;
    public int internalFireTime;
    public int internalFireSize = 0;
    public GameObject info;
    
    void Start()
    {
        
    }

    void Update()
    {
        internalStickCount = GatherSticks.stickCount;
        internalFireTime = FireTimer.fireTime;
        internalFireSize = FireTimer.fireSize;
        if (internalFireTime <= 1 && internalFireSize > 0)
        {
            FireTimer.fireSize -= 1;
            FireTimer.fireTime = 50;
        }




    }
    // Either increases fire size or starts fire from dead.
    public void BuildTheFire()
    {
        if (GatherSticks.stickCount > 1)
       { 
        GatherSticks.stickCount -= 2;
            if (FireTimer.fireTime <= 75)
            {
                FireTimer.fireTime += 25;
            }
            else
            {
                FireTimer.fireTime += 100 - FireTimer.fireTime;
            }
        FireTimer.fireBurning = true;
        info.GetComponent<InfoText>().InfoTextReturn("You add a few sticks to the fire");
           
        if (internalFireTime >= 90 && internalFireSize < 3)
        {
            FireTimer.fireSize += 1;
            FireTimer.fireTime = 50;
        }
        if (internalFireSize == 0 && GatherSticks.stickCount >=5)
        {
            GatherSticks.stickCount -= 4;
            FireTimer.fireSize = 1;
        }
    }
    }

 
}


