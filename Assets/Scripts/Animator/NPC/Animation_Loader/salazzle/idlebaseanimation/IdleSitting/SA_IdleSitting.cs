using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Salazzle.idlebaseanimation.IdleSitting
{
	public class SA_IdleSitting : MonoBehaviour 
	{
		private Animator Salazzle_Animator;
		public void SA_IdleSittingController()
		{
			Salazzle_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Salazzle_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}