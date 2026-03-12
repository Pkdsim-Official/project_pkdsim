using Project_Pkdsim.ANIMATOR.Parents.Glaceon.Mom.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Parents.Glaceon.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Glaceon.Mom.converteranimations.WalkingTo
{
		public class GLParentMom_WalkingTo : MonoBehaviour 
	{
		private GLParentMom_WalkingToSitting GlaceonParentMomWalkingToSitting;
		private GLParentMom_WalkingToStanding GlaceonParentMomWalkingToStanding;
		public void GLParentMom_WalkingToController()
		{
			GLParentMom_WalkingToStartWalking();
			GLParentMom_WalkingToStanding();
		}
		private void GLParentMom_WalkingToStartWalking()
		{
			GlaceonParentMomWalkingToSitting.GLParentMom_WalkingToSittingController();
		}
		private void GLParentMom_WalkingToStanding()
		{
			GlaceonParentMomWalkingToStanding.GLParentMom_WalkingToStandingController();
		}
	}
}