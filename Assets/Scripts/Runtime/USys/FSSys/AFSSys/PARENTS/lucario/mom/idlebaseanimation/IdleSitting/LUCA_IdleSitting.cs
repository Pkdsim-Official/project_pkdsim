using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.idlebaseanimation.IdleSitting
{
	public class LUCAParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator lucarioParentMom_Animator;
		public void LUCAParentMom_IdleSittingController()
		{
			lucarioParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			lucarioParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}