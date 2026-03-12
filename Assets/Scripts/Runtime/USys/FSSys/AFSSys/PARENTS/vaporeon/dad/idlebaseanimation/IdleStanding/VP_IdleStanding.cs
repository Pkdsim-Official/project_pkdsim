using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.idlebaseanimation.IdleStanding
{
	public class VPParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator VaporeonParentDad_Animator;
		public void VPParentDad_IdleStandingController()
		{
			VaporeonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VaporeonParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}