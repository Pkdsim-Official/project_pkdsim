using project_pkdsim.ANIMATOR.NPC.Hatterene.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.NPC.Hatterene.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Hatterene.converteranimations.WalkingTo
{
	public class HAT_WalkingTo : MonoBehaviour 
	{
		private HAT_WalkingToStanding Hatterene_WalkingToStanding;
		private HAT_WalkingToSitting Hatterene_WalkingToSitting;
		public void HAT_WalkingToController()
		{
			Load_HAT_WalkingToStanding();
			Load_HAT_WalkingToWSitting();
		}
		private void Load_HAT_WalkingToStanding()
		{
			Hatterene_WalkingToStanding.HAT_WalkingToStandingController();
		}
		private void Load_HAT_WalkingToWSitting()
		{
			Hatterene_WalkingToSitting.HAT_WalkingToSittingController();
		}
	}
}