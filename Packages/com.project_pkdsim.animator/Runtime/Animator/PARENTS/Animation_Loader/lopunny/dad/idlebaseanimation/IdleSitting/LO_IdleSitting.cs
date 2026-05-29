using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lopunny.Dad.idlebaseanimation.IdleSitting
{
	public class LOIdleSitting : MonoBehaviour 
	{
		private Animator FlareonParentDad_Animator;
		public void LOIdleSittingController()
		{
			FlareonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}