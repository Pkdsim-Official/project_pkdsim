using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.converteranimations.SittingTo
{
	public class SYLParentDad_SittingTo : MonoBehaviour 
	{
		private SYLParentDad_SittingToStartWalking Sylveon_SittingToStartWalking;
		private SYLParentDad_SittingToStanding Sylveon_SittingToStanding;
		public void SYLParentDad_SittingToController()
		{
			Load_SYLParentDad_SittingToStartWalking();
			Load_SYLParentDad_SittingToStanding();
		}
		private void Load_SYLParentDad_SittingToStartWalking()
		{
			Sylveon_SittingToStartWalking.SYLParentDad_SittingToStartWalkingController();
		}
		private void Load_SYLParentDad_SittingToStanding()
		{
			Sylveon_SittingToStanding.SYLParentDad_SittingToStandingController();
		}
	}
}