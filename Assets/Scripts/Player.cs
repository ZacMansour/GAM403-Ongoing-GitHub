using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //right click to rename variables so the rest in the script changes as well
    public Light myLight;
    public int health = 100;
    public int healthBonus = 10;
    public float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        /*normal color creates basic primary and secondary colors
         * whereas new color allows you to control RGB setting with
         * 1 being the highest value instead of it being 255*/
        myLight.color = Color.blue;
        
        //myLight.color = new Color(1, 1, 1);
        AddToHealth();

        //Adds full health
        AddToHealth(100);

        //Adds half health
        AddToHealth(50);

        //Adds tiny health
        AddToHealth(10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            AddToHealth(1);
        }

        if(Input.GetKeyDown(KeyCode.J))
        {
            AddToHealth(50);
            Debug.Log("Big Health");
        }

        if (Input.GetKeyUp(KeyCode.J))
        {
            AddToHealth(150);
            Debug.Log("Big Health Up");
        }

        float moveHorizontal = (Input.GetAxis("Horizontal"));
        float moveVertical = (Input.GetAxis("Vertical"));

        transform.Translate(new Vector3(moveHorizontal, 0.0f, moveVertical) * speed);
    }

    //both mean the same thing but += is just shorter
    //adds to our health
    void AddToHealth()
    {
       //health = health + 10;
        health += healthBonus;
    }

    /*words in brackets allow for AddToHealth to be used again in a differing way
     * if taken out it will not work as Unity can see two of the same functions*/
    void AddToHealth(int healthModifier)
    {
        health += healthModifier;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered the trigger zone");
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    private void OnTriggerStay(Collider other)
    {
        health -= 1;
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

}
