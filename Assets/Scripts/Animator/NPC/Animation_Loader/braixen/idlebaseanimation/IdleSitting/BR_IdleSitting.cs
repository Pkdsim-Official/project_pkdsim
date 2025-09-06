using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Braixen.idlebaseanimation.IdleSitting
{
	public class BRIdleSitting : MonoBehaviour 
	{
		private Animator Braixen_Animator;
		public void BRIdleSittingController()
		{
			Braixen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Braixen_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}