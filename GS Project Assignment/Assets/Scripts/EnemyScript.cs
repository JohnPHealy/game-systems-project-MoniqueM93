using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public bool isSick = true;
    public GameObject sneeze;
    float fireRate;
    float nextFire;

    // Start is called efore the first frame update
    void Start()
    {
        fireRate = 6f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(isSick == true)
        {
            CheckIfTimeToFire();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("FlyMask"))
        {
            print("hit");
            isSick = false;
        }

        if (collision.gameObject.tag.Equals("Player") && isSick == true)
        {
            PlayerHealthDisplay.healthLevel -= 10;
        }
    }

    void CheckIfTimeToFire()
    {
        if(Time.time > nextFire)
        {
            Instantiate(sneeze, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
