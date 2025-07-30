using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Mom.converteranimations.SittingTo
{
	public class LUCAParentMom_SittingTo : MonoBehaviour 
	{
		private LUCAParentMom_SittingToStartWalking LucarioParentMomSittingToStartWalking;
		private LUCAParentMom_SittingToStanding LucarioParentMomSittingToStanding;
		public void LUCAParentMom_SittingToController()
		{
			LUCAParentMom_SittingToStartWalking();
			LUCAParentMom_SittingToStanding();
		}
		private void LUCAParentMom_SittingToStartWalking()
		{
			LucarioParentMomSittingToStartWalking.LUCAParentMom_SittingToStartWalkingController();
		}
		private void LUCAParentMom_SittingToStanding()
		{
			LucarioParentMomSittingToStanding.LUCAParentMom_SittingToStandingController();
		}

	}
}