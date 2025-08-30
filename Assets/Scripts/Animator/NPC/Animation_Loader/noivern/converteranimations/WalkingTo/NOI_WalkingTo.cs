using project_pkdsim.Models.ANIMATOR.NPC.Noivern.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Noivern.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Noivern.converteranimations.WalkingTo
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