using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SneezeScript : MonoBehaviour
{
    float movespeed = 5f;
    public Rigidbody2D sneezeRB;
    PlayerDefend target;
    Vector2 moveDirection;
    public float sneezeLifetime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        sneezeRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<PlayerDefend>();
        moveDirection = (target.transform.position - transform.position).normalized * movespeed;
        sneezeRB.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, sneezeLifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            PlayerHealthDisplay.healthLevel -= 5;
        }

        if (collision.gameObject.tag.Equals("SprayParts"))
        {
            Destroy(gameObject);
        }
    }
}
