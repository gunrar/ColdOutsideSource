using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonWalk : MonoBehaviour
{
    public bool tooFarUp;
    public bool tooFarDown;
    public bool tooFarLeft;
    public bool tooFarRight;
    public float xPos;
    public float yPos;
    public GameObject person;
    public bool delay = false;
    private Vector3 newPosition;
    public int direction;
    public GameObject fire;
    public float fireX;
    public float fireY;

    
    void Start()
    {
        fireX = fire.transform.position.x + 25;
        fireY = fire.transform.position.y +25;
    }

    void Update()
    {

        person.transform.position = newPosition;
        StartCoroutine(Walk());
    }

    IEnumerator Walk()
    {
        if (delay == false)
        {
            delay = true;
            direction = Random.Range(0, 5);
            if (direction>=0&& direction < 1)
            {
                xPos += 1;
                newPosition = new Vector3(xPos + fireX, yPos + fireY, 0);
                yield return new WaitForSeconds(1f);
                xPos += 1;
                newPosition = new Vector3(xPos + fireX, yPos + fireY, 0);
                yield return new WaitForSeconds(1f);
                xPos += 1;
                newPosition = new Vector3(xPos + fireX, yPos + fireY, 0);
                yield return new WaitForSeconds(1f);
                xPos += 1;
                newPosition = new Vector3(xPos + fireX, yPos + fireY, 0);
                yield return new WaitForSeconds(1f);

            }
            if (direction >= 1 && direction < 2)
            {
                xPos -= 1;
                newPosition = new Vector3(xPos + fireX, yPos + fireY, 0);
                yield return new WaitForSeconds(1f);
                xPos -= 1;
                newPosition = new Vector3(xPos + fireX, yPos + fireY, 0);
                yield return new WaitForSeconds(1f);
                xPos -= 1;
                newPosition = new Vector3(xPos + fireX, yPos + fireY, 0);
                yield return new WaitForSeconds(1f);
                xPos -= 1;
                newPosition = new Vector3(xPos + fireX, yPos + fireY, 0);
                yield return new WaitForSeconds(1f);

            }
            if (direction >= 2 && direction < 3)
            {
                yPos -= 1;
                newPosition = new Vector3(xPos + fireX, yPos + fireY, 0);
                yield return new WaitForSeconds(1f);
                yPos -= 1;
                newPosition = new Vector3(xPos + fireX, yPos + fireY, 0);
                yield return new WaitForSeconds(1f);
                yPos -= 1;
                newPosition = new Vector3(xPos + fireX, yPos + fireY, 0);
                yield return new WaitForSeconds(1f);
                yPos -= 1;
                newPosition = new Vector3(xPos + fireX, yPos + fireY, 0);
                yield return new WaitForSeconds(1f);

            }
            if (direction >= 3 && direction < 4)
            {
                yPos += 1;
                newPosition = new Vector3(xPos + fireX, yPos + fireY, 0);
                yield return new WaitForSeconds(1f);
                yPos += 1;
                newPosition = new Vector3(xPos + fireX, yPos + fireY, 0);
                yield return new WaitForSeconds(1f);
                yPos += 1;
                newPosition = new Vector3(xPos + fireX, yPos + fireY, 0);
                yield return new WaitForSeconds(1f);
                yPos += 1;
                newPosition = new Vector3(xPos + fireX, yPos + fireY, 0);
                yield return new WaitForSeconds(1f);

            }
            if (direction >= 4)
            {
               
                yield return new WaitForSeconds(10f);
               
            }


            person.transform.position = newPosition;
            delay = false;
        }
    }


}
