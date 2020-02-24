using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_Controller : MonoBehaviour
{
	public CharacterController controller;
	public float speed = 12f;
	public float gravity = -9.81f;
	public Transform groundCheck;
	public float groundDistance = 0.4f;
	public LayerMask groundMask;
	public float jumpHeight = 2f;
	public float crouchScale;
	private bool isGrounded;
	private bool space;
	Vector3 velocity;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = 10;
            }
            else
            {
                speed = 5;
            }
            gameObject.transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //Checks if player is on the ground.

		if (isGrounded && velocity.y < 0)
		{
			velocity.y = -2f;
		}

        float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		if (Input.GetButtonDown("Jump") && isGrounded)
		{
			velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
		}

		if (Input.GetKey(KeyCode.LeftControl))
		{
			transform.localScale = new Vector3(1,crouchScale,1);
			Vector3 move = transform.right * x + transform.forward * z;
			controller.Move(move * (speed / 3) * Time.deltaTime); //Moves the player at third speed
		} 
		else
		{
			transform.localScale = new Vector3(1,1,1);
			Vector3 move = transform.right * x + transform.forward * z;
			controller.Move(move * speed * Time.deltaTime); //Moves the player
		}

		velocity.y += gravity * Time.deltaTime;
		controller.Move(velocity * Time.deltaTime); //This pulls the player back down to Earth.
    }
}
