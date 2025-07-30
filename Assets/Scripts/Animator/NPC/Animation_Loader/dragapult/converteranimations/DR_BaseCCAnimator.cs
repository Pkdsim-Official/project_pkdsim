using project_pkdsim.ANIMATOR.Npcs.Dragapult.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Npcs.Dragapult.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Npcs.Dragapult.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Dragapult.converteranimations
{
	public class DragapultCoverterAnimatorController : MonoBehaviour 
	{
		private DR_SittingTo DragapultSittingto;
		
		private DR_WalkingTo DragapultWalkingto;
		
		private DR_IdleTo DragapultIdleto;

		public void DRCoverterToAnimatorController()
		{
			DragapultWalkingto.DR_WalkingToController();

			DragapultIdleto.DR_IdleToController();
			
			DragapultSittingto.DR_SittingToController();	
		}
	}
}