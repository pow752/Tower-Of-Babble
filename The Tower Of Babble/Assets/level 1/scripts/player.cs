using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{


    public float HP = 100;
    public float speed;
    // public Rigidbody2D rb;

    public Rigidbody2D rb;
    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetTrigger("Atack");
        }


            if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(Vector2.up * speed);

            rb.AddForce(Vector2.up * speed);
            // transform.position += Vector3.right * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * speed);
            // transform.position += Vector3.right * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * speed);
            // transform.position += Vector3.right * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * speed);
            // transform.position += Vector3.right * speed;
        }

        if (Input.GetKey(KeyCode.P))
        {
            HP -= 1;
            //rb.AddForce(Vector2.right * speed);
            // transform.position += Vector3.right * speed;
        }


        if (HP <= 0)
        {
            Destroy(gameObject);
        }




    }
}
