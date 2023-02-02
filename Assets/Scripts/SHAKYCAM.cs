using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHAKYCAM : MonoBehaviour
{
    public Camera Main_Camera;
    public float cameraSize;

    private void OnTriggerEnter2D(Collider2D other) {
		Main_Camera = GameObject.Find("MainCamera").GetComponent<Camera>();
	    Main_Camera.orthographicSize = cameraSize;
		
	}
   
    
}
