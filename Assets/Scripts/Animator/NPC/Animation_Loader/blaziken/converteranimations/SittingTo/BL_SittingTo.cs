using project_pkdsim.Models.ANIMATOR.NPC.Blaziken.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Models.ANIMATOR.NPC.Blaziken.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Blaziken.converteranimations.SittingTo
{
	public class BLSittingTo : MonoBehaviour 
	{
		private BLSittingToStartWalking BlazikensittingToStartWalking;
		private BLSittingToStanding BlazikensittingToStanding;
		public void BLSittingToController()
		{
			BLSittingToStartWalking();
			BLSittingToStanding();
		}
		private void BLSittingToStartWalking()
		{
			BlazikensittingToStartWalking.BLSittingToStartWalkingController();
		}
		private void BLSittingToStanding()
		{
			BlazikensittingToStanding.BLSittingToStandingController();
		}

	}
}