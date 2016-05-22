using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private float speed;
	public float thrust; 
	private Rigidbody rb; 
	void Start () {
		

		speed = 10; 

		rb = GetComponent<Rigidbody>();

	}


	//Physics code goes here
	void FixedUpdate () 
	{
		
		float moveHorizontal = Input.GetAxis ("Horizontal"); 
		float moveVertial = Input.GetAxis ("Vertical"); 
		//prams x y z
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertial); 
	

		rb.AddForce (movement * speed); 

		if (Input.GetKey (KeyCode.B)) {
			//rb.Sleep();

		rb.velocity = Vector3.zero;
		}



	}
}
