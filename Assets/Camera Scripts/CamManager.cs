using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager : MonoBehaviour
{

    public Camera cam;
    private float camFOV;
    public float zoomSpeed = 30.0f;

    private float mouseScrollInput;

    [SerializeField] private CameraRoam cameraRoam;
    [SerializeField] private CameraFollow cameraFollow;

    private bool camLock = true;

    // Start is called before the first frame update
    void Start()
    {
        camFOV = cam.fieldOfView;

        cameraRoam.enabled = false;
        cameraFollow.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        mouseScrollInput = Input.GetAxis("Mouse ScrollWheel");

        camFOV -= mouseScrollInput * zoomSpeed;
        camFOV = Mathf.Clamp(camFOV, 5, 60);
        
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, camFOV, zoomSpeed);

        if(camLock == false)
        {
            if(Input.GetKeyDown(KeyCode.Y))
            {
                camLock = true;

                cameraRoam.enabled = false;
                cameraFollow.enabled = true;
            }
        }
        else if(camLock == true)
        {
            if(Input.GetKeyDown(KeyCode.Y))
            {
                camLock = false;

                cameraRoam.enabled = true;
                cameraFollow.enabled = false;
            }
        }
    }
}
