using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

    void OnCollisionEnter(Collision col)
	{
        Destroy(col.gameObject);
	}
}
