using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation
{
	public class JolteonParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private JT_IdleStanding JT_idlestanding;
		
		private JT_IdleSitting JT_idlesitting;

		public void JTParentMom_IdleAnimatorController()
		{
			JT_idlestanding.JT_IdleStandingController();
			JT_idlesitting.JT_IdleSittingController();	
		}
	}
}