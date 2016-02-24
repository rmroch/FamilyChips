using System;
using UnityEngine;
using System.Collections;
using Microsoft.Win32;
using Random = UnityEngine.Random;

public class CoinCollision : MonoBehaviour
{
    public float minForce = 8f;
    public float maxForce = 10f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.Equals("CubeLauncher"))
        {
            rb.velocity = new Vector3(0, Random.Range(minForce, maxForce), 0);
        }

        Int32 count = 0;
        Collider[] colliders;
        colliders = Physics.OverlapSphere(this.transform.position, 2.0f);
        Debug.Log(this.gameObject.name);
        foreach (Collider colliderObject in colliders)
        {
            if (colliderObject.name.Equals(this.gameObject.name))
            {
                count++;
            }
        }
        Debug.Log(count);
        if (count > 2)
        {
            foreach (Collider colliderObject in colliders)
            {
                if (colliderObject.name.Equals(this.gameObject.name))
                {
                    Debug.Log("destroy");
                    Destroy(colliderObject.gameObject);
                }
            }
        }
    }
}
