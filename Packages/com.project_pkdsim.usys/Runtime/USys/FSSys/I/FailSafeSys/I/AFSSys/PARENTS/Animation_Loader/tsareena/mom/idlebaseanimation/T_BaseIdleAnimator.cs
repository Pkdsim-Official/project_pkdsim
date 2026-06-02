using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.idlebaseanimation
{
	public class TsareenaParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private T_IdleStanding Tidlestanding;
		
		private T_IdleSitting Tidlesitting;
		
		public void	T_IdleAnimatorController()
		{
			T_IdleStandingAnimatorController();
			T_IdleSittingAnimatorController();
		}
		private void T_IdleStandingAnimatorController()
		{
			Tidlestanding.T_IdleStandingController();
		}
		private void T_IdleSittingAnimatorController()
		{
			Tidlesitting.T_IdleSittingController();
		}
	}
}