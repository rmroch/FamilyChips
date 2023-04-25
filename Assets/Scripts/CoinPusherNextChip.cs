using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class CoinPusherNextChip : MonoBehaviour
{
    private bool _isChipInHand = false;
    private float _timeLeft;
    private GameObject _chipInHand;
    private Vector3 _offset;
    private Vector3 _screenPoint;
    public Camera cam;

    public float TimeBetweenChips = 10f;
    public float LeftEdge = 5.4f;
    public float RightEdge = -5.4f;
    public GameObject[] Chips;

	// Use this for initialization
	void Start () {
        if (cam == null)
        {
            cam = Camera.main;
        }
	}
	
	// Update is called once per frame
	void Update () {
        _timeLeft -= Time.deltaTime;
	    if (_isChipInHand == false
            && _timeLeft < 0)
	    {
	        _isChipInHand = true;
            Int32 chipIndex = Random.Range(0, Chips.Length);
            _chipInHand = (GameObject)Instantiate(Chips[chipIndex], 
                new Vector3(0, 9f, .759f), 
                Quaternion.identity);
	    }
	    else
	    {
            if (_chipInHand != null 
            && _isChipInHand)
	        {
	            float boundedXPos = _chipInHand.transform.position.x;

                
                Vector3 rawPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
                if(rawPosition.x < _chipInHand.transform.position.x){
                    boundedXPos-=.5f;
                    if (boundedXPos > LeftEdge)
                    {
                        boundedXPos = LeftEdge;
                    }
                    _chipInHand.transform.position = new Vector3(boundedXPos, 10f, .75f);
                }
                if(rawPosition.x > _chipInHand.transform.position.x){
                    boundedXPos+=.5f;
                    if (boundedXPos < RightEdge)
                    {
                        boundedXPos = RightEdge;
                    }
                    _chipInHand.transform.position = new Vector3(boundedXPos, 10f, .75f);
                }
                if(Input.GetMouseButtonDown(0)){
                    _isChipInHand = false;
                    _timeLeft = TimeBetweenChips;
                }
	        }
	    }
	}
}
