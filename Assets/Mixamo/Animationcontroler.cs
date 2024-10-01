using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationcontroler : MonoBehaviour
{
    private Animator animator;
    private int isWalkingHash;
    private int isRunningHash;

    void Start()
    {
        animator = this.GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");

    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool fowardPressed = (Input.GetKey(KeyCode.W));

        bool isRunning = animator.GetBool(isRunningHash);
        bool runPressed = (Input.GetKey(KeyCode.LeftShift));

        if (fowardPressed && !isWalking)
        {
            animator.SetBool(isWalkingHash, true);
        }

        if (!fowardPressed && isWalking)
        {
            animator.SetBool(isWalkingHash, false);
        }

        if ((fowardPressed && runPressed) && !isRunning)
        {
            animator.SetBool(isRunningHash, true);
        }

        if ((!fowardPressed && runPressed) && !isRunning)
        {
            animator.SetBool(isRunningHash, false);

        }

    }
}
