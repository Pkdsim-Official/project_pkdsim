using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.idlebaseanimation.IdleSitting
{
	public class VEIdleSitting : MonoBehaviour 
	{
		private Animator Vespiquen_Animator;
		public void VEIdleSittingController()
		{
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}