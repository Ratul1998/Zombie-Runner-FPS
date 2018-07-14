using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class innerVoice : MonoBehaviour {
    public AudioClip whathappned;
    public AudioClip goodLandingArea;
    private AudioSource a;
	// Use this for initialization
	void Start () {
        a = GetComponent<AudioSource>();
        a.clip = whathappned;
        a.Play();
	}
	
	void OnFindClearArea()
    {
        a.clip = goodLandingArea;
        a.Play();

        Invoke("CallHeli", goodLandingArea.length + 1f);
    }
    void CallHeli()
    {
        SendMessageUpwards("OnMakeInitialHeliCall");
    }
}
