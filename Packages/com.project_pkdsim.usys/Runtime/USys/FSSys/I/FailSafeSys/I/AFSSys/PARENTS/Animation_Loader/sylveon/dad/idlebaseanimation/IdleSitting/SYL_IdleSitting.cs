using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.idlebaseanimation.IdleSitting
{
	public class SYLParentDad_IdleSitting : MonoBehaviour 
	{
		public Animator Sylveon_Animator;
		public void SYLParentDad_IdleSittingController()
		{
			Sylveon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Sylveon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}