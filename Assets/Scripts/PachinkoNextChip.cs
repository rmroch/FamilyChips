using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class PachinkoNextChip : MonoBehaviour
{
    private bool _isChipInHand = false;
    private GameObject _chipInHand;
    private Vector3 _offset;
    private Vector3 _screenPoint;

    public Int32 TimeBetweenChips = 10;
    public float LeftEdge = 5.4f;
    public float RightEdge = -5.4f;
    public GameObject[] Chips;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (_isChipInHand == false)
	    {
	        _isChipInHand = true;
            Int32 chipIndex = Random.Range(0, Chips.Length);
            _chipInHand = (GameObject)Instantiate(Chips[chipIndex], 
                new Vector3(0, 9f, .759f), 
                Quaternion.identity);
	    }
	    else
	    {
	        if (_chipInHand != null)
	        {
	            float boundedXPos = _chipInHand.transform.position.x;
	            if (boundedXPos > LeftEdge)
	            {
	                boundedXPos = LeftEdge;
	            }
	            if (boundedXPos < RightEdge)
	            {
	                boundedXPos = RightEdge;
	            }
                _chipInHand.transform.position = new Vector3(boundedXPos, 10f, .759f);
	        }
	    }
	    if (Input.GetKey(KeyCode.RightArrow))
	    {
            if (_chipInHand != null
                && _isChipInHand)
            {
                _chipInHand.transform.position = new Vector3(_chipInHand.transform.position.x + .5f, 10f, .759f);
            }
	    }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (_chipInHand != null
                && _isChipInHand)
            {
                _chipInHand.transform.position = new Vector3(_chipInHand.transform.position.x - .5f, 10f, .759f);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_chipInHand != null
                && _isChipInHand)
            {
                _isChipInHand = false;
            }
        }
	}

    //void OnMouseDown()
    //{
    //    Debug.Log("OnMouseDown");
    //    _screenPoint = Camera.main.WorldToScreenPoint(_chipInHand.transform.position);

    //    _offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _screenPoint.z));
    //}

    //void OnMouseDrag()
    //{
    //    Debug.Log("OnMouseDrag");
    //    Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _screenPoint.z);
    //    Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + _offset;

    //    if (_chipInHand != null)
    //    {
    //        _chipInHand.transform.position = new Vector3(curPosition.x, 10f, .759f);
    //    }
    //}

    //void OnMouseUp()
    //{
    //    Debug.Log("OnMouseUp");
    //    _isChipInHand = false;
    //}
}
