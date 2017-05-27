using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

    public float limitTime;
    float time;
    public Text timeText;

    public bool endGame;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!endGame)
        {
            time += Time.deltaTime;
            timeText.text = "Time: " + ((int)time).ToString() + "/" + limitTime.ToString();
            if (time < limitTime)
            {
                if (GameObject.FindObjectOfType<Character>() == null)
                    endGame = true;
            }
            else
                endGame = true;
        }
        else
        {

        }
	}

    void EndGame1()
    {

    }
}
