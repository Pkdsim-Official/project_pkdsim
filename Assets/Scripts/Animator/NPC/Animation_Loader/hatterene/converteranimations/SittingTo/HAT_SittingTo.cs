using project_pkdsim.ANIMATOR.Npcs.Hatterene.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Npcs.Hatterene.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Hatterene.converteranimations.SittingTo
{
	public class HAT_SittingTo : MonoBehaviour 
	{
		private HAT_SittingToStartWalking HatterenesittingToStartWalking;
		private HAT_SittingToStanding HatterenesittingToStanding;
		public void HAT_SittingToController()
		{
			HAT_SittingToStartWalking();
			HAT_SittingToStanding();
		}
		private void HAT_SittingToStartWalking()
		{
			HatterenesittingToStartWalking.HAT_SittingToStartWalkingController();
		}
		private void HAT_SittingToStanding()
		{
			HatterenesittingToStanding.HAT_SittingToStandingController();
		}
	}
}