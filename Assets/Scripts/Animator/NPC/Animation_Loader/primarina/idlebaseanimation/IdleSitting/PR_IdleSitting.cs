using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Primarina.idlebaseanimation.IdleSitting
{
	public class PRIdleSitting : MonoBehaviour 
	{
		private Animator Primarina_Animator;
		public void PRIdleSittingController()
		{
			Primarina_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Primarina_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}