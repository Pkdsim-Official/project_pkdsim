using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.converteranimations.SittingTo
{
	public class FR_SittingTo : MonoBehaviour 
	{
		private FR_SittingToStartWalking FrostlassSittingToStartWalking;
		private FR_SittingToStanding FrostlassSittingToStanding;
		public void FR_SittingToController()
		{
			FR_SittingToStartWalking();
			FR_SittingToStanding();
		}
		private void FR_SittingToStartWalking()
		{
			FrostlassSittingToStartWalking.FR_SittingToStartWalkingController();
		}
		private void FR_SittingToStanding()
		{
			FrostlassSittingToStanding.FR_SittingToStandingController();
		}

	}
}