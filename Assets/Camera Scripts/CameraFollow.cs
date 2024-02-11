using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;   // The target to follow
    public float smoothSpeed = 0.125f;  // The smoothness of the camera follow
    public Vector3 offset;  // The offset from the target's position

    private void Start() {
        offset = new Vector3(0.0f, 14.4f, -5.0f);;
    }

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

        }
    }
}
