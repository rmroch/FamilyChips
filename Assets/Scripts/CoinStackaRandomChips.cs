using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class CoinStackaRandomChips : MonoBehaviour
{
    public float FrontZ = -3f;
    public float BackZ = 3f;
    public float RightX = 14f;
    public float LeftX = -14f;
    public float Delay = .2f;
    public GameObject[] Chips;

    private float _curTime = 0;

    // Use this for initialization
    void Update()
    {
        _curTime += Time.deltaTime;
        if (_curTime > Delay)
        {
            _curTime = 0;
            Int32 chipIndex = Random.Range(0, Chips.Length);
            Instantiate(Chips[chipIndex],
                new Vector3(Random.Range(LeftX, RightX), Random.Range(3f, 15f), Random.Range(FrontZ, BackZ)),
                Quaternion.identity);
        }
    }
}
