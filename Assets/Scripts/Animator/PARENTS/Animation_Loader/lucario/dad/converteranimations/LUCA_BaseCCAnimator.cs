using project_pkdsim.ANIMATOR.Parents.Lucario.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Lucario.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Lucario.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Dad.converteranimations
{
	public class LucarioParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private LUCAParentDad_SittingTo LucarioParentDadsittingto;
		
		private LUCAParentDad_WalkingTo LucarioParentDadwalkingto;
		
		private LUCAParentDad_IdleTo LucarioParentDadidleto;

		public void LUCAParentDad_ConverterAnimatorController()
		{
			LucarioParentDadwalkingto.LUCAParentDad_WalkingToController();

			LucarioParentDadidleto.LUCAParentDad_IdleToController();
			
			LucarioParentDadsittingto.LUCAParentDad_SittingToController();	
		}
	}
}