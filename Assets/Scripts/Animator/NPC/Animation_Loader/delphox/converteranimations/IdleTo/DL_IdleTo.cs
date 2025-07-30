using project_pkdsim.ANIMATOR.Npcs.Delphox.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Npcs.Delphox.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Delphox.converteranimations.IdleTo
{
	public class DL_IdleTo : MonoBehaviour 
	{
		private DL_IdleToRun Delphox_IdleToRun;
		private DL_IdleToWalk Delphox_IdleToWalk;
		public void DL_IdleToController()
		{
			Load_DL_IdleToRun();
			Load_DL_IdleToWalk();
		}
		private void Load_DL_IdleToRun()
		{
			Delphox_IdleToRun.DL_IdleToRunController();
		}
		private void Load_DL_IdleToWalk()
		{
			Delphox_IdleToWalk.DL_IdleToWalkController();
		}
	}
}