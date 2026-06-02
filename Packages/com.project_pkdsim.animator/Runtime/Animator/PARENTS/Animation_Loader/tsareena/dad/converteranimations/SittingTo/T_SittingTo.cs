using project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.converteranimations.SittingTo
{
	public class TParentDad_SittingTo : MonoBehaviour 
	{
		private TParentDad_SittingToStartWalking TsareenasittingToStartWalking;
		private TParentDad_SittingToStanding TsareenasittingToStanding;
		public void TParentDad_SittingToController()
		{
			TParentDad_SittingToStartWalking();
			TParentDad_SittingToStanding();
		}
		private void TParentDad_SittingToStartWalking()
		{
			TsareenasittingToStartWalking.TParentDad_SittingToStartWalkingController();
		}
		private void TParentDad_SittingToStanding()
		{
			TsareenasittingToStanding.TParentDad_SittingToStandingController();
		}
	}
}