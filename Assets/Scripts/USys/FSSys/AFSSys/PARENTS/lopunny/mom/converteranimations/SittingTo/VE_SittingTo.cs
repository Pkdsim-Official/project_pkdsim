using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.SittingTo
{
	public class LOParentMom_SittingTo : MonoBehaviour 
	{
		private LOParentMom_SittingToStartWalking LopunnyParentMomSittingToStartWalking;
		private LOParentMom_SittingToStanding LopunnyParentMomSittingToStanding;
		public void LOParentMom_SittingToController()
		{
			LOParentMom_SittingToStartWalking();
			LOParentMom_SittingToStanding();
		}
		private void LOParentMom_SittingToStartWalking()
		{
			LopunnyParentMomSittingToStartWalking.LOParentMom_SittingToStartWalkingController();
		}
		private void LOParentMom_SittingToStanding()
		{
			LopunnyParentMomSittingToStanding.LOParentMom_SittingToStandingController();
		}

	}
}