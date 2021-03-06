﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {
    GameObject camera;
    GameObject popUp;
    Animator anim;
    public int counter;
    int random;
    AudioSource sfx;
    
	void Start () {
        CheckSound();
        camera = GameObject.Find("Main Camera");
        random = Random.Range(0, 3);

        popUp = GameObject.Find("Canvas/Finish Screen");
        anim = popUp.GetComponent<Animator>();
        sfx = GameObject.Find("SFX").GetComponent<AudioSource>();
    }
	
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }

        if (counter == 0)
        {
            anim.SetBool("isFinish", true);
        }
	}

    public void NextLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene("Level "+ nextSceneIndex);
    }

    public void IterCounter()
    {
        sfx.Play();
        counter--;
    }

    void CheckSound()
    {
        
    }
}
