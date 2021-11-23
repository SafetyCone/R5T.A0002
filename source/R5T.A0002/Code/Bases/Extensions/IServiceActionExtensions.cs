using System;

using R5T.Lombardy;

using R5T.D0063.Default;
using R5T.D0065.Standard;
using R5T.D0070.A001;
using R5T.T0062;


namespace R5T.A0002
{
    public static class IServiceActionExtensions
    {
        public static IServiceActionAggregation AddA0002ServiceActions(this IServiceAction _)
        {
            // Services.
            // Level 0.
            var environmentVariableProviderActions = Instances.ServiceAction.AddEnvironmentVariableProviderActions();
            var stringlyTypedPathOperatorActions = Instances.ServiceAction.AddStringlyTypedPathOperatorActions();

            // Level 1.
            var executableDirectoryPathProviderActions = Instances.ServiceAction.AddExecutableDirectoryPathProviderActions(
                stringlyTypedPathOperatorActions.StringlyTypedPathOperatorAction);

            // Level 2.
            var appSettingsFilePathProviderActions = Instances.ServiceAction.AddAppSettingsFilePathProviderActions(
                executableDirectoryPathProviderActions.ExecutableDirectoryPathProviderAction,
                stringlyTypedPathOperatorActions.FileNameOperatorAction,
                stringlyTypedPathOperatorActions.StringlyTypedPathOperatorAction);

            // Now allow derived host startups to configure services.
            var output = new ServiceActionAggregation()
                .FillFrom(appSettingsFilePathProviderActions)
                .FillFrom(environmentVariableProviderActions)
                .FillFrom(executableDirectoryPathProviderActions)
                .FillFrom(stringlyTypedPathOperatorActions)
                ;

            return output;
        }
    }
}
