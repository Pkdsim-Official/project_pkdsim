using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class GARDParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator GardevoirParentMom_Animator;
		public void GARDParentMom_WalkingToSittingController()
		{
			GardevoirParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GardevoirParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}