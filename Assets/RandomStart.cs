using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomStart : StateMachineBehaviour
{
    private int wait_time = 0;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        wait_time = Random.Range(0, 60 * 5);
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (wait_time == 0)
            animator.SetTrigger("MoveTrigger");
        else
            wait_time--;
        Debug.Log(wait_time);
    }
}