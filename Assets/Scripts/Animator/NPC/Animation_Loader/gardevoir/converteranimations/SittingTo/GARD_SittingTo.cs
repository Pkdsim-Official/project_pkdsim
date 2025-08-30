using project_pkdsim.Models.ANIMATOR.NPC.Gardevoir.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Models.ANIMATOR.NPC.Gardevoir.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Gardevoir.converteranimations.SittingTo
{
	public class GARDSittingTo : MonoBehaviour 
	{
		private GARDSittingToStartWalking GardevoirsittingToStartWalking;
		private GARDSittingToStanding GardevoirsittingToStanding;
		public void GARDSittingToController()
		{
			GARDSittingToStartWalking();
			GARDSittingToStanding();
		}
		private void GARDSittingToStartWalking()
		{
			GardevoirsittingToStartWalking.GARDSittingToStartWalkingController();
		}
		private void GARDSittingToStanding()
		{
			GardevoirsittingToStanding.GARDSittingToStandingController();
		}
	}
}