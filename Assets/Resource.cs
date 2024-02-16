using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    [SerializeField] private float maxHP = 10.0f;
    [SerializeField] GameObject woodDrop;
    private float HP;

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

    public void TakeDamage(float damage)
    {
        Mathf.Clamp(HP -= damage, 0.0f, maxHP);
        Debug.Log(HP);
    }
}
