using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinStackaGameManager : MonoBehaviour
{
    public int Score;
    public float TimeRemaining = 30f;
    public Text ScoreText;
    public Text TimeRemainingText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    TimeRemaining -= Time.deltaTime;
        TimeRemainingText.text = string.Format("Time Remaining: {0}", TimeRemaining);

        Int32 count = 0;
        Collider[] colliders;
        colliders = Physics.OverlapSphere(this.transform.position, 7.0f);
	    foreach(var col in colliders)
	    {
	        if (!col.gameObject.name.Equals("RailFrontCube")
                && !col.gameObject.name.Equals("RailBackCube")
                && !col.gameObject.name.Equals("PlatformCube"))
	        {
                Debug.Log(col.gameObject.name);
	            count++;
	        }
	    }
        ScoreText.text = string.Format("Score: {0}", count);
	}
}
