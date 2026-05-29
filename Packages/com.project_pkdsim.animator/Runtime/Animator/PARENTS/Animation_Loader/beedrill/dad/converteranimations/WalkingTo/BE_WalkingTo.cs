using project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.converteranimations.WalkingTo
{
	public class BE_WalkingTo : MonoBehaviour 
	{
		private BE_WalkingToStanding BeedrillWalkingToStanding;
		private BE_WalkingToSitting BeedrillWalkingToSitting;
		public void BE_WalkingToController()
		{
			Load_BE_WalkingToStanding();
			Load_BE_WalkingToWSitting();
		}
		private void Load_BE_WalkingToStanding()
		{
			BeedrillWalkingToStanding.BE_WalkingToStandingController();
		}
		private void Load_BE_WalkingToWSitting()
		{
			BeedrillWalkingToSitting.BE_WalkingToSittingController();
		}
	}
}