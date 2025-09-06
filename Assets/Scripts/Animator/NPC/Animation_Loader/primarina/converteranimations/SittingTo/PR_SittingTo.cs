using project_pkdsim.ANIMATOR.NPC.Primarina.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Primarina.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Primarina.converteranimations.SittingTo
{
	public class PRSittingTo : MonoBehaviour 
	{
		private PRSittingToStartWalking PrimarinasittingToStartWalking;
		private PRSittingToStanding PrimarinasittingToStanding;
		public void PRSittingToController()
		{
			PRSittingToStartWalking();
			PRSittingToStanding();
		}
		private void PRSittingToStartWalking()
		{
			PrimarinasittingToStartWalking.PRSittingToStartWalkingController();
		}
		private void PRSittingToStanding()
		{
			PrimarinasittingToStanding.PRSittingToStandingController();
		}

	}
}