using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour
{
    private Animator animator;
    private CharacterMovement movement;
    void Start()
    {
        animator = GetComponent<Animator>();
        movement = GetComponent<CharacterMovement>();
    }

    void Update()
    {
        animator.SetFloat("CharacterSpeed", movement.GetMoveSpeed());
        animator.SetBool("IsFalling", !movement.isGrounded);
        if(Input.GetButtonUp("Fire1"))
        {
            animator.SetTrigger("doRoll");
        }
    }
}
