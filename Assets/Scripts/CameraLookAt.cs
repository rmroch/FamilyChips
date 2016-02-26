using UnityEngine;
using System.Collections;

public class CameraLookAt : MonoBehaviour
{
    public GameObject camera;
    public GameObject chip;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (chip != null)
	    {
	        camera.transform.LookAt(chip.transform);
	    }
	}
}
