using project_pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations
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