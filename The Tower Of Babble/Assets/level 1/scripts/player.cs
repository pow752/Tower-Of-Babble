using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{


    public float HP = 100;
    public float speed;
    public int nextlv = 0;

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

        var mousePosishon = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosishon, Vector3.forward );
        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        rb.angularVelocity = 0;

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

            Application.LoadLevel(5);
          //  Destroy(gameObject);
        }




    }

    public void takeDamage(float dps)
    {
        HP -= dps;
    }

}
