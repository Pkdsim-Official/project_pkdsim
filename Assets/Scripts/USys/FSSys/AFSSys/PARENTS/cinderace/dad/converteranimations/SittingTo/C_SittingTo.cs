using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Dad.converteranimations.SittingTo
{
	public class CParentDad_SittingTo : MonoBehaviour 
	{
		private CParentDad_SittingToStartWalking CinderaceParentDadSittingToStartWalking;
		private CParentDad_SittingToStanding CinderaceParentDadSittingToStanding;
		public void CParentDad_SittingToController()
		{
			CParentDad_SittingToStartWalking();
			CParentDad_SittingToStanding();
		}
		private void CParentDad_SittingToStartWalking()
		{
			CinderaceParentDadSittingToStartWalking.CParentDad_SittingToStartWalkingController();
		}
		private void CParentDad_SittingToStanding()
		{
			CinderaceParentDadSittingToStanding.CParentDad_SittingToStandingController();
		}
	}
}