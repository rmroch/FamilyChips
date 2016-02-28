using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnNextCoin : MonoBehaviour
{
    public bool Trigger;
    public bool IsBlueFace = true;
    public float WaitTime = 5f;
    public GameObject[] Coins;
    public GameObject SpawnGameObject;
    public GameObject SpringGameObject;
    public GameObject camera;
    public GameObject chip;
    public GameObject OptionsPanel;
    public AudioClip BackgroundAudioClip;

    private Animator _springAnimator;

	// Use this for initialization
	void Start ()
	{
	    StartCoroutine(SpawnCoin());
        _springAnimator = SpringGameObject.GetComponent<Animator>();
        AudioSource.PlayClipAtPoint(BackgroundAudioClip, new Vector3(0,0,0));
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Escape))
	    {
            Debug.Log("esc");
	        if (OptionsPanel.activeInHierarchy)
	        {
                OptionsPanel.SetActive(false);
	        }
	        else
	        {
                OptionsPanel.SetActive(true);
	        }
	    }

	    if (Trigger)
	    {
            StartCoroutine(SpawnCoin());
	    }
        if (chip != null)
        {
            camera.transform.LookAt(chip.transform);
        }
	}

    public void Exit()
    {
        Application.Quit();
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
        chip = Instantiate(Coins[Random.Range(0, Coins.Length)],
            SpawnGameObject.transform.position,
            rotation) as GameObject;
        //_springAnimator.SetTrigger("SpringMove");
        Trigger = true;
    }
}
