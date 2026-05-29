using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Dad.idlebaseanimation.IdleSitting
{
	public class LUCAIdleSitting : MonoBehaviour 
	{
		private Animator Lucario_Animator;
		public void LUCAIdleSittingController()
		{
			Lucario_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Lucario_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}