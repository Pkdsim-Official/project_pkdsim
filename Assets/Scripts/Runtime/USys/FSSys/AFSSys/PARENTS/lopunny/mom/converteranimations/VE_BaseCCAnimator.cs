using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations
{
	public class LopunnyParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private LOParentMom_SittingTo LopunnyParentMomSittingto;
		
		private LOParentMom_WalkingTo LopunnyParentMomWalkingto;
		
		private LOParentMom_IdleTo LopunnyParentMomIdleto;

		public void LOParentMom_ConverterAnimatorController()
		{
			LopunnyParentMomWalkingto.LOParentMom_WalkingToController();

			LopunnyParentMomIdleto.LOParentMom_IdleToController();
			
			LopunnyParentMomSittingto.LOParentMom_SittingToController();	
		}
	}
}