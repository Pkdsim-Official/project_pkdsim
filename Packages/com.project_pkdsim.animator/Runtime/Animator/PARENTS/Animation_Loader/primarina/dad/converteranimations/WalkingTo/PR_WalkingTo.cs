using project_pkdsim.ANIMATOR.Parents.Primarina.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Primarina.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Primarina.Dad.converteranimations.WalkingTo
{
	public class PRWalkingTo : MonoBehaviour 
	{
		private PRWalkingToStanding PrimarinaWalkingToStanding;
		private PRWalkingToSitting PrimarinaWalkingToSitting;
		public void PRWalkingToController()
		{
			Load_PRWalkingToStanding();
			Load_PRWalkingToWSitting();
		}
		private void Load_PRWalkingToStanding()
		{
			PrimarinaWalkingToStanding.PRWalkingToStandingController();
		}
		private void Load_PRWalkingToWSitting()
		{
			PrimarinaWalkingToSitting.PRWalkingToSittingController();
		}
	}
}