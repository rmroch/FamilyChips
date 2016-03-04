using System;
using UnityEngine;
using System.Collections;
using Microsoft.Win32;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class CoinCollision : MonoBehaviour
{
    public float minForce = 8f;
    public float maxForce = 10f;
    public Rigidbody rb;
    //public AudioClip ChipHitAudioClip;

    private GameObject _springTensionSlider;
    private GameObject _gameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _gameManager = GameObject.Find("GameManager");
        _springTensionSlider = GameObject.Find("Slider");
    }

    void OnCollisionEnter(Collision col)
    {
        if (_springTensionSlider != null)
        {
            Debug.Log(string.Format("Spring Tension Slider Value: {0}",
                _springTensionSlider.GetComponent<Slider>().value));
            if (col.gameObject.name.Equals("CubeLauncher"))
            {
                rb.velocity = new Vector3(0,
                    Random.Range((minForce + _springTensionSlider.GetComponent<Slider>().value), maxForce), 0);
            }

            Int32 count = 0;
            Collider[] colliders;
            colliders = Physics.OverlapSphere(this.transform.position, 2.0f);
            Debug.Log(this.gameObject.name);
            foreach (Collider colliderObject in colliders)
            {
                if (colliderObject.name.Equals(this.gameObject.name))
                {
                    count++;
                }
            }
            Debug.Log(count);
            if (count > 2)
            {
                _gameManager.GetComponent<UpdateScore>().AddAmount(count);
                foreach (Collider colliderObject in colliders)
                {
                    if (colliderObject.name.Equals(this.gameObject.name))
                    {
                        Debug.Log("destroy");
                        Destroy(colliderObject.gameObject);
                    }
                }
            }
        }
    }
}
