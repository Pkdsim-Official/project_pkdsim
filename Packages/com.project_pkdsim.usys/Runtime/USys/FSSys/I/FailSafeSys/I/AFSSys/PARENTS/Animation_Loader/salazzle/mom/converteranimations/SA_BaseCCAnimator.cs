using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations
{
	public class SalazzleParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private SA_SittingTo SalazzleParentMom_sittingto;
		
		private SA_WalkingTo SalazzleParentMom_walkingto;
		
		private SA_IdleTo SalazzleParentMom_idleto;

		public void SA_ConverterAnimatorController()
		{
			SalazzleParentMom_walkingto.SA_WalkingToController();

			SalazzleParentMom_idleto.SA_IdleToController();
			
			SalazzleParentMom_sittingto.SA_SittingToController();	
		}
	}
}