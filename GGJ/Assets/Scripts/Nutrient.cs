using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Nutrient : MonoBehaviour
{
    public GameObject player;

    public float stamina;
    public float decayMultiplier = 1;
    public Image healthBar;
    public bool hasHealthBar;

    [SerializeField] Text gameOverText;

    void Update()
    {
        if (healthBar.fillAmount <= 0 )
        {
            player.GetComponent<PlayerControls>().enabled = false;
            if(player.active)
            {
                player.SetActive(false);
                gameOverText.gameObject.SetActive(true);
                Invoke("Credits", 4f);
            }
            
        }
        else if (hasHealthBar)
        {
            healthBar.fillAmount = stamina / 100;
        }
        stamina -= Time.deltaTime*decayMultiplier;
    }

    public void Credits()
    {
        SceneManager.LoadScene(2);
    }

}
