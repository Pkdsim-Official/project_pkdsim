using project_pkdsim.ANIMATOR.Npcs.Meowscarada.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Npcs.Meowscarada.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Meowscarada.converteranimations.IdleTo
{
	public class MEOW_IdleTo : MonoBehaviour 
	{
		private MEOW_IdleToRun Meowscarada_IdleToRun;
		private MEOW_IdleToWalk Meowscarada_IdleToWalk;

		public void MEOW_IdleToController()
		{
			Load_MEOW_IdleToRun();
			Load_MEOW_IdleToWalk();
		}
		private void Load_MEOW_IdleToRun()
		{
			Meowscarada_IdleToRun.MEOW_IdleToRunController();
		}
		private void Load_MEOW_IdleToWalk()
		{
			Meowscarada_IdleToWalk.MEOW_IdleToWalkController();
		}
	}
}