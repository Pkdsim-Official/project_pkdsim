using project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations.SittingTo
{
	public class FRSittingTo : MonoBehaviour 
	{
		private FRSittingToStartWalking FrostlasssittingToStartWalking;
		private FRSittingToStanding FrostlasssittingToStanding;
		public void FRSittingToController()
		{
			FRSittingToStartWalking();
			FRSittingToStanding();
		}
		private void FRSittingToStartWalking()
		{
			FrostlasssittingToStartWalking.FRSittingToStartWalkingController();
		}
		private void FRSittingToStanding()
		{
			FrostlasssittingToStanding.FRSittingToStandingController();
		}

	}
}