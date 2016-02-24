using UnityEngine;
using System.Collections;

public class SpawnNextCoin : MonoBehaviour
{
    public bool Trigger;
    public bool IsBlueFace = true;
    public float WaitTime = 5f;
    public GameObject[] Coins;
    public GameObject SpawnGameObject;

	// Use this for initialization
	void Start ()
	{
	    StartCoroutine(SpawnCoin());
	}
	
	// Update is called once per frame
	void Update () {
	    if (Trigger)
	    {
            StartCoroutine(SpawnCoin());
	    }
	}

    public IEnumerator SpawnCoin()
    {
        Quaternion rotation = Quaternion.identity;
        Trigger = false;
        yield return new WaitForSeconds(WaitTime);
        if (IsBlueFace)
        {
            rotation = Quaternion.Euler(0, -180, 0);
            IsBlueFace = false;
        }
        else
        {
            IsBlueFace = true;
        }
        Instantiate(Coins[Random.Range(0, Coins.Length)],
            SpawnGameObject.transform.position,
            rotation);
        Trigger = true;
    }
}
