using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.idlebaseanimation.IdleSitting
{
	public class LOParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator FlareonParentMom_Animator;
		public void LOParentMom_IdleSittingController()
		{
			FlareonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}