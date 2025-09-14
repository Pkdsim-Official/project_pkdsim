using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Mom.converteranimations.SittingTo
{
	public class NOIParentMom_SittingTo : MonoBehaviour 
	{
		private NOIParentMom_SittingToStartWalking NoivernParentMomSittingToStartWalking;
		private NOIParentMom_SittingToStanding NoivernParentMomSittingToStanding;
		public void NOIParentMom_SittingToController()
		{
			NOIParentMom_SittingToStartWalking();
			NOIParentMom_SittingToStanding();
		}
		private void NOIParentMom_SittingToStartWalking()
		{
			NoivernParentMomSittingToStartWalking.NOIParentMom_SittingToStartWalkingController();
		}
		private void NOIParentMom_SittingToStanding()
		{
			NoivernParentMomSittingToStanding.NOIParentMom_SittingToStandingController();
		}

	}
}