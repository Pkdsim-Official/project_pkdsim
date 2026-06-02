using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.SittingTo
{
	public class LUNAParentMom_SittingTo : MonoBehaviour 
	{
		private LUNAParentMom_SittingToStartWalking LunalasittingToStartWalking;
		private LUNAParentMom_SittingToStanding LunalasittingToStanding;
		public void LUNAParentMom_SittingToController()
		{
			LUNAParentMom_SittingToStartWalking();
			LUNAParentMom_SittingToStanding();
		}
		private void LUNAParentMom_SittingToStartWalking()
		{
			LunalasittingToStartWalking.LUNAParentMom_SittingToStartWalkingController();
		}
		private void LUNAParentMom_SittingToStanding()
		{
			LunalasittingToStanding.LUNAParentMom_SittingToStandingController();
		}

	}
}