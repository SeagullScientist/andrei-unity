using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public float damage = 10.0f;
    public float range = 100.0f;
    public Transform fireStart;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        LayerMask mask = LayerMask.GetMask("Terrain", "Enemy");
        RaycastHit2D hit = Physics2D.Raycast(fireStart.position, fireStart.up, range, mask);
        if (hit.collider != null)
        {
            target gametarget = hit.transform.GetComponent<target>();
            if (gametarget != null)
            {
                gametarget.TakeDamage(damage);
            }
        }
        
    }
}
