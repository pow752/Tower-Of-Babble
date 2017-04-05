using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelthStuff : MonoBehaviour {
    public GameObject playerStuff;
    public GameObject UI;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (playerStuff.GetComponent<player>().HP<=65)
        {
            heart3.SetActive(false);
            if (playerStuff.GetComponent<player>().HP <= 25)
            {
                heart2.SetActive(false);
            }
        }

        if (playerStuff.GetComponent<player>().HP >= 70)
        {
            heart3.SetActive(true);
            if (playerStuff.GetComponent<player>().HP >= 30)
            {
                heart3.SetActive(true);
            }
        }



    }
}
