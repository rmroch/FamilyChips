using UnityEngine;
using System.Collections;

public class SliderControl : MonoBehaviour
{
    public float zBackPos = 6f;
    public float zForwardPos = -2f;
    public float Speed = .05f;

    private bool _isMovingForward;
	
	// Update is called once per frame
	void Update ()
	{
	    //Debug.Log(string.Format("isMovingForward: {0}",_isMovingForward));
        //Debug.Log(string.Format("z: {0}", transform.position.z));

	    if (_isMovingForward)
	    {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - Speed);
            CheckBounds();
	    }
	    else
	    {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Speed);
            CheckBounds();
	    }
	}

    private void CheckBounds()
    {
        if (transform.position.z < zForwardPos)
        {
            //Debug.Log("z is less than zForwardPos");
            _isMovingForward = false;
        }

        if (transform.position.z > zBackPos)
        {
            //Debug.Log("z is more than zBackPos");
            _isMovingForward = true;
        }
    }
}
