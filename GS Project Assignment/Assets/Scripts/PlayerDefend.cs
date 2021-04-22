using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDefend : MonoBehaviour
{
    public GameObject maskToss;
    public Transform throwPoint;
    public bool hasMasks = false;
    public bool hasCleaner = false;
    public GameObject sprayPump;
 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            maskThrow();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            cleanerSpray();
        }

        if (CleanerPickupDisplay.cleanerAmount > 0)
        {
            hasCleaner = true;
        }
        else
        {
            hasCleaner = false;
        }

        if (MaskPickUpDisplay.maskAmount > 0)
        {
            hasMasks = true;
        }
        else
        {
            hasMasks = false;
        }
    }

    void maskThrow()
    {
        if (!hasMasks)
            return;

        MaskPickUpDisplay.maskAmount -= 1;
        Instantiate(maskToss, throwPoint.position, Quaternion.identity);
    }

    void cleanerSpray()
    {
        if (!hasCleaner)
            return;

        CleanerPickupDisplay.cleanerAmount -= 5;
        Instantiate(sprayPump, throwPoint.position, Quaternion.identity);
    }
}
