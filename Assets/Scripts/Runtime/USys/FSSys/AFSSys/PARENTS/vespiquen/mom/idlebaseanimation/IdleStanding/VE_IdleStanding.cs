using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.idlebaseanimation.IdleStanding
{
	public class VEParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator VespiquenParentMom_Animator;
		public void VEParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			VespiquenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VespiquenParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}