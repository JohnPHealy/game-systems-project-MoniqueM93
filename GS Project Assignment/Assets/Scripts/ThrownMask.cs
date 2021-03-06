using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrownMask : MonoBehaviour
{
    public float speed = 7.5f;
    public float flySpeed = 5;
    public Rigidbody2D maskRB;
    public GameObject thrownMask;
    public float lifetime = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(thrownMask, lifetime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        maskRB.velocity = transform.right * transform.localScale.x * speed * flySpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
