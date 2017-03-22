using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour {

    public float speed;
    public bool seePlayer = false;
    public Transform player;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        if (seePlayer)
        {
            float z = Mathf.Atan2((player.transform.position.y - transform.position.y), (player.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;

            transform.eulerAngles = new Vector3(0, 0, z);
            rb.AddForce(gameObject.transform.up * speed);
        }

    }


}
