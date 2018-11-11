using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour {
	CameraRaycaster cameraRaycaster;
	// Use thi s for initialization
	void Start () {
		cameraRaycaster = GetComponent<CameraRaycaster>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
