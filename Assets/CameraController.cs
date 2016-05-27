using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Camera camera;
    private float aspect;

    void Start()
    {
        setFOV(60);
        aspect = camera.aspect;
    }

    void Update()
    {
        //Check to see if aspect ratio has changed
        //If true, the FOV needs to be recalculated
        if (!aspect.Equals(camera.aspect))
        {
            setFOV(60);
            aspect = camera.aspect;
        }

    }
   
    //Set the camera field of view
    //hFOV is the desired horizontal field of view
    void setFOV(float hFOV)
    {
        hFOV = hFOV * Mathf.Deg2Rad;
        hFOV = Mathf.Tan(hFOV / 2) / (camera.aspect);
        float vFOV = Mathf.Atan(hFOV) * 2;
        camera.fieldOfView = vFOV * Mathf.Rad2Deg;
    }

}
