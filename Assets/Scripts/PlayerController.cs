using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float thrust; 
	private Rigidbody rb; 

	void Start () {

		rb = GetComponent<Rigidbody>();

	}
	//Physics code goes here
	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal"); 
		float moveVertial = Input.GetAxis ("Vertical"); 

		Vector3 movement = new Vector3(moveHorizontal, 0.0, moveVertial); 

		//rb.AddForce(Vector3)
	}
}
