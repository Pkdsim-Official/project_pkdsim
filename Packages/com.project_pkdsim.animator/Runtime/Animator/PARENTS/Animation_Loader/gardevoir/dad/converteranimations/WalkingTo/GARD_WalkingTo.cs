using project_pkdsim.ANIMATOR.Parents.Gardevoir.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Gardevoir.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Gardevoir.Dad.converteranimations.WalkingTo
{
	public class GARD_WalkingTo : MonoBehaviour 
	{
		private GARD_WalkingToSitting GardevoirWalkingToSitting;
		private GARD_WalkingToStanding GardevoirWalkingToStanding;
		public void GARD_WalkingToController()
		{
			GARD_WalkingToStartWalking();
			GARD_WalkingToStanding();
		}
		private void GARD_WalkingToStartWalking()
		{
			GardevoirWalkingToSitting.GARD_WalkingToSittingController();
		}
		private void GARD_WalkingToStanding()
		{
			GardevoirWalkingToStanding.GARD_WalkingToStandingController();
		}
	}
}