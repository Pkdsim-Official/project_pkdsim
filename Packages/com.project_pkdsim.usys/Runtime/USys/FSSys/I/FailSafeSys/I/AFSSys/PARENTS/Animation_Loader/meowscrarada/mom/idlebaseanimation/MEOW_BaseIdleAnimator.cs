using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.idlebaseanimation
{
	public class MeowscaradaParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private MEOWParentMom_IdleStanding Meowscaradaidlestanding;
		
		private MEOWParentMom_IdleSitting Meowscaradaidlesitting;
		
		public void	MEOWParentMom_IdleAnimatorController()
		{
			MEOWParentMom_IdleStandingAnimatorController();
			MEOWParentMom_IdleSittingAnimatorController();
		}
		private void MEOWParentMom_IdleStandingAnimatorController()
		{
			Meowscaradaidlestanding.MEOWParentMom_IdleStandingController();
		}
		private void MEOWParentMom_IdleSittingAnimatorController()
		{
			Meowscaradaidlesitting.MEOWParentMom_IdleSittingController();
		}
	}
}