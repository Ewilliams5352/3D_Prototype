using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsRan1 : MonoBehaviour
{

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        //if player presses W key will set isRunning boolen to true
        if (Input.GetKey("w"))
        {
            animator.SetBool("IsRunning", true);
        }
    }
}
