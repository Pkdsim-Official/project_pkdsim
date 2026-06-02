using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.idlebaseanimation.IdleSitting
{
	public class HATParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator HattereneParentMom_Animator;
		public void HATParentMom_IdleSittingController()
		{
			HattereneParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			HattereneParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}