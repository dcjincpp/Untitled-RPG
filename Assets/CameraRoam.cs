using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRoam : MonoBehaviour
{

    public float camSpeed = 20.0f;
    public float screenSizeThickness = 10.0f;

    public Vector3 CameraPos;

    // Update is called once per frame
    void Update()
    {
        CameraPos = transform.position;

        //Move camera: Up
        if(Input.mousePosition.y >= Screen.height - screenSizeThickness)
        {
            CameraPos.z += camSpeed * Time.deltaTime;

        }

        //Move camera: Down
        if(Input.mousePosition.y <= screenSizeThickness)
        {
            CameraPos.z -= camSpeed * Time.deltaTime;

        }

        //Move camera: Left
        if(Input.mousePosition.x <= screenSizeThickness)
        {
            CameraPos.x -= camSpeed * Time.deltaTime;

        }

        //Move camera: Right
        if(Input.mousePosition.x >= Screen.width - screenSizeThickness)
        {
            CameraPos.x += camSpeed * Time.deltaTime;

        }

        transform.position = CameraPos;
    }
}
