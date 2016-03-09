using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class CoinStackaRandomChips : MonoBehaviour
{
    public float FrontZ = -3f;
    public float BackZ = 3f;
    public float RightX = 14f;
    public float LeftX = -14f;
    public float Delay = .2f;
    public GameObject[] Chips;
    public int Score;
    public float TimeRemaining = 30f;
    public Text ScoreText;
    public Text TimeRemainingText;
    public Button PlayAgainButton;

    private float _curTime = 0;
    private float _colSize = 6.0f;

    // Use this for initialization
    void Update()
    {
        ChipControl();
        GameControl();
    }

    public void PlayAgain()
    {
        Collider[] colliders;
        colliders = Physics.OverlapSphere(this.transform.position, _colSize);
        foreach (var col in colliders)
        {
            if (!col.gameObject.name.Equals("RailFrontCube")
                && !col.gameObject.name.Equals("RailBackCube")
                && !col.gameObject.name.Equals("PlatformCube"))
            {
                Destroy(col.gameObject);
            }
        }

        TimeRemaining = 30f;
        TimeRemainingText.text = string.Format("Time Remaining: {0}", TimeRemaining);

        Score = 0;
        ScoreText.text = string.Format("Score: {0}", Score);

        PlayAgainButton.gameObject.SetActive(false);
    }

    private void GameControl()
    {
        if (TimeRemaining <= 0)
        {
            TimeRemaining = 0;
            PlayAgainButton.gameObject.SetActive(true);
        }
        else
        {
            TimeRemaining -= Time.deltaTime;
        }
        TimeRemainingText.text = string.Format("Time Remaining: {0}", TimeRemaining);

        Int32 count = 0;
        Collider[] colliders;
        colliders = Physics.OverlapSphere(this.transform.position, _colSize);
        foreach (var col in colliders)
        {
            if (!col.gameObject.name.Equals("RailFrontCube")
                && !col.gameObject.name.Equals("RailBackCube")
                && !col.gameObject.name.Equals("PlatformCube"))
            {
                Debug.Log(col.gameObject.name);
                count++;
            }
        }
        Score = count;
        ScoreText.text = string.Format("Score: {0}", Score);
    }

    private void ChipControl()
    {
        if (TimeRemaining > 0)
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
}
