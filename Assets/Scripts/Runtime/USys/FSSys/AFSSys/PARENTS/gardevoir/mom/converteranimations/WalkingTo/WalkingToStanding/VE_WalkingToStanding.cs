using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class GARDParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator GardevoirParentMom_Animator;
		public void GARDParentMom_WalkingToStandingController()
		{
			GardevoirParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GardevoirParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}