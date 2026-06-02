using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.converteranimations.SittingTo
{
	public class SYLParentMom_SittingTo : MonoBehaviour 
	{
		private SYLParentMom_SittingToStartWalking Sylveon_SittingToStartWalking;
		private SYLParentMom_SittingToStanding Sylveon_SittingToStanding;
		public void SYLParentMom_SittingToController()
		{
			Load_SYLParentMom_SittingToStartWalking();
			Load_SYLParentMom_SittingToStanding();
		}
		private void Load_SYLParentMom_SittingToStartWalking()
		{
			Sylveon_SittingToStartWalking.SYLParentMom_SittingToStartWalkingController();
		}
		private void Load_SYLParentMom_SittingToStanding()
		{
			Sylveon_SittingToStanding.SYLParentMom_SittingToStandingController();
		}
	}
}