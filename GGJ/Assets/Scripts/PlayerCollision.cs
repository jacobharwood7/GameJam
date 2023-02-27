using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    [SerializeField] Nutrient attributes;


    // Collision Code 
    public void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.tag == "DinoSkull")
        {
            attributes.stamina -= 5;
        }
        else if (collision.gameObject.tag == "RockBoundry")
        {
            Debug.Log("We have hit the rock");
            attributes.stamina -= 10;

        }
        else if (collision.gameObject.tag == "Nuke")
        {
            attributes.stamina = 0;

        }
       else if (collision.gameObject.tag == "Ant")
        {
            attributes.stamina -= 5;
        }
        else if (collision.gameObject.tag == "AntQueen")
        {
            attributes.stamina -= 20;
        }
    }
    public void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.tag == "Toxic Waste")
        {
            attributes.decayMultiplier = 2;
        }
        if (trig.gameObject.tag == "Nutrient") 
        {
            attributes.stamina += 10;
            Destroy(trig.gameObject);
        }
        if (trig.gameObject.tag == "Body")
        {
            attributes.stamina = 3;
        }
    }

}
