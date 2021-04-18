using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth = 100;
    public bool hasMasks = false;
    public bool hasCleaner = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CleanerPickupDisplay.cleanerAmount > 0)
        {
            hasCleaner = true;
        } else
        {
            hasCleaner = false;
        }

        if(MaskPickUpDisplay.maskAmount > 0)
        {
            hasMasks = true;
        } else
        {
            hasMasks = false;
        }
    }
}
