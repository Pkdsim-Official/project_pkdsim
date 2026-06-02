using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.converteranimations.WalkingTo
{
	public class GARCParentDad_WalkingTo : MonoBehaviour 
	{
		private GARCParentDad_WalkingToStanding GarchompWalkingToStanding;
		private GARCParentDad_WalkingToSitting GarchompWalkingToSitting;
		public void GARCParentDad_WalkingToController()
		{
			Load_GARCParentDad_WalkingToStanding();
			Load_GARCParentDad_WalkingToWSitting();
		}
		private void Load_GARCParentDad_WalkingToStanding()
		{
			GarchompWalkingToStanding.GARCParentDad_WalkingToStandingController();
		}
		private void Load_GARCParentDad_WalkingToWSitting()
		{
			GarchompWalkingToSitting.GARCParentDad_WalkingToSittingController();
		}
	}
}