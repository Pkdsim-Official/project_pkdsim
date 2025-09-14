using project_pkdsim.ANIMATOR.Npcs.Garchomp.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Npcs.Garchomp.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Garchomp.converteranimations.SittingTo
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