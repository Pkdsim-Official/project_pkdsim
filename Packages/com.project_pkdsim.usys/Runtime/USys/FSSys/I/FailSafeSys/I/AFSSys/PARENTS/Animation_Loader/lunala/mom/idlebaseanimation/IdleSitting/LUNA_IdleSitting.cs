using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.idlebaseanimation.IdleSitting
{
	public class LUNAParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator FlareonParentMom_Animator;
		public void LUNAParentMom_IdleSittingController()
		{
			FlareonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}