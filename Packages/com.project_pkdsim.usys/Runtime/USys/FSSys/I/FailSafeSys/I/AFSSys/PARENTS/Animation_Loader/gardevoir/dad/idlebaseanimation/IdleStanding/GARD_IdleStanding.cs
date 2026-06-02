using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.idlebaseanimation.IdleStanding
{
	public class GARDIdleStanding : MonoBehaviour 
	{
		public Animator GardevoirParentDad_Animator;
		public void GARDIdleStandingController()
		{
			// Assign the idle animation clip
			GardevoirParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GardevoirParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}