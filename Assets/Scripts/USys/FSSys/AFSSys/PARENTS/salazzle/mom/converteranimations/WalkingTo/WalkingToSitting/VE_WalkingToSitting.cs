using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class SParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator SalazzleParentMom_Animator;
		public void SParentMom_WalkingToSittingController()
		{
			SalazzleParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			SalazzleParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}