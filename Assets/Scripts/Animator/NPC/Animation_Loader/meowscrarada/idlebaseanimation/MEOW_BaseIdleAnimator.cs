using project_pkdsim.ANIMATOR.NPC.Meowscarada.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Meowscarada.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Meowscarada.idlebaseanimation
{
	public class MeowscaradaIdleAnimatorController : MonoBehaviour 
	{
		private MEOWIdleStanding Meowscaradaidlestanding;
		
		private MEOWIdleSitting Meowscaradaidlesitting;
		
		public void	MEOWIdleAnimatorController()
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