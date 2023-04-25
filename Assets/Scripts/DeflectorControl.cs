using UnityEngine;
using System.Collections;

public class DeflectorControl : MonoBehaviour
{
    public float minRotation = 290f;
    public float maxRotation = 360f;
    public float rotation = 310f;
    public GameObject DeflectorGameObject;
    Vector3 prevPosition = new Vector3(0f,0f,0f);

	// Update is called once per physics timestep
	void FixedUpdate () {
        Vector3 rawPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
        if(prevPosition.x == 0){
            prevPosition = rawPosition;
        }

        if(rawPosition.x > prevPosition.x) {
            rotation -= 1;
            if(rotation < minRotation) {
                rotation = minRotation;
            }
            prevPosition = rawPosition;
        }

        if(rawPosition.x < prevPosition.x) {
            rotation += 1;
            if(rotation > maxRotation) {
                rotation = maxRotation;
            }
            prevPosition = rawPosition;
        }

	    DeflectorGameObject.transform.rotation = Quaternion.Euler(rotation, 270f, 0f);
	}
}
