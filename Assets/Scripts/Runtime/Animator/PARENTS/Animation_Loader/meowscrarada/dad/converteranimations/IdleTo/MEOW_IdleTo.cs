using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations.IdleTo
{
	public class MEOWIdleTo : MonoBehaviour 
	{
		private MEOWIdleToRun MeowscaradaIdleToRun;
		private MEOWIdleToWalk MeowscaradaIdleToWalk;

		public void MEOW_IdleToController()
		{
			Load_MEOWIdleToRun();
			Load_MEOWIdleToWalk();
		}
		private void Load_MEOWIdleToRun()
		{
			MeowscaradaIdleToRun.MEOWIdleToRunController();
		}
		private void Load_MEOWIdleToWalk()
		{
			MeowscaradaIdleToWalk.MEOWIdleToWalkController();
		}
	}
}