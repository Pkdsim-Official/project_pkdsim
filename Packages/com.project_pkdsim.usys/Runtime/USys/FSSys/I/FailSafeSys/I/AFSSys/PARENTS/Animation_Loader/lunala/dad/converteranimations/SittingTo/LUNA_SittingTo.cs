using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.converteranimations.SittingTo
{
	public class LUNAParentDad_SittingTo : MonoBehaviour 
	{
		private LUNAParentDad_SittingToStartWalking LunalasittingToStartWalking;
		private LUNAParentDad_SittingToStanding LunalasittingToStanding;
		public void LUNAParentDad_SittingToController()
		{
			LUNAParentDad_SittingToStartWalking();
			LUNAParentDad_SittingToStanding();
		}
		private void LUNAParentDad_SittingToStartWalking()
		{
			LunalasittingToStartWalking.LUNAParentDad_SittingToStartWalkingController();
		}
		private void LUNAParentDad_SittingToStanding()
		{
			LunalasittingToStanding.LUNAParentDad_SittingToStandingController();
		}

	}
}