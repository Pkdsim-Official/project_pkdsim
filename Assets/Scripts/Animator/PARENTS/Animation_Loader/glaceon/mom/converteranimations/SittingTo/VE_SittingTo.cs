using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.converteranimations.SittingTo
{
	public class GLParentMom_SittingTo : MonoBehaviour 
	{
		private GLParentMom_SittingToStartWalking GlaceonParentMomSittingToStartWalking;
		private GLParentMom_SittingToStanding GlaceonParentMomSittingToStanding;
		public void GLParentMom_SittingToController()
		{
			GLParentMom_SittingToStartWalking();
			GLParentMom_SittingToStanding();
		}
		private void GLParentMom_SittingToStartWalking()
		{
			GlaceonParentMomSittingToStartWalking.GLParentMom_SittingToStartWalkingController();
		}
		private void GLParentMom_SittingToStanding()
		{
			GlaceonParentMomSittingToStanding.GLParentMom_SittingToStandingController();
		}

	}
}