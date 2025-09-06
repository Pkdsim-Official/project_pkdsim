using project_pkdsim.ANIMATOR.NPC.Tsareena.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Tsareena.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Tsareena.converteranimations.SittingTo
{
	public class TSittingTo : MonoBehaviour 
	{
		private TSittingToStartWalking TsareenasittingToStartWalking;
		private TSittingToStanding TsareenasittingToStanding;
		public void TSittingToController()
		{
			TSittingToStartWalking();
			TSittingToStanding();
		}
		private void TSittingToStartWalking()
		{
			TsareenasittingToStartWalking.TSittingToStartWalkingController();
		}
		private void TSittingToStanding()
		{
			TsareenasittingToStanding.TSittingToStandingController();
		}

	}
}