using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomfoolery : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject Idiot;

    public void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.tag == "Stupid")
        {
            Idiot.SetActive(true);
            Invoke("StopItAll", 0.2f);
            audioSource.Play();
        }
    }

    public void StopItAll()
    {
        Idiot.SetActive(false);
    }
}
