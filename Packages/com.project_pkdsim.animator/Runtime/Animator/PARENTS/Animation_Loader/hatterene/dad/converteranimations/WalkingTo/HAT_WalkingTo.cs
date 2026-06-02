using project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations.WalkingTo
{
	public class HAT_WalkingTo : MonoBehaviour 
	{
		private HAT_WalkingToStanding HattereneWalkingToStanding;
		private HAT_WalkingToSitting HattereneWalkingToSitting;
		public void HAT_WalkingToController()
		{
			Load_HAT_WalkingToStanding();
			Load_HAT_WalkingToWSitting();
		}
		private void Load_HAT_WalkingToStanding()
		{
			HattereneWalkingToStanding.HAT_WalkingToStandingController();
		}
		private void Load_HAT_WalkingToWSitting()
		{
			HattereneWalkingToSitting.HAT_WalkingToSittingController();
		}
	}
}