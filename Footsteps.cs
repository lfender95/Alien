using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioClip walkSound;
    public float footstepDelay;

    private float nextFootstep = 0;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow)
            || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow))
        {
            nextFootstep -= Time.deltaTime;
            if (nextFootstep <= 0)
            {
                GetComponent<AudioSource>().PlayOneShot(walkSound, 0.7f);
                nextFootstep += footstepDelay;
            }
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S)
            || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
        {
            nextFootstep -= Time.deltaTime;
            if (nextFootstep <= 0)
            {
                GetComponent<AudioSource>().PlayOneShot(walkSound, 0.7f);
                nextFootstep += footstepDelay;
            }
        }
    }
}