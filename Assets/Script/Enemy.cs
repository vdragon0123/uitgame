﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public GameObject player;

    Vector3 vectorDirection;
    public Transform objectDirection;
    public GameObject posEnemy;
    GameObject posObject;

    Rigidbody rb;

    public bool isRunScript;
    bool onceTime;
    bool onceTimeAttack;

    public bool isEnemyFollow;
    public bool isEnemyBoss;
    public bool isEnemyNormal;

    float timeSacle;
    float timeRotation;
    public  bool isRotation;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        onceTime = true;
        onceTimeAttack = true;

    }
	
	// Update is called once per frame
	void Update () {
        if (isEnemyFollow)
        {
            if (!isRunScript)
            {
                if (onceTime)
                {
                    posObject = Instantiate(posEnemy, new Vector3(transform.position.x, 2.8f, transform.position.z), transform.rotation);
                    onceTime = false;
                }
            }
            if (isRunScript)
            {
                if (player != null)
                {
                    vectorDirection = objectDirection.position - transform.position;

                    /*if (transform.up != (player.transform.position - transform.position))
                        transform.Rotate(Vector3.forward * Time.deltaTime * 80);*/

                    //rb.MovePosition(transform.position + transform.up * Time.deltaTime * 3);
                    Vector3 distanceVecter3 = player.transform.position - transform.position;
                    Vector2 distanceVector2 = new Vector2(distanceVecter3.x, distanceVecter3.z);
                    /*if (Vector2.Angle(distanceVector2, new Vector2(transform.up.x, transform.up.z)) < 30f)
                    {
                        rb.MovePosition(transform.position + transform.up * Time.deltaTime * 3);
                    }
                    else
                    {
                        transform.Rotate(Vector3.forward * Time.deltaTime * 80);
                    }*/
                    //Vector2 transformVector2 = new Vector2(transform.up.x, transform.up.z);

                    LookAt2Din3D(distanceVector2, transform, 2f);
                    rb.MovePosition(transform.position + transform.up * Time.deltaTime * 10);
                }
                
            }
        }
        if (isEnemyBoss)
        {
            if (!isRunScript)
            {
                timeSacle += Time.deltaTime;
                float scaleXY = Mathf.Lerp(0, 0.5f, timeSacle / 1.5f);
                transform.localScale = new Vector3(scaleXY, scaleXY, 1);
                if (scaleXY == 0.5f)
                    isRunScript = true;
            }
            else
            {
                if (player != null)
                {
                    Vector3 distanceVecter3 = player.transform.position - transform.position;
                    Vector2 distanceVector2 = new Vector2(distanceVecter3.x, distanceVecter3.z);
                    LookAt2Din3D(distanceVector2, transform, 5f);
                    Debug.DrawLine(Vector3.zero, new Vector3(1, 0, 0), Color.red);
                    if (Vector2.Distance(new Vector2(player.transform.position.x, player.transform.position.z), new Vector2(transform.position.x, transform.position.z)) < 20f)
                    {
                        if (Vector2.Angle(distanceVector2, new Vector2(transform.up.x, transform.up.z)) < 10f)
                        {
                            if (onceTimeAttack)
                            {
                                rb.AddForce(transform.up * 7000);
                                onceTimeAttack = false;
                            }
                        }
                    }
                    else
                    {
                        onceTimeAttack = true;
                    }
                }
                
            }
        }
        if (isEnemyNormal)
        {
            if (isRunScript)
            {
                if (isRotation)
                {
                    timeRotation += Time.deltaTime;
                    float timeMax = Random.Range(0.5f, 1.5f);
                    if (timeRotation < timeMax)
                    {
                        transform.Rotate(Vector3.forward * Time.deltaTime * 80);
                        rb.MovePosition(transform.position + transform.up * Time.deltaTime * 8 * -1);
                    }
                    else
                    {
                        timeRotation = 0;
                        isRotation = false;
                    }                       
                }
                else
                    rb.MovePosition(transform.position + transform.up * Time.deltaTime * 8);
            }
        }
    }

    private float AngleBetweenVector2(Vector2 vec1, Vector2 vec2)
    {
        Vector2 diference = vec2 - vec1;
        float sign = (vec2.y < vec1.y) ? -1.0f : 1.0f;
        return Vector2.Angle(Vector2.right, diference) * sign;
    }

    private void LookAt2Din3D(Vector2 distanceVector2, Transform transform, float speed)
    {
        var angle = Mathf.Atan2(distanceVector2.x, distanceVector2.y) * Mathf.Rad2Deg;
        //angle -= (float)270;
        //transform.rotation = Quaternion.Slerp(transform.rotation, player.transform.rotation, Time.time * 1);
        var goalRotation = Quaternion.Euler(90f, angle, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, goalRotation, Time.deltaTime * speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            if (isEnemyFollow)
            {
                isRunScript = true;
                Destroy(posObject);
            }       
            if (isEnemyNormal)
            {
                isRunScript = true;
            }
        }
        if (collision.gameObject.tag == "Player")
        {
            if (isEnemyBoss)
            {
                Destroy(collision.gameObject);
            }
            if (isEnemyFollow)
            {
                Destroy(gameObject);
                player.GetComponent<Character>().direction *= -1;
                player.GetComponent<Character>().isRespawnEnemyFollow = true;
            }
            if (isEnemyNormal)
            {
                Destroy(collision.gameObject);
            }
        }
        if (collision.gameObject.tag == "Wall")
        {
            if (isEnemyNormal)
                isRotation = true;
        }
        if (collision.gameObject.tag == "EnemyFollow")
        {
            if (isEnemyNormal)
                isRotation = true;
        }
        if (collision.gameObject.tag == "EnemyBoss")
        {
            if (isEnemyNormal)
                isRotation = true;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            if (isEnemyNormal)
                isRotation = true;
        }
        if (collision.gameObject.tag == "EnemyFollow")
        {
            if (isEnemyNormal)
                isRotation = true;
        }
        if (collision.gameObject.tag == "EnemyBoss")
        {
            if (isEnemyNormal)
                isRotation = true;
        }
    }
}
