using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Lunala.idlebaseanimation.IdleSitting
{
	public class LUNAIdleSitting : MonoBehaviour 
	{
		private Animator Flareon_Animator;
		public void LUNAIdleSittingController()
		{
			Flareon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Flareon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}