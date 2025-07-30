using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class TParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator TsareenaParentMom_Animator;
		public void TParentMom_WalkingToStandingController()
		{
			TsareenaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			TsareenaParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}