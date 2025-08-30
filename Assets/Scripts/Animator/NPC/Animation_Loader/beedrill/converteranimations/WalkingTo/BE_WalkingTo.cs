using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations.WalkingTo
{
	public class BEWalkingTo : MonoBehaviour 
	{
		private BEWalkingToStanding BeedrillWalkingToStanding;
		private BEWalkingToSitting BeedrillWalkingToSitting;
		public void BEWalkingToController()
		{
			Load_BEWalkingToStanding();
			Load_BEWalkingToWSitting();
		}
		private void Load_BEWalkingToStanding()
		{
			BeedrillWalkingToStanding.BEWalkingToStandingController();
		}
		private void Load_BEWalkingToWSitting()
		{
			BeedrillWalkingToSitting.BEWalkingToSittingController();
		}
	}
}