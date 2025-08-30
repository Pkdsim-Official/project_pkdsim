using project_pkdsim.Models.ANIMATOR.NPC.Cinderace.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Models.ANIMATOR.NPC.Cinderace.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;
using Unity.Entities.UniversalDelegates;

namespace project_pkdsim.Models.ANIMATOR.NPC.Cinderace.converteranimations.SittingTo
{
	public class CSittingTo : MonoBehaviour 
	{
		private CSittingToStartWalking CinderacesittingToStartWalking;
		private CSittingToStanding CinderacesittingToStanding;
		public void CSittingToController()
		{
			CSittingToStartWalking();
			CSittingToStanding();
		}
		private void CSittingToStartWalking()
		{
			CinderacesittingToStartWalking.CSittingToStartWalkingController();
		}
		private void CSittingToStanding()
		{
			CinderacesittingToStanding.CSittingToStandingController();
		}

	}
}