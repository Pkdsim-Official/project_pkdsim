using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.WalkingTo.WalkingToStanding
{
	public class VEParentDad_WalkingToStanding : MonoBehaviour 
	{
		private Animator Vespiquen_Animator;
		public void VEParentDad_WalkingToStandingController()
		{
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}