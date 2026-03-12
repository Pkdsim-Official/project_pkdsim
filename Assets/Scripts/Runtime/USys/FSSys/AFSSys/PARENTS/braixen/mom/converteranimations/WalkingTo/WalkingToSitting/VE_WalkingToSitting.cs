using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class BRParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator BraixenParentMom_Animator;
		public void BRParentMom_WalkingToSittingController()
		{
			BraixenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BraixenParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}