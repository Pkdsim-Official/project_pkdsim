using project_pkdsim.ANIMATOR.NPC.Braixen.converteranimations._SittingTo._SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Braixen.converteranimations._SittingTo._SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Braixen.converteranimations._SittingTo
{
	public class BR_SittingTo : MonoBehaviour 
	{
		private BR_SittingToStartWalking BraixensittingToStartWalking;
		private BR_SittingToStanding BraixensittingToStanding;
		public void BR_SittingToController()
		{
			BR_SittingToStartWalking();
			BR_SittingToStanding();
		}
		private void BR_SittingToStartWalking()
		{
			BraixensittingToStartWalking.BR_SittingToStartWalkingController();
		}
		private void BR_SittingToStanding()
		{
			BraixensittingToStanding.BR_SittingToStandingController();
		}

	}
}