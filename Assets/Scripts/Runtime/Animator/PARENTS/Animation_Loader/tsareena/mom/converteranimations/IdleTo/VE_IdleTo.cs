using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.IdleTo
{
	public class TParentMom_IdleTo : MonoBehaviour 
	{
		private TParentMom_IdleToRun TsareenaParentMomIdleToRun;
		private TParentMom_IdleToWalk TsareenaParentMomIdleToWalk;

		public void TParentMom_IdleToController()
		{
			Load_TParentMom_idleToRun();
			Load_TParentMom_idleToWalk();
		}
		private void Load_TParentMom_idleToRun()
		{
			TsareenaParentMomIdleToRun.TParentMom_IdleToRunController();
		}
		private void Load_TParentMom_idleToWalk()
		{
			TsareenaParentMomIdleToWalk.TParentMom_IdleToWalkController();
		}
	}
}