using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnNextCoin : MonoBehaviour
{
    public bool Trigger;
    public bool IsBlueFace = true;
    public float WaitTime = 5f;
    public GameObject[] Coins;
    public GameObject spawnGameObject;
    public GameObject springGameObject;
    public GameObject launchLaneGameObject;
    public GameObject camera;
    public GameObject chip;
    public AudioClip BackgroundAudioClip;

    private Animator _springAnimator;

	// Use this for initialization
	void Start ()
	{
	    StartCoroutine(SpawnCoin());
        _springAnimator = springGameObject.GetComponent<Animator>();
        AudioSource.PlayClipAtPoint(BackgroundAudioClip, new Vector3(0,0,0));
	}
	
	void Update () {
	    if (Trigger)
	    {
            //Collider[] hitColliders = Physics.OverlapBox(launchLaneGameObject.transform.position, transform.localScale / 2, Quaternion.identity);
            //Debug.Log(hitColliders.Length);
            StartCoroutine(SpawnCoin());
	    }
        // if (chip != null)
        // {
        //     camera.transform.LookAt(chip.transform);
        // }
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
            spawnGameObject.transform.position,
            rotation) as GameObject;
        chip.GetComponent<LockXYRotationToZero>().useLockXY = true;
        //_springAnimator.SetTrigger("SpringMove");
        Trigger = true;
    }
}
