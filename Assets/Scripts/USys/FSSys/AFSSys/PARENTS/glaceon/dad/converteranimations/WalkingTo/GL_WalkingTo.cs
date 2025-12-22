using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.converteranimations.WalkingTo
{
	public class GLParentDad_WalkingTo : MonoBehaviour 
	{
		private GLParentDad_WalkingToSitting GlaceonParentDadWalkingToSitting;
		private GLParentDad_WalkingToStanding GlaceonParentDadWalkingToStanding;
		
		public void GLParentDad_WalkingToController()
		{
			GLParentDad_WalkingToStartWalking();
			GLParentDad_WalkingToStanding();
		}
		private void GLParentDad_WalkingToStartWalking()
		{
			GlaceonParentDadWalkingToSitting.GLParentDad_WalkingToSittingController();
		}
		private void GLParentDad_WalkingToStanding()
		{
			GlaceonParentDadWalkingToStanding.GLParentDad_WalkingToStandingController();
		}
	}
}