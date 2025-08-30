using project_pkdsim.Models.ANIMATOR.NPC.Vespiquen.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Models.ANIMATOR.NPC.Vespiquen.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Vespiquen.converteranimations.SittingTo
{
	public class VESittingTo : MonoBehaviour 
	{
		private VESittingToStartWalking VespiquensittingToStartWalking;
		private VESittingToStanding VespiquensittingToStanding;
		public void VESittingToController()
		{
			VESittingToStartWalking();
			VESittingToStanding();
		}
		private void VESittingToStartWalking()
		{
			VespiquensittingToStartWalking.VESittingToStartWalkingController();
		}
		private void VESittingToStanding()
		{
			VespiquensittingToStanding.VESittingToStandingController();
		}

	}
}