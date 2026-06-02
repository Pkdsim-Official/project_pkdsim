using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.idlebaseanimation.IdleSitting
{
	public class DLIdleSitting : MonoBehaviour 
	{
		private Animator DelphoxParentMom_Animator;
		public void DLIdleSittingController()
		{
			DelphoxParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DelphoxParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}