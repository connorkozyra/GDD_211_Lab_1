using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;

    void Start()
    {
        // Get the Animator component attached to the player GameObject
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check for player input
        if (Input.GetKeyDown(KeyCode.Y))
        {
            // Trigger animation for input 1
            SetAnimation("Animation1");
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            // Trigger animation for input 2
            SetAnimation("Animation2");
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            // Trigger animation for input 3
            SetAnimation("Animation3");
        }
        else if (!IsAnyKeyBeingPressed())
        {
            // Trigger idle animation when no keys are being pressed
            SetAnimation("Idle");
        }
    }

    void SetAnimation(string animationTrigger)
    {
        // Reset all triggers before setting the new one to avoid conflicts
        animator.ResetTrigger("Animation1");
        animator.ResetTrigger("Animation2");
        animator.ResetTrigger("Animation3");
        animator.ResetTrigger("Idle");

        // Set the new animation trigger
        animator.SetTrigger(animationTrigger);
    }

    bool IsAnyKeyBeingPressed()
    {
        // Check if any key is currently being pressed
        return Input.GetKey(KeyCode.Alpha1) || Input.GetKey(KeyCode.Alpha2) || Input.GetKey(KeyCode.Alpha3);
    }
}
