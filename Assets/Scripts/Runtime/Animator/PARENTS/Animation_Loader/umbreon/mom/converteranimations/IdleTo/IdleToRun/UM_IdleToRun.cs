using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.converteranimations.IdleTo.IdleToRun
{
	public class UMParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator UmbreonParentMom_Animator;
		public void UMParentMom_IdleToRunController()
		{
			UmbreonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			UmbreonParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}