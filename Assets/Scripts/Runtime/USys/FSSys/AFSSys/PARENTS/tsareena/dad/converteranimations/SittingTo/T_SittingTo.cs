using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Dad.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Dad.converteranimations.SittingTo
{
	public class TParentDad_SittingTo : MonoBehaviour 
	{
		private TParentDad_SittingToStartWalking TParentDadsittingToStartWalking;
		private TParentDad_SittingToStanding TParentDadsittingToStanding;
		public void TParentDad_SittingToController()
		{
			TParentDad_SittingToStartWalking();
			TParentDad_SittingToStanding();
		}
		private void TParentDad_SittingToStartWalking()
		{
			TParentDadsittingToStartWalking.TParentDad_SittingToStartWalkingController();
		}
		private void TParentDad_SittingToStanding()
		{
			TParentDadsittingToStanding.TParentDad_SittingToStandingController();
		}
	}
}