using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MouseDrag : MonoBehaviour {
    // Use this for initialization
    Vector3 originalPos, finalButtonPos;
    public Vector3 truePos;
    public float minX, maxX, minY, maxY;
    NextButton nextButton;
    float distance = 9f;
    bool isFinish = false;

	void Start () {
        originalPos = transform.position;
        //truePos = new Vector3(-11.38f, 1.73f, 0f);
        finalButtonPos = new Vector3(173,-94,0);
        nextButton = GameObject.Find("Canvas/Next Button").GetComponent<NextButton>();
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
        if (tag == "True" && transform.position.x < maxX && transform.position.x > minX 
            && transform.position.y < maxY && transform.position.y > minY)
        {
            transform.position = truePos;
            nextButton.setFinishTrue();
        }
        else
        {
            transform.position = originalPos;
        }
    }
}
