using System;

using R5T.T0123;

using Instances = R5T.T0123.X001.Instances;


namespace System
{
    public static class IRepositoryPathOperatorExtensions
    {
        public static string GetRepositoryDirectoryPath(this IRepositoryPathOperator _,
            string repositoriesDirectoryPath,
            string repositoryName)
        {
            var repositoryDirectoryName = Instances.RepositoryNameOperator.GetRepositoryDirectoryName(repositoryName);

            var repositoryDirectoryPath = Instances.PathOperator.GetDirectoryPath(repositoriesDirectoryPath, repositoryDirectoryName);
            return repositoryDirectoryPath;
        }
    }
}