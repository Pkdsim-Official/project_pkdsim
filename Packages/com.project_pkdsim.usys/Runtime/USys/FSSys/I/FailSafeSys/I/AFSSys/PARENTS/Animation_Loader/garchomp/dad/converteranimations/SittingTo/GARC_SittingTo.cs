using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.converteranimations.SittingTo
{
	public class GARCParentDad_SittingTo : MonoBehaviour 
	{
		private GARCParentDad_SittingToStartWalking GarchompSittingToStartWalking;
		private GARCParentDad_SittingToStanding GarchompSittingToStanding;
		public void GARCParentDad_SittingToController()
		{
			GARCParentDad_SittingToStartWalking();
			GARCParentDad_SittingToStanding();
		}
		private void GARCParentDad_SittingToStartWalking()
		{
			GarchompSittingToStartWalking.GARCParentDad_SittingToStartWalkingController();
		}
		private void GARCParentDad_SittingToStanding()
		{
			GarchompSittingToStanding.GARCParentDad_SittingToStandingController();
		}
	}
}