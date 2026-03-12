using Project_Pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.IdleTo
{
	public class DLParentMom_IdleTo : MonoBehaviour 
	{
		private DLParentMom_IdleToRun DelphoxParentMomIdleToRun;
		private DLParentMom_IdleToWalk DelphoxParentMomIdleToWalk;

		public void DLParentMom_IdleToController()
		{
			Load_DLParentMom_idleToRun();
			Load_DLParentMom_idleToWalk();
		}
		private void Load_DLParentMom_idleToRun()
		{
			DelphoxParentMomIdleToRun.DLParentMom_IdleToRunController();
		}
		private void Load_DLParentMom_idleToWalk()
		{
			DelphoxParentMomIdleToWalk.DLParentMom_IdleToWalkController();
		}
	}
}