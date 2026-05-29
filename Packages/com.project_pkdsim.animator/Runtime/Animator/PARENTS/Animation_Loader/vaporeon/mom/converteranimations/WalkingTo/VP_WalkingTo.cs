using project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.WalkingTo
{
	public class VP_WalkingTo : MonoBehaviour 
	{
		private VP_WalkingToSitting VP_WalkingToSitting;
		
		private VP_WalkingToStanding VP_WalkingToStanding;

		public void VP_WalkingToController() 
		{
			VP_WalkingToSittingController();
			VP_WalkingToStandingController();
		}
		private void VP_WalkingToSittingController()
		{
			VP_WalkingToSitting.VP_WalkingToSittingController();
		}
		private void VP_WalkingToStandingController()
		{
			VP_WalkingToStanding.VP_WalkingToStandingController();
		}
	}
}