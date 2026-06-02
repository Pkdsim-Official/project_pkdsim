using project_pkdsim.ANIMATOR.NPC.Zoroark.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Zoroark.converteranimations._SittingTo;
using project_pkdsim.ANIMATOR.NPC.Zoroark.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Zoroark.converteranimations
{
	public class Zoroark_ConverterAnimatorController : MonoBehaviour 
	{
		private Z_SittingTo Zoroarksittingto;
		
		private Z_WalkingTo Zoroarkwalkingto;
		
		private Z_IdleTo Zoroarkidleto;

		public void Z_ConverterAnimatorController()
		{
			Zoroarkwalkingto.Z_WalkingToController();

			Zoroarkidleto.Z_IdleToController();
			
			Zoroarksittingto.Z_SittingToController();	
		}
	}
}