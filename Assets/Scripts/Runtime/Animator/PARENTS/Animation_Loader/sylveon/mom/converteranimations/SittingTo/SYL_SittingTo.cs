using Project_Pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations.SittingTo
{
	public class SYLParentMom_SittingTo : MonoBehaviour 
	{
		private SYLParentMom_SittingToStartWalking SylveonParentMomSittingToStartWalking;
		private SYLParentMom_SittingToStanding SylveonParentMomSittingToStanding;
		public void SYLParentMom_SittingToController()
		{
			SYLParentMom_SittingToStartWalking();
			SYLParentMom_SittingToStanding();
		}
		private void SYLParentMom_SittingToStartWalking()
		{
			SylveonParentMomSittingToStartWalking.SYLParentMom_SittingToStartWalkingController();
		}
		private void SYLParentMom_SittingToStanding()
		{
			SylveonParentMomSittingToStanding.SYLParentMom_SittingToStandingController();
		}

	}
}