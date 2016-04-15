using UnityEngine;
using System.Collections;

public class Tiara : MonoBehaviour {
    Color origin, transparent;
    SpriteRenderer renderer;

    // Use this for initialization
    void Start () {
        renderer = gameObject.GetComponent<SpriteRenderer>();
        origin = renderer.color;
    }
	
	// Update is called once per frame
	void Update () {
        renderer.color = Color.Lerp(origin, Color.white, Time.time * 0.5f);
    }
}
