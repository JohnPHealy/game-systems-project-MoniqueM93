using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public bool isSick = true;

    // Start is called efore the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
