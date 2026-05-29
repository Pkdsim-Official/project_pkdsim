using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations.WalkingTo
{
	public class NOIWalkingTo : MonoBehaviour 
	{
		private NOIWalkingToSitting NoivernWalkingToSitting;
		private NOIWalkingToStanding NoivernWalkingToStanding;
		public void NOIWalkingToController()
		{
			NOIWalkingToSitting();
			NOIWalkingToStanding();
		}
		private void NOIWalkingToSitting()
		{
			NoivernWalkingToSitting.NOIWalkingToSittingController();
		}
		private void NOIWalkingToStanding()
		{
			NoivernWalkingToStanding.NOIWalkingToStandingController();
		}
	}
}