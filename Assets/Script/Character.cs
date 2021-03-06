﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour {

    Rigidbody rig;
    Vector3 vectorDirection;
    public Transform objectDirection;

    public bool isRotationLeftPointerDown;
    public bool isRotationRightPointerDown;
    public bool isAddForcePointerDown;

    public float speed = 10f;
    public float startSpeed;

    float timeFillAmount;
    public Image loadingImage;

    float force;
    bool onceTime;

    public float direction;

    float timeRespawnEnemyFollow;
    public bool isRespawnEnemyFollow;
    public GameObject enemyFollow;
    // Use this for initialization
    void Start () {
        rig = GetComponent<Rigidbody>();
        direction = 1;
        startSpeed = speed;
	}
	
	// Update is called once per frame
	void Update () {
        if (isRespawnEnemyFollow)
        {
            timeRespawnEnemyFollow += Time.deltaTime;
            if (timeRespawnEnemyFollow > 5f)
            {
                isRespawnEnemyFollow = false;
                float maxX = GameObject.FindGameObjectWithTag("Ground").GetComponent<BoxCollider>().bounds.max.x;
                float maxZ = GameObject.FindGameObjectWithTag("Ground").GetComponent<BoxCollider>().bounds.max.z;
                float minX = GameObject.FindGameObjectWithTag("Ground").GetComponent<BoxCollider>().bounds.min.x;
                float minZ = GameObject.FindGameObjectWithTag("Ground").GetComponent<BoxCollider>().bounds.min.z;
                float posX = Random.Range(minX + 20, maxX - 20);
                float posZ = Random.Range(minZ + 20, maxZ - 20);
                var go = Instantiate(enemyFollow, new Vector3(posX, 45f, posZ), transform.rotation);
                timeRespawnEnemyFollow = 0;
                go.GetComponent<Enemy>().isEnemyFollow = true;
                go.GetComponent<Enemy>().player = gameObject;
            }
        }
        vectorDirection = objectDirection.position - transform.position;
        rig.MovePosition(transform.position + transform.up * Time.deltaTime * speed * direction);
        if (isRotationLeftPointerDown)
            transform.Rotate(Vector3.forward * Time.deltaTime * 80);
        if (isRotationRightPointerDown)
            transform.Rotate(Vector3.forward * -1 * Time.deltaTime * 80);

        timeFillAmount += Time.deltaTime;
        loadingImage.fillAmount = Mathf.Lerp(0, 1, timeFillAmount / 3);
            
        Debug.Log(Vector2.Angle(Vector2.up, new Vector2(transform.up.x, transform.up.z)));
        if (isAddForcePointerDown)
        {
            /*onceTime = false;
            Time.timeScale = 0.5f;
            timeFillAmount += Time.deltaTime;
            force = Mathf.Lerp(2000, 8000, timeFillAmount / 1);
            loadingImage.fillAmount = Mathf.Lerp(0, 1, timeFillAmount / 1);
            if (loadingImage.fillAmount == 1)
            {
                onceTime = true;
                isAddForcePointerDown = false;
                timeFillAmount = 0;
                loadingImage.fillAmount = 0;
                rig.AddForce(transform.up * force);
                Time.timeScale = 1f;
            }*/
            
        }
    }

    public void AddForceForward()
    {
        rig.AddForce(vectorDirection.normalized * 800);
    }

    public void RotationLeftPointerDown()
    {
        isRotationLeftPointerDown = true;
    }

    public void RotationLeftPointerUp()
    {
        isRotationLeftPointerDown = false;
    }

    public void RotationRightPointerDown()
    {
        isRotationRightPointerDown = true;
    }

    public void RotationRightPointerUp()
    {
        isRotationRightPointerDown = false;
    }

    public void AddForcePointerDown()
    {
        if (loadingImage.fillAmount == 1)
        {
            isAddForcePointerDown = true;
        }
        
    }

    public void AddForcePointerUp()
    {
        if (isAddForcePointerDown)
        {
            isAddForcePointerDown = false;
            timeFillAmount = 0;
            loadingImage.fillAmount = 0;
            rig.AddForce(transform.up * 5500 * direction);
            Time.timeScale = 1f;
        }        
    }


}
