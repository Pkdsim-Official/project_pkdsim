using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.idlebaseanimation.IdleStanding
{
	public class VEParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator Vespiquen_Animator;
		public void VEParentDad_IdleStandingController()
		{
			// Assign the idle animation clip
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}