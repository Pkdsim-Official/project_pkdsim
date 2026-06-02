using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.WalkingTo
{
	public class VPParentMom_WalkingTo : MonoBehaviour 
	{
		private VPParentMom_WalkingToSitting VPParentMom_WalkingToSitting;
		
		private VPParentMom_WalkingToStanding VPParentMom_WalkingToStanding;

		public void VPParentMom_WalkingToController() 
		{
			VPParentMom_WalkingToSittingController();
			VPParentMom_WalkingToStandingController();
		}
		private void VPParentMom_WalkingToSittingController()
		{
			VPParentMom_WalkingToSitting.VPParentMom_WalkingToSittingController();
		}
		private void VPParentMom_WalkingToStandingController()
		{
			VPParentMom_WalkingToStanding.VPParentMom_WalkingToStandingController();
		}
	}
}