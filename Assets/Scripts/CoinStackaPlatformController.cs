using System;
using UnityEngine;
using System.Collections;
using System.Linq;

public class CoinStackaPlatformController : MonoBehaviour {
    public float Speed = .05f;
    private Rigidbody _rigidbody;

	// Use this for initialization
	void Start ()
	{
	    _rigidbody = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Int32 count = 0;
        Collider[] colliders;
        colliders = Physics.OverlapSphere(this.transform.position, 4.0f);
	    Speed = (.05f * colliders.Length);
	    if(Input.GetKey(KeyCode.RightArrow))
        {
            _rigidbody.AddForce(new Vector3(20f, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidbody.AddForce(new Vector3(-20f, 0, 0));
        }
    }
}
