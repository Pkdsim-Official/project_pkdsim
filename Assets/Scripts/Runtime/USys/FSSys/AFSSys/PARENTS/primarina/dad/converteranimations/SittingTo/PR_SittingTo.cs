using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.converteranimations.SittingTo
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