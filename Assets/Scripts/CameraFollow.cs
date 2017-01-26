using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	[SerializeField]
	private GameObject ball;
	private Vector3 offset;
	[SerializeField]
	private float LerpRate;//this is the delay between which the camera follows the ball
	public bool gameOver;
	// Use this for initialization
	void Start () {
		offset = ball.transform.position - transform.position;
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!gameOver)
		{
			Follow();
			
		}
	}

	void Follow(){
		Vector3 pos = transform.position;
		Vector3 targetPos = ball.transform.position - offset;
		pos = //Task : complete the line by overwriting the value of pos with the position of the camera, the position of the ball and the rate at which the camera should follow the ball 
		transform.position = pos;
	}
}
