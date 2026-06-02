using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.SittingTo
{
	public class SA_SittingTo : MonoBehaviour 
	{
		private SA_SittingToStartWalking SalazzleParentMom_sittingToStartWalking;
		private SA_SittingToStanding SalazzleParentMom_sittingToStanding;
		public void SA_SittingToController()
		{
			SA_SittingToStartWalking();
			SA_SittingToStanding();
		}
		private void SA_SittingToStartWalking()
		{
			SalazzleParentMom_sittingToStartWalking.SA_SittingToStartWalkingController();
		}
		private void SA_SittingToStanding()
		{
			SalazzleParentMom_sittingToStanding.SA_SittingToStandingController();
		}
	}
}