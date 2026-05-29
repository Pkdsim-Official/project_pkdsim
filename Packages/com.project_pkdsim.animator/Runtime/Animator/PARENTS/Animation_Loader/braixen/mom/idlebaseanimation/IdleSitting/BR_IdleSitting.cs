using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Mom.idlebaseanimation.IdleSitting
{
	public class BRIdleSitting : MonoBehaviour 
	{
		private Animator BraixenParentMom_Animator;
		public void BRIdleSittingController()
		{
			BraixenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BraixenParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}