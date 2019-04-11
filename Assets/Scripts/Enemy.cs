using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    GameObject player;
    public float dist;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(player.transform);

        dist = Vector3.Distance(transform.position, player.transform.position);

        //if player distance greater than 15 units stop looking at player
        if (dist <= 15)
        {
            transform.LookAt(player.transform);
            agent.SetDestination(player.transform.position);
        }

        //if player is closer than three units change colour to blue
        if (dist <= 3)
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        else
            GetComponent<Renderer>().material.color = Color.red;
    }
}
