using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vishonScript : MonoBehaviour {

	// Use this for initialization
	//void Start () {
        //GameObject thePlayer = GameObject.Find("ThePlayer");
       // GameObject.Find("ThePlayer").GetComponent<Ai>().seePlayer = true;
    // }
	
	// Update is called once per frame
	//void Update () {
		
	//}

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            this.transform.parent.GetComponent<Ai>().seePlayer = true;
        }

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.transform.parent.GetComponent<Ai>().atackPlayer = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.transform.parent.GetComponent<Ai>().atackPlayer = false;
        }
    }
}
