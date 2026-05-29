using project_pkdsim.ANIMATOR.Parents.Dragapult.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Dragapult.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Dragapult.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Dragapult.converteranimations
{
	public class Dragapult_ConverterToAnimatorController : MonoBehaviour 
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