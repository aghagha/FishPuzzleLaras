using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour {
    public Button soundButton;
    public Sprite sound, silent;
    GameObject camera;


    void Start() {
        camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update() {

    }

    public void Play()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void SetSound()
    {
        if(PlayerPrefs.GetString("Sound") == "On")
        {
            PlayerPrefs.SetString("Sound", "Off");
            soundButton.image.overrideSprite = silent;
            camera.GetComponent<AudioSource>().mute = true;

        }
        else if (PlayerPrefs.GetString("Sound") == "Off")
        {
            PlayerPrefs.SetString("Sound", "On");
            soundButton.image.overrideSprite = sound;
            camera.GetComponent<AudioSource>().mute = false;
        }
    }
}
