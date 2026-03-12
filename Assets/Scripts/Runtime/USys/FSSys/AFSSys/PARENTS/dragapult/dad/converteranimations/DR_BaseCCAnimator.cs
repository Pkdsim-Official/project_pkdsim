using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Dad.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Dad.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Dad.converteranimations
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