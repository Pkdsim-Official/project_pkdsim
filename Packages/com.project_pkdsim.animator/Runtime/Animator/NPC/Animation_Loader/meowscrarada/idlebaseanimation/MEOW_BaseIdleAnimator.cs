using project_pkdsim.ANIMATOR.NPC.Meowscarada.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Meowscarada.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Meowscarada.idlebaseanimation
{
	public class Meowscarada_IdleAnimatorController : MonoBehaviour 
	{
		private MEOW_IdleStanding Meowscaradaidlestanding;
		
		private MEOW_IdleSitting Meowscaradaidlesitting;
		
		public void	MEOW_IdleAnimatorController()
		{
			MEOW_IdleStandingAnimatorController();
			MEOW_IdleSittingAnimatorController();
		}
		private void MEOW_IdleStandingAnimatorController()
		{
			Meowscaradaidlestanding.MEOW_IdleStandingController();
		}
		private void MEOW_IdleSittingAnimatorController()
		{
			Meowscaradaidlesitting.MEOW_IdleSittingController();
		}
	}
}