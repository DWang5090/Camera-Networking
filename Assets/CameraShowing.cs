using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class CameraShowing : NetworkBehaviour {

    public Camera frontCamera;
    public Camera leftCamera;

	// Use this for initialization
	void Start () {
        if (isServer)
        {
            return;
        }else
        {
            frontCamera.enabled = false;
        }
	}
	
}
