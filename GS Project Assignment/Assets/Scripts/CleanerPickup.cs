using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanerPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
    //    if (collision.gameObject.tag.Equals("Player"))
    //    {
    //        CleanerPickupDisplay.cleanerAmount += 10;
    //        Destroy(gameObject);
    //    }

        if (CleanerPickupDisplay.cleanerAmount > 100 && collision.gameObject.tag.Equals("Player"))
        {
            CleanerPickupDisplay.cleanerAmount += 0;
        } else if (CleanerPickupDisplay.cleanerAmount < 100 && collision.gameObject.tag.Equals("Player"))
        {
            CleanerPickupDisplay.cleanerAmount += 10;
            Destroy(gameObject);
        }
    }
}
