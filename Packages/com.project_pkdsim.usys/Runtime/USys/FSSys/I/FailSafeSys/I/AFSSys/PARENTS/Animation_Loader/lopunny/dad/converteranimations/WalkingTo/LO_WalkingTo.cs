using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.converteranimations.WalkingTo
{
	public class LOParentDad_WalkingTo : MonoBehaviour 
	{
		private LOParentDad_WalkingToStanding LopunnyWalkingToStanding;
		private LOParentDad_WalkingToSitting LopunnyWalkingToSitting;
		public void LOParentDad_WalkingToController()
		{
			Load_LOParentDad_WalkingToStanding();
			Load_LOParentDad_WalkingToWSitting();
		}
		private void Load_LOParentDad_WalkingToStanding()
		{
			LopunnyWalkingToStanding.LOParentDad_WalkingToStandingController();
		}
		private void Load_LOParentDad_WalkingToWSitting()
		{
			LopunnyWalkingToSitting.LOParentDad_WalkingToSittingController();
		}
	}
}