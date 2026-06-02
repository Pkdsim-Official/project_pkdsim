using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.idlebaseanimation
{
	public class GlaceonParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private GLParentMom_IdleStanding GlaceonParentMom_idlestanding;
		
		private GLParentMom_IdleSitting GlaceonParentMom_idlesitting;
			

		public void GLParentMom_IdleAnimatorController()
		{
			GlaceonParentMom_idlestanding.GLParentMom_IdleStandingController();
			GlaceonParentMom_idlesitting.GLParentMom_IdleSittingController();	
		}
	}
}