using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public float health = 50.0f;
    public void TakeDamage(float ammount)
    {
        health -= ammount;
        if (health <= 0.0f)
        {
            Die();
        }
        
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
