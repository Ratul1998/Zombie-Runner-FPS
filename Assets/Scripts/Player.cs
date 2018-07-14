using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Transform playerSpwanPoints;
    public bool reSpwan = false;
    bool lastToggle = false;
    public GameObject LandingArea;
    private Transform[] spwanPoints;
	void Start () {
        spwanPoints = playerSpwanPoints.GetComponentsInChildren<Transform>();
       
    }
	
	
	void Update () {
        if (lastToggle != reSpwan)
        {
            Respwan();
            reSpwan = false;
        }
        else
        {
            lastToggle = reSpwan;
        }
	}
    private void Respwan()
    {
        int i = Random.Range(1,spwanPoints.Length);
        transform.position = spwanPoints[i].transform.position;
    }
    void OnFindClearArea()
    {
        Invoke("DropFlare", 3f);
    }
    void DropFlare()
    {
        Instantiate(LandingArea, transform.position, transform.rotation);
    }
}
