using project_pkdsim.ANIMATOR.NPC.Absol.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Absol.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Absol.converteranimations.SittingTo
{
	public class AB_SittingTo : MonoBehaviour 
	{
		private AB_SittingToStartWalking AbsolSittingToStartWalking;
		private AB_SittingToStanding AbsolSittingToStanding;
		public void AB_SittingToController()
		{
			AB_SittingToStartWalking();
			AB_SittingToStanding();
		}
		private void AB_SittingToStartWalking()
		{
			AbsolSittingToStartWalking.AB_SittingToStartWalkingController();
		}
		private void AB_SittingToStanding()
		{
			AbsolSittingToStanding.AB_SittingToStandingController();
		}

	}
}