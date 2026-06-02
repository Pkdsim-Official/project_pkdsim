using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.converteranimations.WalkingTo
{
	public class VPParentDad_WalkingTo : MonoBehaviour 
	{
		private VPParentDad_WalkingToSitting VPParentDad_WalkingToSitting;
		
		private VPParentDad_WalkingToStanding VPParentDad_WalkingToStanding;

		public void VPParentDad_WalkingToController() 
		{
			VPParentDad_WalkingToSittingController();
			VPParentDad_WalkingToStandingController();
		}
		private void VPParentDad_WalkingToSittingController()
		{
			VPParentDad_WalkingToSitting.VPParentDad_WalkingToSittingController();
		}
		private void VPParentDad_WalkingToStandingController()
		{
			VPParentDad_WalkingToStanding.VPParentDad_WalkingToStandingController();
		}
	}
}