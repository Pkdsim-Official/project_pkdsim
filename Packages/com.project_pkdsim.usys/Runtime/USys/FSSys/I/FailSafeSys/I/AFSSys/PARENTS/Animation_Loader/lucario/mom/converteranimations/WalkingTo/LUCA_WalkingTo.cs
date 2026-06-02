using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.WalkingTo
{
	public class LUCAParentMom_WalkingTo : MonoBehaviour 
	{
		private LUCAParentMom_WalkingToStanding LucarioWalkingToStanding;
		private LUCAParentMom_WalkingToSitting LucarioWalkingToSitting;
		public void LUCAParentMom_WalkingToController()
		{
			Load_LUCAParentMom_WalkingToStanding();
			Load_LUCAParentMom_WalkingToWSitting();
		}
		private void Load_LUCAParentMom_WalkingToStanding()
		{
			LucarioWalkingToStanding.LUCAParentMom_WalkingToStandingController();
		}
		private void Load_LUCAParentMom_WalkingToWSitting()
		{
			LucarioWalkingToSitting.LUCAParentMom_WalkingToSittingController();
		}
	}
}