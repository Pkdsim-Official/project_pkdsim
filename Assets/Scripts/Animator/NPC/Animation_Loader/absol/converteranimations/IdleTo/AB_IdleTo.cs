using project_pkdsim.Models.ANIMATOR.NPC.Absol.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Models.ANIMATOR.NPC.Absol.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Absol.converteranimations.IdleTo
{
	public class ABIdleTo : MonoBehaviour 
	{

		private ABIdleToRun AbsolIdleToRun;
		private ABIdleToWalk AbsolIdleToWalk;
		public void ABIdleToController()
		{
			Load_ABidleToRun();
			Load_ABidleToWalk();
		}
		private void Load_ABidleToRun()
		{
			AbsolIdleToRun.ABIdleToRunController();
		}
		private void Load_ABidleToWalk()
		{
			AbsolIdleToWalk.ABIdleToWalkController();
		}
	}
}