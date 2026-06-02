using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.idlebaseanimation
{
	public class MeowscaradaParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private MEOWParentDad_IdleStanding Meowscaradaidlestanding;
		
		private MEOWParentDad_IdleSitting Meowscaradaidlesitting;
		
		public void	MEOWParentDad_IdleAnimatorController()
		{
			MEOWParentDad_IdleStandingAnimatorController();
			MEOWParentDad_IdleSittingAnimatorController();
		}
		private void MEOWParentDad_IdleStandingAnimatorController()
		{
			Meowscaradaidlestanding.MEOWParentDad_IdleStandingController();
		}
		private void MEOWParentDad_IdleSittingAnimatorController()
		{
			Meowscaradaidlesitting.MEOWParentDad_IdleSittingController();
		}
	}
}