using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations
{
	public class LunalaParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private LUNAParentMom_SittingTo LunalaParentMomSittingto;
		
		private LUNAParentMom_WalkingTo LunalaParentMomWalkingto;
		
		private LUNAParentMom_IdleTo LunalaParentMomIdleto;

		public void LUNAParentMom_ConverterAnimatorController()
		{
			LunalaParentMomWalkingto.LUNAParentMom_WalkingToController();

			LunalaParentMomIdleto.LUNAParentMom_IdleToController();
			
			LunalaParentMomSittingto.LUNAParentMom_SittingToController();	
		}
	}
}