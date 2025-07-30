using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.converteranimations.SittingTo
{
	public class FLParentDadDad_SittingTo : MonoBehaviour 
	{
		private FLParentDadDad_SittingToStartWalking FlareonSittingToStartWalking;
		private FLParentDadDad_SittingToStanding FlareonSittingToStanding;

		public void FLParentDadDad_SittingToController()
		{
			Load_FLParentDadDad_SittingToStanding();
			Load_FLParentDadDad_SittingToWalking();
		}
		private void Load_FLParentDadDad_SittingToStanding()
		{
			FlareonSittingToStanding.FLParentDadDad_SittingToStandingController();
		}
		private void Load_FLParentDadDad_SittingToWalking()
		{
			FlareonSittingToStartWalking.FLParentDadDad_SittingToStartWalkingController();
		}
	}
}