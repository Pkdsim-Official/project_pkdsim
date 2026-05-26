namespace project_pkdsim.Generics.Parents.Type.Species
{
    public enum ParentsSpeciesType
    {
        #region beedrill
        Vespiquen,
        Scizor,
        #endregion

        #region Garchomp
        Gabite,
        Salamence,
        #endregion

        #region Absol
        Zoroark, 
        Umbreon,
        #endregion

        #region Lucario
        Blaziken, 
        Machamp,
        #endregion

        #region Gardevior
        Kirlia,
        Gallade,
        #endregion

        #region Lopunny
        Gothitelle,
        Lucario,
        #endregion

        #region Sylveon
        #endregion

        #region Umbreon
        #endregion

        #region Espeon
        #endregion
        
        #region Vaporeon
        #endregion

        #region Flareon
        #endregion

        #region Jolteon
        #endregion

        #region Leafeon
        #endregion

        #region Glaceon
        #endregion

        #region Zoroark
        #endregion
        
        #region Noivern
        #endregion
        
        #region Hatterene
        #endregion

        #region Dragapult
        #endregion

        #region Cinderace
        #endregion

        #region Delphox
        #endregion

        #region Braixen
        #endregion

        #region Frostlass
        #endregion

        #region Vespiquen
        #endregion

    }

    public interface IParentSpecies
    {
        ParentsSpeciesType ParentsSpecies { get; }
    }
}