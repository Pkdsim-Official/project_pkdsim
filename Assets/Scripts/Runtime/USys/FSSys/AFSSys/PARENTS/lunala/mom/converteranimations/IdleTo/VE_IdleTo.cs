using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.IdleTo
{
	public class LUNAParentMom_IdleTo : MonoBehaviour 
	{
		private LUNAParentMom_IdleToRun LunalaParentMomIdleToRun;
		private LUNAParentMom_IdleToWalk LunalaParentMomIdleToWalk;

		public void LUNAParentMom_IdleToController()
		{
			Load_LUNAParentMom_idleToRun();
			Load_LUNAParentMom_idleToWalk();
		}
		private void Load_LUNAParentMom_idleToRun()
		{
			LunalaParentMomIdleToRun.LUNAParentMom_IdleToRunController();
		}
		private void Load_LUNAParentMom_idleToWalk()
		{
			LunalaParentMomIdleToWalk.LUNAParentMom_IdleToWalkController();
		}
	}
}