using project_pkdsim.Models.ANIMATOR.NPC.Garchomp.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Models.ANIMATOR.NPC.Garchomp.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Garchomp.converteranimations.SittingTo
{
	public class GARCSittingTo : MonoBehaviour 
	{
		private GARCSittingToStartWalking GarchompsittingToStartWalking;
		private GARCSittingToStanding GarchompsittingToStanding;
		public void GARCSittingToController()
		{
			GARCSittingToStartWalking();
			GARCSittingToStanding();
		}
		private void GARCSittingToStartWalking()
		{
			GarchompsittingToStartWalking.GARCSittingToStartWalkingController();
		}
		private void GARCSittingToStanding()
		{
			GarchompsittingToStanding.GARCSittingToStandingController();
		}

	}
}