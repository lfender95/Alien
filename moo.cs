using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moo : MonoBehaviour
{
    public AudioSource MooSound;
    // Start is called before the first frame update
    void Start()
    {
        MooSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        { MooSound.Play(); }
    }
}
