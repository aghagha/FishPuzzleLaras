using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour {

    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void Play()
    {
        SceneManager.LoadScene("Level Selector");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
