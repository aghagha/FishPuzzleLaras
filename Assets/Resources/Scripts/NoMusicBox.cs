using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NoMusicBox : MonoBehaviour {
    public Sprite sound, silent;
    public Button soundButton;
    GameObject camera;
    void Awake()
    {

        GameObject musicBox = GameObject.Find("Music Box");
        if (musicBox != null) Destroy(musicBox.gameObject);

        camera = GameObject.Find("Main Camera");
        if (PlayerPrefs.GetString("Sound") == null) PlayerPrefs.SetString("Sound", "On");
    }
    // Use this for initialization
    void Start () {
        UpdateSoundButton();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void UpdateSoundButton()
    {
        if (PlayerPrefs.GetString("Sound") == "On")
        {
            soundButton.image.overrideSprite = sound;
            camera.GetComponent<AudioSource>().mute = false;
        }
        else if (PlayerPrefs.GetString("Sound") == "Off")
        {
            soundButton.image.overrideSprite = silent;
            camera.GetComponent<AudioSource>().mute = true;
        }
    }
}
