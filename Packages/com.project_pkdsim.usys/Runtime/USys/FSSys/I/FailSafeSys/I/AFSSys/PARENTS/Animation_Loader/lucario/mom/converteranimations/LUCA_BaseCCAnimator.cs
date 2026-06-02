using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations
{
	public class Lucario_ConverterAnimatorController : MonoBehaviour 
	{
		private LUCAParentMom_SittingTo Lucariosittingto;
		
		private LUCAParentMom_WalkingTo Lucariowalkingto;
		
		private LUCAParentMom_IdleTo Lucarioidleto;

		public void LUCAParentMom_ConverterAnimatorController()
		{
			Lucariowalkingto.LUCAParentMom_WalkingToController();

			Lucarioidleto.LUCAParentMom_IdleToController();
			
			Lucariosittingto.LUCAParentMom_SittingToController();	
		}
	}
}