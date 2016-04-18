using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MouseDrag : MonoBehaviour {
    // Use this for initialization
    Vector3 originalPos;
    public Vector3 truePos;
    public float minX, maxX, minY, maxY;
    NextButton nextButton;
    float distance = 9f;
    bool isFinish = false;
    Level level;
    GameObject camera;
    Animator anim;

	void Start () {
        Tresshold(0.15f, 0.11f);

        originalPos = transform.position;

        camera = GameObject.Find("Main Camera");
        level = camera.GetComponent<Level>();
        anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnMouseDown()
    {
        originalPos = transform.position;
    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPosition;
    }

    void OnMouseUp()
    {
        if (transform.position.x < maxX && transform.position.x > minX 
            && transform.position.y < maxY && transform.position.y > minY)
        {
            transform.position = truePos;
            level.IterCounter();
            anim.SetBool("isTrue", true);
            GetComponent<MouseDrag>().enabled = false;
        }
        else
        {
            transform.position = originalPos;
        }
    }

    void Tresshold(float xx, float yy)
    {
        minX = truePos.x - xx;
        maxX = truePos.x + xx;
        minY = truePos.y - yy;
        maxY = truePos.y + yy;
    }
}
