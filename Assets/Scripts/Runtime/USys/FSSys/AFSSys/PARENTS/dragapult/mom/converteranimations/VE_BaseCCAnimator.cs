using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations
{
	public class DragapultParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private DRParentMom_SittingTo DragapultParentMomSittingto;
		
		private DRParentMom_WalkingTo DragapultParentMomWalkingto;
		
		private DRParentMom_IdleTo DragapultParentMomIdleto;

		public void DRParentMom_ConverterAnimatorController()
		{
			DragapultParentMomWalkingto.DRParentMom_WalkingToController();

			DragapultParentMomIdleto.DRParentMom_IdleToController();
			
			DragapultParentMomSittingto.DRParentMom_SittingToController();	
		}
	}
}