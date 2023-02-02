using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenPortla : MonoBehaviour
{
	
	public string sceneNames;
	
    private void OnTriggerEnter2D(Collider2D coll) {
		if (coll.name == "Player") {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
