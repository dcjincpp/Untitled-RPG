using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobProjectile : MonoBehaviour
{
    public float initialSpeed = 10f;
    public float angle = 45f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        Vector3 localForward = Vector3.forward; // or your desired local direction
        Vector3 worldForward = transform.TransformDirection(localForward);
        rb.velocity = worldForward * initialSpeed + Vector3.up * 2f;
    }
}
