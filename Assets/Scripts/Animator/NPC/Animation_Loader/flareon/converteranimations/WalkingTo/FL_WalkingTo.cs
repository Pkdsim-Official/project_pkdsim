using project_pkdsim.ANIMATOR.NPC.Flareon.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.NPC.Flareon.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Flareon.converteranimations.WalkingTo
{
	public class FL_WalkingTo : MonoBehaviour 
	{
		private FL_WalkingToStanding FL_WalkingToStanding;
		private FL_WalkingToSitting FL_WalkingToSitting;
		public void FL_WalkingToController()
		{
			Load_FL_WalkingToStanding();
			Load_FL_WalkingToWSitting();
		}
		private void Load_FL_WalkingToStanding()
		{
			FL_WalkingToStanding.FL_WalkingToStandingController();
		}
		private void Load_FL_WalkingToWSitting()
		{
			FL_WalkingToSitting.FL_WalkingToSittingController();
		}
	}
}