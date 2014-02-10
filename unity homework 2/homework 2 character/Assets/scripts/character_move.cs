using UnityEngine;
using System.Collections;

public class character_move : MonoBehaviour {
	public float speed = 10.0F;
	public float jumpSpeed = 10.0F;
	public float gravity = 5.0F;
	public Vector3 moveDirection = Vector3.zero;

	void OnTriggerEnter (){
		transform.position = new Vector3(5.123963f,1.38792f,-2.270246f);
		                                  }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		moveDirection = Vector3.zero;
		CharacterController controller = GetComponent<CharacterController>();

		if (controller.isGrounded) {
			if (Input.GetKey(KeyCode.A))
				moveDirection += transform.forward;
			if (Input.GetKey(KeyCode.D))
			    moveDirection += -transform.forward;
				moveDirection *= speed;
//			if (Input.GetKey(KeyCode.W))
//				transform.Rotate(Vector3.right * Time.deltaTime);

		if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;
		}
		moveDirection.y -= gravity * Time.deltaTime; 
		controller.Move(moveDirection * Time.deltaTime);
		
	}
}
