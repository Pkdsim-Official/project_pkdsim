using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.IdleTo
{
	public class LUCAParentMom_IdleTo : MonoBehaviour 
	{
		private LUCAParentMom_IdleToRun LucarioParentMomIdleToRun;
		private LUCAParentMom_IdleToWalk LucarioParentMomIdleToWalk;

		public void LUCAParentMom_IdleToController()
		{
			Load_LUCAParentMom_idleToRun();
			Load_LUCAParentMom_idleToWalk();
		}
		private void Load_LUCAParentMom_idleToRun()
		{
			LucarioParentMomIdleToRun.LUCAParentMom_IdleToRunController();
		}
		private void Load_LUCAParentMom_idleToWalk()
		{
			LucarioParentMomIdleToWalk.LUCAParentMom_IdleToWalkController();
		}
	}
}