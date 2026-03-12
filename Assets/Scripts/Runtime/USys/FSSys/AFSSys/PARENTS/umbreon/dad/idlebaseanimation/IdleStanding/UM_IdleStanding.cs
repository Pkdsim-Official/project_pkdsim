using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.idlebaseanimation.IdleStanding
{
	public class UMParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator UmbreonParentDad_Animator;

		public void UMParentDad_IdleStandingController()
		{
			UmbreonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			UmbreonParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}