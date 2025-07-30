using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.idlebaseanimation.IdleSitting
{
	public class SYLParentDad_IdleSitting : MonoBehaviour 
	{
		public Animator SylveonParentDad_Animator;
		public void SYLParentDad_IdleSittingController()
		{
			SylveonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			SylveonParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}