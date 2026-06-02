using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.idlebaseanimation.IdleStanding
{
	public class VPParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator Vaporeon_Animator;
		public void VPParentDad_IdleStandingController()
		{
			Vaporeon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vaporeon_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}