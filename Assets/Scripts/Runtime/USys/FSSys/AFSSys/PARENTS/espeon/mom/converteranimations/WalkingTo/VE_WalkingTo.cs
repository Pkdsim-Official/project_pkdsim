using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.converteranimations.WalkingTo
{
		public class ESParentMom_WalkingTo : MonoBehaviour 
	{
		private ESParentMom_WalkingToSitting EspeonParentMomWalkingToSitting;
		private ESParentMom_WalkingToStanding EspeonParentMomWalkingToStanding;
		public void ESParentMom_WalkingToController()
		{
			ESParentMom_WalkingToStartWalking();
			ESParentMom_WalkingToStanding();
		}
		private void ESParentMom_WalkingToStartWalking()
		{
			EspeonParentMomWalkingToSitting.ESParentMom_WalkingToSittingController();
		}
		private void ESParentMom_WalkingToStanding()
		{
			EspeonParentMomWalkingToStanding.ESParentMom_WalkingToStandingController();
		}
	}
}