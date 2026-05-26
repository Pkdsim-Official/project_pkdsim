using project_pkdsim.ANIMATOR.NPC.Meowscarada.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Meowscarada.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Meowscarada.idlebaseanimation
{
	public class Meowscarada_IdleAnimatorController : MonoBehaviour 
	{
		private MEOWIdleStanding Meowscaradaidlestanding;
		
		private MEOW_IdleSitting Meowscaradaidlesitting;
		
		public void	MEOW_IdleAnimatorController()
		{
			MEOWIdleStandingAnimatorController();
			MEOW_IdleSittingAnimatorController();
		}
		private void MEOWIdleStandingAnimatorController()
		{
			Meowscaradaidlestanding.MEOWIdleStandingController();
		}
		private void MEOW_IdleSittingAnimatorController()
		{
			Meowscaradaidlesitting.MEOW_IdleSittingController();
		}
	}
}