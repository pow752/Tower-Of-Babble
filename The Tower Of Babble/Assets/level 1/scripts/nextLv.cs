using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLv : MonoBehaviour {
    public int nextlv = 0;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            Application.LoadLevel(nextlv);
        }

    }
}
