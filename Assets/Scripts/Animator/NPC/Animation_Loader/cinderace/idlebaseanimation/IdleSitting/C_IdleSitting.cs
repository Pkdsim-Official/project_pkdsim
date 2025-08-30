using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Cinderace.idlebaseanimation.IdleSitting
{
	public class CIdleSitting : MonoBehaviour 
	{
		private Animator Cinderace_Animator;
		public void CIdleSittingController()
		{
			Cinderace_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Cinderace_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}