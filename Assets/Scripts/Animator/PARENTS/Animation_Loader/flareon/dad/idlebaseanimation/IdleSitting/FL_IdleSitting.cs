using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Flareon.Dad.idlebaseanimation.IdleSitting
{
	public class FLParentDadDad_IdleSitting : MonoBehaviour 
	{
		public Animator FlareonParentDad_Animator;
		public void FLParentDadDad_IdleSittingController()
		{
			FlareonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}