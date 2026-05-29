using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Absol.Dad.idlebaseanimation.IdleSitting
{
	public class ABIdleSitting : MonoBehaviour 
	{
		private Animator AbsolParent_Animator;
		public void ABIdleSittingController()
		{
			AbsolParent_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			AbsolParent_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}