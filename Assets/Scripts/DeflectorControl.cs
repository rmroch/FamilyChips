using UnityEngine;
using System.Collections;

public class DeflectorControl : MonoBehaviour
{
    public float minRotation = 290f;
    public float maxRotation = 360f;
    public float Rotation = 310f;
    public GameObject DeflectorGameObject;

	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.LeftArrow))
	    {
	        if (Rotation < maxRotation)
	        {
	            Rotation += 1;
	        }
	    }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (Rotation > minRotation)
            {
                Rotation -= 1;
            }
        }

	    DeflectorGameObject.transform.rotation = Quaternion.Euler(Rotation, 270f, 0f);
	}
}
