using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Dragapult.idlebaseanimation.IdleSitting
{
	public class DR_IdleSitting : MonoBehaviour 
	{
		private Animator Dragapult_Animator;
		public void DR_IdleSittingController()
		{
			Dragapult_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Dragapult_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}