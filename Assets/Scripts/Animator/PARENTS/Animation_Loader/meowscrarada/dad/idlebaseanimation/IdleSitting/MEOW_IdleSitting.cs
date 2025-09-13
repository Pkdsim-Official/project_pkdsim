using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Meowscarada.idlebaseanimation.IdleSitting
{
	public class MEOWIdleSitting : MonoBehaviour 
	{
		private Animator Meowscarada_Animator;
		public void MEOWIdleSittingController()
		{
			Meowscarada_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Meowscarada_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}