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

/*	void Update () {

		if (Input.GetKey (KeyCode.B)) {
			Debug.Log ("B pushed");
			speed = speed - 10;

		}

		if (Input.GetKey(KeyCode.A))
			Debug.Log("Pressing A");

		if (Input.GetKey(KeyCode.W))
			Debug.Log("Pressing W");

		if (Input.GetKey(KeyCode.S))
			Debug.Log("Pressing S");

		if (Input.GetKey(KeyCode.D))
			Debug.Log("Pressing D");



	}
*/

	//Physics code goes here
	void FixedUpdate () 
	{
		
		float moveHorizontal = Input.GetAxis ("Horizontal"); 
		float moveVertial = Input.GetAxis ("Vertical"); 
		//prams x y z
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertial); 
	

		rb.AddForce (movement * speed); 

		if (Input.GetKey (KeyCode.B)) {
			rb.Sleep(); 
		}



	}
}
