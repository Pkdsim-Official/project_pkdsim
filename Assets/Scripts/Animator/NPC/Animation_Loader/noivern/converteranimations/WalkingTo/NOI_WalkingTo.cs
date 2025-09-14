using project_pkdsim.ANIMATOR.Npcs.Noivern.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Npcs.Noivern.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Noivern.converteranimations.WalkingTo
{
	public class NOI_WalkingTo : MonoBehaviour 
	{
		private NOI_WalkingToSitting Noivern_WalkingToSitting;
		private NOI_WalkingToStanding Noivern_WalkingToStanding;
		public void NOI_WalkingToController()
		{
			NOI_WalkingToSitting();
			NOI_WalkingToStanding();
		}
		private void NOI_WalkingToSitting()
		{
			Noivern_WalkingToSitting.NOI_WalkingToSittingController();
		}
		private void NOI_WalkingToStanding()
		{
			Noivern_WalkingToStanding.NOI_WalkingToStandingController();
		}
	}
}