using project_pkdsim.ANIMATOR.NPC.Vespiquen.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Vespiquen.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Vespiquen.converteranimations.SittingTo
{
	public class VE_SittingTo : MonoBehaviour 
	{
		private VE_SittingToStartWalking VespiquensittingToStartWalking;
		private VE_SittingToStanding VespiquensittingToStanding;
		public void VE_SittingToController()
		{
			VE_SittingToStartWalking();
			VE_SittingToStanding();
		}
		private void VE_SittingToStartWalking()
		{
			VespiquensittingToStartWalking.VE_SittingToStartWalkingController();
		}
		private void VE_SittingToStanding()
		{
			VespiquensittingToStanding.VE_SittingToStandingController();
		}

	}
}