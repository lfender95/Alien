using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public Collider col;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(Vector3.forward * 10);
        if (Input.GetKey(KeyCode.DownArrow))
            rb.AddForce(Vector3.back * 10);
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(Vector3.left * 10);
        if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(Vector3.right * 10);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Car")

        {
            SceneManager.LoadScene("Win");
        }
    }
}
