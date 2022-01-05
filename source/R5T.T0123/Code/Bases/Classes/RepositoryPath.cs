using System;


namespace R5T.T0123
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class RepositoryPath : IRepositoryPath
    {
        #region Static
        
        public static RepositoryPath Instance { get; } = new();

        #endregion
    }
}