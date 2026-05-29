using project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.converteranimations
{
	public class DelphoxParentMom_ConverterToAnimatorController : MonoBehaviour 
	{
		private DRSittingTo DragapultSittingto;
		
		private DRWalkingTo DragapultWalkingto;
		
		private DRIdleTo DragapultIdleto;

		public void DR_ConverterToAnimatorController()
		{
			DragapultWalkingto.DRWalkingToController();

			DragapultIdleto.DR_IdleToController();
			
			DragapultSittingto.DRSittingToController();	
		}
	}
}