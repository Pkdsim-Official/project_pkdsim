using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.converteranimations.IdleTo
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