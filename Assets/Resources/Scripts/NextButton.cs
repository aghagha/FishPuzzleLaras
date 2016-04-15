using UnityEngine;
using System.Collections;

public class NextButton : MonoBehaviour {
    public Animator anim;
    bool isFinish = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (isFinish)
        {
            anim.SetBool("isFinish", true);
        }
	}

    public void setFinishTrue()
    {
        isFinish = true;
    }
}
