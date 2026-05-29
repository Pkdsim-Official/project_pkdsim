using project_pkdsim.ANIMATOR.Parents.Meowscarada.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Meowscarada.Mom.idlebaseanimation
{
	public class Meowscarada_IdleAnimatorController : MonoBehaviour 
	{
		private MEOWIdleStanding Meowscaradaidlestanding;
		
		private MEOWIdleSitting Meowscaradaidlesitting;
		
		public void	MEOW_IdleAnimatorController()
		{
			MEOWIdleStandingAnimatorController();
			MEOWIdleSittingAnimatorController();
		}
		private void MEOWIdleStandingAnimatorController()
		{
			Meowscaradaidlestanding.MEOWIdleStandingController();
		}
		private void MEOWIdleSittingAnimatorController()
		{
			Meowscaradaidlesitting.MEOWIdleSittingController();
		}
	}
}