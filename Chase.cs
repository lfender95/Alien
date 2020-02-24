using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    public NavMeshAgent self;
    public GameObject wp1;
    public GameObject wp2;
    public GameObject wp3;
    public GameObject wp4;
    public GameObject wp5;
    public GameObject wp6;
    public GameObject wp7;
    public GameObject wp8;

    public GameObject angryGuard;
    public GameObject calmGuard;
    

    //Have a state for walking
    public bool isWalking = true;
    //have a state for chasing
    public bool isChasing = false;

    public int destPoint = 0;
    public Transform[] points;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void NextDest()
    {

        if (points.Length == 0)
            return;

        self.destination = points[destPoint].position;

        destPoint = (destPoint + 1) % points.Length;
    }
    void MoveTo(GameObject dest)
    {
        self.SetDestination(dest.transform.position);
    }
}
