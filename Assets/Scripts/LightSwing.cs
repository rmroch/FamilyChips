using UnityEngine;
using System.Collections;

public class LightSwing : MonoBehaviour
{

    public float minXRotation = -30f;
    public float maxXRotation = 30f;
    public float minYRotation = -30f;
    public float maxYRotation = 30f;
    public float speedX = 5f;
    public float speedY = 5f;

    private float xRotation = 0f;
    private float yRotation = 0f;

    private bool increaseX = true;
    private bool increaseY = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (increaseX)
	    {
	        if (xRotation + speedX > maxXRotation)
	        {
	            increaseX = false;
	        }
	        else
	        {
	            xRotation += speedX;
	        }
	    }
	    else
	    {
            if (xRotation - speedX < minXRotation)
            {
                increaseX = true;
            }
            else
            {
                xRotation -= speedX;
            }
	    }

        if (increaseY)
        {
            if (yRotation + speedY > maxYRotation)
            {
                increaseY = false;
            }
            else
            {
                yRotation += speedY;
            }
        }
        else
        {
            if (yRotation - speedY < minYRotation)
            {
                increaseY = true;
            }
            else
            {
                yRotation -= speedY;
            }
        }

        this.transform.rotation = new Quaternion(xRotation, yRotation, 0f, 0f);
	}
}
