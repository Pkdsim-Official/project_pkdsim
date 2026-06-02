using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations
{
	public class TsareenaParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private TParentMom_SittingTo TsareenaParentMom_sittingto;
		
		private TParentMom_WalkingTo TsareenaParentMom_walkingto;
		
		private TParentMom_IdleTo TsareenaParentMom_idleto;

		public void T_ConverterAnimatorController()
		{
			TsareenaParentMom_walkingto.TParentMom_WalkingToController();

			TsareenaParentMom_idleto.TParentMom_IdleToController();
			
			TsareenaParentMom_sittingto.TParentMom_SittingToController();	
		}
	}
}