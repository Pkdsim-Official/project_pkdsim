using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.idlebaseanimation.IdleStanding
{
	public class VEParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator Vespiquen_Animator;
		public void VEParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}