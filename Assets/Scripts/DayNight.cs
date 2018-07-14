using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour {
    
    public float minutesPerSecond;
    private Quaternion startRotation;
	void Start () {
        startRotation = transform.rotation;
	}
	
	
	void Update () {
        float angleThisFrame = Time.deltaTime / 360 * minutesPerSecond;
        transform.RotateAround(transform.position, Vector3.forward, angleThisFrame);
	}
}
