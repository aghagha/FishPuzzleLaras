using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {
    public GameObject clothes1, clothes2, clothes3, clothes4;
    GameObject[] clothes;
    GameObject camera;
    bool[] occupied;
    public Vector3[] pos;
    int random;
    
	void Start () {
        CheckSound();
        camera = GameObject.Find("Main Camera");
        clothes = new GameObject[4];
        occupied = new bool[4] { false, false, false, false };

        random = Random.Range(0, 3);
        clothes1.transform.position = pos[random];
        occupied[random] = true;

        random = Random.Range(0, 3);
        if (occupied[random])
        {
            while (occupied[random])
            {
                random += 1; random %= 4;
            }
        }
        clothes2.transform.position = pos[random];
        occupied[random] = true;

        random = Random.Range(0, 3);
        if (occupied[random])
        {
            while (occupied[random])
            {
                random += 1; random %= 4;
            }
        }
        clothes3.transform.position = pos[random];
        occupied[random] = true;

        random = Random.Range(0, 3);
        if (occupied[random])
        {
            while (occupied[random])
            {
                random += 1; random %= 4;
            }
        }
        clothes4.transform.position = pos[random];
        occupied[random] = true;
        
    }
	
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
	}

    public void NextLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene("Level "+ nextSceneIndex);
    }

    void CheckSound()
    {
        
    }
}
