using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeScript : MonoBehaviour {

    public float speed = 1.0f;
    public Color startColor;
    public Color endColor;
    float startTime;
    FieldOfViewScript fovS;

	void Start () {
        startTime = Time.time;
        GetComponent<Renderer>().material.color = startColor;
        fovS = GetComponentInParent<FieldOfViewScript>();
    }
	
	void Update () {
        float t = (Time.time - startTime) * speed;
        GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, t);
    }
}
