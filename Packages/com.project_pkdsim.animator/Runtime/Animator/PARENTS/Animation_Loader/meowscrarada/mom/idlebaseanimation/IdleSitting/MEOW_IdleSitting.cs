using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Meowscarada.Mom.idlebaseanimation.IdleSitting
{
	public class MEOW_IdleSitting : MonoBehaviour 
	{
		private Animator Meowscarada_Animator;
		public void MEOW_IdleSittingController()
		{
			Meowscarada_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Meowscarada_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}