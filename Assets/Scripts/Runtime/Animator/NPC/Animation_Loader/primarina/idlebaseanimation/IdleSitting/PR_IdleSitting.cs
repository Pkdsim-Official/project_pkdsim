using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Primarina.idlebaseanimation.IdleSitting
{
	public class PR_IdleSitting : MonoBehaviour 
	{
		private Animator Primarina_Animator;
		public void PR_IdleSittingController()
		{
			Primarina_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Primarina_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}