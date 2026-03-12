using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.idlebaseanimation.IdleSitting
{
	public class UMParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator UmbreonParentMom_Animator;
		public void UMParentMom_IdleSittingController()
		{
			UmbreonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			UmbreonParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}