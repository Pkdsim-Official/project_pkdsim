using project_pkdsim.Models.ANIMATOR.NPC.Garchomp.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Garchomp.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Garchomp.converteranimations.WalkingTo
{
	public class GARCWalkingTo : MonoBehaviour 
	{
		private GARCWalkingToStanding GarchompWalkingToStanding;
		private GARCWalkingToSitting GarchompWalkingToSitting;
		public void GARCWalkingToController()
		{
			Load_GARCWalkingToStanding();
			Load_GARCWalkingToWSitting();
		}
		private void Load_GARCWalkingToStanding()
		{
			GarchompWalkingToStanding.GARCWalkingToStandingController();
		}
		private void Load_GARCWalkingToWSitting()
		{
			GarchompWalkingToSitting.GARCWalkingToSittingController();
		}
	}
}