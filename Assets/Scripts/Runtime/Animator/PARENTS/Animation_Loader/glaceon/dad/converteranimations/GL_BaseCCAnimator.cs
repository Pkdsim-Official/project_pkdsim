using Project_Pkdsim.ANIMATOR.Parents.Glaceon.Dad.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Parents.Glaceon.Dad.converteranimations.WalkingTo;
using Project_Pkdsim.ANIMATOR.Parents.Glaceon.Dad.converteranimations.IdleTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Glaceon.Dad.converteranimations
{
	public class GlaceonParentDad_ConverterAnimatorController : MonoBehaviour
	{
		private GLParentDad_IdleTo GlaceonParentDadidleto;

		private GLParentDad_WalkingTo GlaceonParentDadwalkingto;

		private GLParentDad_SittingTo GlaceonParentDadsittingto;
		public void GLParentDad_ConverterAnimatorController()
		{
			GlaceonParentDadwalkingto.GLParentDad_WalkingToController();

			GlaceonParentDadidleto.GLParentDad_IdleToController();

			GlaceonParentDadsittingto.GLParentDad_SittingToController();
		}
	}
}