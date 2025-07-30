using project_pkdsim.ANIMATOR.NPC.Beedrill.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Beedrill.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Beedrill.converteranimations.SittingTo
{
	public class BE_SittingTo : MonoBehaviour 
	{
		private BE_SittingToStartWalking Beedrill_SittingToStartWalking;
		private BE_SittingToStanding Beedrill_SittingToStanding;
		public void BE_SittingToController()
		{
			BE_SittingToStartWalking();
			BE_SittingToStanding();
		}
		private void BE_SittingToStartWalking()
		{
			Beedrill_SittingToStartWalking.BE_SittingToStartWalkingController();
		}
		private void BE_SittingToStanding()
		{
			Beedrill_SittingToStanding.BE_SittingToStandingController();
		}
	}
}