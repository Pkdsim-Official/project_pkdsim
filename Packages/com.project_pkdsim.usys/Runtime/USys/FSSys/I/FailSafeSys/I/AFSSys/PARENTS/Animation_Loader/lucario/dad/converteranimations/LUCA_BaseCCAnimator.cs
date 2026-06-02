using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations
{
	public class LucarioParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private LUCAParentDad_SittingTo Lucariosittingto;
		
		private LUCAParentDad_WalkingTo Lucariowalkingto;
		
		private LUCAParentDad_IdleTo Lucarioidleto;

		public void LUCAParentDad_ConverterAnimatorController()
		{
			Lucariowalkingto.LUCAParentDad_WalkingToController();

			Lucarioidleto.LUCAParentDad_IdleToController();
			
			Lucariosittingto.LUCAParentDad_SittingToController();	
		}
	}
}