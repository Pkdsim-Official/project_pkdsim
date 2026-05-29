using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Mom.idlebaseanimation.IdleSitting
{
	public class NOIIdleSitting : MonoBehaviour 
	{
		private Animator NoivernParentMom_Animator;
		public void NOIIdleSittingController()
		{
			NoivernParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			NoivernParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}