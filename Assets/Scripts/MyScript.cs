using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public float playerSpeed;
    public float speedBurst = 2;
    public int ammo = 100;
    public int health = 100;
    public float playerAccuracyForThisMatch = 15.5f;
    public string player = "Zac";
    public Vector3 starting;

    // Comment on everything to keep track of functions
    // Start is called before the first frame update
    void Start()
    {
        ammo = ammo + 20;

        if(ammo < 10)
        {
            Debug.Log("Ammo Is Low");
        }

        Debug.Log("My Ammo Is: " + ammo);
        transform.position = starting;
        ammo = 400;
    }

    // Update is called once per frame
    void Update()
    {
        playerSpeed = playerSpeed + speedBurst;
        transform.Translate(Vector3.forward * playerSpeed);
    }
}
