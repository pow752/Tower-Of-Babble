using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLv : MonoBehaviour {
    public int nextlv = 0;
    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            Application.LoadLevel(nextlv);
        }

    }
}
