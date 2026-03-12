using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.converteranimations.SittingTo
{
	public class GARC_SittingTo : MonoBehaviour 
	{
		private GARC_SittingToStartWalking GarchompSittingToStartWalking;
		private GARC_SittingToStanding GarchompSittingToStanding;
		public void GARC_SittingToController()
		{
			GARC_SittingToStartWalking();
			GARC_SittingToStanding();
		}
		private void GARC_SittingToStartWalking()
		{
			GarchompSittingToStartWalking.GARC_SittingToStartWalkingController();
		}
		private void GARC_SittingToStanding()
		{
			GarchompSittingToStanding.GARC_SittingToStandingController();
		}
	}
}