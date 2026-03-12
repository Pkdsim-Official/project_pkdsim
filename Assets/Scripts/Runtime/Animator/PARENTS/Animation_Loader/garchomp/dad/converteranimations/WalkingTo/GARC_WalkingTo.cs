using Project_Pkdsim.ANIMATOR.Parents.Garchomp.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Parents.Garchomp.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Garchomp.converteranimations.WalkingTo
{
	public class GARC_WalkingTo : MonoBehaviour 
	{
		private GARC_WalkingToStanding GarchompWalkingToStanding;
		private GARC_WalkingToSitting GarchompWalkingToSitting;
		public void GARC_WalkingToController()
		{
			Load_GARC_WalkingToStanding();
			Load_GARC_WalkingToWSitting();
		}
		private void Load_GARC_WalkingToStanding()
		{
			GarchompWalkingToStanding.GARC_WalkingToStandingController();
		}
		private void Load_GARC_WalkingToWSitting()
		{
			GarchompWalkingToSitting.GARC_WalkingToSittingController();
		}
	}
}