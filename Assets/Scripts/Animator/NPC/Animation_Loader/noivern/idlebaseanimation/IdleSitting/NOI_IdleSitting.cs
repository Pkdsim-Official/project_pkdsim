using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Noivern.idlebaseanimation.IdleSitting
{
	public class NOI_IdleSitting : MonoBehaviour 
	{
		private Animator Noivern_Animator;
		public void NOI_IdleSittingController()
		{
			Noivern_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Noivern_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}