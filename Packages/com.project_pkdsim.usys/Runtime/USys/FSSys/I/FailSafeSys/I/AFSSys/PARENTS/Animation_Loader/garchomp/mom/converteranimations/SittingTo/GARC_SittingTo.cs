using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.SittingTo
{
	public class GARCParentMom_SittingTo : MonoBehaviour 
	{
		private GARCParentMom_SittingToStartWalking GarchompSittingToStartWalking;
		private GARCParentMom_SittingToStanding GarchompSittingToStanding;
		public void GARCParentMom_SittingToController()
		{
			GARCParentMom_SittingToStartWalking();
			GARCParentMom_SittingToStanding();
		}
		private void GARCParentMom_SittingToStartWalking()
		{
			GarchompSittingToStartWalking.GARCParentMom_SittingToStartWalkingController();
		}
		private void GARCParentMom_SittingToStanding()
		{
			GarchompSittingToStanding.GARCParentMom_SittingToStandingController();
		}
	}
}