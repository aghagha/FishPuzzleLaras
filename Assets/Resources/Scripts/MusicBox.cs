using UnityEngine;
using System.Collections;

public class MusicBox : MonoBehaviour {

	void Awake () {
        if (PlayerPrefs.GetString("Sound") == "Off")
        {
            GetComponent<AudioSource>().enabled = false;
        }
        else if (PlayerPrefs.GetString("Sound") == "On")
        {
            GetComponent<AudioSource>().enabled = true;
        }
    }
	
    void Start()
    {
        print(PlayerPrefs.GetString("Sound"));
    }

	void Update () {
	
	}

}
