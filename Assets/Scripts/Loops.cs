using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public GameObject brick;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            Instantiate(brick,(Vector3.right*i*2), brick.transform.rotation);
            brick.transform.position = (Vector3.up * 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
