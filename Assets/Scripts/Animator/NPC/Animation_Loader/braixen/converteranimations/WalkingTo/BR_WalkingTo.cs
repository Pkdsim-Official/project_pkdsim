using project_pkdsim.ANIMATOR.NPC.Braixen.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.NPC.Braixen.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Braixen.converteranimations.WalkingTo
{
	public class BR_WalkingTo : MonoBehaviour 
	{
		private BR_WalkingToStanding BraixenWalkingToStanding;
		private BR_WalkingToSitting BraixenWalkingToSitting;
		public void BR_WalkingToController()
		{
			Load_BR_WalkingToStanding();
			Load_BR_WalkingToWSitting();
		}
		private void Load_BR_WalkingToStanding()
		{
			BraixenWalkingToStanding.BR_WalkingToStandingController();
		}
		private void Load_BR_WalkingToWSitting()
		{
			BraixenWalkingToSitting.BR_WalkingToSittingController();
		}
	}
}