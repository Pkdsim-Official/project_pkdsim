using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations
{
	public class Tsareena_ConverterToAnimatorController : MonoBehaviour 
	{
		private TSittingTo Tsareenasittingto;
		
		private TWalkingTo Tsareenawalkingto;
		
		private TIdleTo Tsareenaidleto;

		public void T_ConverterToAnimatorController()
		{
			Tsareenawalkingto.TWalkingToController();

			Tsareenaidleto.T_IdleToController();
			
			Tsareenasittingto.TSittingToController();	
		}
	}
}