using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
	[SerializeField]
	private GameObject particle;
	[SerializeField]
	private float speed;
	Rigidbody rb;
	private bool started;
	private bool gameOver;

	void Awake(){
		rb = GetComponent<Rigidbody>();
	}
	// Use this for initialization
	void Start () {
		started = false;
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (!started){
			if(Input.GetMouseButtonDown(0)){//accept left mouse clicks as inputs
				rb.velocity = new Vector3(speed,0,0);//move the ball initially on its x axis at a speed of speed
				started = true;

				GameManager.instance.StartGame();
			}
		}

		
		if(!Physics.Raycast(transform.position,Vector3.down,1f)){//if the ray emitted from the ball is not interacting with the platform end the game
			gameOver = true;
			rb.velocity = new Vector3(0,-25f,0);//allos the ball to fall of platform

			Camera.main.GetComponent<CameraFollow>().gameOver = true;

			GameManager.instance.GameOver();
		}

		if(Input.GetMouseButtonDown(0) && !gameOver){
			switchDirection();
		}
	}
	void switchDirection(){//switches the direction the ball move whether it moves along the z axis or x axis
		if(rb.velocity.z > 0){//if the ball is already moving along the z axis switch the direction to the x axis
			rb.velocity = new Vector3(speed,0,0);
		}
		else if (rb.velocity.x > 0){//if the ball is already moving along the x axis switch the direction to the z axis
			rb.velocity = new Vector3(0,0,speed);
		}
	}

	//Task : Implement a method that instantiates the particle effect when the 
	//ball object has entered through the diamond object
	//remember to destroy the diamond and the particle effect
	
}
