using System;
using UnityEngine;
using System.Collections;
using System.Linq.Expressions;
using Random = UnityEngine.Random;

public class RandomCoins : MonoBehaviour
{
    public Int32 CoinCount = 10;
    public GameObject EvanCoin;
    public GameObject EileenCoin;

	// Use this for initialization
	void Start () {
	    for (int i = 0; i < CoinCount; i++)
	    {
	        Instantiate(EvanCoin, new Vector3(Random.Range(-1f, 1f), Random.Range(3f, 15f), Random.Range(-1f, 1f)),
	            Quaternion.identity);
            Instantiate(EileenCoin, new Vector3(Random.Range(-1f, 1f), Random.Range(3f, 15f), Random.Range(-1f, 1f)),
                Quaternion.identity);
	    }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
