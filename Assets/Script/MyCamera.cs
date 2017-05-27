using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour {

    public Transform player;
    Vector3 distance;
    Vector3 beforeTransformPlayer;
    Vector3 distance2;
	// Use this for initialization
	void Start () {
        distance = transform.position - player.position;
        beforeTransformPlayer = player.transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        if (player != null)
        {
            float deltaX = player.transform.position.x - beforeTransformPlayer.x;
            float deltaZ = player.transform.position.z - beforeTransformPlayer.z;
            transform.position = new Vector3(transform.position.x + deltaX / 2, transform.position.y + deltaZ * (transform.forward + transform.up).y / 11, transform.position.z + deltaZ * (transform.forward + transform.up).z / 11);

            beforeTransformPlayer = player.transform.position;
        }
    }
}
