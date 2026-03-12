using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class ESParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator EspeonParentMom_Animator;
		public void ESParentMom_WalkingToStandingController()
		{
			EspeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			EspeonParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}