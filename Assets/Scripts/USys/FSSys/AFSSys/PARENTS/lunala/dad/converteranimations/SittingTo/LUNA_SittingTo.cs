using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.converteranimations.SittingTo
{
	public class LUNASittingTo : MonoBehaviour 
	{
		private LUNASittingToStartWalking LunalasittingToStartWalking;
		private LUNASittingToStanding LunalasittingToStanding;
		public void LUNASittingToController()
		{
			LUNASittingToStartWalking();
			LUNASittingToStanding();
		}
		private void LUNASittingToStartWalking()
		{
			LunalasittingToStartWalking.LUNASittingToStartWalkingController();
		}
		private void LUNASittingToStanding()
		{
			LunalasittingToStanding.LUNASittingToStandingController();
		}

	}
}