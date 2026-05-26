using project_pkdsim.ANIMATOR.NPC.Blaziken.converteranimations._SittingTo._SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Blaziken.converteranimations._SittingTo._SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Blaziken.converteranimations._SittingTo
{
	public class BL_SittingTo : MonoBehaviour 
	{
		private BL_SittingToStartWalking Blaziken_SittingToStartWalking;
		private BL_SittingToStanding Blaziken_SittingToStanding;
		public void BL_SittingToController()
		{
			BL_SittingToStartWalking();
			BL_SittingToStanding();
		}
		private void BL_SittingToStartWalking()
		{
			Blaziken_SittingToStartWalking.BL_SittingToStartWalkingController();
		}
		private void BL_SittingToStanding()
		{
			Blaziken_SittingToStanding.BL_SittingToStandingController();
		}

	}
}