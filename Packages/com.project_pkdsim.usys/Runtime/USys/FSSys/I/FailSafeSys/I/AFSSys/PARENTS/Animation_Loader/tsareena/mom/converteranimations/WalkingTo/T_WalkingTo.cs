using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.WalkingTo.WalkingToStanding;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.WalkingTo.WalkingToSitting;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.WalkingTo
{
	public class TParentMom_WalkingTo : MonoBehaviour 
	{
		private TParentMom_WalkingToSitting TsareenaParentMom_WalkingToSitting;
		private TParentMom_WalkingToStanding TsareenaParentMom_WalkingToStanding;
		public void TParentMom_WalkingToController()
		{
			TParentMom_WalkingToSitting();
			TParentMom_WalkingToStanding();
		}
		private void TParentMom_WalkingToSitting()
		{
			TsareenaParentMom_WalkingToSitting.TParentMom_WalkingToSittingController();
		}
		private void TParentMom_WalkingToStanding()
		{
			TsareenaParentMom_WalkingToStanding.TParentMom_WalkingToStandingController();
		}
	}
}