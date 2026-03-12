using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class PRParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator PrimarinaParentMom_Animator;
		public void PRParentMom_WalkingToSittingController()
		{
			PrimarinaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PrimarinaParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}