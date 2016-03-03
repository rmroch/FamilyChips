using System;
using UnityEngine;
using System.Collections;
using System.Linq.Expressions;
using Random = UnityEngine.Random;

public class RandomCoins : MonoBehaviour
{
    public Int32 ChipCount = 10;
    public float FrontZ = -8f;
    public float BackZ = 6f;
    public GameObject[] Chips;

	// Use this for initialization
	void Start () {

        for (int i = 0; i < ChipCount; i++)
	    {
	        Int32 chipIndex = Random.Range(0, Chips.Length);
            Instantiate(Chips[chipIndex], new Vector3(Random.Range(-1f, 1f), Random.Range(3f, 15f), Random.Range(FrontZ, BackZ)),
	            Quaternion.identity);
	    }
	}
}
