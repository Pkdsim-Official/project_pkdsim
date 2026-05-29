using project_pkdsim.ANIMATOR.Parents.Garchomp.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Garchomp.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Garchomp.Dad.converteranimations.SittingTo
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