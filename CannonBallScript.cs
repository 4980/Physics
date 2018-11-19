using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallScript : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	Vector3 acceleration = Vector3.zero;

	Vector3 gravityConstant = new Vector3(0, -9.8f,0);

	// Use this for initialization
	void Start () {

		acceleration = new Vector3(0, 50, 0);
		
	}
	
	// Update is called once per frame
	void Update () {

		velocity += acceleration + gravityConstant * Time.deltaTime;
		transform.position += velocity * Time.deltaTime;

		if(transform.position.y < 0){
			//transform.position = new Vector3(transform.position.x, 0, transform.position.z);
			velocity.y *= -.9f;
		}

		acceleration = Vector3.zero;
		
	}
}
