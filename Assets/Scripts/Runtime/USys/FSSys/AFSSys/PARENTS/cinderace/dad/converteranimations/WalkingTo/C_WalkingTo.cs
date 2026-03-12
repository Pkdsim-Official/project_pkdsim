using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Dad.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Dad.converteranimations.WalkingTo
{
	public class CParentDad_WalkingTo : MonoBehaviour
	{
		private CParentDad_WalkingToSitting CinderaceParentDadWalkingToSitting;
		private CParentDad_WalkingToStanding CinderaceParentDadWalkingToStanding;
		public void CParentDad_WalkingToController()
		{
			CParentDad_WalkingToStartWalking();
			CParentDad_WalkingToStanding();
		}
		private void CParentDad_WalkingToStartWalking()
		{
			CinderaceParentDadWalkingToSitting.CParentDad_WalkingToSittingController();
		}
		private void CParentDad_WalkingToStanding()
		{
			CinderaceParentDadWalkingToStanding.CParentDad_WalkingToStandingController();
		}
	}
}