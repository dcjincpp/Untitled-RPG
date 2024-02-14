using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    [Header ("Q")]
    [SerializeField] private GameObject qAbility;
    
    private int layer_mask;

    private void Start() {
        layer_mask = LayerMask.GetMask("Ground");
    }

    private void Update() {

        
        // Check for mouse input
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameObject projectile = Instantiate(qAbility, transform.position, transform.rotation);
        }

    }
}
