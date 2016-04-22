using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
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

    public void PlayLevel()
    {
        SceneManager.LoadScene("Level " + EventSystem.current.currentSelectedGameObject.name);
    }

    public void PlayNext()
    {
        Scene now;
        string currentLevel;
        now = SceneManager.GetActiveScene();
        currentLevel = now.name.Split(' ')[1];
        SceneManager.LoadScene("Level " + (System.Convert.ToInt32(currentLevel) + 1).ToString() );
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
