using project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations.SittingTo
{
	public class FR_SittingTo : MonoBehaviour 
	{
		private FR_SittingToStartWalking FrostlassSittingToStartWalking;
		private FR_SittingToStanding FrostlassSittingToStanding;
		public void FR_SittingToController()
		{
			FR_SittingToStartWalking();
			FR_SittingToStanding();
		}
		private void FR_SittingToStartWalking()
		{
			FrostlassSittingToStartWalking.FR_SittingToStartWalkingController();
		}
		private void FR_SittingToStanding()
		{
			FrostlassSittingToStanding.FR_SittingToStandingController();
		}

	}
}