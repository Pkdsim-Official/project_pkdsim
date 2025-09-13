using project_pkdsim.ANIMATOR.NPC.Noivern.converteranimations._SittingTo._SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Noivern.converteranimations._SittingTo._SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Noivern.converteranimations._SittingTo
{
	public class NOI_SittingTo : MonoBehaviour 
	{
		private NOI_SittingToStartWalking NoivernsittingToStartWalking;
		private NOI_SittingToStanding NoivernsittingToStanding;
		public void NOI_SittingToController()
		{
			NOI_SittingToStartWalking();
			NOI_SittingToStanding();
		}
		private void NOI_SittingToStartWalking()
		{
			NoivernsittingToStartWalking.NOI_SittingToStartWalkingController();
		}
		private void NOI_SittingToStanding()
		{
			NoivernsittingToStanding.NOI_SittingToStandingController();
		}
	}
}