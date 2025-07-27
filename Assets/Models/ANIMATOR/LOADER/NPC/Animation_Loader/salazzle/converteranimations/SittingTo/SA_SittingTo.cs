using project_pkdsim.Assets.Models.ANIMATOR.NPC.Salazzle.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.Models.ANIMATOR.NPC.Salazzle.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Salazzle.converteranimations.SittingTo
{
	public class SA_SittingTo : MonoBehaviour 
	{
		private SA_SittingToStartWalking Salazzle_sittingToStartWalking;
		private SA_SittingToStanding Salazzle_sittingToStanding;
		public void SA_SittingToController()
		{
			SA_SittingToStartWalking();
			SA_SittingToStanding();
		}
		private void SA_SittingToStartWalking()
		{
			Salazzle_sittingToStartWalking.SA_SittingToStartWalkingController();
		}
		private void SA_SittingToStanding()
		{
			Salazzle_sittingToStanding.SA_SittingToStandingController();
		}
	}
}