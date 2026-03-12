using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class HATParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator HattereneParentMom_Animator;
		public void HATParentMom_WalkingToSittingController()
		{
			HattereneParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			HattereneParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}