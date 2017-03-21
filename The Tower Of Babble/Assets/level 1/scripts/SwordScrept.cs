using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScrept : MonoBehaviour {

void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="badguy")
             Destroy(other.gameObject);
    }
}
