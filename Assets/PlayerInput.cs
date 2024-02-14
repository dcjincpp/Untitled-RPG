using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Ray ray;
    [SerializeField] private PlayerNavMesh playerMovement;
    [SerializeField] private float rotateSpeedMovement = 5.0f;
    private float rotateVelocity = 0;

    private void Update() {

        //Moving
        if (Input.GetMouseButtonDown(1)) // Right mouse button click
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            int layer_mask = LayerMask.GetMask("Ground");

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layer_mask))
            {

                //Rotationvvvvvvvvvvvvvvvvvvvvvvvv
                Quaternion rotationToLookAt = Quaternion.LookRotation(hit.point - transform.position);
                float rotationY = Mathf.SmoothDampAngle(transform.eulerAngles.y,
                                                        rotationToLookAt.eulerAngles.y,
                                                        ref rotateVelocity,
                                                        rotateSpeedMovement/playerMovement.Speed() * (Time.deltaTime * 5));

                transform.eulerAngles = new Vector3(0, rotationY, 0);
                //Rotation^^^^^^^^^^^^^^^^^^^^^^^^

                playerMovement.Move(hit.point);
            }
        }
    }
}
