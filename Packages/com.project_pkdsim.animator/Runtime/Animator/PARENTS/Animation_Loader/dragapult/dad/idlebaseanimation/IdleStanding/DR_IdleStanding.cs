using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Dragapult.idlebaseanimation.IdleStanding
{
	public class DRIdleStanding : MonoBehaviour 
	{
		public Animator DelphoxParentDad_Animator;
		public void DRIdleStandingController()
		{
			// Assign the idle animation clip
			DelphoxParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DelphoxParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}