using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Gardevoir.Dad.idlebaseanimation.IdleSitting
{
	public class GARDIdleSitting : MonoBehaviour 
	{
		private Animator Gardevoir_Animator;
		public void GARDIdleSittingController()
		{
			Gardevoir_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Gardevoir_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}