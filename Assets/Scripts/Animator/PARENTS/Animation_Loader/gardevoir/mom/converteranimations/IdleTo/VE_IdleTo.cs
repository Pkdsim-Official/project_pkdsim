using project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.IdleTo
{
	public class GARDParentMom_IdleTo : MonoBehaviour 
	{
		private GARDParentMom_IdleToRun GardevoirParentMomIdleToRun;
		private GARDParentMom_IdleToWalk GardevoirParentMomIdleToWalk;

		public void GARDParentMom_IdleToController()
		{
			Load_GARDParentMom_idleToRun();
			Load_GARDParentMom_idleToWalk();
		}
		private void Load_GARDParentMom_idleToRun()
		{
			GardevoirParentMomIdleToRun.GARDParentMom_IdleToRunController();
		}
		private void Load_GARDParentMom_idleToWalk()
		{
			GardevoirParentMomIdleToWalk.GARDParentMom_IdleToWalkController();
		}
	}
}