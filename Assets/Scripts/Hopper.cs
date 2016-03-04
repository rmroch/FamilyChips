using UnityEngine;
using System.Collections;

public class Hopper : MonoBehaviour {
    private GameObject _gameManager;

    void Start()
    {
        _gameManager = GameObject.Find("GameManager");
    }
    private void OnCollisionEnter(Collision col)
    {
        _gameManager.GetComponent<UpdateScore>().AddAmount(1);
        Destroy(col.gameObject);
    }
}
