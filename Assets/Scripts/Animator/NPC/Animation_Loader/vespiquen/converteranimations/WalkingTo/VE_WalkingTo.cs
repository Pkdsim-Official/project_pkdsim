using project_pkdsim.ANIMATOR.Npcs.Vespiquen.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Npcs.Vespiquen.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Vespiquen.converteranimations.WalkingTo
{
		public class VE_WalkingTo : MonoBehaviour 
	{
		private VE_WalkingToSitting Vespiquen_WalkingToSitting;
		private VE_WalkingToStanding Vespiquen_WalkingToStanding;
		public void VE_WalkingToController()
		{
			VE_WalkingToStartWalking();
			VE_WalkingToStanding();
		}
		private void VE_WalkingToStartWalking()
		{
			Vespiquen_WalkingToSitting.VE_WalkingToSittingController();
		}
		private void VE_WalkingToStanding()
		{
			Vespiquen_WalkingToStanding.VE_WalkingToStandingController();
		}
	}
}