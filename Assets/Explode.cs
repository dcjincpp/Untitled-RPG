using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    [SerializeField] float damage = 3.0f;
    
    private void OnCollisionEnter(Collision other) {
        Resource damageable = other.gameObject.GetComponent<Resource>();
        if(damageable != null)
        {
            damageable.TakeDamage(damage);
        }
        
        Destroy(this.gameObject);
    }
}
