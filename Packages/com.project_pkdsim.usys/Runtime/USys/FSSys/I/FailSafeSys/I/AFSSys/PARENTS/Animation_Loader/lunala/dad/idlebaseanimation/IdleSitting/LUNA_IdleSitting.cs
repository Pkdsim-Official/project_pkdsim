using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.idlebaseanimation.IdleSitting
{
	public class LUNAParentDad_IdleSitting : MonoBehaviour 
	{
		private Animator FlareonParentDad_Animator;
		public void LUNAParentDad_IdleSittingController()
		{
			FlareonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}