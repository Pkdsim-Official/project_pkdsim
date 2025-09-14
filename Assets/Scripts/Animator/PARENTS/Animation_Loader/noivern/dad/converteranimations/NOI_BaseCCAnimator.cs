using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations
{
	public class NoivernConverterAnimatorController : MonoBehaviour
	{
		private NOIParentDad_SittingTo NoivernParentDadsittingto;

		private NOIParentDad_WalkingTo NoivernParentDadwalkingto;

		private NOIParentDad_IdleTo NoivernParentDadidleto;

		public void NOIParentDad_ConverterAnimatorController()
		{
			NoivernParentDadwalkingto.NOIParentDad_WalkingToController();

			NoivernParentDadidleto.NOIParentDad_IdleToController();

			NoivernParentDadsittingto.NOIParentDad_SittingToController();
		}
	}
}