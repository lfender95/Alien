using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO_Rotator : MonoBehaviour
{
    public int spin;

    void Update()
    {
        transform.Rotate(0, spin * Time.deltaTime, 0);
    }
}