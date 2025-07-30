using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.idlebaseanimation.IdleSitting
{
	public class DLParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator DelphoxParentMom_Animator;
		public void DLParentMom_IdleSittingController()
		{
			DelphoxParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DelphoxParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}