using project_pkdsim.Models.ANIMATOR.NPC.Braixen.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Models.ANIMATOR.NPC.Braixen.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Braixen.converteranimations.SittingTo
{
	public class BRSittingTo : MonoBehaviour 
	{
		private BRSittingToStartWalking BraixensittingToStartWalking;
		private BRSittingToStanding BraixensittingToStanding;
		public void BRSittingToController()
		{
			BRSittingToStartWalking();
			BRSittingToStanding();
		}
		private void BRSittingToStartWalking()
		{
			BraixensittingToStartWalking.BRSittingToStartWalkingController();
		}
		private void BRSittingToStanding()
		{
			BraixensittingToStanding.BRSittingToStandingController();
		}

	}
}