using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Frostlass.idlebaseanimation.IdleSitting
{
	public class FRIdleSitting : MonoBehaviour 
	{
		private Animator Frostlass_Animator;
		public void FRIdleSittingController()
		{
			Frostlass_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Frostlass_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}