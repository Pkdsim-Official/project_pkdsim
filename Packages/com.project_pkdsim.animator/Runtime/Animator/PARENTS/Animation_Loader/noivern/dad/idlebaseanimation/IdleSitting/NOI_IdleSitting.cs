using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Dad.idlebaseanimation.IdleSitting
{
	public class NOIIdleSitting : MonoBehaviour 
	{
		private Animator NoivernParentDad_Animator;
		public void NOIIdleSittingController()
		{
			NoivernParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			NoivernParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}