using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class VPParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator VaporeonParentMom_Animator;
		public void VPParentMom_WalkingToSittingController()
		{
			VaporeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VaporeonParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}