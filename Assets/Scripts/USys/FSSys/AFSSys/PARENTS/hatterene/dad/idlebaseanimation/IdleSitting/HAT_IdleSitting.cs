using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.idlebaseanimation.IdleSitting
{
	public class HATParentDad_IdleSitting : MonoBehaviour 
	{
		private Animator HattereneParentDad_Animator;
		public void HATParentDad_IdleSittingController()
		{
			HattereneParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			HattereneParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}