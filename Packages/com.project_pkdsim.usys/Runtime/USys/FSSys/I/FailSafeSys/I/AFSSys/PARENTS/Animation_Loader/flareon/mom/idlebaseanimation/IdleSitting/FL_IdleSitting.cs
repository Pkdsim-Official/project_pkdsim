using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.idlebaseanimation.IdleSitting
{
	public class FLParentMom_IdleSitting : MonoBehaviour 
	{
		public Animator FlareonParentMom_Animator;
		public void FLParentMom_IdleSittingController()
		{
			FlareonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}