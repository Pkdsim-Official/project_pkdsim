using project_pkdsim.Models.ANIMATOR.NPC.Gardevoir.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Models.ANIMATOR.NPC.Gardevoir.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Gardevoir.converteranimations.IdleTo
{
	public class GARDIdleTo : MonoBehaviour 
	{
		private GARDIdleToWalk GardevoirIdleToWalk;
		private GARDIdleToRun GardevoirIdleToRun;
		public void GARDIdleToController()
		{
			Load_GARDidleToRun();
			Load_GARDidleToWalk();
		}
		private void Load_GARDidleToRun()
		{
			GardevoirIdleToRun.GARDIdleToRunController();
		}
		private void Load_GARDidleToWalk()
		{
			GardevoirIdleToWalk.GARDIdleToWalkController();
		}
	}
}