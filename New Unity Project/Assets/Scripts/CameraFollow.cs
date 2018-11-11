using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    // Use this for initialization
        GameObject player; // define var for player tag
	
        void Start () {
        player = GameObject.FindGameObjectWithTag ("Player");
        

	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position;
	}
       

        
}
