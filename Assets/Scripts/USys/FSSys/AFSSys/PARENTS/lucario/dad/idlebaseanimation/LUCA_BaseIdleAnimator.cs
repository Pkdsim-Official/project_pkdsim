using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.idlebaseanimation
{
	public class LucarioParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private LUCAParentDad_IdleStanding LucarioIdleStanding;
		
		private LUCAParentDad_IdleSitting LucarioIdleSitting;
		
		public void	LUCAParentDad_IdleAnimatorController()
		{
			LUCAParentDad_IdleStandingAnimatorController();
			LUCAParentDad_IdleSittingAnimatorController();
		}
		private void LUCAParentDad_IdleStandingAnimatorController()
		{
			LucarioIdleStanding.LUCAParentDad_IdleStandingController();
		}
		private void LUCAParentDad_IdleSittingAnimatorController()
		{
			LucarioIdleSitting.LUCAParentDad_IdleSittingController();
		}
	}
}