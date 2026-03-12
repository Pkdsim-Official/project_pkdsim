using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations
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