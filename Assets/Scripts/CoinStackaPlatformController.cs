using UnityEngine;
using System.Collections;

public class CoinStackaPlatformController : MonoBehaviour {
    public float Speed = .05f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + Speed, -2.53f, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - Speed, -2.53f, 0);
        }
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, -2.53f, 0);
        gameObject.transform.rotation = Quaternion.identity;
    }
}
