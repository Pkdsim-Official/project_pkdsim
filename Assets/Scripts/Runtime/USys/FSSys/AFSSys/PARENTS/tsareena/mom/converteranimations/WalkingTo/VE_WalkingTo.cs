using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.WalkingTo
{
		public class TParentMom_WalkingTo : MonoBehaviour 
	{
		private TParentMom_WalkingToSitting TsareenaParentMomWalkingToSitting;
		private TParentMom_WalkingToStanding TsareenaParentMomWalkingToStanding;
		public void TParentMom_WalkingToController()
		{
			TParentMom_WalkingToStartWalking();
			TParentMom_WalkingToStanding();
		}
		private void TParentMom_WalkingToStartWalking()
		{
			TsareenaParentMomWalkingToSitting.TParentMom_WalkingToSittingController();
		}
		private void TParentMom_WalkingToStanding()
		{
			TsareenaParentMomWalkingToStanding.TParentMom_WalkingToStandingController();
		}
	}
}