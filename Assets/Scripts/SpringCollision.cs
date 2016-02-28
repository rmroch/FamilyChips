using UnityEngine;
using System.Collections;

public class SpringCollision : MonoBehaviour
{
    public AudioClip SpringAudioClip;

    private void OnTriggerEnter()
    {
        Debug.Log("trugger");
        AudioSource.PlayClipAtPoint(SpringAudioClip, new Vector3(0,0,0));
        Animator animator = GetComponent<Animator>();
        animator.SetTrigger("SpringMove");
    }
}
