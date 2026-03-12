using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class FRParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator FrostlassParentMom_Animator;
		public void FRParentMom_WalkingToSittingController()
		{
			FrostlassParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FrostlassParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}