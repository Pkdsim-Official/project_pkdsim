using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.idlebaseanimation.IdleSitting
{
	public class LOParentDad_IdleSitting : MonoBehaviour 
	{
		private Animator LopunnyParentDad_Animator;
		public void LOParentDad_IdleSittingController()
		{
			LopunnyParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LopunnyParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}