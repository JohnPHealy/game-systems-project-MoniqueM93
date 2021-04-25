using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
 //       if (collision.gameObject.tag.Equals("Player"))
 //       {
 //           PlayerHealthDisplay.healthLevel += 5;
 //           Destroy(gameObject);
  //      }

        if (PlayerHealthDisplay.healthLevel > 100 && collision.gameObject.tag.Equals("Player"))
        {
            PlayerHealthDisplay.healthLevel += 0;
        } else if (PlayerHealthDisplay.healthLevel < 100 && collision.gameObject.tag.Equals("Player"))
        {
            PlayerHealthDisplay.healthLevel += 5;
            Destroy(gameObject);
        }
    }
}
