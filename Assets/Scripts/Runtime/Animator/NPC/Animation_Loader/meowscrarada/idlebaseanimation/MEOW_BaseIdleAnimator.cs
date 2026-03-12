using Project_Pkdsim.ANIMATOR.Npcs.Meowscarada.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Meowscarada.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Meowscarada.idlebaseanimation
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