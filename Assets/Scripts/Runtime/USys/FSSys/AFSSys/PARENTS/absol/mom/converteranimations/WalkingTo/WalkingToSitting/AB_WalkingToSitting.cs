using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class ABParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator AbsolParentMom_Animator;
		public void ABParentMom_WalkingToSittingController()
		{
			AbsolParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			AbsolParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}