using project_pkdsim.Models.ANIMATOR.NPC.Zoroark.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Models.ANIMATOR.NPC.Zoroark.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Zoroark.converteranimations.SittingTo
{
	public class ZSittingTo : MonoBehaviour 
	{
		private ZSittingToStartWalking ZoroarksittingToStartWalking;
		private ZSittingToStanding ZoroarksittingToStanding;
		public void ZSittingToController()
		{
			ZSittingToStartWalking();
			ZSittingToStanding();
		}
		private void ZSittingToStartWalking()
		{
			ZoroarksittingToStartWalking.ZSittingToStartWalkingController();
		}
		private void ZSittingToStanding()
		{
			ZoroarksittingToStanding.ZSittingToStandingController();
		}

	}
}