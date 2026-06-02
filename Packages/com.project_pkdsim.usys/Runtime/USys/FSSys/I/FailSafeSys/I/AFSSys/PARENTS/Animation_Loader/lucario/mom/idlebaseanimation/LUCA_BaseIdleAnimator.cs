using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.idlebaseanimation
{
	public class Lucario_IdleAnimatorController : MonoBehaviour 
	{
		private LUCAParentMom_IdleStanding LucarioIdleStanding;
		
		private LUCAParentMom_IdleSitting LucarioIdleSitting;
		
		public void	LUCAParentMom_IdleAnimatorController()
		{
			LUCAParentMom_IdleStandingAnimatorController();
			LUCAParentMom_IdleSittingAnimatorController();
		}
		private void LUCAParentMom_IdleStandingAnimatorController()
		{
			LucarioIdleStanding.LUCAParentMom_IdleStandingController();
		}
		private void LUCAParentMom_IdleSittingAnimatorController()
		{
			LucarioIdleSitting.LUCAParentMom_IdleSittingController();
		}
	}
}