using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Dad.converteranimations.SittingTo
{
	public class SA_SittingTo : MonoBehaviour 
	{
		private SA_SittingToStartWalking sittingToStartWalking;
		private SA_SittingToStanding sittingToStanding;
		public void SA_SittingToController()
		{
			SA_SittingToStartWalking();
			SA_SittingToStanding();
		}
		private void SA_SittingToStartWalking()
		{
			sittingToStartWalking.SA_SittingToStartWalkingController();
		}
		private void SA_SittingToStanding()
		{
			sittingToStanding.SA_SittingToStandingController();
		}
	}
}