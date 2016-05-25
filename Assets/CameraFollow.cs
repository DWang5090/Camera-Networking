using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject induceCamera;
	// Update is called once per frame
	void Update () {
	    if(transform.position != induceCamera.transform.position)
        {
            transform.position = Vector3.Slerp(transform.position, induceCamera.transform.position, Time.deltaTime * 1.0f);
        }
	}
}
