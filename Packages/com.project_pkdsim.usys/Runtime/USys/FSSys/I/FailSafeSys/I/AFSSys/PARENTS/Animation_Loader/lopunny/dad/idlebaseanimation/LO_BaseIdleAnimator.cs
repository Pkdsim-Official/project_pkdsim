using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.idlebaseanimation
{
	public class LopunnyParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private LOParentDad_IdleStanding Lopunnyidlestanding;
		
		private LOParentDad_IdleSitting Lopunnyidlesitting;
		
		public void	LOParentDad_IdleAnimatorController()
		{
			LOParentDad_IdleStandingAnimatorController();
			LOParentDad_IdleSittingAnimatorController();
		}
		private void LOParentDad_IdleStandingAnimatorController()
		{
			Lopunnyidlestanding.LOParentDad_IdleStandingController();
		}
		private void LOParentDad_IdleSittingAnimatorController()
		{
			Lopunnyidlesitting.LOParentDad_IdleSittingController();
		}
	}
}