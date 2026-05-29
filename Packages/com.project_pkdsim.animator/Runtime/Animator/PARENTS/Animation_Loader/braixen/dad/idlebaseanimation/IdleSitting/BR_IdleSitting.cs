using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Dad.idlebaseanimation.IdleSitting
{
	public class BRIdleSitting : MonoBehaviour 
	{
		private Animator BraixenParentDad_Animator;
		public void BRIdleSittingController()
		{
			BraixenParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BraixenParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}