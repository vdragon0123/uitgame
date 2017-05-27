﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Around : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.FindObjectOfType<Character>().speed = 2;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.FindObjectOfType<Character>().speed = 6;
        }
    }
}
