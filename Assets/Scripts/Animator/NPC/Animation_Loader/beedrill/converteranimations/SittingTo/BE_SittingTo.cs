using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations.SittingTo
{
	public class BE_SittingTo : MonoBehaviour 
	{
		private BE_SittingToStartWalking BeedrillSittingToStartWalking;
		private BE_SittingToStanding BeedrillSittingToStanding;
		public void BE_SittingToController()
		{
			BE_SittingToStartWalking();
			BE_SittingToStanding();
		}
		private void BE_SittingToStartWalking()
		{
			BeedrillSittingToStartWalking.BE_SittingToStartWalkingController();
		}
		private void BE_SittingToStanding()
		{
			BeedrillSittingToStanding.BE_SittingToStandingController();
		}
	}
}