using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {
    private float timeScinceLastTrigger = 0f;
    private bool foundClearArea = false;
	void Update () {
        timeScinceLastTrigger += Time.deltaTime;
        if (timeScinceLastTrigger > 1f && Time.realtimeSinceStartup > 10f && !foundClearArea)
        {
            SendMessageUpwards("OnFindClearArea");
            foundClearArea = true;
        }
	}
    void OnTriggerStay()
    {
        if (GetComponent<Collider>().tag != "Player")
        {
            timeScinceLastTrigger = 0f;
        }
    }
}
