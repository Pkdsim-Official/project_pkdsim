using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.converteranimations
{
	public class LopunnyParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private LOParentDad_SittingTo LopunnyParentDadsittingto;

		private LOParentDad_WalkingTo LopunnyParentDadwalkingto;
		
		private LOParentDad_IdleTo LopunnyParentDadidleto;

		public void LOParentDad_ConverterAnimatorController()
		{
			LopunnyParentDadwalkingto.LOParentDad_WalkingToController();

			LopunnyParentDadidleto.LOParentDad_IdleToController();
			
			LopunnyParentDadsittingto.LOParentDad_SittingToController();	
		}
	}
}