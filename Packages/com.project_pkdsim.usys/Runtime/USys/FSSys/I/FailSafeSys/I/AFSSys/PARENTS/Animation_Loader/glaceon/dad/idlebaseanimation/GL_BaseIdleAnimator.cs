using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.idlebaseanimation
{
	public class GlaceonParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private GLParentDad_IdleStanding GlaceonParentDad_idlestanding;
		
		private GLParentDad_IdleSitting GlaceonParentDad_idlesitting;
			

		public void GLParentDad_IdleAnimatorController()
		{
			GlaceonParentDad_idlestanding.GLParentDad_IdleStandingController();
			GlaceonParentDad_idlesitting.GLParentDad_IdleSittingController();	
		}
	}
}