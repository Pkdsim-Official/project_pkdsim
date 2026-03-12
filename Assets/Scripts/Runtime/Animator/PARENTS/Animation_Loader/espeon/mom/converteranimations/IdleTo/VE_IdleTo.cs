using Project_Pkdsim.ANIMATOR.Parents.Espeon.Mom.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Parents.Espeon.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Espeon.Mom.converteranimations.IdleTo
{
	public class ESParentMom_IdleTo : MonoBehaviour 
	{
		private ESParentMom_IdleToRun EspeonParentMomIdleToRun;
		private ESParentMom_IdleToWalk EspeonParentMomIdleToWalk;

		public void ESParentMom_IdleToController()
		{
			Load_ESParentMom_idleToRun();
			Load_ESParentMom_idleToWalk();
		}
		private void Load_ESParentMom_idleToRun()
		{
			EspeonParentMomIdleToRun.ESParentMom_IdleToRunController();
		}
		private void Load_ESParentMom_idleToWalk()
		{
			EspeonParentMomIdleToWalk.ESParentMom_IdleToWalkController();
		}
	}
}