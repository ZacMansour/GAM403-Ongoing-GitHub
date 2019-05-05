using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public Weapons weapons;
    public Transform firingPoint;
    public int speed = 10;

    // Update is called once per frame
    void Update()
    {
       if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(weapons.currentProjectile,firingPoint.position, firingPoint.rotation);
        }
    }
}
