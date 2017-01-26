using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour {

	[SerializeField]
	private GameObject platform;
	[SerializeField]
	private GameObject diamond;
	private Vector3 lastPos;
	private float size;
	public bool gameover;
	// Use this for initialization
	void Start () {
		lastPos = platform.transform.position;
		size = platform.transform.localScale.x;
		
		for(int i = 0; i<20; i++){// when game starts spawn 20 platforms
			SpawnPlatforms();
		}

		
	}
	
	public void StartSpawningPlatforms(){
		//Task : Use a method to call the SpawnPlatforms method after a certain time and at a rate 
		
	}
	// Update is called once per frame
	void Update () {
		if (GameManager.instance.gameover == true){
			//Task : Since the game is over cancel calling the method SpawnPlatforms
		}
	}

	void SpawnPlatforms(){
		
		// Task: Complete this method by deriving some way of making the platforms spawn randomly
		
	}

	void SpawnX(){

		Vector3 pos = lastPos;
		pos.x += size;
		lastPos = pos;

		Instantiate(platform,pos,Quaternion.identity);// this creates a new platform game object at the new position with no rotation
		// P.S Quaternion.identiy is used when the gameObject should have no rotation

		
		
	}

	void SpawnZ(){
		Vector3 pos = lastPos;
		pos.z += size;
		lastPos = pos;
		
		//Task : Find a way to create the diamond game objects on platfors N.B. remember diamonds must appear above the platforms
	}
}
