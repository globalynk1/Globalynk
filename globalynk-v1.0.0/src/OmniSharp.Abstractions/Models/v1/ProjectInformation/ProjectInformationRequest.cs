using OmniSharp.Mef;

﻿namespace OmniSharp.Models.ProjectInformation
{
    [OmniSharpEndpoint(OmniSharpEndpoints.ProjectInformation, typeof(ProjectInformationRequest), typeof(ProjectInformationResponse))]
    public class ProjectInformationRequest : Request { }
}
