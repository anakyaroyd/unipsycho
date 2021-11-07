using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_IKControl : MonoBehaviour
{
    protected Animator animator;

    public bool ikActive = false;
    public Transform rightHandObj = null;
    public Transform lookObj = null;

    private void Awake() {
        animator = GetComponent<Animator>();
    }

    // a callback for calculating IK
    private void OnAnimatorIK() {
        if (animator) {

            // if the IK is active, set the position and rotation directly to the goal
            if (ikActive) {

                // Set the right hand target position and rotation, if one has been assigned
                if (rightHandObj != null) {
                    animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
                    animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
                    animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandObj.position);
                    animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandObj.rotation);
                }
            }

            // in the IK is not active, set the position and rotation of the hand and head back
            else {
                animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 0);
                animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 0);
                animator.SetLookAtWeight(0);
            }
        }
    }
}
