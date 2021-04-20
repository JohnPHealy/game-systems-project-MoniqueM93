using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D myRB;
    public float maxSpeed;
    public float acceleration;
    public float currentSpeed;
    public float veritcalSpeed;
    public float jumpForce;
    public bool grounded;
    public Transform animatorGO;
    float animatorGOInitial;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        animatorGOInitial = animatorGO.localScale.x;
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed = myRB.velocity.x;

        veritcalSpeed = myRB.velocity.y;

        //to check for input axis on the keyboard
        float move = Input.GetAxis("Horizontal");

        //flip animator following input
        if (move > 0)
        {
            animatorGO.localScale = new Vector3(animatorGOInitial, animatorGO.localScale.y, animatorGO.localScale.z);
        }
        else if (move < 0)
        {
            animatorGO.localScale = new Vector3(-animatorGOInitial, animatorGO.localScale.y, animatorGO.localScale.z);
        }
        //end of flipping animator

        //jump code starts
        if (Input.GetKeyDown("space") && grounded == true)
        {
            myRB.AddForce(new Vector2(0, jumpForce));
        }
        //jump code ends

        if (Mathf.Abs(currentSpeed) < maxSpeed)
        {
            myRB.AddRelativeForce(new Vector2(move * acceleration, 0));
        }
        // end of left and right code

        //animator speed
        //anim.SetFloat("speed", Mathf.Abs(currentSpeed + move));
        //anim.SetFloat("vspeed", veritcalSpeed);
        //end of animator speed
    }

    //grounded check
//    void OnTriggerStay2D(Collider2D collision)
//    {
//        if (collision.gameObject.tag != "Player")
//        {
//            grounded = true;
 //           anim.SetBool("grounded", true);
//        }
//    }

//    private void OnTriggerExit2D(Collider2D collision)
//    {
//        if (collision.gameObject.tag != "Player")
//        {
//            grounded = false;
//            anim.SetBool("grounded", false);
//        }
//    }

    // Grounded ends


}
