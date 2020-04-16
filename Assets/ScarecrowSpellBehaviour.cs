﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScarecrowSpellBehaviour : StateMachineBehaviour
{
    [SerializeField] AudioClip scarecrowSpell;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PlayerController playerController = animator.GetComponent<PlayerController>();
        PlayerLogic playerLogic = animator.GetComponent<PlayerLogic>();
        playerController.setIsUnderSpell(true);
        animator.GetComponent<PlayerLogic>().audioSource.Stop();
        playerLogic.playSound(scarecrowSpell);
        //animator.SetBool("scarecrowSpellOn", false);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.GetComponent<PlayerController>().setIsUnderSpell(false);
        //animator.SetBool("scarecrowSpellOn", true);

    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
