using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.NPC_AnimatorBase
{
    public interface INpc_AnimatorBase
    {
        Animator animator { get; set; }
        void LoadNpc_AnimatorController();
        public bool IsRunning { get; set; }
        public bool IsWalking { get; set; }
        public bool IsSitting { get; set; }
        public bool IsStanding { get; set; }
        public bool IsIdle { get; set; }
        public bool IsJumping { get; set; }
        
        void SetRunningAnimation()
        {
            animator.SetBool(IsRunning.ToString(), true); // Example: Set IsRunning bool parameter to true
        }
        void SetJumpingAnimation()
        {
            animator.SetBool(IsJumping.ToString(), true);         // Example: Trigger for Jump animation
        }

        void SetWalkingAnimation()
        {
            animator.SetBool(IsWalking.ToString(), true);      // Example: Trigger for Walk animation
        }
        void SetSittingAnimation()
        {
        animator.SetBool(IsSitting.ToString(), true);      // Example: Trigger for Sitting animation
        }

        void SetStandingAnimation()
        {
        animator.SetBool(IsStanding.ToString(), true);     // Example: Trigger for Standing animation
        }

        void SetIdleAnimation()
        {
            animator.SetTrigger(IsIdle.ToString());         // Example: Trigger for Idle animation
        }
    }
}