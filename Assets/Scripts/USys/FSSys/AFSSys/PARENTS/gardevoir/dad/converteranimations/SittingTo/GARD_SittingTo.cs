using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.converteranimations.SittingTo
{
	public class GARD_SittingTo : MonoBehaviour 
	{
		private GARD_SittingToStartWalking GardevoirSittingToStartWalking;
		private GARD_SittingToStanding GardevoirSittingToStanding;
		public void GARD_SittingToController()
		{
			GARD_SittingToStartWalking();
			GARD_SittingToStanding();
		}
		private void GARD_SittingToStartWalking()
		{
			GardevoirSittingToStartWalking.GARD_SittingToStartWalkingController();
		}
		private void GARD_SittingToStanding()
		{
			GardevoirSittingToStanding.GARD_SittingToStandingController();
		}
	}
}