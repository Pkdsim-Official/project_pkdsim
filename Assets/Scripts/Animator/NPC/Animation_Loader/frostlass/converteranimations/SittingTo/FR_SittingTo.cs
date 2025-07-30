using project_pkdsim.ANIMATOR.Npcs.Frostlass.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Npcs.Frostlass.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Frostlass.converteranimations.SittingTo
{
	public class FR_SittingTo : MonoBehaviour 
	{
		private FR_SittingToStartWalking Frostlass_SittingToStartWalking;
		private FR_SittingToStanding Frostlass_SittingToStanding;
		public void FR_SittingToController()
		{
			FR_SittingToStartWalking();
			FR_SittingToStanding();
		}
		private void FR_SittingToStartWalking()
		{
			Frostlass_SittingToStartWalking.FR_SittingToStartWalkingController();
		}
		private void FR_SittingToStanding()
		{
			Frostlass_SittingToStanding.FR_SittingToStandingController();
		}

	}
}