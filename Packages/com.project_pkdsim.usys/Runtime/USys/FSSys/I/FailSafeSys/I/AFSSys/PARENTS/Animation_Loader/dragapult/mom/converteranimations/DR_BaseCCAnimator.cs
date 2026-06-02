using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations
{
	public class DragapultParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private DRParentMom_SittingTo DragapultSittingto;
		
		private DRParentMom_WalkingTo DragapultWalkingto;
		
		private DRParentMom_IdleTo DragapultIdleto;

		public void DRParentMom_ConverterAnimatorController()
		{
			DragapultWalkingto.DRParentMom_WalkingToController();

			DragapultIdleto.DRParentMom_IdleToController();
			
			DragapultSittingto.DRParentMom_SittingToController();	
		}
	}
}