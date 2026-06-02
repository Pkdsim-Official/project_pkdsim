using project_pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations.IdleTo
{
	public class MEOW_IdleTo : MonoBehaviour 
	{
		private MEOW_IdleToRun MeowscaradaIdleToRun;
		private MEOW_IdleToWalk MeowscaradaIdleToWalk;

		public void MEOW_IdleToController()
		{
			Load_MEOW_IdleToRun();
			Load_MEOW_IdleToWalk();
		}
		private void Load_MEOW_IdleToRun()
		{
			MeowscaradaIdleToRun.MEOW_IdleToRunController();
		}
		private void Load_MEOW_IdleToWalk()
		{
			MeowscaradaIdleToWalk.MEOW_IdleToWalkController();
		}
	}
}