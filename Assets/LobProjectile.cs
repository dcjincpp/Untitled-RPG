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

        // Calculate the initial velocity based on the launch angle
        Vector3 initialVelocity = CalculateInitialVelocity(initialSpeed, angle);

        // Apply the initial velocity to the Rigidbody
        rb.velocity = initialVelocity;
    }

    private Vector3 CalculateInitialVelocity(float speed, float launchAngle)
    {
        // Convert launch angle from degrees to radians
        float radianAngle = Mathf.Deg2Rad * launchAngle;

        // Calculate the initial velocity components
        float initialVelocityX = speed * Mathf.Cos(radianAngle);
        float initialVelocityY = speed * Mathf.Sin(radianAngle);

        // Create the initial velocity vector
        Vector3 initialVelocity = new Vector3(initialVelocityX, initialVelocityY, 0f);

        return initialVelocity;
    }
}
