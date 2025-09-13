using project_pkdsim.ANIMATOR.NPC.Garchomp.converteranimations._SittingTo._SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Garchomp.converteranimations._SittingTo._SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Garchomp.converteranimations._SittingTo
{
	public class GARC_SittingTo : MonoBehaviour 
	{
		private GARC_SittingToStartWalking Garchomp_SittingToStartWalking;
		private GARC_SittingToStanding Garchomp_SittingToStanding;
		public void GARC_SittingToController()
		{
			GARC_SittingToStartWalking();
			GARC_SittingToStanding();
		}
		private void GARC_SittingToStartWalking()
		{
			Garchomp_SittingToStartWalking.GARC_SittingToStartWalkingController();
		}
		private void GARC_SittingToStanding()
		{
			Garchomp_SittingToStanding.GARC_SittingToStandingController();
		}
	}
}