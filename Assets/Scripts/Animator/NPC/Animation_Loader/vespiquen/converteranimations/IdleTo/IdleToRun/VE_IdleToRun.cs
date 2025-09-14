using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Vespiquen.converteranimations.IdleTo.IdleToRun
{
	public class VE_IdleToRun : MonoBehaviour 
	{
		private Animator Vespiquen_Animator;
		public void VE_IdleToRunController()
		{
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}