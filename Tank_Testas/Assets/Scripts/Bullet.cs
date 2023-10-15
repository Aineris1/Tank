using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Bullet : MonoBehaviour
{
    public float lifetime = 5f;
    public GameObject ExplosionVfx;
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 1000f);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Tank") || other.gameObject.CompareTag("Destructable"));
        {
            Instantiate(ExplosionVfx, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }   
}
