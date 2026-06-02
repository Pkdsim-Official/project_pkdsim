using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.converteranimations.WalkingTo
{
	public class HATParentMom_WalkingTo : MonoBehaviour 
	{
		private HATParentMom_WalkingToStanding HattereneWalkingToStanding;
		private HATParentMom_WalkingToSitting HattereneWalkingToSitting;
		public void HATParentMom_WalkingToController()
		{
			Load_HATParentMom_WalkingToStanding();
			Load_HATParentMom_WalkingToWSitting();
		}
		private void Load_HATParentMom_WalkingToStanding()
		{
			HattereneWalkingToStanding.HATParentMom_WalkingToStandingController();
		}
		private void Load_HATParentMom_WalkingToWSitting()
		{
			HattereneWalkingToSitting.HATParentMom_WalkingToSittingController();
		}
	}
}