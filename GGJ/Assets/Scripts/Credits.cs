using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    private Animation anim;
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene(0);
    }

    public void Start()
    {
        Invoke("CreditsAnimation", 1.0f);
    }
    // Update is called once per frame
    public void CreditsAnimation()
    {
        anim.Play("BackDrop");
        anim.Play("Credits");
        anim.Play("Menu");
        anim.Play("Title");

    }
}
