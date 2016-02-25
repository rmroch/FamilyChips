using UnityEngine;
using System.Collections;

public class SpringCollision : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        Debug.Log("trugger");
        Animator animator = GetComponent<Animator>();
        animator.SetTrigger("SpringMove");
    }
}
