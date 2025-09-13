using project_pkdsim.ANIMATOR.NPC.Braixen.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.NPC.Braixen.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Braixen.converteranimations.WalkingTo
{
	public class BR_WalkingTo : MonoBehaviour 
	{
		private BR_WalkingToStanding Braixen_WalkingToStanding;
		private BR_WalkingToSitting Braixen_WalkingToSitting;
		public void BR_WalkingToController()
		{
			Load_BR_WalkingToStanding();
			Load_BR_WalkingToWSitting();
		}
		private void Load_BR_WalkingToStanding()
		{
			Braixen_WalkingToStanding.BR_WalkingToStandingController();
		}
		private void Load_BR_WalkingToWSitting()
		{
			Braixen_WalkingToSitting.BR_WalkingToSittingController();
		}
	}
}