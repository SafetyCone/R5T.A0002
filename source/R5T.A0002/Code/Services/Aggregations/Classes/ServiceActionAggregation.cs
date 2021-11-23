using System;

using R5T.Lombardy;

using R5T.D0063;
using R5T.D0065;
using R5T.D0070;
using R5T.T0063;

using ExecutingAssembly = R5T.D0071.ExecutingAssembly;


namespace R5T.A0002
{
    public class ServiceActionAggregation : IServiceActionAggregation
    {
        public IServiceAction<IAppSettingsFilePathProvider> AppSettingsFilePathProvider { get; set; }
        public IServiceAction<IAppSettingsDirectoryPathProvider> AppSettingsDirectoryPathProviderAction { get; set; }
        public IServiceAction<IAppSettingsFileNameProvider> AppSettingsFileNameProviderAction { get; set; }
        public IServiceAction<IEnvironmentVariableProvider> EnvironmentVariableProviderAction { get; set; }
        public IServiceAction<IEnvironmentVariablesProvider> EnvironmentVariablesProviderAction { get; set; }
        public IServiceAction<IExecutableDirectoryPathProvider> ExecutableDirectoryPathProviderAction { get; set; }
        public IServiceAction<IExecutableFilePathProvider> ExecutableFilePathProviderAction { get; set; }
        public IServiceAction<ExecutingAssembly.IFilePathProvider> ExecutingAssemblyFilePathProviderAction { get; set; }
        public IServiceAction<IDirectoryNameOperator> DirectoryNameOperatorAction { get; set; }
        public IServiceAction<IDirectorySeparatorOperator> DirectorySeparatorOperatorAction { get; set; }
        public IServiceAction<IFileExtensionOperator> FileExtensionOperatorAction { get; set; }
        public IServiceAction<IFileNameOperator> FileNameOperatorAction { get; set; }
        public IServiceAction<IStringlyTypedPathOperator> StringlyTypedPathOperatorAction { get; set; }
    }
}
