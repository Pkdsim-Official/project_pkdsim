using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.idlebaseanimation.IdleStanding
{
	public class GARDIdleStanding : MonoBehaviour 
	{
		public Animator GardevoirParentMom_Animator;
		public void GARDIdleStandingController()
		{
			// Assign the idle animation clip
			GardevoirParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GardevoirParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}