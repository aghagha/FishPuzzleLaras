using UnityEngine;
using System.Collections;

public class Shines : MonoBehaviour {
    Color origin, transparent;
    SpriteRenderer renderer;
    float speed, timer = 0;
	// Use this for initialization
	void Start () {
        renderer = gameObject.GetComponent<SpriteRenderer>();
        origin = renderer.color;
        transparent = new Color(255, 255, 255, 0);
        speed = Random.Range(1f, 3f);
	}
	
	// Update is called once per frame
	void Update () {
        renderer.color = Color.Lerp(origin, transparent, Mathf.PingPong(Time.time * speed, 1));
	}
}
