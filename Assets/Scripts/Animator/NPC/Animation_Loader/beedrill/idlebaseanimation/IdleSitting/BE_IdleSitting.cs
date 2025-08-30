using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Beedrill.idlebaseanimation.IdleSitting
{
	public class BEIdleSitting : MonoBehaviour 
	{
		private Animator Beedrill_Animator;
		public void BEIdleSittingController()
		{
			Beedrill_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Beedrill_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}