using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayParticleScript : MonoBehaviour
{
    public float speed = 30f;
    public Rigidbody2D particleRB;
    public GameObject flyingParticle;
    public float lifetime = 8f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(flyingParticle, lifetime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        particleRB.velocity = transform.right * transform.localScale.x * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Virus"))
        {
            Destroy(gameObject);
        }
    }
}
