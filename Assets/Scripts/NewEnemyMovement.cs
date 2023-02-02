using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
	private float dirX;
	public float moveSpeed;
	private Rigidbody2D RB2D;
	private bool facingRight = true;
	private Vector3 localScale;
	
    void Start()
    {
		localScale = transform.localScale;
		RB2D = GetComponent<Rigidbody2D>();
		dirX = -1f;
        
    }
//private void OnTriggerEnter2D(Collider2D coll) {
	private void OnTriggerEnter2D(Collider2D coll) {
		if (coll.GetComponent<Wall>()) {
			 dirX *= -1f;
		 }
		// if (coll.gameObject.name == "wallRat1" || coll.gameObject.name == "wallRat2")
			// dirX *= -1f;
		// Debug.Log(coll);
		// Debug.Log(coll.gameObject.name);
	}
	
	private void FixedUpdate() {
		RB2D.velocity = new Vector2(dirX * moveSpeed, RB2D.velocity.y);
	}
    
	private void LateUpdate() {
		checkWhereToFace();
	}
	
	private void checkWhereToFace() {
		if (dirX > 0)
			facingRight = false;
		else if (dirX < 0)
			facingRight = true;
		
		if(( facingRight) && (localScale.x < 0) || ((!facingRight) && (localScale.x > 0)))
			localScale.x *= -1;
		
		transform.localScale = localScale;
	}
}
