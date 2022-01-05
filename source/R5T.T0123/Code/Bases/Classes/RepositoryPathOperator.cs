using System;


namespace R5T.T0123
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class RepositoryPathOperator : IRepositoryPathOperator
    {
        #region Static
        
        public static RepositoryPathOperator Instance { get; } = new();

        #endregion
    }
}