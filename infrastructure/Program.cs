using Pulumi;
using Pulumi.AzureNative.Resources;
using Pulumi.AzureNative.Web;
using Pulumi.AzureNative.Web.Inputs;

await Pulumi.Deployment.RunAsync(() =>
{
    var resume_website_resource_group = new ResourceGroup("resume-website-resource-group", new ResourceGroupArgs
    {
        Location = "westus",
        ResourceGroupName = "resume-website-resource-group",
    }, new CustomResourceOptions
    {
        Protect = true,
    });

    var resume_website_app_service_plan = new AppServicePlan("resume-website-app-service-plan", new AppServicePlanArgs
    {
        HyperV = false,
        IsSpot = false,
        IsXenon = false,
        Kind = "app",
        Location = "West US 3",
        MaximumElasticWorkerCount = 1,
        Name = "resume-website-app-service-plan",
        PerSiteScaling = false,
        Reserved = false,
        ResourceGroupName = "resume-website-resource-group",
        Sku = new SkuDescriptionArgs
        {
            Capacity = 0,
            Family = "F",
            Name = "F1",
            Size = "F1",
            Tier = "Free",
        },
        TargetWorkerCount = 0,
        TargetWorkerSizeId = 0,
    }, new CustomResourceOptions
    {
        Protect = true,
    });

    var resume_website_app_service = new WebApp("resume-website-app-service", new WebAppArgs
    {
        ClientAffinityEnabled = true,
        ClientCertEnabled = false,
        ClientCertMode = ClientCertMode.Required,
        ContainerSize = 0,
        CustomDomainVerificationId = "28E203BF2AB351C51DB8D760E5BB82ADF35299C32C77553F2C666A2D7373B33A",
        DailyMemoryTimeQuota = 0,
        Enabled = true,
        HostNameSslStates =
            {
                new HostNameSslStateArgs
                {
                    HostType = HostType.Standard,
                    Name = "sonny-huynh.azurewebsites.net",
                    SslState = SslState.Disabled,
                },
                new HostNameSslStateArgs
                {
                    HostType = HostType.Repository,
                    Name = "sonny-huynh.scm.azurewebsites.net",
                    SslState = SslState.Disabled,
                },
            },
        HostNamesDisabled = false,
        HttpsOnly = false,
        HyperV = false,
        IsXenon = false,
        KeyVaultReferenceIdentity = "SystemAssigned",
        Kind = "app",
        Location = "West US 3",
        Name = "sonny-huynh",
        RedundancyMode = RedundancyMode.None,
        Reserved = false,
        ResourceGroupName = "resume-website-resource-group",
        ScmSiteAlsoStopped = false,
        ServerFarmId = "/subscriptions/094ddcf8-f6e7-418a-ab99-56c9bf143fb5/resourceGroups/resume-website-resource-group/providers/Microsoft.Web/serverfarms/resume-website-app-service-plan",
        SiteConfig = new SiteConfigArgs
        {
            AcrUseManagedIdentityCreds = false,
            AlwaysOn = false,
            FunctionAppScaleLimit = 0,
            Http20Enabled = false,
            LinuxFxVersion = "",
            MinimumElasticInstanceCount = 0,
            NumberOfWorkers = 1,
        },
        StorageAccountRequired = false,
    }, new CustomResourceOptions
    {
        Protect = true,
    });
});