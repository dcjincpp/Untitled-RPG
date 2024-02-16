using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField] private float maxHP = 10.0f;
    private float HP;
    private GameObject woodDrop;

    // Start is called before the first frame update
    void Start()
    {
        HP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            Instantiate(woodDrop, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }

    private void TakeDamage(float damage)
    {
        HP -= damage;
    }
}
