using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class WelcomePage : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
        yield return new WaitForSeconds(4.5f);
        SceneManager.LoadScene("MainMenu");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
