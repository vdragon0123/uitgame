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
    public float direction;

    public bool isMoveX;
    public bool isMoveY;
    bool onceTime;

    public float tocDoGiam = 1;
    public float tocDoTang = 1;
	// Use this for initialization
	void Start () {

        health.fillAmount = 0.5f;
        maxX = GameObject.FindGameObjectWithTag("Ground").GetComponent<BoxCollider>().bounds.max.x;
        maxZ = GameObject.FindGameObjectWithTag("Ground").GetComponent<BoxCollider>().bounds.max.z;
        minX = GameObject.FindGameObjectWithTag("Ground").GetComponent<BoxCollider>().bounds.min.x;
        minZ = GameObject.FindGameObjectWithTag("Ground").GetComponent<BoxCollider>().bounds.min.z;
        Debug.Log(maxX);
        direction = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (gameObject.tag == "Around1")
        {
            timeHealth += Time.deltaTime;
            if (timeHealth > 3)
                health.fillAmount -= 0.005f / tocDoGiam;
            //Debug.Log(gameObject.GetComponent<SpriteRenderer>().bounds.max);
            if (isMoveX)
            {
                if (direction == 1)
                {
                    if (!onceTime)
                        transform.position = new Vector3(transform.position.x + Time.deltaTime * speed * direction, transform.position.y, transform.position.z);
                    if (Mathf.Abs(transform.position.x - maxX) < 0.5f)
                    {
                        transform.position = new Vector3(minX, transform.position.y, transform.position.z);
                    }
                }
                else
                {
                    if (!onceTime)
                        transform.position = new Vector3(transform.position.x + Time.deltaTime * speed * direction, transform.position.y, transform.position.z);
                    if (Mathf.Abs(transform.position.x - minX) < 0.5f)
                    {
                        transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
                    }
                }
                    
            }
            if (isMoveY)
            {
                if (direction == 1)
                {
                    if (!onceTime)
                        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Time.deltaTime * speed * direction);
                    if (Mathf.Abs(transform.position.z - maxZ) < 0.5f)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y, minZ);
                    }
                }
                else
                {
                    if (!onceTime)
                        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Time.deltaTime * speed * direction);
                    if (Mathf.Abs(transform.position.z - minZ) < 0.5f)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y, maxZ);
                    }
                }
            }
        }
        if (gameObject.tag == "Around2")
        {
            timeHealth += Time.deltaTime;
            if (timeHealth > 3)
                health.fillAmount -= 0.005f / tocDoGiam;
            if (isMoveX)
            {
                if (direction == 1)
                {
                    if (!onceTime)
                        transform.position = new Vector3(transform.position.x + Time.deltaTime * speed * direction, transform.position.y, transform.position.z);
                    if (Mathf.Abs(transform.position.x - maxX) < 0.5f)
                    {
                        transform.position = new Vector3(minX, transform.position.y, transform.position.z);
                    }
                }
                else
                {
                    if (!onceTime)
                        transform.position = new Vector3(transform.position.x + Time.deltaTime * speed * direction, transform.position.y, transform.position.z);
                    if (Mathf.Abs(transform.position.x - minX) < 0.5f)
                    {
                        transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
                    }
                }
            }
            if (isMoveY)
            {
                if (direction == 1)
                {
                    if (!onceTime)
                        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Time.deltaTime * speed * direction);
                    if (Mathf.Abs(transform.position.z - maxZ) < 0.5f)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y, minZ);
                    }
                }
                else
                {
                    if (!onceTime)
                        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Time.deltaTime * speed * direction);
                    if (Mathf.Abs(transform.position.z - minZ) < 0.5f)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y, maxZ);
                    }
                }
            }
        }
        if (gameObject.tag == "Around3")
        {
            timeHealth += Time.deltaTime;
            if (timeHealth > 3)
                health.fillAmount -= 0.005f / tocDoGiam;
            if (isMoveX)
            {
                if (direction == 1)
                {
                    if (!onceTime)
                        transform.position = new Vector3(transform.position.x + Time.deltaTime * speed * direction, transform.position.y, transform.position.z);
                    if (Mathf.Abs(transform.position.x - maxX) < 0.5f)
                    {
                        transform.position = new Vector3(minX, transform.position.y, transform.position.z);
                    }
                }
                else
                {
                    if (!onceTime)
                        transform.position = new Vector3(transform.position.x + Time.deltaTime * speed * direction, transform.position.y, transform.position.z);
                    if (Mathf.Abs(transform.position.x - minX) < 0.5f)
                    {
                        transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
                    }
                }
            }
            if (isMoveY)
            {
                if (direction == 1)
                {
                    if (!onceTime)
                        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Time.deltaTime * speed * direction);
                    if (Mathf.Abs(transform.position.z - maxZ) < 0.5f)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y, minZ);
                    }
                }
                else
                {
                    if (!onceTime)
                        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Time.deltaTime * speed * direction);
                    if (Mathf.Abs(transform.position.z - minZ) < 0.5f)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y, maxZ);
                    }
                }
            }
        }

        if (gameObject.tag == "Around4")
        {
            timeHealth += Time.deltaTime;
            if (timeHealth > 3)
                health.fillAmount -= 0.005f / tocDoGiam;
            if (isMoveX)
            {
                if (direction == 1)
                {
                    if (!onceTime)
                        transform.position = new Vector3(transform.position.x + Time.deltaTime * speed * direction, transform.position.y, transform.position.z);
                    if (Mathf.Abs(transform.position.x - maxX) < 0.5f)
                    {
                        transform.position = new Vector3(minX, transform.position.y, transform.position.z);
                    }
                }
                else
                {
                    if (!onceTime)
                        transform.position = new Vector3(transform.position.x + Time.deltaTime * speed * direction, transform.position.y, transform.position.z);
                    if (Mathf.Abs(transform.position.x - minX) < 0.5f)
                    {
                        transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
                    }
                }
            }
            if (isMoveY)
            {
                if (direction == 1)
                {
                    if (!onceTime)
                        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Time.deltaTime * speed * direction);
                    if (Mathf.Abs(transform.position.z - maxZ) < 0.5f)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y, minZ);
                    }
                }
                else
                {
                    if (!onceTime)
                        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Time.deltaTime * speed * direction);
                    if (Mathf.Abs(transform.position.z - minZ) < 0.5f)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y, maxZ);
                    }
                }
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Around1")
        {
            if (other.gameObject.tag == "Around2")
                other.gameObject.GetComponent<Around>().direction *= -1;
            if (other.gameObject.tag == "Around3")
                other.gameObject.GetComponent<Around>().direction *= -1;
            if (other.gameObject.tag == "Around4")
                other.gameObject.GetComponent<Around>().direction *= -1;
        }
        if (gameObject.tag == "Around2")
        {
            if (other.gameObject.tag == "Around1")
                other.gameObject.GetComponent<Around>().direction *= -1;
            if (other.gameObject.tag == "Around3")
                other.gameObject.GetComponent<Around>().direction *= -1;
            if (other.gameObject.tag == "Around4")
                other.gameObject.GetComponent<Around>().direction *= -1;
        }
        if (gameObject.tag == "Around3")
        {
            if (other.gameObject.tag == "Around2")
                other.gameObject.GetComponent<Around>().direction *= -1;
            if (other.gameObject.tag == "Around1")
                other.gameObject.GetComponent<Around>().direction *= -1;
            if (other.gameObject.tag == "Around4")
                other.gameObject.GetComponent<Around>().direction *= -1;
        }
        if (gameObject.tag == "Around4")
        {
            if (other.gameObject.tag == "Around2")
                other.gameObject.GetComponent<Around>().direction *= -1;
            if (other.gameObject.tag == "Around3")
                other.gameObject.GetComponent<Around>().direction *= -1;
            if (other.gameObject.tag == "Around1")
                other.gameObject.GetComponent<Around>().direction *= -1;
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
                health.fillAmount += 0.0005f * tocDoTang;

            }
        }
        if (gameObject.tag == "Around2")
        {
            if (other.gameObject.tag == "Player")
            {
                GameObject.FindObjectOfType<Character>().speed = 2;
                timeHealth = 0;
                health.fillAmount += 0.0005f * tocDoTang;

            }
        }
        if (gameObject.tag == "Around3")
        {
            if (other.gameObject.tag == "Player")
            {
                GameObject.FindObjectOfType<Character>().speed = 2;
                timeHealth = 0;
                health.fillAmount += 0.0005f * tocDoTang;

            }
        }

        if (gameObject.tag == "Around4")
        {
            if (other.gameObject.tag == "Player")
            {
                GameObject.FindObjectOfType<Character>().speed = 2;
                timeHealth = 0;
                health.fillAmount += 0.0005f * tocDoTang;

            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (gameObject.tag == "Around1")
        {
            if (other.gameObject.tag == "Player")
            {
                GameObject.FindObjectOfType<Character>().speed = GameObject.FindObjectOfType<Character>().startSpeed;
            }
        }
        if (gameObject.tag == "Around2")
        {
            if (other.gameObject.tag == "Player")
            {
                GameObject.FindObjectOfType<Character>().speed = GameObject.FindObjectOfType<Character>().startSpeed;
            }
        }
        if (gameObject.tag == "Around3")
        {
            if (other.gameObject.tag == "Player")
            {
                GameObject.FindObjectOfType<Character>().speed = GameObject.FindObjectOfType<Character>().startSpeed;
            }
        }
        if (gameObject.tag == "Around4")
        {
            if (other.gameObject.tag == "Player")
            {
                GameObject.FindObjectOfType<Character>().speed = GameObject.FindObjectOfType<Character>().startSpeed;
            }
        }
    }
}
