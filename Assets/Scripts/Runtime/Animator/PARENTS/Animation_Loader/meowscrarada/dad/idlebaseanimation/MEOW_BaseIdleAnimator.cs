using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Meowscarada.idlebaseanimation
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