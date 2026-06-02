using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.converteranimations
{
	public class DragapultParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private DRParentDad_SittingTo DragapultSittingto;
		
		private DRParentDad_WalkingTo DragapultWalkingto;
		
		private DRParentDad_IdleTo DragapultIdleto;

		public void DRParentDad_ConverterAnimatorController()
		{
			DragapultWalkingto.DRParentDad_WalkingToController();

			DragapultIdleto.DRParentDad_IdleToController();
			
			DragapultSittingto.DRParentDad_SittingToController();	
		}
	}
}