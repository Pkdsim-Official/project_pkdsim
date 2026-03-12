using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Umbreon.Dad.idlebaseanimation.IdleSitting
{
	public class UMParentDad_IdleSitting : MonoBehaviour 
	{
		public Animator UmbreonParentDad_Animator;
		public void UMParentDad_IdleSittingController()
		{
			UmbreonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			UmbreonParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}