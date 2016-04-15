using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MyUnitySingleton : MonoBehaviour {
    private static MyUnitySingleton instance = null;
    public static MyUnitySingleton Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        } else {
            instance = this;
        }
        if (SceneManager.GetActiveScene().buildIndex != 6) DontDestroyOnLoad(instance);
    }
}
