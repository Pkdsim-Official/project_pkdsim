using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.idlebaseanimation
{
	public class LopunnyParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private LOParentMom_IdleStanding Lopunnyidlestanding;
		
		private LOParentMom_IdleSitting Lopunnyidlesitting;
		
		public void	LOParentMom_IdleAnimatorController()
		{
			LOParentMom_IdleStandingAnimatorController();
			LOParentMom_IdleSittingAnimatorController();
		}
		private void LOParentMom_IdleStandingAnimatorController()
		{
			Lopunnyidlestanding.LOParentMom_IdleStandingController();
		}
		private void LOParentMom_IdleSittingAnimatorController()
		{
			Lopunnyidlesitting.LOParentMom_IdleSittingController();
		}
	}
}