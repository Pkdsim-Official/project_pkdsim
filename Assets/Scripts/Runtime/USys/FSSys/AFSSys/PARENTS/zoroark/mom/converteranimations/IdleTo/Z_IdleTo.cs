using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.converteranimations.IdleTo
{
	public class ZParentMom_IdleTo : MonoBehaviour 
	{
		private ZParentMom_IdleToRun ZoroarkIdleToRun;
		private ZParentMom_IdleToWalk ZoroarkIdleToWalk;
		public void ZParentMom_IdleToController()
		{
			Load_ZParentMom_idleToRun();
			Load_ZParentMom_idleToWalk();
		}
		private void Load_ZParentMom_idleToRun()
		{
			ZoroarkIdleToRun.ZParentMom_IdleToRunController();
		}
		private void Load_ZParentMom_idleToWalk()
		{
			ZoroarkIdleToWalk.ZParentMom_IdleToWalkController();
		}
	}
}