using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.SittingTo
{
	public class LOParentMom_SittingTo : MonoBehaviour 
	{
		private LOParentMom_SittingToStartWalking LopunnysittingToStartWalking;
		private LOParentMom_SittingToStanding LopunnysittingToStanding;
		public void LOParentMom_SittingToController()
		{
			LOParentMom_SittingToStartWalking();
			LOParentMom_SittingToStanding();
		}
		private void LOParentMom_SittingToStartWalking()
		{
			LopunnysittingToStartWalking.LOParentMom_SittingToStartWalkingController();
		}
		private void LOParentMom_SittingToStanding()
		{
			LopunnysittingToStanding.LOParentMom_SittingToStandingController();
		}

	}
}