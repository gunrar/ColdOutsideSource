using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public GameObject hero;
    private Vector3 heroPosition;
    public float xPos = 0;
    public float yPos = 0;
    private Vector3 orientation;
    public GameObject weapon;
    public static bool isAttacking = false; 
    private void Start()
    {
        heroPosition = new Vector3(512, 384, 0);
    }

    void Update()
    {
        hero.transform.eulerAngles = orientation;
        hero.transform.position = heroPosition;
        StartCoroutine(moveAround());
        StartCoroutine(HeroAttack());
    }

    IEnumerator moveAround()
    {
        if (Input.GetButtonDown("Right"))
        {
            orientation = new Vector3(0, 0, 0);
            xPos += 7;
            heroPosition = new Vector3(xPos+512, yPos+384, 0);
        }
        if (Input.GetButtonDown("Up"))
        {
            orientation = new Vector3(0, 0, 90);
            yPos += 7;
            heroPosition = new Vector3(xPos + 512, yPos + 384, 0);
        }
        if (Input.GetButtonDown("Down"))
        {
            orientation = new Vector3(0, 0, 270);
            yPos -= 7;
            heroPosition = new Vector3(xPos + 512, yPos + 384, 0);
        }
        if (Input.GetButtonDown("Left"))
        {
            orientation = new Vector3(0, 0, 180);
            xPos -= 7;
            heroPosition = new Vector3(xPos + 512, yPos + 384, 0);
        }
        yield return new WaitForSeconds(0.01f);
        
    }

    IEnumerator HeroAttack()
    {
        if (!isAttacking && Input.GetButtonDown("Attack"))
        {
            isAttacking = true;
            weapon.SetActive(true);
            yield return new WaitForSeconds(0.25f);
            weapon.SetActive(false);
            isAttacking = false;
        }
    }
}
