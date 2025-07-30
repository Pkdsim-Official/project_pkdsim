using project_pkdsim.ANIMATOR.Parents.Delphox.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Delphox.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Delphox.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Delphox.Dad.converteranimations
{
	public class DragapultConverterAnimatorController : MonoBehaviour 
	{
		private DRSittingTo DragapultSittingto;
		
		private DRWalkingTo DragapultWalkingto;
		
		private DRIdleTo DragapultIdleto;

		public void DRConverterAnimatorController()
		{
			DragapultWalkingto.DRWalkingToController();

			DragapultIdleto.DR_IdleToController();
			
			DragapultSittingto.DRSittingToController();	
		}
	}
}