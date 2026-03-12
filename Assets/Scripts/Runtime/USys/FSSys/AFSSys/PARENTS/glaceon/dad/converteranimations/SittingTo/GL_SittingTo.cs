using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.converteranimations.SittingTo.SittingToStanding;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.converteranimations.SittingTo
{
	public class GLParentDad_SittingTo : MonoBehaviour 
	{
		private GLParentDad_SittingToStartWalking GlaceonParentDadsittingToStartWalking;
		private GLParentDad_SittingToStanding GlaceonParentDadsittingToStanding;
		public void GLParentDad_SittingToController()
		{
			GLParentDad_SittingToStartWalking();
			GLParentDad_SittingToStanding();
		}
		private void GLParentDad_SittingToStartWalking()
		{
			GlaceonParentDadsittingToStartWalking.GLParentDad_SittingToStartWalkingController();
		}
		private void GLParentDad_SittingToStanding()
		{
			GlaceonParentDadsittingToStanding.GLParentDad_SittingToStandingController();
		}
	}
}