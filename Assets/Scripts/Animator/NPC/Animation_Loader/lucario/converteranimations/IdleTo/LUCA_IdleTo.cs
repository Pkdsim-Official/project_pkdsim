using project_pkdsim.ANIMATOR.NPC.Lucario.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.NPC.Lucario.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Lucario.converteranimations.IdleTo
{
	public class LUCA_IdleTo : MonoBehaviour 
	{
		private LUCA_IdleToRun Lucario_IdleToRun;
		private LUCA_IdleToWalk Lucario_IdleToWalk;

		public void LUCA_IdleToController()
		{
			Load_LUCAidleToRun();
			Load_LUCAidleToWalk();
		}
		private void Load_LUCAidleToRun()
		{
			Lucario_IdleToRun.LUCA_IdleToRunController();
		}
		private void Load_LUCAidleToWalk()
		{
			Lucario_IdleToWalk.LUCA_IdleToWalkController();
		}
	}
}