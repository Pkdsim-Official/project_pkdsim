using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations
{
	public class VaporeonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VPParentMom_SittingTo VaporeonParentMomSittingto;
		
		private VPParentMom_WalkingTo VaporeonParentMomWalkingto;
		
		private VPParentMom_IdleTo VaporeonParentMomIdleto;

		public void VPParentMom_ConverterAnimatorController()
		{
			VaporeonParentMomWalkingto.VPParentMom_WalkingToController();

			VaporeonParentMomIdleto.VPParentMom_IdleToController();
			
			VaporeonParentMomSittingto.VPParentMom_SittingToController();	
		}
	}
}