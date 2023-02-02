using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFightMain : MonoBehaviour

{
	
	bool fightOn = false;
	private Vector3 boulderPosition;
	private Vector3 targetPosition;
	private Rigidbody2D rb1;
	private Rigidbody2D rb2;
	private Rigidbody2D rb3;
	private GameObject boulder1;
	private GameObject boulder2;
	private GameObject boulder3;
	[SerializeField] private Animator myAnimationController;
	
	private void OnTriggerEnter2D(Collider2D other) {
		fightOn = true;
		
		if (other.CompareTag("Player"))
		{
			myAnimationController.SetBool("PlayerIsThere", true);
		}
	}
	
	void Start() {
		boulder1 = GameObject.Find("boulder1");
		boulder2 = GameObject.Find("boulder2");
		boulder3 = GameObject.Find("boulder3");
		rb1 = boulder1.GetComponent<Rigidbody2D>();
		rb2 = boulder2.GetComponent<Rigidbody2D>();
		rb3 = boulder3.GetComponent<Rigidbody2D>();
	}

	void Update() {
		
		if(fightOn){
			float timeRandom = Random.Range(0, 100);
			//Hard coded X values to spawn
			float positionRandom1 = Random.Range(144, 191);
			float positionRandom2 = Random.Range(144, 191);
			float positionRandom3 = Random.Range(144, 191);
			//Hard coded y Values to spawn
			float positionRandomVert1 = Random.Range(29, 33);
			float positionRandomVert2 = Random.Range(29, 33);
			float positionRandomVert3 = Random.Range(29, 33);
			float velocityRandom = Random.Range(-10, -1);

			rb1.gravityScale = 1f;
			rb2.gravityScale = 1f;
			rb3.gravityScale = 1f;

			if(timeRandom >= 80){

				if(transform.Find("boulder1").position.y < -1)
				{
					targetPosition = new Vector3(positionRandom1, positionRandomVert1, 0);
					transform.Find("boulder1").position = targetPosition;
					rb1.velocity = new Vector2(0, velocityRandom);
				}
				
				if(transform.Find("boulder2").position.y < -1)
				{
					targetPosition = new Vector3(positionRandom2, positionRandomVert2, 0);
					transform.Find("boulder2").position = targetPosition;
					rb2.velocity = new Vector2(0, velocityRandom);
				}

				if(transform.Find("boulder3").position.y < -1)
				{
					targetPosition = new Vector3(positionRandom3, positionRandomVert3, 0);
					transform.Find("boulder3").position = targetPosition;
					rb3.velocity = new Vector2(0, velocityRandom);
				}
			}
		}
	}
}
