using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerExit(Collider col){
		if(col.gameObject.tag == "Ball"){
			Invoke("FallDown",.5f);
		}
	}

	void FallDown(){
		//Task : Complete the method . This method should make the platform the the ball has just passed over fall down . Remember to destroy the gameObject (to free up memory)
		
	}
}
