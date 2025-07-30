using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class LEParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator LeafeonParentMom_Animator;
		public void LEParentMom_WalkingToStandingController()
		{
			LeafeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LeafeonParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}