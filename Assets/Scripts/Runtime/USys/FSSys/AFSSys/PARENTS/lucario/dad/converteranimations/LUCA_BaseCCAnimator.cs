using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations
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