using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockXYRotationToZero : MonoBehaviour
{
    float zRotationSpeed = 0;
    float zRotationDecrease = .02f;
    float zRotation = 0;
    float prevPositionY = 0;
    float prevPositionX = 0;

    public bool useLockXY = false;
    Rigidbody m_Rigidbody;

    void Start () {
        if(useLockXY) {
            m_Rigidbody = GetComponent<Rigidbody>();
            m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionZ;
        }
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
