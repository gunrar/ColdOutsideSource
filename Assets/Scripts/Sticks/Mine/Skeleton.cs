using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
    public int HP = 10;
    public float skeletonX;
    public float skeletonY;
    public float weaponX;
    public float weaponY;
    public GameObject weapon;
    public GameObject skeleton;
    private Vector3 skeletonPosition;
    public bool beingAttacked = false;
    public GameObject hero;
    void Start()
    {
        skeletonPosition = new Vector3(540, 384, 0);
    }

    // Update is called once per frame
    void Update()
    {
        beingAttacked = Walk.isAttacking;
        skeleton.transform.position = skeletonPosition;
        weaponX = weapon.transform.position.x;
        weaponY = weapon.transform.position.y;
        skeletonX = skeleton.transform.position.x;
        skeletonY = skeleton.transform.position.y;
        StartCoroutine(checkDamage());
        if (HP <= 0)
        {
            skeleton.SetActive(false);
        }
    }
    IEnumerator checkDamage()
    {
        if (hero.transform.eulerAngles.z == 90)
        {
            if (weaponX - skeletonX < 2 && weaponX - skeletonX > -2 && weaponY - skeletonY < 7 && weaponY - skeletonY > -7 && beingAttacked)
            {
                HP -= 10;
            }
        }
        if (hero.transform.eulerAngles.z == 270)
        {
            if (weaponX - skeletonX < 2 && weaponX - skeletonX > -2 && weaponY - skeletonY < 7 && weaponY - skeletonY > -7 && beingAttacked)
            {
                HP -= 10;
            }
        }
        if (hero.transform.eulerAngles.z == 180)
        {
            if (weaponX - skeletonX < 7 && weaponX - skeletonX > -7 && weaponY - skeletonY < 2 && weaponY - skeletonY > -2 && beingAttacked)
            {
                HP -= 10;
            }
        }
        if (hero.transform.eulerAngles.z == 0)
        {
           
            if (weaponX - skeletonX < 7 && weaponX - skeletonX > -7 && weaponY - skeletonY < 2 && weaponY - skeletonY > -2 && beingAttacked)
            {
                HP -= 10;
            }
        }
      

        yield return new WaitForSeconds(0.001f);
    }
}
