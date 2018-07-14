using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {
    private bool called = false;
    private Rigidbody r;
	// Use this for initialization
	void Start () { 
        r = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	
    public void Call()
    {
        r.velocity = new Vector3 (0, 0, 50f);
        called = true;
    }
}
