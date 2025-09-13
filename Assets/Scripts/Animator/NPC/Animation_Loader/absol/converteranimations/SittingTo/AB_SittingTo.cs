using project_pkdsim.ANIMATOR.NPC.Absol.converteranimations._SittingTo._SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Absol.converteranimations._SittingTo._SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Absol.converteranimations._SittingTo
{
	public class AB_SittingTo : MonoBehaviour 
	{
		private AB_SittingToStartWalking Absol_SittingToStartWalking;
		private AB_SittingToStanding Absol_SittingToStanding;
		public void AB_SittingToController()
		{
			AB_SittingToStartWalking();
			AB_SittingToStanding();
		}
		private void AB_SittingToStartWalking()
		{
			Absol_SittingToStartWalking.AB_SittingToStartWalkingController();
		}
		private void AB_SittingToStanding()
		{
			Absol_SittingToStanding.AB_SittingToStandingController();
		}

	}
}