using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.idlebaseanimation.IdleSitting
{
	public class NOIIdleSitting : MonoBehaviour 
	{
		private Animator Noivern_Animator;
		public void NOIIdleSittingController()
		{
			Noivern_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Noivern_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}