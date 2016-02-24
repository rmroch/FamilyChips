using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{

    private Int32 _score;

    public Text TextScore;

	// Use this for initialization
	void Start ()
	{
	    _score = 0;
	}

    public void AddAmount(Int32 updateAmount)
    {
        _score += updateAmount;
        TextScore.text = string.Format("Score: {0}", _score);
    }
}
