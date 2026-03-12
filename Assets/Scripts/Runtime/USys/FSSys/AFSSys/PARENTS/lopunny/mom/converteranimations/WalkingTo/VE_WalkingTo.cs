using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.WalkingTo
{
		public class LOParentMom_WalkingTo : MonoBehaviour 
	{
		private LOParentMom_WalkingToSitting LopunnyParentMomWalkingToSitting;
		private LOParentMom_WalkingToStanding LopunnyParentMomWalkingToStanding;
		public void LOParentMom_WalkingToController()
		{
			LOParentMom_WalkingToStartWalking();
			LOParentMom_WalkingToStanding();
		}
		private void LOParentMom_WalkingToStartWalking()
		{
			LopunnyParentMomWalkingToSitting.LOParentMom_WalkingToSittingController();
		}
		private void LOParentMom_WalkingToStanding()
		{
			LopunnyParentMomWalkingToStanding.LOParentMom_WalkingToStandingController();
		}
	}
}