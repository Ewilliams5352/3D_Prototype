using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsRan1 : MonoBehaviour
{

    Animator animator;

    //simplifing code
    int iswalkingHash;
    int isrunningHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        //simplifing code
        iswalkingHash = Animator.StringToHash("iswalking");
        isrunningHash = Animator.StringToHash("isrunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool isrunning = animator.GetBool(isrunningHash);
        bool iswalking = animator.GetBool(iswalkingHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        //if player presses w key
        if (!iswalking && forwardPressed)
        {
            //then set iswalking to true
            animator.SetBool(iswalkingHash, true);
        }

        // if w key is not pressed
        if (iswalking && !forwardPressed)
        {
            //then set iswalking to false
            animator.SetBool(iswalkingHash, false);
        }

        //if the player is walking and not running and Left Shift is pressed
        if (!isrunning && (forwardPressed && runPressed))
        {
            //then set is running to true
            animator.SetBool(isrunningHash, true);
        }

        //if the player stops running and walking
        if (isrunning && (!forwardPressed || !runPressed))
        {
            //then set is running to false
            animator.SetBool(isrunningHash, false);
        }
    }
    }
