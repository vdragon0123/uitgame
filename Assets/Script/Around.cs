using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Around : MonoBehaviour {

    public Image health;
    public float healthPoint;
    public float maxHealthPoint;
    float timeHealth;

    float maxX;
    float minX;
    float maxZ;
    float minZ;

    public float speed;
    float direction;

    public bool isMove;
    bool onceTime;
	// Use this for initialization
	void Start () {

        health.fillAmount = 0.5f;
        maxX = GameObject.FindGameObjectWithTag("Ground").GetComponent<BoxCollider>().bounds.max.x;
        maxZ = GameObject.FindGameObjectWithTag("Ground").GetComponent<BoxCollider>().bounds.max.z;
        minX = GameObject.FindGameObjectWithTag("Ground").GetComponent<BoxCollider>().bounds.min.x;
        minZ = GameObject.FindGameObjectWithTag("Ground").GetComponent<BoxCollider>().bounds.min.z;
        Debug.Log(maxX);
        isMove = true;
        direction = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (gameObject.tag == "Around1")
        {
            timeHealth += Time.deltaTime;
            if (timeHealth > 3)
                health.fillAmount -= 0.005f;
            //Debug.Log(gameObject.GetComponent<SpriteRenderer>().bounds.max);
            if (isMove)
            {
                if (!onceTime)
                    transform.position = new Vector3(transform.position.x + Time.deltaTime * speed * direction, transform.position.y, transform.position.z);
                if (Mathf.Abs(transform.position.x - maxX) < 0.5f)
                {
                    transform.position = new Vector3(minX, transform.position.y, transform.position.z);
                }
                    
            }
        }
        if (gameObject.tag == "Around2")
        {
            timeHealth += Time.deltaTime;
            if (timeHealth > 3)
                health.fillAmount -= 0.005f;
            if (isMove)
            {
                if (!onceTime)
                    transform.position = new Vector3(transform.position.x + Time.deltaTime * speed, transform.position.y, transform.position.z);
                if (Mathf.Abs(transform.position.x - maxX) < 0.5f)
                {
                    transform.position = new Vector3(minX, transform.position.y, transform.position.z);
                }

            }
        }
        if (gameObject.tag == "Around3")
        {
            timeHealth += Time.deltaTime;
            if (timeHealth > 3)
                health.fillAmount -= 0.005f;
            if (isMove)
            {
                if (!onceTime)
                    transform.position = new Vector3(transform.position.x + Time.deltaTime * speed, transform.position.y, transform.position.z);
                if (Mathf.Abs(transform.position.x - maxX) < 0.5f)
                {
                    transform.position = new Vector3(minX, transform.position.y, transform.position.z);
                }

            }
        }

        if (gameObject.tag == "Around4")
        {
            timeHealth += Time.deltaTime;
            if (timeHealth > 3)
                health.fillAmount -= 0.005f;
            if (isMove)
            {
                if (!onceTime)
                    transform.position = new Vector3(transform.position.x + Time.deltaTime * speed, transform.position.y, transform.position.z);
                if (Mathf.Abs(transform.position.x - maxX) < 0.5f)
                {
                    transform.position = new Vector3(minX, transform.position.y, transform.position.z);
                }

            }
        }

    }

    void OnTriggerStay(Collider other)
    {
        if (gameObject.tag == "Around1")
        {
            if (other.gameObject.tag == "Player")
            {
                GameObject.FindObjectOfType<Character>().speed = 2;
                timeHealth = 0;
                health.fillAmount += 0.005f;

            }
        }
        if (gameObject.tag == "Around2")
        {
            if (other.gameObject.tag == "Player")
            {
                GameObject.FindObjectOfType<Character>().speed = 2;
                timeHealth = 0;
                health.fillAmount += 0.005f;

            }
            else
            {
                if (other.gameObject.tag != "Enemy" && other.gameObject.tag != "Ground")
                    direction *= -1;
            }
        }
        if (gameObject.tag == "Around3")
        {
            if (other.gameObject.tag == "Player")
            {
                GameObject.FindObjectOfType<Character>().speed = 2;
                timeHealth = 0;
                health.fillAmount += 0.005f;

            }
        }

        if (gameObject.tag == "Around4")
        {
            if (other.gameObject.tag == "Player")
            {
                GameObject.FindObjectOfType<Character>().speed = 2;
                timeHealth = 0;
                health.fillAmount += 0.005f;

            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (gameObject.tag == "Around1")
        {
            if (other.gameObject.tag == "Player")
            {
                GameObject.FindObjectOfType<Character>().speed = 6;
            }
        }
        if (gameObject.tag == "Around2")
        {
            if (other.gameObject.tag == "Player")
            {
                GameObject.FindObjectOfType<Character>().speed = 6;
            }
        }
        if (gameObject.tag == "Around3")
        {
            if (other.gameObject.tag == "Player")
            {
                GameObject.FindObjectOfType<Character>().speed = 6;
            }
        }
        if (gameObject.tag == "Around4")
        {
            if (other.gameObject.tag == "Player")
            {
                GameObject.FindObjectOfType<Character>().speed = 6;
            }
        }
    }
}
