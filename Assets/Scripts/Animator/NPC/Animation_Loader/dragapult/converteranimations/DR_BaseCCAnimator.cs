using project_pkdsim.Models.ANIMATOR.NPC.Dragapult.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Dragapult.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Dragapult.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Dragapult.converteranimations
{
	public class DragapultCoverterAnimatorController : MonoBehaviour 
	{
		private DRSittingTo DragapultSittingto;
		
		private DRWalkingTo DragapultWalkingto;
		
		private DRIdleTo DragapultIdleto;

		public void DRCoverterToAnimatorController()
		{
			DragapultWalkingto.DRWalkingToController();

			DragapultIdleto.DR_IdleToController();
			
			DragapultSittingto.DRSittingToController();	
		}
	}
}