using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nutrient : MonoBehaviour
{
    public GameObject player;
    public float stamina;

    public Image healthBar;
    public bool hasHealthBar;

    void Update()
    {
        if (hasHealthBar)
        {
            healthBar.fillAmount = stamina / 100;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "nutrient") ;
        {
            stamina = stamina + 10;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Rock") ;
        {
            stamina = 0;
        }
        if (collision.gameObject.tag == "Dinosaur") ;
        {
            stamina = 5;
        }
    }


}
