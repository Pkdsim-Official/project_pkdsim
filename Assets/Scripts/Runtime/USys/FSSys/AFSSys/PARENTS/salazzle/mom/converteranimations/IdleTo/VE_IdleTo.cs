using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.IdleTo
{
	public class SParentMom_IdleTo : MonoBehaviour 
	{
		private SParentMom_IdleToRun SalazzleParentMomIdleToRun;
		private SParentMom_IdleToWalk SalazzleParentMomIdleToWalk;

		public void SParentMom_IdleToController()
		{
			Load_SParentMom_idleToRun();
			Load_SParentMom_idleToWalk();
		}
		private void Load_SParentMom_idleToRun()
		{
			SalazzleParentMomIdleToRun.SParentMom_IdleToRunController();
		}
		private void Load_SParentMom_idleToWalk()
		{
			SalazzleParentMomIdleToWalk.SParentMom_IdleToWalkController();
		}
	}
}