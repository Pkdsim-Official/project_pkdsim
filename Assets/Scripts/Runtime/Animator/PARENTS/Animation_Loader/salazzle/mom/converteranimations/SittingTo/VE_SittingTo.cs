using Project_Pkdsim.ANIMATOR.Parents.Salazzle.Mom.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Parents.Salazzle.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Salazzle.Mom.converteranimations.SittingTo
{
	public class SParentMom_SittingTo : MonoBehaviour 
	{
		private SParentMom_SittingToStartWalking SalazzleParentMomSittingToStartWalking;
		private SParentMom_SittingToStanding SalazzleParentMomSittingToStanding;
		public void SParentMom_SittingToController()
		{
			SParentMom_SittingToStartWalking();
			SParentMom_SittingToStanding();
		}
		private void SParentMom_SittingToStartWalking()
		{
			SalazzleParentMomSittingToStartWalking.SParentMom_SittingToStartWalkingController();
		}
		private void SParentMom_SittingToStanding()
		{
			SalazzleParentMomSittingToStanding.SParentMom_SittingToStandingController();
		}

	}
}