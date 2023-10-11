using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;

    public GameObject AsteroidPrefab;

    private void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collsion)
    {
        Destroy(collsion.gameObject);
        Destroy(gameObject);
    }
}
