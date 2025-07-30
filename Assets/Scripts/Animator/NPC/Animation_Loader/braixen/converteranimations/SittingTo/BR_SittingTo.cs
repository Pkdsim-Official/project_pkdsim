using project_pkdsim.ANIMATOR.Npcs.Braixen.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Npcs.Braixen.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Braixen.converteranimations.SittingTo
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