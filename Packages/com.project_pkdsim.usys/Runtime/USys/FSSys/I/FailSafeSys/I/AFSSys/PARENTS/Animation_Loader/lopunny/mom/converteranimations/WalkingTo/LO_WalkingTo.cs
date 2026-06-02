using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.WalkingTo
{
	public class LOParentMom_WalkingTo : MonoBehaviour 
	{
		private LOParentMom_WalkingToStanding LopunnyWalkingToStanding;
		private LOParentMom_WalkingToSitting LopunnyWalkingToSitting;
		public void LOParentMom_WalkingToController()
		{
			Load_LOParentMom_WalkingToStanding();
			Load_LOParentMom_WalkingToWSitting();
		}
		private void Load_LOParentMom_WalkingToStanding()
		{
			LopunnyWalkingToStanding.LOParentMom_WalkingToStandingController();
		}
		private void Load_LOParentMom_WalkingToWSitting()
		{
			LopunnyWalkingToSitting.LOParentMom_WalkingToSittingController();
		}
	}
}