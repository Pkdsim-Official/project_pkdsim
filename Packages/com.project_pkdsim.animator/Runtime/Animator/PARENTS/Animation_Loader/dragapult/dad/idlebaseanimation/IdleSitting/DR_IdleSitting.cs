using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Dragapult.idlebaseanimation.IdleSitting
{
	public class DRIdleSitting : MonoBehaviour 
	{
		private Animator DelphoxParentDad_Animator;
		public void DRIdleSittingController()
		{
			DelphoxParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DelphoxParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}