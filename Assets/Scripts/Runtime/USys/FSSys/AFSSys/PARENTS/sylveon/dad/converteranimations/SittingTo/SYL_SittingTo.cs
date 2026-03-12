using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.converteranimations.SittingTo.SittingToStanding;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.converteranimations.SittingTo
{
	public class SYLParentDad_SittingTo : MonoBehaviour 
	{
		private SYLParentDad_SittingToStartWalking SylveonParentDadSittingToStartWalking;
		private SYLParentDad_SittingToStanding SylveonParentDadSittingToStanding;
		public void SYLParentDad_SittingToController()
		{
			Load_SYLParentDad_SittingToStartWalking();
			Load_SYLParentDad_SittingToStanding();
		}
		private void Load_SYLParentDad_SittingToStartWalking()
		{
			SylveonParentDadSittingToStartWalking.SYLParentDad_SittingToStartWalkingController();
		}
		private void Load_SYLParentDad_SittingToStanding()
		{
			SylveonParentDadSittingToStanding.SYLParentDad_SittingToStandingController();
		}
	}
}