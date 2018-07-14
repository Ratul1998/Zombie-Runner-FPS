using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {
    public AudioClip initialHelliCall;
    public AudioClip initialCallReply;

    private AudioSource a;
    void Start()
    {
        a = GetComponent<AudioSource>();
    }
    void OnMakeInitialHeliCall()
    {
        a.clip = initialHelliCall;
        a.Play();
        Invoke("InitialReply", initialHelliCall.length + 1f);
    }
    void InitialReply()
    {
        a.clip = initialCallReply;
        a.Play();
        BroadcastMessage("Call");
    }
}
