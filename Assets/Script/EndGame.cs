using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

    public float limitTime;
    float time;
    public Text timeText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        timeText.text = "Time: " + ((int)time).ToString() + "/" + limitTime.ToString();
        if (time < limitTime)
        {

        }
	}

    void EndGame1()
    {

    }
}
