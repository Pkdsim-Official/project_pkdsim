using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Absol.idlebaseanimation.IdleSitting
{
	public class ABIdleSitting : MonoBehaviour 
	{
		private Animator Absol_Animator;
		public void ABIdleSittingController()
		{
			Absol_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Absol_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}