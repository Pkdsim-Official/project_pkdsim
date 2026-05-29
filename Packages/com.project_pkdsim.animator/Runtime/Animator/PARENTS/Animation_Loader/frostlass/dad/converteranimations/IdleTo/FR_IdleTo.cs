using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.Dadconverteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.Dadconverteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.Dadconverteranimations.IdleTo
{
	public class FR_IdleTo : MonoBehaviour 
	{
		private FR_IdleToRun FrostlassIdleToRun;
		private FR_IdleToWalk FrostlassIdleToWalk;
		public void FR_IdleToController()
		{
			Load_FR_IdleToRun();
			Load_FR_IdleToWalk();
		}
		private void Load_FR_IdleToRun()
		{
			FrostlassIdleToRun.FR_IdleToRunController();
		}
		private void Load_FR_IdleToWalk()
		{
			FrostlassIdleToWalk.FR_IdleToWalkController();
		}
	}
}