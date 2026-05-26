using project_pkdsim.ANIMATOR.NPC.Primarina.converteranimations._SittingTo._SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Primarina.converteranimations._SittingTo._SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Primarina.converteranimations._SittingTo
{
	public class PR_SittingTo : MonoBehaviour 
	{
		private PR_SittingToStartWalking PrimarinasittingToStartWalking;
		private PR_SittingToStanding PrimarinasittingToStanding;
		public void PR_SittingToController()
		{
			PR_SittingToStartWalking();
			PR_SittingToStanding();
		}
		private void PR_SittingToStartWalking()
		{
			PrimarinasittingToStartWalking.PR_SittingToStartWalkingController();
		}
		private void PR_SittingToStanding()
		{
			PrimarinasittingToStanding.PR_SittingToStandingController();
		}

	}
}