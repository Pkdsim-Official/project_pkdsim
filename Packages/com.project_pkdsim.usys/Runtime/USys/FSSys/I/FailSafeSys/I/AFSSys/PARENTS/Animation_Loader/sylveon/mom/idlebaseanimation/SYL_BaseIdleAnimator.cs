using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.idlebaseanimation
{
	public class SylveonParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private SYLParentMom_IdleStanding SYLParentMom_idlestanding;
		
		private SYLParentMom_IdleSitting SYLParentMom_idlesitting;

		public void SYLParentMom_IdleAnimatorController()
		{
			SYLParentMom_idlestanding.SYLParentMom_IdleStandingController();
			SYLParentMom_idlesitting.SYLParentMom_IdleSittingController();	
		}
	}
}