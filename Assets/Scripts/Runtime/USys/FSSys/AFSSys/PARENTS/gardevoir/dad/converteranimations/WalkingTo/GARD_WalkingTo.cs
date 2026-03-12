using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.converteranimations.WalkingTo
{
	public class GARD_WalkingTo : MonoBehaviour 
	{
		private GARD_WalkingToSitting GardevoirWalkingToSitting;
		private GARD_WalkingToStanding GardevoirWalkingToStanding;
		public void GARD_WalkingToController()
		{
			GARD_WalkingToStartWalking();
			GARD_WalkingToStanding();
		}
		private void GARD_WalkingToStartWalking()
		{
			GardevoirWalkingToSitting.GARD_WalkingToSittingController();
		}
		private void GARD_WalkingToStanding()
		{
			GardevoirWalkingToStanding.GARD_WalkingToStandingController();
		}
	}
}