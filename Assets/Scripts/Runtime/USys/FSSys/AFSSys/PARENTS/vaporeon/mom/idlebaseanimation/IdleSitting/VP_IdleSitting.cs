using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.idlebaseanimation.IdleSitting
{
	public class VPParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator VaporeonParentMom_Animator;
		public void VPParentMom_IdleSittingController()
		{
			VaporeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VaporeonParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}