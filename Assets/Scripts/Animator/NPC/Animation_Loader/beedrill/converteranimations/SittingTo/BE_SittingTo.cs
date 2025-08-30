using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations.SittingTo
{
	public class BESittingTo : MonoBehaviour 
	{
		private BESittingToStartWalking BeedrillsittingToStartWalking;
		private BESittingToStanding BeedrillsittingToStanding;
		public void BESittingToController()
		{
			BESittingToStartWalking();
			BESittingToStanding();
		}
		private void BESittingToStartWalking()
		{
			BeedrillsittingToStartWalking.BESittingToStartWalkingController();
		}
		private void BESittingToStanding()
		{
			BeedrillsittingToStanding.BESittingToStandingController();
		}
	}
}