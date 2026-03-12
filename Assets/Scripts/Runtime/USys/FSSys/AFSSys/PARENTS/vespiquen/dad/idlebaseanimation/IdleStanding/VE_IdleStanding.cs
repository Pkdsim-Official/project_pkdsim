using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.idlebaseanimation.IdleStanding
{
	public class VEParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator VespiquenParentDad_Animator;
		public void VEParentDad_IdleStandingController()
		{
			// Assign the idle animation clip
			VespiquenParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VespiquenParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}