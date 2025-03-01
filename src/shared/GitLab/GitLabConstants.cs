using System;
using System.Collections.Generic;
using System.Linq;

namespace GitLab
{
    public static class GitLabConstants
    {
        // owned by https://gitlab.com/gitcredentialmanager
        public const string OAuthClientId = "172b9f227872b5dde33f4d9b1db06a6a5515ae79508e7a00c973c85ce490671e";
        public const string OAuthClientSecret = "7da92770d1447508601e4ba026bc5eb655c8268e818cd609889cc9bae2023f39";

        public static readonly Uri OAuthRedirectUri = new Uri("http://127.0.0.1/");
        // https://docs.gitlab.com/ee/api/oauth2.html#authorization-code-flow
        public static readonly Uri OAuthAuthorizationEndpointRelativeUri = new Uri("/oauth/authorize", UriKind.Relative);
        public static readonly Uri OAuthTokenEndpointRelativeUri = new Uri("/oauth/token", UriKind.Relative);

        public const AuthenticationModes DotComAuthenticationModes = AuthenticationModes.Browser | AuthenticationModes.Pat;

        public static class EnvironmentVariables
        {
            public const string DevOAuthClientId = "GCM_DEV_GITLAB_CLIENTID";
            public const string DevOAuthClientSecret = "GCM_DEV_GITLAB_CLIENTSECRET";
            public const string DevOAuthRedirectUri = "GCM_DEV_GITLAB_REDIRECTURI";
            public const string AuthenticationModes = "GCM_GITLAB_AUTHMODES";

        }

        public static class GitConfiguration
        {
            public static class Credential
            {
                public const string AuthenticationModes = "gitLabAuthModes";
                public const string DevOAuthClientId = "gitLabDevClientId";
                public const string DevOAuthClientSecret = "gitLabDevClientSecret";
                public const string DevOAuthRedirectUri = "gitLabDevRedirectUri";
            }
        }

        public static bool IsGitLabDotCom(Uri uri) => StringComparer.OrdinalIgnoreCase.Equals(uri.Host, "gitlab.com");
    }
}
