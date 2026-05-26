using project_pkdsim.ANIMATOR.NPC.Garchomp.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.NPC.Garchomp.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Garchomp.converteranimations.WalkingTo
{
	public class GARC_WalkingTo : MonoBehaviour 
	{
		private GARC_WalkingToStanding Garchomp_WalkingToStanding;
		private GARC_WalkingToSitting Garchomp_WalkingToSitting;
		public void GARC_WalkingToController()
		{
			Load_GARC_WalkingToStanding();
			Load_GARC_WalkingToWSitting();
		}
		private void Load_GARC_WalkingToStanding()
		{
			Garchomp_WalkingToStanding.GARC_WalkingToStandingController();
		}
		private void Load_GARC_WalkingToWSitting()
		{
			Garchomp_WalkingToSitting.GARC_WalkingToSittingController();
		}
	}
}