using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.SittingTo
{
	public class TParentMom_SittingTo : MonoBehaviour 
	{
		private TParentMom_SittingToStartWalking TsareenasittingToStartWalking;
		private TParentMom_SittingToStanding TsareenasittingToStanding;
		public void TParentMom_SittingToController()
		{
			TParentMom_SittingToStartWalking();
			TParentMom_SittingToStanding();
		}
		private void TParentMom_SittingToStartWalking()
		{
			TsareenasittingToStartWalking.TParentMom_SittingToStartWalkingController();
		}
		private void TParentMom_SittingToStanding()
		{
			TsareenasittingToStanding.TParentMom_SittingToStandingController();
		}

	}
}