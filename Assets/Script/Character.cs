using System.Collections;
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

    public float speed = 6f;

    float timeFillAmount;
    public Image loadingImage;

    float force;
    bool onceTime;
    // Use this for initialization
    void Start () {
        rig = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        vectorDirection = objectDirection.position - transform.position;
        rig.MovePosition(transform.position + transform.up * Time.deltaTime * speed);
        if (isRotationLeftPointerDown)
            transform.Rotate(Vector3.forward * Time.deltaTime * 80);
        if (isRotationRightPointerDown)
            transform.Rotate(Vector3.forward * -1 * Time.deltaTime * 80);

        timeFillAmount += Time.deltaTime;
        loadingImage.fillAmount = Mathf.Lerp(0, 1, timeFillAmount / 3);
        

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
            rig.AddForce(transform.up * 5500);
            Time.timeScale = 1f;
        }        
    }


}
