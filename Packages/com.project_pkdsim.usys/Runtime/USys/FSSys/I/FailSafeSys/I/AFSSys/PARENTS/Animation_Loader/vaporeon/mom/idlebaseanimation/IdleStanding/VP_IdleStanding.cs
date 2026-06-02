using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.idlebaseanimation.IdleStanding
{
	public class VPParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator Vaporeon_Animator;
		public void VPParentMom_IdleStandingController()
		{
			Vaporeon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vaporeon_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}