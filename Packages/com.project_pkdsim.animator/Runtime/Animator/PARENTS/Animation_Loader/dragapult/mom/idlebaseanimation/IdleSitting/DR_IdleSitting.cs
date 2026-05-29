using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.idlebaseanimation.IdleSitting
{
	public class DRIdleSitting : MonoBehaviour 
	{
		private Animator DelphoxParentMom_Animator;
		public void DRIdleSittingController()
		{
			DelphoxParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DelphoxParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}