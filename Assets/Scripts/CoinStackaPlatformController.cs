using UnityEngine;
using System.Collections;

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
