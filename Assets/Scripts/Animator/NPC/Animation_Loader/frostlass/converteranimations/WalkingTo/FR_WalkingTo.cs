using project_pkdsim.ANIMATOR.NPC.Frostlass.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.NPC.Frostlass.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Frostlass.converteranimations.WalkingTo
{
	public class FR_WalkingTo : MonoBehaviour 
	{
		
		private FR_WalkingToStanding Frostlass_WalkingToStanding;
		private FR_WalkingToSitting Frostlass_WalkingToSitting;
		public void FR_WalkingToController()
		{
			Load_FR_WalkingToStanding();
			Load_FR_WalkingToWSitting();
		}
		private void Load_FR_WalkingToStanding()
		{
			Frostlass_WalkingToStanding.FR_WalkingToStandingController();
		}
		private void Load_FR_WalkingToWSitting()
		{
			Frostlass_WalkingToSitting.FR_WalkingToSittingController();
		}
	}
}