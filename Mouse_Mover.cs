using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Mover : MonoBehaviour
{
	public float mouseSensitivity = 100;
	public Transform playerBody;
	private float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //Hides the cursor from the screen.
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
		float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

		xRotation -= mouseY;
		xRotation = Mathf.Clamp(xRotation, -90, 90); //Keeps the player from tilting the camera too far.

		playerBody.Rotate(Vector3.up * mouseX); //Twists the entire players body, along with camera.
		transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); //Tilts just the camera, not affecting the body.
    }
}
