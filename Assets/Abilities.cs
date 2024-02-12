using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    [SerializeField] private GameObject qAbility;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(qAbility, transform.position, transform.rotation);
        }
    }
}
