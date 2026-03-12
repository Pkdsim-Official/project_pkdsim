using Project_Pkdsim.ANIMATOR.Npcs.Vaporeon.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Vaporeon.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Vaporeon.converteranimations.WalkingTo
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