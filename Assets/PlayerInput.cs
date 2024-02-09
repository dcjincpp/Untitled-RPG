using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Ray ray;
    [SerializeField] private PlayerNavMesh playerMovement;
    private void Update() {
        if (Input.GetMouseButton(1)) // Right mouse button click
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // The ray has hit something
                Debug.Log("Hit: " + hit.collider.gameObject.name);
                Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red);
                playerMovement.Move(hit.point);
            }
        }
    }
}
