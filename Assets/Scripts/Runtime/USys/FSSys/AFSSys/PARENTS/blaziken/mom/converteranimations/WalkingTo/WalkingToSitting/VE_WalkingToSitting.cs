using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class BLParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator BLazikenParentMom_Animator;
		public void BLParentMom_WalkingToSittingController()
		{
			BLazikenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BLazikenParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}