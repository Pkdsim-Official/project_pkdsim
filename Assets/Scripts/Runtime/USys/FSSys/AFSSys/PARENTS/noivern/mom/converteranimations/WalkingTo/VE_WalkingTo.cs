using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.converteranimations.WalkingTo
{
		public class NOIParentMom_WalkingTo : MonoBehaviour 
	{
		private NOIParentMom_WalkingToSitting NoivernParentMomWalkingToSitting;
		private NOIParentMom_WalkingToStanding NoivernParentMomWalkingToStanding;
		public void NOIParentMom_WalkingToController()
		{
			NOIParentMom_WalkingToStartWalking();
			NOIParentMom_WalkingToStanding();
		}
		private void NOIParentMom_WalkingToStartWalking()
		{
			NoivernParentMomWalkingToSitting.NOIParentMom_WalkingToSittingController();
		}
		private void NOIParentMom_WalkingToStanding()
		{
			NoivernParentMomWalkingToStanding.NOIParentMom_WalkingToStandingController();
		}
	}
}