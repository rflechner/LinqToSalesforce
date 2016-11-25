using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using LinqToSalesforce;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace LinqToSalesforce.CsharpTests
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAccountType
    {
        [EnumMember(Value = "Prospect")]
        Prospect,
        [EnumMember(Value = "Customer - Direct")]
        CustomerDirect,
        [EnumMember(Value = "Customer - Channel")]
        CustomerChannel,
        [EnumMember(Value = "Channel Partner / Reseller")]
        ChannelPartnerReseller,
        [EnumMember(Value = "Installation Partner")]
        InstallationPartner,
        [EnumMember(Value = "Technology Partner")]
        TechnologyPartner,
        [EnumMember(Value = "Other")]
        Other
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAccountIndustry
    {
        [EnumMember(Value = "Agriculture")]
        Agriculture,
        [EnumMember(Value = "Apparel")]
        Apparel,
        [EnumMember(Value = "Banking")]
        Banking,
        [EnumMember(Value = "Biotechnology")]
        Biotechnology,
        [EnumMember(Value = "Chemicals")]
        Chemicals,
        [EnumMember(Value = "Communications")]
        Communications,
        [EnumMember(Value = "Construction")]
        Construction,
        [EnumMember(Value = "Consulting")]
        Consulting,
        [EnumMember(Value = "Education")]
        Education,
        [EnumMember(Value = "Electronics")]
        Electronics,
        [EnumMember(Value = "Energy")]
        Energy,
        [EnumMember(Value = "Engineering")]
        Engineering,
        [EnumMember(Value = "Entertainment")]
        Entertainment,
        [EnumMember(Value = "Environmental")]
        Environmental,
        [EnumMember(Value = "Finance")]
        Finance,
        [EnumMember(Value = "Food & Beverage")]
        FoodBeverage,
        [EnumMember(Value = "Government")]
        Government,
        [EnumMember(Value = "Healthcare")]
        Healthcare,
        [EnumMember(Value = "Hospitality")]
        Hospitality,
        [EnumMember(Value = "Insurance")]
        Insurance,
        [EnumMember(Value = "Machinery")]
        Machinery,
        [EnumMember(Value = "Manufacturing")]
        Manufacturing,
        [EnumMember(Value = "Media")]
        Media,
        [EnumMember(Value = "Not For Profit")]
        NotForProfit,
        [EnumMember(Value = "Recreation")]
        Recreation,
        [EnumMember(Value = "Retail")]
        Retail,
        [EnumMember(Value = "Shipping")]
        Shipping,
        [EnumMember(Value = "Technology")]
        Technology,
        [EnumMember(Value = "Telecommunications")]
        Telecommunications,
        [EnumMember(Value = "Transportation")]
        Transportation,
        [EnumMember(Value = "Utilities")]
        Utilities,
        [EnumMember(Value = "Other")]
        Other
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAccountOwnership
    {
        [EnumMember(Value = "Public")]
        Public,
        [EnumMember(Value = "Private")]
        Private,
        [EnumMember(Value = "Subsidiary")]
        Subsidiary,
        [EnumMember(Value = "Other")]
        Other
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAccountRating
    {
        [EnumMember(Value = "Hot")]
        Hot,
        [EnumMember(Value = "Warm")]
        Warm,
        [EnumMember(Value = "Cold")]
        Cold
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAccountCustomerPriority__c
    {
        [EnumMember(Value = "High")]
        High,
        [EnumMember(Value = "Low")]
        Low,
        [EnumMember(Value = "Medium")]
        Medium
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAccountSLA__c
    {
        [EnumMember(Value = "Gold")]
        Gold,
        [EnumMember(Value = "Silver")]
        Silver,
        [EnumMember(Value = "Platinum")]
        Platinum,
        [EnumMember(Value = "Bronze")]
        Bronze
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAccountActive__c
    {
        [EnumMember(Value = "No")]
        No,
        [EnumMember(Value = "Yes")]
        Yes
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAccountUpsellOpportunity__c
    {
        [EnumMember(Value = "Maybe")]
        Maybe,
        [EnumMember(Value = "No")]
        No,
        [EnumMember(Value = "Yes")]
        Yes
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAccountContactRoleRole
    {
        [EnumMember(Value = "Business User")]
        BusinessUser,
        [EnumMember(Value = "Decision Maker")]
        DecisionMaker,
        [EnumMember(Value = "Economic Buyer")]
        EconomicBuyer,
        [EnumMember(Value = "Economic Decision Maker")]
        EconomicDecisionMaker,
        [EnumMember(Value = "Evaluator")]
        Evaluator,
        [EnumMember(Value = "Executive Sponsor")]
        ExecutiveSponsor,
        [EnumMember(Value = "Influencer")]
        Influencer,
        [EnumMember(Value = "Technical Buyer")]
        TechnicalBuyer,
        [EnumMember(Value = "Other")]
        Other
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAccountFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAccountHistoryField
    {
        [EnumMember(Value = "accountMerged")]
        accountMerged,
        [EnumMember(Value = "AccountNumber")]
        AccountNumber,
        [EnumMember(Value = "AccountSource")]
        AccountSource,
        [EnumMember(Value = "Active__c")]
        Activec,
        [EnumMember(Value = "AnnualRevenue")]
        AnnualRevenue,
        [EnumMember(Value = "BillingAddress")]
        BillingAddress,
        [EnumMember(Value = "BillingCity")]
        BillingCity,
        [EnumMember(Value = "BillingCountry")]
        BillingCountry,
        [EnumMember(Value = "BillingGeocodeAccuracy")]
        BillingGeocodeAccuracy,
        [EnumMember(Value = "BillingLatitude")]
        BillingLatitude,
        [EnumMember(Value = "BillingLongitude")]
        BillingLongitude,
        [EnumMember(Value = "BillingPostalCode")]
        BillingPostalCode,
        [EnumMember(Value = "BillingState")]
        BillingState,
        [EnumMember(Value = "BillingStreet")]
        BillingStreet,
        [EnumMember(Value = "CleanStatus")]
        CleanStatus,
        [EnumMember(Value = "created")]
        created,
        [EnumMember(Value = "accountCreatedFromLead")]
        accountCreatedFromLead,
        [EnumMember(Value = "CustomerPriority__c")]
        CustomerPriorityc,
        [EnumMember(Value = "DandbCompany")]
        DandbCompany,
        [EnumMember(Value = "Description")]
        Description,
        [EnumMember(Value = "DunsNumber")]
        DunsNumber,
        [EnumMember(Value = "Fax")]
        Fax,
        [EnumMember(Value = "feedEvent")]
        feedEvent,
        [EnumMember(Value = "Industry")]
        Industry,
        [EnumMember(Value = "Jigsaw")]
        Jigsaw,
        [EnumMember(Value = "accountUpdatedByLead")]
        accountUpdatedByLead,
        [EnumMember(Value = "personAccountUpdatedByLead")]
        personAccountUpdatedByLead,
        [EnumMember(Value = "NaicsCode")]
        NaicsCode,
        [EnumMember(Value = "NaicsDesc")]
        NaicsDesc,
        [EnumMember(Value = "Name")]
        Name,
        [EnumMember(Value = "NumberOfEmployees")]
        NumberOfEmployees,
        [EnumMember(Value = "NumberofLocations__c")]
        NumberofLocationsc,
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "ownerAccepted")]
        ownerAccepted,
        [EnumMember(Value = "ownerAssignment")]
        ownerAssignment,
        [EnumMember(Value = "Ownership")]
        Ownership,
        [EnumMember(Value = "Parent")]
        Parent,
        [EnumMember(Value = "Phone")]
        Phone,
        [EnumMember(Value = "Rating")]
        Rating,
        [EnumMember(Value = "locked")]
        locked,
        [EnumMember(Value = "unlocked")]
        unlocked,
        [EnumMember(Value = "ShippingAddress")]
        ShippingAddress,
        [EnumMember(Value = "ShippingCity")]
        ShippingCity,
        [EnumMember(Value = "ShippingCountry")]
        ShippingCountry,
        [EnumMember(Value = "ShippingGeocodeAccuracy")]
        ShippingGeocodeAccuracy,
        [EnumMember(Value = "ShippingLatitude")]
        ShippingLatitude,
        [EnumMember(Value = "ShippingLongitude")]
        ShippingLongitude,
        [EnumMember(Value = "ShippingPostalCode")]
        ShippingPostalCode,
        [EnumMember(Value = "ShippingState")]
        ShippingState,
        [EnumMember(Value = "ShippingStreet")]
        ShippingStreet,
        [EnumMember(Value = "Sic")]
        Sic,
        [EnumMember(Value = "SicDesc")]
        SicDesc,
        [EnumMember(Value = "Site")]
        Site,
        [EnumMember(Value = "SLA__c")]
        SLAc,
        [EnumMember(Value = "SLAExpirationDate__c")]
        SLAExpirationDatec,
        [EnumMember(Value = "SLASerialNumber__c")]
        SLASerialNumberc,
        [EnumMember(Value = "TextName")]
        TextName,
        [EnumMember(Value = "TickerSymbol")]
        TickerSymbol,
        [EnumMember(Value = "Tradestyle")]
        Tradestyle,
        [EnumMember(Value = "Type")]
        Type,
        [EnumMember(Value = "UpsellOpportunity__c")]
        UpsellOpportunityc,
        [EnumMember(Value = "Website")]
        Website,
        [EnumMember(Value = "YearStarted")]
        YearStarted
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAccountPartnerRole
    {
        [EnumMember(Value = "System Integrator")]
        SystemIntegrator,
        [EnumMember(Value = "Agency")]
        Agency,
        [EnumMember(Value = "Advertiser")]
        Advertiser,
        [EnumMember(Value = "VAR/Reseller")]
        VARReseller,
        [EnumMember(Value = "Distributor")]
        Distributor,
        [EnumMember(Value = "Developer")]
        Developer,
        [EnumMember(Value = "Broker")]
        Broker,
        [EnumMember(Value = "Lender")]
        Lender,
        [EnumMember(Value = "Supplier")]
        Supplier,
        [EnumMember(Value = "Institution")]
        Institution,
        [EnumMember(Value = "Contractor")]
        Contractor,
        [EnumMember(Value = "Dealer")]
        Dealer,
        [EnumMember(Value = "Consultant")]
        Consultant
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAccountShareAccountAccessLevel
    {
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit,
        [EnumMember(Value = "All")]
        All
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAccountShareOpportunityAccessLevel
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAccountShareCaseAccessLevel
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAccountShareContactAccessLevel
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAccountShareRowCause
    {
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "Manual")]
        Manual,
        [EnumMember(Value = "Rule")]
        Rule,
        [EnumMember(Value = "ImplicitChild")]
        ImplicitChild,
        [EnumMember(Value = "ImplicitParent")]
        ImplicitParent,
        [EnumMember(Value = "ImplicitPerson")]
        ImplicitPerson,
        [EnumMember(Value = "Team")]
        Team,
        [EnumMember(Value = "Territory")]
        Territory,
        [EnumMember(Value = "TerritoryManual")]
        TerritoryManual,
        [EnumMember(Value = "TerritoryRule")]
        TerritoryRule,
        [EnumMember(Value = "Territory2Forecast")]
        Territory2Forecast
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickActivityHistoryStatus
    {
        [EnumMember(Value = "Not Started")]
        NotStarted,
        [EnumMember(Value = "In Progress")]
        InProgress,
        [EnumMember(Value = "Completed")]
        Completed,
        [EnumMember(Value = "Waiting on someone else")]
        Waitingonsomeoneelse,
        [EnumMember(Value = "Deferred")]
        Deferred
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickActivityHistoryPriority
    {
        [EnumMember(Value = "High")]
        High,
        [EnumMember(Value = "Normal")]
        Normal,
        [EnumMember(Value = "Low")]
        Low
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickActivityHistoryActivityType
    {
        [EnumMember(Value = "Call")]
        Call,
        [EnumMember(Value = "Email")]
        Email,
        [EnumMember(Value = "Meeting")]
        Meeting,
        [EnumMember(Value = "Other")]
        Other
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickActivityHistoryCallType
    {
        [EnumMember(Value = "Internal")]
        Internal,
        [EnumMember(Value = "Inbound")]
        Inbound,
        [EnumMember(Value = "Outbound")]
        Outbound
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickApexClassStatus
    {
        [EnumMember(Value = "Inactive")]
        Inactive,
        [EnumMember(Value = "Active")]
        Active,
        [EnumMember(Value = "Deleted")]
        Deleted
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickApexComponentControllerType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "5")]
        _5
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickApexLogLocation
    {
        [EnumMember(Value = "Monitoring")]
        Monitoring,
        [EnumMember(Value = "Profiling")]
        Profiling,
        [EnumMember(Value = "SystemLog")]
        SystemLog,
        [EnumMember(Value = "HeapDump")]
        HeapDump,
        [EnumMember(Value = "Preserved")]
        Preserved
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickApexPageControllerType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "5")]
        _5
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickApexTriggerTableEnumOrId
    {
        [EnumMember(Value = "Account")]
        Account,
        [EnumMember(Value = "Asset")]
        Asset,
        [EnumMember(Value = "AssistantInteraction")]
        AssistantInteraction,
        [EnumMember(Value = "Attachment")]
        Attachment,
        [EnumMember(Value = "Campaign")]
        Campaign,
        [EnumMember(Value = "CampaignMember")]
        CampaignMember,
        [EnumMember(Value = "Case")]
        Case,
        [EnumMember(Value = "CaseComment")]
        CaseComment,
        [EnumMember(Value = "ChatterMessage")]
        ChatterMessage,
        [EnumMember(Value = "CollaborationGroup")]
        CollaborationGroup,
        [EnumMember(Value = "CollaborationGroupMember")]
        CollaborationGroupMember,
        [EnumMember(Value = "CollaborationGroupRecord")]
        CollaborationGroupRecord,
        [EnumMember(Value = "Contact")]
        Contact,
        [EnumMember(Value = "ContentDistribution")]
        ContentDistribution,
        [EnumMember(Value = "ContentDocument")]
        ContentDocument,
        [EnumMember(Value = "ContentDocumentLink")]
        ContentDocumentLink,
        [EnumMember(Value = "ContentVersion")]
        ContentVersion,
        [EnumMember(Value = "Contract")]
        Contract,
        [EnumMember(Value = "DandBCompany")]
        DandBCompany,
        [EnumMember(Value = "DuplicateRecordItem")]
        DuplicateRecordItem,
        [EnumMember(Value = "DuplicateRecordSet")]
        DuplicateRecordSet,
        [EnumMember(Value = "EmailMessage")]
        EmailMessage,
        [EnumMember(Value = "Event")]
        Event,
        [EnumMember(Value = "FeedComment")]
        FeedComment,
        [EnumMember(Value = "FeedItem")]
        FeedItem,
        [EnumMember(Value = "Goal")]
        Goal,
        [EnumMember(Value = "GoalLink")]
        GoalLink,
        [EnumMember(Value = "Idea")]
        Idea,
        [EnumMember(Value = "IdeaComment")]
        IdeaComment,
        [EnumMember(Value = "Lead")]
        Lead,
        [EnumMember(Value = "Macro")]
        Macro,
        [EnumMember(Value = "Metric")]
        Metric,
        [EnumMember(Value = "MetricDataLink")]
        MetricDataLink,
        [EnumMember(Value = "Note")]
        Note,
        [EnumMember(Value = "Opportunity")]
        Opportunity,
        [EnumMember(Value = "OpportunityLineItem")]
        OpportunityLineItem,
        [EnumMember(Value = "Order")]
        Order,
        [EnumMember(Value = "OrderItem")]
        OrderItem,
        [EnumMember(Value = "Partner")]
        Partner,
        [EnumMember(Value = "Pricebook2")]
        Pricebook2,
        [EnumMember(Value = "Product2")]
        Product2,
        [EnumMember(Value = "RecordOrigin")]
        RecordOrigin,
        [EnumMember(Value = "SocialPersona")]
        SocialPersona,
        [EnumMember(Value = "Solution")]
        Solution,
        [EnumMember(Value = "StreamingChannel")]
        StreamingChannel,
        [EnumMember(Value = "Task")]
        Task,
        [EnumMember(Value = "Topic")]
        Topic,
        [EnumMember(Value = "TopicAssignment")]
        TopicAssignment,
        [EnumMember(Value = "User")]
        User,
        [EnumMember(Value = "UserProvAccount")]
        UserProvAccount,
        [EnumMember(Value = "UserProvAccountStaging")]
        UserProvAccountStaging,
        [EnumMember(Value = "UserProvisioningLog")]
        UserProvisioningLog,
        [EnumMember(Value = "UserProvisioningRequest")]
        UserProvisioningRequest,
        [EnumMember(Value = "UserProvMockTarget")]
        UserProvMockTarget,
        [EnumMember(Value = "WorkCoaching")]
        WorkCoaching,
        [EnumMember(Value = "WorkFeedback")]
        WorkFeedback,
        [EnumMember(Value = "WorkFeedbackQuestion")]
        WorkFeedbackQuestion,
        [EnumMember(Value = "WorkFeedbackQuestionSet")]
        WorkFeedbackQuestionSet,
        [EnumMember(Value = "WorkFeedbackRequest")]
        WorkFeedbackRequest,
        [EnumMember(Value = "WorkFeedbackTemplate")]
        WorkFeedbackTemplate,
        [EnumMember(Value = "WorkPerformanceCycle")]
        WorkPerformanceCycle
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickApexTriggerStatus
    {
        [EnumMember(Value = "Inactive")]
        Inactive,
        [EnumMember(Value = "Active")]
        Active,
        [EnumMember(Value = "Deleted")]
        Deleted
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAssetStatus
    {
        [EnumMember(Value = "Shipped")]
        Shipped,
        [EnumMember(Value = "Installed")]
        Installed,
        [EnumMember(Value = "Registered")]
        Registered,
        [EnumMember(Value = "Obsolete")]
        Obsolete,
        [EnumMember(Value = "Purchased")]
        Purchased
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAssetFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAssetHistoryField
    {
        [EnumMember(Value = "Account")]
        Account,
        [EnumMember(Value = "Contact")]
        Contact,
        [EnumMember(Value = "created")]
        created,
        [EnumMember(Value = "Description")]
        Description,
        [EnumMember(Value = "feedEvent")]
        feedEvent,
        [EnumMember(Value = "InstallDate")]
        InstallDate,
        [EnumMember(Value = "IsCompetitorProduct")]
        IsCompetitorProduct,
        [EnumMember(Value = "Name")]
        Name,
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "ownerAccepted")]
        ownerAccepted,
        [EnumMember(Value = "ownerAssignment")]
        ownerAssignment,
        [EnumMember(Value = "Parent")]
        Parent,
        [EnumMember(Value = "Price")]
        Price,
        [EnumMember(Value = "Product2")]
        Product2,
        [EnumMember(Value = "PurchaseDate")]
        PurchaseDate,
        [EnumMember(Value = "Quantity")]
        Quantity,
        [EnumMember(Value = "locked")]
        locked,
        [EnumMember(Value = "unlocked")]
        unlocked,
        [EnumMember(Value = "RootAsset")]
        RootAsset,
        [EnumMember(Value = "SerialNumber")]
        SerialNumber,
        [EnumMember(Value = "Status")]
        Status,
        [EnumMember(Value = "UsageEndDate")]
        UsageEndDate
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAssignmentRuleSobjectType
    {
        [EnumMember(Value = "Case")]
        Case,
        [EnumMember(Value = "Lead")]
        Lead
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAsyncApexJobJobType
    {
        [EnumMember(Value = "Future")]
        Future,
        [EnumMember(Value = "SharingRecalculation")]
        SharingRecalculation,
        [EnumMember(Value = "ScheduledApex")]
        ScheduledApex,
        [EnumMember(Value = "BatchApex")]
        BatchApex,
        [EnumMember(Value = "BatchApexWorker")]
        BatchApexWorker,
        [EnumMember(Value = "TestRequest")]
        TestRequest,
        [EnumMember(Value = "TestWorker")]
        TestWorker,
        [EnumMember(Value = "ApexToken")]
        ApexToken,
        [EnumMember(Value = "Queueable")]
        Queueable
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickAsyncApexJobStatus
    {
        [EnumMember(Value = "Queued")]
        Queued,
        [EnumMember(Value = "Processing")]
        Processing,
        [EnumMember(Value = "Aborted")]
        Aborted,
        [EnumMember(Value = "Completed")]
        Completed,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Preparing")]
        Preparing,
        [EnumMember(Value = "Holding")]
        Holding
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickBusinessHoursTimeZoneSidKey
    {
        [EnumMember(Value = "Pacific/Kiritimati")]
        PacificKiritimati,
        [EnumMember(Value = "Pacific/Tongatapu")]
        PacificTongatapu,
        [EnumMember(Value = "Pacific/Chatham")]
        PacificChatham,
        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland,
        [EnumMember(Value = "Pacific/Enderbury")]
        PacificEnderbury,
        [EnumMember(Value = "Pacific/Fiji")]
        PacificFiji,
        [EnumMember(Value = "Asia/Kamchatka")]
        AsiaKamchatka,
        [EnumMember(Value = "Australia/Lord_Howe")]
        AustraliaLordHowe,
        [EnumMember(Value = "Australia/Sydney")]
        AustraliaSydney,
        [EnumMember(Value = "Pacific/Guadalcanal")]
        PacificGuadalcanal,
        [EnumMember(Value = "Pacific/Norfolk")]
        PacificNorfolk,
        [EnumMember(Value = "Australia/Adelaide")]
        AustraliaAdelaide,
        [EnumMember(Value = "Australia/Brisbane")]
        AustraliaBrisbane,
        [EnumMember(Value = "Australia/Darwin")]
        AustraliaDarwin,
        [EnumMember(Value = "Asia/Seoul")]
        AsiaSeoul,
        [EnumMember(Value = "Asia/Tokyo")]
        AsiaTokyo,
        [EnumMember(Value = "Asia/Hong_Kong")]
        AsiaHongKong,
        [EnumMember(Value = "Asia/Kuala_Lumpur")]
        AsiaKualaLumpur,
        [EnumMember(Value = "Asia/Manila")]
        AsiaManila,
        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai,
        [EnumMember(Value = "Asia/Singapore")]
        AsiaSingapore,
        [EnumMember(Value = "Asia/Taipei")]
        AsiaTaipei,
        [EnumMember(Value = "Australia/Perth")]
        AustraliaPerth,
        [EnumMember(Value = "Asia/Bangkok")]
        AsiaBangkok,
        [EnumMember(Value = "Asia/Ho_Chi_Minh")]
        AsiaHoChiMinh,
        [EnumMember(Value = "Asia/Jakarta")]
        AsiaJakarta,
        [EnumMember(Value = "Asia/Rangoon")]
        AsiaRangoon,
        [EnumMember(Value = "Asia/Dhaka")]
        AsiaDhaka,
        [EnumMember(Value = "Asia/Kathmandu")]
        AsiaKathmandu,
        [EnumMember(Value = "Asia/Colombo")]
        AsiaColombo,
        [EnumMember(Value = "Asia/Kolkata")]
        AsiaKolkata,
        [EnumMember(Value = "Asia/Karachi")]
        AsiaKarachi,
        [EnumMember(Value = "Asia/Tashkent")]
        AsiaTashkent,
        [EnumMember(Value = "Asia/Yekaterinburg")]
        AsiaYekaterinburg,
        [EnumMember(Value = "Asia/Kabul")]
        AsiaKabul,
        [EnumMember(Value = "Asia/Dubai")]
        AsiaDubai,
        [EnumMember(Value = "Asia/Tbilisi")]
        AsiaTbilisi,
        [EnumMember(Value = "Asia/Tehran")]
        AsiaTehran,
        [EnumMember(Value = "Africa/Nairobi")]
        AfricaNairobi,
        [EnumMember(Value = "Asia/Baghdad")]
        AsiaBaghdad,
        [EnumMember(Value = "Asia/Kuwait")]
        AsiaKuwait,
        [EnumMember(Value = "Asia/Riyadh")]
        AsiaRiyadh,
        [EnumMember(Value = "Europe/Istanbul")]
        EuropeIstanbul,
        [EnumMember(Value = "Europe/Minsk")]
        EuropeMinsk,
        [EnumMember(Value = "Europe/Moscow")]
        EuropeMoscow,
        [EnumMember(Value = "Africa/Cairo")]
        AfricaCairo,
        [EnumMember(Value = "Africa/Johannesburg")]
        AfricaJohannesburg,
        [EnumMember(Value = "Asia/Jerusalem")]
        AsiaJerusalem,
        [EnumMember(Value = "Europe/Athens")]
        EuropeAthens,
        [EnumMember(Value = "Europe/Bucharest")]
        EuropeBucharest,
        [EnumMember(Value = "Europe/Helsinki")]
        EuropeHelsinki,
        [EnumMember(Value = "Africa/Algiers")]
        AfricaAlgiers,
        [EnumMember(Value = "Europe/Amsterdam")]
        EuropeAmsterdam,
        [EnumMember(Value = "Europe/Berlin")]
        EuropeBerlin,
        [EnumMember(Value = "Europe/Brussels")]
        EuropeBrussels,
        [EnumMember(Value = "Europe/Paris")]
        EuropeParis,
        [EnumMember(Value = "Europe/Prague")]
        EuropePrague,
        [EnumMember(Value = "Europe/Rome")]
        EuropeRome,
        [EnumMember(Value = "Europe/Dublin")]
        EuropeDublin,
        [EnumMember(Value = "Europe/Lisbon")]
        EuropeLisbon,
        [EnumMember(Value = "Europe/London")]
        EuropeLondon,
        [EnumMember(Value = "GMT")]
        GMT,
        [EnumMember(Value = "Atlantic/Cape_Verde")]
        AtlanticCapeVerde,
        [EnumMember(Value = "America/Sao_Paulo")]
        AmericaSaoPaulo,
        [EnumMember(Value = "Atlantic/South_Georgia")]
        AtlanticSouthGeorgia,
        [EnumMember(Value = "America/Argentina/Buenos_Aires")]
        AmericaArgentinaBuenosAires,
        [EnumMember(Value = "America/Santiago")]
        AmericaSantiago,
        [EnumMember(Value = "America/St_Johns")]
        AmericaStJohns,
        [EnumMember(Value = "America/Caracas")]
        AmericaCaracas,
        [EnumMember(Value = "America/Halifax")]
        AmericaHalifax,
        [EnumMember(Value = "America/Puerto_Rico")]
        AmericaPuertoRico,
        [EnumMember(Value = "Atlantic/Bermuda")]
        AtlanticBermuda,
        [EnumMember(Value = "America/Bogota")]
        AmericaBogota,
        [EnumMember(Value = "America/Indiana/Indianapolis")]
        AmericaIndianaIndianapolis,
        [EnumMember(Value = "America/Lima")]
        AmericaLima,
        [EnumMember(Value = "America/New_York")]
        AmericaNewYork,
        [EnumMember(Value = "America/Panama")]
        AmericaPanama,
        [EnumMember(Value = "America/Chicago")]
        AmericaChicago,
        [EnumMember(Value = "America/El_Salvador")]
        AmericaElSalvador,
        [EnumMember(Value = "America/Mexico_City")]
        AmericaMexicoCity,
        [EnumMember(Value = "America/Denver")]
        AmericaDenver,
        [EnumMember(Value = "America/Phoenix")]
        AmericaPhoenix,
        [EnumMember(Value = "America/Los_Angeles")]
        AmericaLosAngeles,
        [EnumMember(Value = "America/Tijuana")]
        AmericaTijuana,
        [EnumMember(Value = "America/Anchorage")]
        AmericaAnchorage,
        [EnumMember(Value = "Pacific/Honolulu")]
        PacificHonolulu,
        [EnumMember(Value = "Pacific/Niue")]
        PacificNiue,
        [EnumMember(Value = "Pacific/Pago_Pago")]
        PacificPagoPago
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickBusinessProcessTableEnumOrId
    {
        [EnumMember(Value = "Case")]
        Case,
        [EnumMember(Value = "Lead")]
        Lead,
        [EnumMember(Value = "Opportunity")]
        Opportunity,
        [EnumMember(Value = "Solution")]
        Solution
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCampaignType
    {
        [EnumMember(Value = "Conference")]
        Conference,
        [EnumMember(Value = "Webinar")]
        Webinar,
        [EnumMember(Value = "Trade Show")]
        TradeShow,
        [EnumMember(Value = "Public Relations")]
        PublicRelations,
        [EnumMember(Value = "Partners")]
        Partners,
        [EnumMember(Value = "Referral Program")]
        ReferralProgram,
        [EnumMember(Value = "Advertisement")]
        Advertisement,
        [EnumMember(Value = "Banner Ads")]
        BannerAds,
        [EnumMember(Value = "Direct Mail")]
        DirectMail,
        [EnumMember(Value = "Email")]
        Email,
        [EnumMember(Value = "Telemarketing")]
        Telemarketing,
        [EnumMember(Value = "Other")]
        Other
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCampaignStatus
    {
        [EnumMember(Value = "Planned")]
        Planned,
        [EnumMember(Value = "In Progress")]
        InProgress,
        [EnumMember(Value = "Completed")]
        Completed,
        [EnumMember(Value = "Aborted")]
        Aborted
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCampaignFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCampaignMemberStatus
    {
        [EnumMember(Value = "Planned")]
        Planned,
        [EnumMember(Value = "Received")]
        Received,
        [EnumMember(Value = "Responded")]
        Responded,
        [EnumMember(Value = "Sent")]
        Sent
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCampaignShareCampaignAccessLevel
    {
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit,
        [EnumMember(Value = "All")]
        All
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCampaignShareRowCause
    {
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "Manual")]
        Manual,
        [EnumMember(Value = "Rule")]
        Rule,
        [EnumMember(Value = "ImplicitChild")]
        ImplicitChild,
        [EnumMember(Value = "ImplicitParent")]
        ImplicitParent,
        [EnumMember(Value = "ImplicitPerson")]
        ImplicitPerson,
        [EnumMember(Value = "Team")]
        Team,
        [EnumMember(Value = "Territory")]
        Territory,
        [EnumMember(Value = "TerritoryManual")]
        TerritoryManual,
        [EnumMember(Value = "TerritoryRule")]
        TerritoryRule,
        [EnumMember(Value = "Territory2Forecast")]
        Territory2Forecast
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCaseType
    {
        [EnumMember(Value = "Mechanical")]
        Mechanical,
        [EnumMember(Value = "Electrical")]
        Electrical,
        [EnumMember(Value = "Electronic")]
        Electronic,
        [EnumMember(Value = "Structural")]
        Structural,
        [EnumMember(Value = "Other")]
        Other
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCaseStatus
    {
        [EnumMember(Value = "New")]
        New,
        [EnumMember(Value = "Working")]
        Working,
        [EnumMember(Value = "Escalated")]
        Escalated,
        [EnumMember(Value = "Closed")]
        Closed
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCaseReason
    {
        [EnumMember(Value = "Installation")]
        Installation,
        [EnumMember(Value = "Equipment Complexity")]
        EquipmentComplexity,
        [EnumMember(Value = "Performance")]
        Performance,
        [EnumMember(Value = "Breakdown")]
        Breakdown,
        [EnumMember(Value = "Equipment Design")]
        EquipmentDesign,
        [EnumMember(Value = "Feedback")]
        Feedback,
        [EnumMember(Value = "Other")]
        Other
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCaseOrigin
    {
        [EnumMember(Value = "Phone")]
        Phone,
        [EnumMember(Value = "Email")]
        Email,
        [EnumMember(Value = "Web")]
        Web
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCasePriority
    {
        [EnumMember(Value = "High")]
        High,
        [EnumMember(Value = "Medium")]
        Medium,
        [EnumMember(Value = "Low")]
        Low
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCaseSLAViolation__c
    {
        [EnumMember(Value = "No")]
        No,
        [EnumMember(Value = "Yes")]
        Yes
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCaseProduct__c
    {
        [EnumMember(Value = "GC1040")]
        GC1040,
        [EnumMember(Value = "GC1060")]
        GC1060,
        [EnumMember(Value = "GC3020")]
        GC3020,
        [EnumMember(Value = "GC3040")]
        GC3040,
        [EnumMember(Value = "GC3060")]
        GC3060,
        [EnumMember(Value = "GC5020")]
        GC5020,
        [EnumMember(Value = "GC5040")]
        GC5040,
        [EnumMember(Value = "GC5060")]
        GC5060,
        [EnumMember(Value = "GC1020")]
        GC1020
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCasePotentialLiability__c
    {
        [EnumMember(Value = "No")]
        No,
        [EnumMember(Value = "Yes")]
        Yes
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCaseContactRoleRole
    {
        [EnumMember(Value = "Technical Contact")]
        TechnicalContact,
        [EnumMember(Value = "Business Contact")]
        BusinessContact,
        [EnumMember(Value = "Decision Maker")]
        DecisionMaker,
        [EnumMember(Value = "Other")]
        Other
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCaseFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCaseHistoryField
    {
        [EnumMember(Value = "Account")]
        Account,
        [EnumMember(Value = "Asset")]
        Asset,
        [EnumMember(Value = "BusinessHours")]
        BusinessHours,
        [EnumMember(Value = "closed")]
        closed,
        [EnumMember(Value = "Contact")]
        Contact,
        [EnumMember(Value = "created")]
        created,
        [EnumMember(Value = "Description")]
        Description,
        [EnumMember(Value = "EngineeringReqNumber__c")]
        EngineeringReqNumberc,
        [EnumMember(Value = "feedEvent")]
        feedEvent,
        [EnumMember(Value = "IsClosedOnCreate")]
        IsClosedOnCreate,
        [EnumMember(Value = "IsEscalated")]
        IsEscalated,
        [EnumMember(Value = "Origin")]
        Origin,
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "ownerAccepted")]
        ownerAccepted,
        [EnumMember(Value = "ownerAssignment")]
        ownerAssignment,
        [EnumMember(Value = "ownerEscalated")]
        ownerEscalated,
        [EnumMember(Value = "Parent")]
        Parent,
        [EnumMember(Value = "PotentialLiability__c")]
        PotentialLiabilityc,
        [EnumMember(Value = "Priority")]
        Priority,
        [EnumMember(Value = "Product__c")]
        Productc,
        [EnumMember(Value = "Reason")]
        Reason,
        [EnumMember(Value = "locked")]
        locked,
        [EnumMember(Value = "unlocked")]
        unlocked,
        [EnumMember(Value = "SLAViolation__c")]
        SLAViolationc,
        [EnumMember(Value = "Status")]
        Status,
        [EnumMember(Value = "Subject")]
        Subject,
        [EnumMember(Value = "Type")]
        Type
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCaseShareCaseAccessLevel
    {
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit,
        [EnumMember(Value = "All")]
        All
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCaseShareRowCause
    {
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "Manual")]
        Manual,
        [EnumMember(Value = "Rule")]
        Rule,
        [EnumMember(Value = "ImplicitChild")]
        ImplicitChild,
        [EnumMember(Value = "ImplicitParent")]
        ImplicitParent,
        [EnumMember(Value = "ImplicitPerson")]
        ImplicitPerson,
        [EnumMember(Value = "Team")]
        Team,
        [EnumMember(Value = "Territory")]
        Territory,
        [EnumMember(Value = "TerritoryManual")]
        TerritoryManual,
        [EnumMember(Value = "TerritoryRule")]
        TerritoryRule,
        [EnumMember(Value = "Territory2Forecast")]
        Territory2Forecast
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCaseTeamRoleAccessLevel
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCategoryNodeSortStyle
    {
        [EnumMember(Value = "custom")]
        custom,
        [EnumMember(Value = "alphabetical")]
        alphabetical
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCollaborationGroupCollaborationType
    {
        [EnumMember(Value = "Public")]
        Public,
        [EnumMember(Value = "Private")]
        Private
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCollaborationGroupFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCollaborationGroupMemberNotificationFrequency
    {
        [EnumMember(Value = "P")]
        P,
        [EnumMember(Value = "D")]
        D,
        [EnumMember(Value = "W")]
        W,
        [EnumMember(Value = "N")]
        N
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCollaborationInvitationStatus
    {
        [EnumMember(Value = "Sent")]
        Sent,
        [EnumMember(Value = "Accepted")]
        Accepted,
        [EnumMember(Value = "Canceled")]
        Canceled
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContactSalutation
    {
        [EnumMember(Value = "Mr.")]
        Mr,
        [EnumMember(Value = "Ms.")]
        Ms,
        [EnumMember(Value = "Mrs.")]
        Mrs,
        [EnumMember(Value = "Dr.")]
        Dr,
        [EnumMember(Value = "Prof.")]
        Prof
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContactLeadSource
    {
        [EnumMember(Value = "Web")]
        Web,
        [EnumMember(Value = "Phone Inquiry")]
        PhoneInquiry,
        [EnumMember(Value = "Partner Referral")]
        PartnerReferral,
        [EnumMember(Value = "Purchased List")]
        PurchasedList,
        [EnumMember(Value = "Other")]
        Other
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContactLevel__c
    {
        [EnumMember(Value = "Secondary")]
        Secondary,
        [EnumMember(Value = "Tertiary")]
        Tertiary,
        [EnumMember(Value = "Primary")]
        Primary
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContactFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContactHistoryField
    {
        [EnumMember(Value = "Account")]
        Account,
        [EnumMember(Value = "AssistantName")]
        AssistantName,
        [EnumMember(Value = "AssistantPhone")]
        AssistantPhone,
        [EnumMember(Value = "Birthdate")]
        Birthdate,
        [EnumMember(Value = "CleanStatus")]
        CleanStatus,
        [EnumMember(Value = "contactMerged")]
        contactMerged,
        [EnumMember(Value = "created")]
        created,
        [EnumMember(Value = "contactCreatedFromLead")]
        contactCreatedFromLead,
        [EnumMember(Value = "Department")]
        Department,
        [EnumMember(Value = "Description")]
        Description,
        [EnumMember(Value = "DoNotCall")]
        DoNotCall,
        [EnumMember(Value = "Email")]
        Email,
        [EnumMember(Value = "EmailBouncedDate")]
        EmailBouncedDate,
        [EnumMember(Value = "EmailBouncedReason")]
        EmailBouncedReason,
        [EnumMember(Value = "Fax")]
        Fax,
        [EnumMember(Value = "feedEvent")]
        feedEvent,
        [EnumMember(Value = "FirstName")]
        FirstName,
        [EnumMember(Value = "HasOptedOutOfEmail")]
        HasOptedOutOfEmail,
        [EnumMember(Value = "HasOptedOutOfFax")]
        HasOptedOutOfFax,
        [EnumMember(Value = "HomePhone")]
        HomePhone,
        [EnumMember(Value = "Jigsaw")]
        Jigsaw,
        [EnumMember(Value = "Languages__c")]
        Languagesc,
        [EnumMember(Value = "LastName")]
        LastName,
        [EnumMember(Value = "contactUpdatedByLead")]
        contactUpdatedByLead,
        [EnumMember(Value = "LeadSource")]
        LeadSource,
        [EnumMember(Value = "Level__c")]
        Levelc,
        [EnumMember(Value = "MailingAddress")]
        MailingAddress,
        [EnumMember(Value = "MailingCity")]
        MailingCity,
        [EnumMember(Value = "MailingCountry")]
        MailingCountry,
        [EnumMember(Value = "MailingGeocodeAccuracy")]
        MailingGeocodeAccuracy,
        [EnumMember(Value = "MailingLatitude")]
        MailingLatitude,
        [EnumMember(Value = "MailingLongitude")]
        MailingLongitude,
        [EnumMember(Value = "MailingPostalCode")]
        MailingPostalCode,
        [EnumMember(Value = "MailingState")]
        MailingState,
        [EnumMember(Value = "MailingStreet")]
        MailingStreet,
        [EnumMember(Value = "MobilePhone")]
        MobilePhone,
        [EnumMember(Value = "Name")]
        Name,
        [EnumMember(Value = "OtherAddress")]
        OtherAddress,
        [EnumMember(Value = "OtherCity")]
        OtherCity,
        [EnumMember(Value = "OtherCountry")]
        OtherCountry,
        [EnumMember(Value = "OtherGeocodeAccuracy")]
        OtherGeocodeAccuracy,
        [EnumMember(Value = "OtherLatitude")]
        OtherLatitude,
        [EnumMember(Value = "OtherLongitude")]
        OtherLongitude,
        [EnumMember(Value = "OtherPhone")]
        OtherPhone,
        [EnumMember(Value = "OtherPostalCode")]
        OtherPostalCode,
        [EnumMember(Value = "OtherState")]
        OtherState,
        [EnumMember(Value = "OtherStreet")]
        OtherStreet,
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "ownerAccepted")]
        ownerAccepted,
        [EnumMember(Value = "ownerAssignment")]
        ownerAssignment,
        [EnumMember(Value = "Phone")]
        Phone,
        [EnumMember(Value = "locked")]
        locked,
        [EnumMember(Value = "unlocked")]
        unlocked,
        [EnumMember(Value = "ReportsTo")]
        ReportsTo,
        [EnumMember(Value = "Salutation")]
        Salutation,
        [EnumMember(Value = "Title")]
        Title
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContactShareContactAccessLevel
    {
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit,
        [EnumMember(Value = "All")]
        All
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContactShareRowCause
    {
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "Manual")]
        Manual,
        [EnumMember(Value = "Rule")]
        Rule,
        [EnumMember(Value = "ImplicitChild")]
        ImplicitChild,
        [EnumMember(Value = "ImplicitParent")]
        ImplicitParent,
        [EnumMember(Value = "ImplicitPerson")]
        ImplicitPerson,
        [EnumMember(Value = "Team")]
        Team,
        [EnumMember(Value = "Territory")]
        Territory,
        [EnumMember(Value = "TerritoryManual")]
        TerritoryManual,
        [EnumMember(Value = "TerritoryRule")]
        TerritoryRule,
        [EnumMember(Value = "Territory2Forecast")]
        Territory2Forecast
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContentDocumentPublishStatus
    {
        [EnumMember(Value = "U")]
        U,
        [EnumMember(Value = "P")]
        P,
        [EnumMember(Value = "R")]
        R
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContentDocumentFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContentDocumentHistoryField
    {
        [EnumMember(Value = "ArchivedBy")]
        ArchivedBy,
        [EnumMember(Value = "ArchivedDate")]
        ArchivedDate,
        [EnumMember(Value = "ContentAsset")]
        ContentAsset,
        [EnumMember(Value = "created")]
        created,
        [EnumMember(Value = "DeletedBy")]
        DeletedBy,
        [EnumMember(Value = "DeletedDate")]
        DeletedDate,
        [EnumMember(Value = "contentDocPublished")]
        contentDocPublished,
        [EnumMember(Value = "contentDocFeatured")]
        contentDocFeatured,
        [EnumMember(Value = "contentDocRepublished")]
        contentDocRepublished,
        [EnumMember(Value = "contentDocUnpublished")]
        contentDocUnpublished,
        [EnumMember(Value = "contentDocSubscribed")]
        contentDocSubscribed,
        [EnumMember(Value = "contentDocUnsubscribed")]
        contentDocUnsubscribed,
        [EnumMember(Value = "feedEvent")]
        feedEvent,
        [EnumMember(Value = "IsArchived")]
        IsArchived,
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "ownerAccepted")]
        ownerAccepted,
        [EnumMember(Value = "ownerAssignment")]
        ownerAssignment,
        [EnumMember(Value = "Parent")]
        Parent,
        [EnumMember(Value = "PublishStatus")]
        PublishStatus,
        [EnumMember(Value = "locked")]
        locked,
        [EnumMember(Value = "unlocked")]
        unlocked,
        [EnumMember(Value = "Title")]
        Title
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContentVersionPublishStatus
    {
        [EnumMember(Value = "U")]
        U,
        [EnumMember(Value = "P")]
        P,
        [EnumMember(Value = "R")]
        R
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContentVersionOrigin
    {
        [EnumMember(Value = "C")]
        C,
        [EnumMember(Value = "H")]
        H
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContentVersionHistoryField
    {
        [EnumMember(Value = "ContentUrl")]
        ContentUrl,
        [EnumMember(Value = "created")]
        created,
        [EnumMember(Value = "Description")]
        Description,
        [EnumMember(Value = "ExternalDataSource")]
        ExternalDataSource,
        [EnumMember(Value = "ExternalDocumentInfo1")]
        ExternalDocumentInfo1,
        [EnumMember(Value = "ExternalDocumentInfo2")]
        ExternalDocumentInfo2,
        [EnumMember(Value = "feedEvent")]
        feedEvent,
        [EnumMember(Value = "IsMajorVersion")]
        IsMajorVersion,
        [EnumMember(Value = "Language")]
        Language,
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "ownerAccepted")]
        ownerAccepted,
        [EnumMember(Value = "ownerAssignment")]
        ownerAssignment,
        [EnumMember(Value = "ReasonForChange")]
        ReasonForChange,
        [EnumMember(Value = "locked")]
        locked,
        [EnumMember(Value = "unlocked")]
        unlocked,
        [EnumMember(Value = "SharingOption")]
        SharingOption,
        [EnumMember(Value = "Title")]
        Title,
        [EnumMember(Value = "contentVersionCommented")]
        contentVersionCommented,
        [EnumMember(Value = "contentVersionCreated")]
        contentVersionCreated,
        [EnumMember(Value = "contentVersionDataReplaced")]
        contentVersionDataReplaced,
        [EnumMember(Value = "contentVersionDeleted")]
        contentVersionDeleted,
        [EnumMember(Value = "contentVersionDownloaded")]
        contentVersionDownloaded,
        [EnumMember(Value = "contentVersionRated")]
        contentVersionRated,
        [EnumMember(Value = "contentVersionUpdated")]
        contentVersionUpdated,
        [EnumMember(Value = "contentVersionViewed")]
        contentVersionViewed
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContentWorkspaceTagModel
    {
        [EnumMember(Value = "U")]
        U,
        [EnumMember(Value = "G")]
        G,
        [EnumMember(Value = "R")]
        R
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContractOwnerExpirationNotice
    {
        [EnumMember(Value = "15")]
        _15,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "45")]
        _45,
        [EnumMember(Value = "60")]
        _60,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "120")]
        _120
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContractStatus
    {
        [EnumMember(Value = "In Approval Process")]
        InApprovalProcess,
        [EnumMember(Value = "Activated")]
        Activated,
        [EnumMember(Value = "Draft")]
        Draft
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContractStatusCode
    {
        [EnumMember(Value = "Draft")]
        Draft,
        [EnumMember(Value = "InApproval")]
        InApproval,
        [EnumMember(Value = "Activated")]
        Activated,
        [EnumMember(Value = "Terminated")]
        Terminated,
        [EnumMember(Value = "Expired")]
        Expired
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContractContactRoleRole
    {
        [EnumMember(Value = "Business User")]
        BusinessUser,
        [EnumMember(Value = "Decision Maker")]
        DecisionMaker,
        [EnumMember(Value = "Economic Buyer")]
        EconomicBuyer,
        [EnumMember(Value = "Economic Decision Maker")]
        EconomicDecisionMaker,
        [EnumMember(Value = "Evaluator")]
        Evaluator,
        [EnumMember(Value = "Executive Sponsor")]
        ExecutiveSponsor,
        [EnumMember(Value = "Influencer")]
        Influencer,
        [EnumMember(Value = "Technical Buyer")]
        TechnicalBuyer,
        [EnumMember(Value = "Other")]
        Other
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContractFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContractHistoryField
    {
        [EnumMember(Value = "Account")]
        Account,
        [EnumMember(Value = "ActivatedBy")]
        ActivatedBy,
        [EnumMember(Value = "ActivatedDate")]
        ActivatedDate,
        [EnumMember(Value = "BillingAddress")]
        BillingAddress,
        [EnumMember(Value = "BillingCity")]
        BillingCity,
        [EnumMember(Value = "BillingCountry")]
        BillingCountry,
        [EnumMember(Value = "BillingGeocodeAccuracy")]
        BillingGeocodeAccuracy,
        [EnumMember(Value = "BillingLatitude")]
        BillingLatitude,
        [EnumMember(Value = "BillingLongitude")]
        BillingLongitude,
        [EnumMember(Value = "BillingPostalCode")]
        BillingPostalCode,
        [EnumMember(Value = "BillingState")]
        BillingState,
        [EnumMember(Value = "BillingStreet")]
        BillingStreet,
        [EnumMember(Value = "CompanySigned")]
        CompanySigned,
        [EnumMember(Value = "CompanySignedDate")]
        CompanySignedDate,
        [EnumMember(Value = "contractActivation")]
        contractActivation,
        [EnumMember(Value = "contractApproval")]
        contractApproval,
        [EnumMember(Value = "contractConversion")]
        contractConversion,
        [EnumMember(Value = "contractDraft")]
        contractDraft,
        [EnumMember(Value = "contractExpiration")]
        contractExpiration,
        [EnumMember(Value = "ContractTerm")]
        ContractTerm,
        [EnumMember(Value = "contractTermination")]
        contractTermination,
        [EnumMember(Value = "created")]
        created,
        [EnumMember(Value = "CustomerSigned")]
        CustomerSigned,
        [EnumMember(Value = "CustomerSignedDate")]
        CustomerSignedDate,
        [EnumMember(Value = "CustomerSignedTitle")]
        CustomerSignedTitle,
        [EnumMember(Value = "Description")]
        Description,
        [EnumMember(Value = "EndDate")]
        EndDate,
        [EnumMember(Value = "feedEvent")]
        feedEvent,
        [EnumMember(Value = "Name")]
        Name,
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "ownerAccepted")]
        ownerAccepted,
        [EnumMember(Value = "ownerAssignment")]
        ownerAssignment,
        [EnumMember(Value = "OwnerExpirationNotice")]
        OwnerExpirationNotice,
        [EnumMember(Value = "Pricebook2")]
        Pricebook2,
        [EnumMember(Value = "locked")]
        locked,
        [EnumMember(Value = "unlocked")]
        unlocked,
        [EnumMember(Value = "ShippingAddress")]
        ShippingAddress,
        [EnumMember(Value = "ShippingCity")]
        ShippingCity,
        [EnumMember(Value = "ShippingCountry")]
        ShippingCountry,
        [EnumMember(Value = "ShippingGeocodeAccuracy")]
        ShippingGeocodeAccuracy,
        [EnumMember(Value = "ShippingLatitude")]
        ShippingLatitude,
        [EnumMember(Value = "ShippingLongitude")]
        ShippingLongitude,
        [EnumMember(Value = "ShippingPostalCode")]
        ShippingPostalCode,
        [EnumMember(Value = "ShippingState")]
        ShippingState,
        [EnumMember(Value = "ShippingStreet")]
        ShippingStreet,
        [EnumMember(Value = "SpecialTerms")]
        SpecialTerms,
        [EnumMember(Value = "StartDate")]
        StartDate,
        [EnumMember(Value = "Status")]
        Status
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickContractStatusStatusCode
    {
        [EnumMember(Value = "Draft")]
        Draft,
        [EnumMember(Value = "InApproval")]
        InApproval,
        [EnumMember(Value = "Activated")]
        Activated,
        [EnumMember(Value = "Terminated")]
        Terminated,
        [EnumMember(Value = "Expired")]
        Expired
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickCronTriggerTimeZoneSidKey
    {
        [EnumMember(Value = "Pacific/Kiritimati")]
        PacificKiritimati,
        [EnumMember(Value = "Pacific/Tongatapu")]
        PacificTongatapu,
        [EnumMember(Value = "Pacific/Chatham")]
        PacificChatham,
        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland,
        [EnumMember(Value = "Pacific/Enderbury")]
        PacificEnderbury,
        [EnumMember(Value = "Pacific/Fiji")]
        PacificFiji,
        [EnumMember(Value = "Asia/Kamchatka")]
        AsiaKamchatka,
        [EnumMember(Value = "Australia/Lord_Howe")]
        AustraliaLordHowe,
        [EnumMember(Value = "Australia/Sydney")]
        AustraliaSydney,
        [EnumMember(Value = "Pacific/Guadalcanal")]
        PacificGuadalcanal,
        [EnumMember(Value = "Pacific/Norfolk")]
        PacificNorfolk,
        [EnumMember(Value = "Australia/Adelaide")]
        AustraliaAdelaide,
        [EnumMember(Value = "Australia/Brisbane")]
        AustraliaBrisbane,
        [EnumMember(Value = "Australia/Darwin")]
        AustraliaDarwin,
        [EnumMember(Value = "Asia/Seoul")]
        AsiaSeoul,
        [EnumMember(Value = "Asia/Tokyo")]
        AsiaTokyo,
        [EnumMember(Value = "Asia/Hong_Kong")]
        AsiaHongKong,
        [EnumMember(Value = "Asia/Kuala_Lumpur")]
        AsiaKualaLumpur,
        [EnumMember(Value = "Asia/Manila")]
        AsiaManila,
        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai,
        [EnumMember(Value = "Asia/Singapore")]
        AsiaSingapore,
        [EnumMember(Value = "Asia/Taipei")]
        AsiaTaipei,
        [EnumMember(Value = "Australia/Perth")]
        AustraliaPerth,
        [EnumMember(Value = "Asia/Bangkok")]
        AsiaBangkok,
        [EnumMember(Value = "Asia/Ho_Chi_Minh")]
        AsiaHoChiMinh,
        [EnumMember(Value = "Asia/Jakarta")]
        AsiaJakarta,
        [EnumMember(Value = "Asia/Rangoon")]
        AsiaRangoon,
        [EnumMember(Value = "Asia/Dhaka")]
        AsiaDhaka,
        [EnumMember(Value = "Asia/Kathmandu")]
        AsiaKathmandu,
        [EnumMember(Value = "Asia/Colombo")]
        AsiaColombo,
        [EnumMember(Value = "Asia/Kolkata")]
        AsiaKolkata,
        [EnumMember(Value = "Asia/Karachi")]
        AsiaKarachi,
        [EnumMember(Value = "Asia/Tashkent")]
        AsiaTashkent,
        [EnumMember(Value = "Asia/Yekaterinburg")]
        AsiaYekaterinburg,
        [EnumMember(Value = "Asia/Kabul")]
        AsiaKabul,
        [EnumMember(Value = "Asia/Dubai")]
        AsiaDubai,
        [EnumMember(Value = "Asia/Tbilisi")]
        AsiaTbilisi,
        [EnumMember(Value = "Asia/Tehran")]
        AsiaTehran,
        [EnumMember(Value = "Africa/Nairobi")]
        AfricaNairobi,
        [EnumMember(Value = "Asia/Baghdad")]
        AsiaBaghdad,
        [EnumMember(Value = "Asia/Kuwait")]
        AsiaKuwait,
        [EnumMember(Value = "Asia/Riyadh")]
        AsiaRiyadh,
        [EnumMember(Value = "Europe/Istanbul")]
        EuropeIstanbul,
        [EnumMember(Value = "Europe/Minsk")]
        EuropeMinsk,
        [EnumMember(Value = "Europe/Moscow")]
        EuropeMoscow,
        [EnumMember(Value = "Africa/Cairo")]
        AfricaCairo,
        [EnumMember(Value = "Africa/Johannesburg")]
        AfricaJohannesburg,
        [EnumMember(Value = "Asia/Jerusalem")]
        AsiaJerusalem,
        [EnumMember(Value = "Europe/Athens")]
        EuropeAthens,
        [EnumMember(Value = "Europe/Bucharest")]
        EuropeBucharest,
        [EnumMember(Value = "Europe/Helsinki")]
        EuropeHelsinki,
        [EnumMember(Value = "Africa/Algiers")]
        AfricaAlgiers,
        [EnumMember(Value = "Europe/Amsterdam")]
        EuropeAmsterdam,
        [EnumMember(Value = "Europe/Berlin")]
        EuropeBerlin,
        [EnumMember(Value = "Europe/Brussels")]
        EuropeBrussels,
        [EnumMember(Value = "Europe/Paris")]
        EuropeParis,
        [EnumMember(Value = "Europe/Prague")]
        EuropePrague,
        [EnumMember(Value = "Europe/Rome")]
        EuropeRome,
        [EnumMember(Value = "Europe/Dublin")]
        EuropeDublin,
        [EnumMember(Value = "Europe/Lisbon")]
        EuropeLisbon,
        [EnumMember(Value = "Europe/London")]
        EuropeLondon,
        [EnumMember(Value = "GMT")]
        GMT,
        [EnumMember(Value = "Atlantic/Cape_Verde")]
        AtlanticCapeVerde,
        [EnumMember(Value = "America/Sao_Paulo")]
        AmericaSaoPaulo,
        [EnumMember(Value = "Atlantic/South_Georgia")]
        AtlanticSouthGeorgia,
        [EnumMember(Value = "America/Argentina/Buenos_Aires")]
        AmericaArgentinaBuenosAires,
        [EnumMember(Value = "America/Santiago")]
        AmericaSantiago,
        [EnumMember(Value = "America/St_Johns")]
        AmericaStJohns,
        [EnumMember(Value = "America/Caracas")]
        AmericaCaracas,
        [EnumMember(Value = "America/Halifax")]
        AmericaHalifax,
        [EnumMember(Value = "America/Puerto_Rico")]
        AmericaPuertoRico,
        [EnumMember(Value = "Atlantic/Bermuda")]
        AtlanticBermuda,
        [EnumMember(Value = "America/Bogota")]
        AmericaBogota,
        [EnumMember(Value = "America/Indiana/Indianapolis")]
        AmericaIndianaIndianapolis,
        [EnumMember(Value = "America/Lima")]
        AmericaLima,
        [EnumMember(Value = "America/New_York")]
        AmericaNewYork,
        [EnumMember(Value = "America/Panama")]
        AmericaPanama,
        [EnumMember(Value = "America/Chicago")]
        AmericaChicago,
        [EnumMember(Value = "America/El_Salvador")]
        AmericaElSalvador,
        [EnumMember(Value = "America/Mexico_City")]
        AmericaMexicoCity,
        [EnumMember(Value = "America/Denver")]
        AmericaDenver,
        [EnumMember(Value = "America/Phoenix")]
        AmericaPhoenix,
        [EnumMember(Value = "America/Los_Angeles")]
        AmericaLosAngeles,
        [EnumMember(Value = "America/Tijuana")]
        AmericaTijuana,
        [EnumMember(Value = "America/Anchorage")]
        AmericaAnchorage,
        [EnumMember(Value = "Pacific/Honolulu")]
        PacificHonolulu,
        [EnumMember(Value = "Pacific/Niue")]
        PacificNiue,
        [EnumMember(Value = "Pacific/Pago_Pago")]
        PacificPagoPago
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickDashboardLeftSize
    {
        [EnumMember(Value = "Narrow")]
        Narrow,
        [EnumMember(Value = "Medium")]
        Medium,
        [EnumMember(Value = "Wide")]
        Wide
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickDashboardMiddleSize
    {
        [EnumMember(Value = "Narrow")]
        Narrow,
        [EnumMember(Value = "Medium")]
        Medium,
        [EnumMember(Value = "Wide")]
        Wide
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickDashboardRightSize
    {
        [EnumMember(Value = "Narrow")]
        Narrow,
        [EnumMember(Value = "Medium")]
        Medium,
        [EnumMember(Value = "Wide")]
        Wide
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickDashboardBackgroundDirection
    {
        [EnumMember(Value = "TopToBottom")]
        TopToBottom,
        [EnumMember(Value = "LeftToRight")]
        LeftToRight,
        [EnumMember(Value = "Diagonal")]
        Diagonal
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickDashboardType
    {
        [EnumMember(Value = "SpecifiedUser")]
        SpecifiedUser,
        [EnumMember(Value = "LoggedInUser")]
        LoggedInUser,
        [EnumMember(Value = "MyTeamUser")]
        MyTeamUser
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickDashboardFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickEmailMessageStatus
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickEmailServicesFunctionAttachmentOption
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickEmailServicesFunctionOverLimitAction
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickEmailServicesFunctionFunctionInactiveAction
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickEmailServicesFunctionAddressInactiveAction
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickEmailServicesFunctionAuthenticationFailureAction
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickEmailServicesFunctionAuthorizationFailureAction
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickEmailTemplateTemplateStyle
    {
        [EnumMember(Value = "none")]
        none,
        [EnumMember(Value = "freeForm")]
        freeForm,
        [EnumMember(Value = "formalLetter")]
        formalLetter,
        [EnumMember(Value = "promotionRight")]
        promotionRight,
        [EnumMember(Value = "promotionLeft")]
        promotionLeft,
        [EnumMember(Value = "newsletter")]
        newsletter,
        [EnumMember(Value = "products")]
        products
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickEmailTemplateTemplateType
    {
        [EnumMember(Value = "text")]
        text,
        [EnumMember(Value = "html")]
        html,
        [EnumMember(Value = "custom")]
        custom,
        [EnumMember(Value = "visualforce")]
        visualforce
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickEmailTemplateEncoding
    {
        [EnumMember(Value = "UTF-8")]
        UTF8,
        [EnumMember(Value = "ISO-8859-1")]
        ISO88591,
        [EnumMember(Value = "Shift_JIS")]
        ShiftJIS,
        [EnumMember(Value = "ISO-2022-JP")]
        ISO2022JP,
        [EnumMember(Value = "EUC-JP")]
        EUCJP,
        [EnumMember(Value = "ks_c_5601-1987")]
        ksc56011987,
        [EnumMember(Value = "Big5")]
        Big5,
        [EnumMember(Value = "GB2312")]
        GB2312
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickEventShowAs
    {
        [EnumMember(Value = "Busy")]
        Busy,
        [EnumMember(Value = "OutOfOffice")]
        OutOfOffice,
        [EnumMember(Value = "Free")]
        Free
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickEventGroupEventType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickEventRecurrenceTimeZoneSidKey
    {
        [EnumMember(Value = "Pacific/Kiritimati")]
        PacificKiritimati,
        [EnumMember(Value = "Pacific/Tongatapu")]
        PacificTongatapu,
        [EnumMember(Value = "Pacific/Chatham")]
        PacificChatham,
        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland,
        [EnumMember(Value = "Pacific/Enderbury")]
        PacificEnderbury,
        [EnumMember(Value = "Pacific/Fiji")]
        PacificFiji,
        [EnumMember(Value = "Asia/Kamchatka")]
        AsiaKamchatka,
        [EnumMember(Value = "Australia/Lord_Howe")]
        AustraliaLordHowe,
        [EnumMember(Value = "Australia/Sydney")]
        AustraliaSydney,
        [EnumMember(Value = "Pacific/Guadalcanal")]
        PacificGuadalcanal,
        [EnumMember(Value = "Pacific/Norfolk")]
        PacificNorfolk,
        [EnumMember(Value = "Australia/Adelaide")]
        AustraliaAdelaide,
        [EnumMember(Value = "Australia/Brisbane")]
        AustraliaBrisbane,
        [EnumMember(Value = "Australia/Darwin")]
        AustraliaDarwin,
        [EnumMember(Value = "Asia/Seoul")]
        AsiaSeoul,
        [EnumMember(Value = "Asia/Tokyo")]
        AsiaTokyo,
        [EnumMember(Value = "Asia/Hong_Kong")]
        AsiaHongKong,
        [EnumMember(Value = "Asia/Kuala_Lumpur")]
        AsiaKualaLumpur,
        [EnumMember(Value = "Asia/Manila")]
        AsiaManila,
        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai,
        [EnumMember(Value = "Asia/Singapore")]
        AsiaSingapore,
        [EnumMember(Value = "Asia/Taipei")]
        AsiaTaipei,
        [EnumMember(Value = "Australia/Perth")]
        AustraliaPerth,
        [EnumMember(Value = "Asia/Bangkok")]
        AsiaBangkok,
        [EnumMember(Value = "Asia/Ho_Chi_Minh")]
        AsiaHoChiMinh,
        [EnumMember(Value = "Asia/Jakarta")]
        AsiaJakarta,
        [EnumMember(Value = "Asia/Rangoon")]
        AsiaRangoon,
        [EnumMember(Value = "Asia/Dhaka")]
        AsiaDhaka,
        [EnumMember(Value = "Asia/Kathmandu")]
        AsiaKathmandu,
        [EnumMember(Value = "Asia/Colombo")]
        AsiaColombo,
        [EnumMember(Value = "Asia/Kolkata")]
        AsiaKolkata,
        [EnumMember(Value = "Asia/Karachi")]
        AsiaKarachi,
        [EnumMember(Value = "Asia/Tashkent")]
        AsiaTashkent,
        [EnumMember(Value = "Asia/Yekaterinburg")]
        AsiaYekaterinburg,
        [EnumMember(Value = "Asia/Kabul")]
        AsiaKabul,
        [EnumMember(Value = "Asia/Dubai")]
        AsiaDubai,
        [EnumMember(Value = "Asia/Tbilisi")]
        AsiaTbilisi,
        [EnumMember(Value = "Asia/Tehran")]
        AsiaTehran,
        [EnumMember(Value = "Africa/Nairobi")]
        AfricaNairobi,
        [EnumMember(Value = "Asia/Baghdad")]
        AsiaBaghdad,
        [EnumMember(Value = "Asia/Kuwait")]
        AsiaKuwait,
        [EnumMember(Value = "Asia/Riyadh")]
        AsiaRiyadh,
        [EnumMember(Value = "Europe/Istanbul")]
        EuropeIstanbul,
        [EnumMember(Value = "Europe/Minsk")]
        EuropeMinsk,
        [EnumMember(Value = "Europe/Moscow")]
        EuropeMoscow,
        [EnumMember(Value = "Africa/Cairo")]
        AfricaCairo,
        [EnumMember(Value = "Africa/Johannesburg")]
        AfricaJohannesburg,
        [EnumMember(Value = "Asia/Jerusalem")]
        AsiaJerusalem,
        [EnumMember(Value = "Europe/Athens")]
        EuropeAthens,
        [EnumMember(Value = "Europe/Bucharest")]
        EuropeBucharest,
        [EnumMember(Value = "Europe/Helsinki")]
        EuropeHelsinki,
        [EnumMember(Value = "Africa/Algiers")]
        AfricaAlgiers,
        [EnumMember(Value = "Europe/Amsterdam")]
        EuropeAmsterdam,
        [EnumMember(Value = "Europe/Berlin")]
        EuropeBerlin,
        [EnumMember(Value = "Europe/Brussels")]
        EuropeBrussels,
        [EnumMember(Value = "Europe/Paris")]
        EuropeParis,
        [EnumMember(Value = "Europe/Prague")]
        EuropePrague,
        [EnumMember(Value = "Europe/Rome")]
        EuropeRome,
        [EnumMember(Value = "Europe/Dublin")]
        EuropeDublin,
        [EnumMember(Value = "Europe/Lisbon")]
        EuropeLisbon,
        [EnumMember(Value = "Europe/London")]
        EuropeLondon,
        [EnumMember(Value = "GMT")]
        GMT,
        [EnumMember(Value = "Atlantic/Cape_Verde")]
        AtlanticCapeVerde,
        [EnumMember(Value = "America/Sao_Paulo")]
        AmericaSaoPaulo,
        [EnumMember(Value = "Atlantic/South_Georgia")]
        AtlanticSouthGeorgia,
        [EnumMember(Value = "America/Argentina/Buenos_Aires")]
        AmericaArgentinaBuenosAires,
        [EnumMember(Value = "America/Santiago")]
        AmericaSantiago,
        [EnumMember(Value = "America/St_Johns")]
        AmericaStJohns,
        [EnumMember(Value = "America/Caracas")]
        AmericaCaracas,
        [EnumMember(Value = "America/Halifax")]
        AmericaHalifax,
        [EnumMember(Value = "America/Puerto_Rico")]
        AmericaPuertoRico,
        [EnumMember(Value = "Atlantic/Bermuda")]
        AtlanticBermuda,
        [EnumMember(Value = "America/Bogota")]
        AmericaBogota,
        [EnumMember(Value = "America/Indiana/Indianapolis")]
        AmericaIndianaIndianapolis,
        [EnumMember(Value = "America/Lima")]
        AmericaLima,
        [EnumMember(Value = "America/New_York")]
        AmericaNewYork,
        [EnumMember(Value = "America/Panama")]
        AmericaPanama,
        [EnumMember(Value = "America/Chicago")]
        AmericaChicago,
        [EnumMember(Value = "America/El_Salvador")]
        AmericaElSalvador,
        [EnumMember(Value = "America/Mexico_City")]
        AmericaMexicoCity,
        [EnumMember(Value = "America/Denver")]
        AmericaDenver,
        [EnumMember(Value = "America/Phoenix")]
        AmericaPhoenix,
        [EnumMember(Value = "America/Los_Angeles")]
        AmericaLosAngeles,
        [EnumMember(Value = "America/Tijuana")]
        AmericaTijuana,
        [EnumMember(Value = "America/Anchorage")]
        AmericaAnchorage,
        [EnumMember(Value = "Pacific/Honolulu")]
        PacificHonolulu,
        [EnumMember(Value = "Pacific/Niue")]
        PacificNiue,
        [EnumMember(Value = "Pacific/Pago_Pago")]
        PacificPagoPago
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickEventRecurrenceType
    {
        [EnumMember(Value = "RecursDaily")]
        RecursDaily,
        [EnumMember(Value = "RecursEveryWeekday")]
        RecursEveryWeekday,
        [EnumMember(Value = "RecursMonthly")]
        RecursMonthly,
        [EnumMember(Value = "RecursMonthlyNth")]
        RecursMonthlyNth,
        [EnumMember(Value = "RecursWeekly")]
        RecursWeekly,
        [EnumMember(Value = "RecursYearly")]
        RecursYearly,
        [EnumMember(Value = "RecursYearlyNth")]
        RecursYearlyNth
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickEventRecurrenceInstance
    {
        [EnumMember(Value = "First")]
        First,
        [EnumMember(Value = "Second")]
        Second,
        [EnumMember(Value = "Third")]
        Third,
        [EnumMember(Value = "Fourth")]
        Fourth,
        [EnumMember(Value = "Last")]
        Last
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickEventRecurrenceMonthOfYear
    {
        [EnumMember(Value = "January")]
        January,
        [EnumMember(Value = "February")]
        February,
        [EnumMember(Value = "March")]
        March,
        [EnumMember(Value = "April")]
        April,
        [EnumMember(Value = "May")]
        May,
        [EnumMember(Value = "June")]
        June,
        [EnumMember(Value = "July")]
        July,
        [EnumMember(Value = "August")]
        August,
        [EnumMember(Value = "September")]
        September,
        [EnumMember(Value = "October")]
        October,
        [EnumMember(Value = "November")]
        November,
        [EnumMember(Value = "December")]
        December
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickEventAttendeeStatus
    {
        [EnumMember(Value = "New")]
        New,
        [EnumMember(Value = "Declined")]
        Declined,
        [EnumMember(Value = "Accepted")]
        Accepted,
        [EnumMember(Value = "Uninvited")]
        Uninvited,
        [EnumMember(Value = "Maybe")]
        Maybe
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickEventFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickFeedPostType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickFiscalYearSettingsYearType
    {
        [EnumMember(Value = "Standard")]
        Standard,
        [EnumMember(Value = "Custom")]
        Custom,
        [EnumMember(Value = "Placeholder")]
        Placeholder
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickFiscalYearSettingsQuarterLabelScheme
    {
        [EnumMember(Value = "NumberByYear")]
        NumberByYear,
        [EnumMember(Value = "Custom")]
        Custom
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickFiscalYearSettingsPeriodLabelScheme
    {
        [EnumMember(Value = "NumberByYear")]
        NumberByYear,
        [EnumMember(Value = "NumberByQuarter")]
        NumberByQuarter,
        [EnumMember(Value = "StandardMonths")]
        StandardMonths,
        [EnumMember(Value = "Custom")]
        Custom
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickFiscalYearSettingsWeekLabelScheme
    {
        [EnumMember(Value = "NumberByYear")]
        NumberByYear,
        [EnumMember(Value = "NumberByQuarter")]
        NumberByQuarter,
        [EnumMember(Value = "NumberByPeriod")]
        NumberByPeriod
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickFiscalYearSettingsQuarterPrefix
    {
        [EnumMember(Value = "Quarter")]
        Quarter,
        [EnumMember(Value = "FQ")]
        FQ,
        [EnumMember(Value = "Q")]
        Q,
        [EnumMember(Value = "Trimester")]
        Trimester
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickFiscalYearSettingsPeriodPrefix
    {
        [EnumMember(Value = "Period")]
        Period,
        [EnumMember(Value = "FP")]
        FP,
        [EnumMember(Value = "P")]
        P,
        [EnumMember(Value = "Month")]
        Month
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickFolderAccessType
    {
        [EnumMember(Value = "Shared")]
        Shared,
        [EnumMember(Value = "Public")]
        Public,
        [EnumMember(Value = "Hidden")]
        Hidden,
        [EnumMember(Value = "PublicInternal")]
        PublicInternal
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickFolderType
    {
        [EnumMember(Value = "Document")]
        Document,
        [EnumMember(Value = "Email")]
        Email,
        [EnumMember(Value = "Report")]
        Report,
        [EnumMember(Value = "Dashboard")]
        Dashboard
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickForecastShareAccessLevel
    {
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit,
        [EnumMember(Value = "All")]
        All
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickForecastShareRowCause
    {
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "Manual")]
        Manual,
        [EnumMember(Value = "Rule")]
        Rule,
        [EnumMember(Value = "ImplicitChild")]
        ImplicitChild,
        [EnumMember(Value = "ImplicitParent")]
        ImplicitParent,
        [EnumMember(Value = "ImplicitPerson")]
        ImplicitPerson,
        [EnumMember(Value = "Team")]
        Team,
        [EnumMember(Value = "Territory")]
        Territory,
        [EnumMember(Value = "TerritoryManual")]
        TerritoryManual,
        [EnumMember(Value = "TerritoryRule")]
        TerritoryRule,
        [EnumMember(Value = "Territory2Forecast")]
        Territory2Forecast
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickGroupType
    {
        [EnumMember(Value = "AllCustomerPortal")]
        AllCustomerPortal,
        [EnumMember(Value = "CollaborationGroup")]
        CollaborationGroup,
        [EnumMember(Value = "Manager")]
        Manager,
        [EnumMember(Value = "ManagerAndSubordinatesInternal")]
        ManagerAndSubordinatesInternal,
        [EnumMember(Value = "Organization")]
        Organization,
        [EnumMember(Value = "PRMOrganization")]
        PRMOrganization,
        [EnumMember(Value = "Queue")]
        Queue,
        [EnumMember(Value = "Regular")]
        Regular,
        [EnumMember(Value = "Role")]
        Role,
        [EnumMember(Value = "RoleAndSubordinates")]
        RoleAndSubordinates,
        [EnumMember(Value = "RoleAndSubordinatesInternal")]
        RoleAndSubordinatesInternal,
        [EnumMember(Value = "SharingRuleGroup")]
        SharingRuleGroup,
        [EnumMember(Value = "Territory")]
        Territory,
        [EnumMember(Value = "TerritoryAndSubordinates")]
        TerritoryAndSubordinates
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickHolidayRecurrenceType
    {
        [EnumMember(Value = "RecursDaily")]
        RecursDaily,
        [EnumMember(Value = "RecursEveryWeekday")]
        RecursEveryWeekday,
        [EnumMember(Value = "RecursMonthly")]
        RecursMonthly,
        [EnumMember(Value = "RecursMonthlyNth")]
        RecursMonthlyNth,
        [EnumMember(Value = "RecursWeekly")]
        RecursWeekly,
        [EnumMember(Value = "RecursYearly")]
        RecursYearly,
        [EnumMember(Value = "RecursYearlyNth")]
        RecursYearlyNth
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickHolidayRecurrenceInstance
    {
        [EnumMember(Value = "First")]
        First,
        [EnumMember(Value = "Second")]
        Second,
        [EnumMember(Value = "Third")]
        Third,
        [EnumMember(Value = "Fourth")]
        Fourth,
        [EnumMember(Value = "Last")]
        Last
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickHolidayRecurrenceMonthOfYear
    {
        [EnumMember(Value = "January")]
        January,
        [EnumMember(Value = "February")]
        February,
        [EnumMember(Value = "March")]
        March,
        [EnumMember(Value = "April")]
        April,
        [EnumMember(Value = "May")]
        May,
        [EnumMember(Value = "June")]
        June,
        [EnumMember(Value = "July")]
        July,
        [EnumMember(Value = "August")]
        August,
        [EnumMember(Value = "September")]
        September,
        [EnumMember(Value = "October")]
        October,
        [EnumMember(Value = "November")]
        November,
        [EnumMember(Value = "December")]
        December
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickIdeaStatus
    {

    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickLeadSalutation
    {
        [EnumMember(Value = "Mr.")]
        Mr,
        [EnumMember(Value = "Ms.")]
        Ms,
        [EnumMember(Value = "Mrs.")]
        Mrs,
        [EnumMember(Value = "Dr.")]
        Dr,
        [EnumMember(Value = "Prof.")]
        Prof
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickLeadLeadSource
    {
        [EnumMember(Value = "Web")]
        Web,
        [EnumMember(Value = "Phone Inquiry")]
        PhoneInquiry,
        [EnumMember(Value = "Partner Referral")]
        PartnerReferral,
        [EnumMember(Value = "Purchased List")]
        PurchasedList,
        [EnumMember(Value = "Other")]
        Other
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickLeadStatus
    {
        [EnumMember(Value = "Open - Not Contacted")]
        OpenNotContacted,
        [EnumMember(Value = "Working - Contacted")]
        WorkingContacted,
        [EnumMember(Value = "Closed - Converted")]
        ClosedConverted,
        [EnumMember(Value = "Closed - Not Converted")]
        ClosedNotConverted
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickLeadIndustry
    {
        [EnumMember(Value = "Agriculture")]
        Agriculture,
        [EnumMember(Value = "Apparel")]
        Apparel,
        [EnumMember(Value = "Banking")]
        Banking,
        [EnumMember(Value = "Biotechnology")]
        Biotechnology,
        [EnumMember(Value = "Chemicals")]
        Chemicals,
        [EnumMember(Value = "Communications")]
        Communications,
        [EnumMember(Value = "Construction")]
        Construction,
        [EnumMember(Value = "Consulting")]
        Consulting,
        [EnumMember(Value = "Education")]
        Education,
        [EnumMember(Value = "Electronics")]
        Electronics,
        [EnumMember(Value = "Energy")]
        Energy,
        [EnumMember(Value = "Engineering")]
        Engineering,
        [EnumMember(Value = "Entertainment")]
        Entertainment,
        [EnumMember(Value = "Environmental")]
        Environmental,
        [EnumMember(Value = "Finance")]
        Finance,
        [EnumMember(Value = "Food & Beverage")]
        FoodBeverage,
        [EnumMember(Value = "Government")]
        Government,
        [EnumMember(Value = "Healthcare")]
        Healthcare,
        [EnumMember(Value = "Hospitality")]
        Hospitality,
        [EnumMember(Value = "Insurance")]
        Insurance,
        [EnumMember(Value = "Machinery")]
        Machinery,
        [EnumMember(Value = "Manufacturing")]
        Manufacturing,
        [EnumMember(Value = "Media")]
        Media,
        [EnumMember(Value = "Not For Profit")]
        NotForProfit,
        [EnumMember(Value = "Recreation")]
        Recreation,
        [EnumMember(Value = "Retail")]
        Retail,
        [EnumMember(Value = "Shipping")]
        Shipping,
        [EnumMember(Value = "Technology")]
        Technology,
        [EnumMember(Value = "Telecommunications")]
        Telecommunications,
        [EnumMember(Value = "Transportation")]
        Transportation,
        [EnumMember(Value = "Utilities")]
        Utilities,
        [EnumMember(Value = "Other")]
        Other
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickLeadRating
    {
        [EnumMember(Value = "Hot")]
        Hot,
        [EnumMember(Value = "Warm")]
        Warm,
        [EnumMember(Value = "Cold")]
        Cold
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickLeadProductInterest__c
    {
        [EnumMember(Value = "GC1000 series")]
        GC1000series,
        [EnumMember(Value = "GC5000 series")]
        GC5000series,
        [EnumMember(Value = "GC3000 series")]
        GC3000series
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickLeadPrimary__c
    {
        [EnumMember(Value = "No")]
        No,
        [EnumMember(Value = "Yes")]
        Yes
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickLeadFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickLeadHistoryField
    {
        [EnumMember(Value = "Address")]
        Address,
        [EnumMember(Value = "AnnualRevenue")]
        AnnualRevenue,
        [EnumMember(Value = "City")]
        City,
        [EnumMember(Value = "CleanStatus")]
        CleanStatus,
        [EnumMember(Value = "Company")]
        Company,
        [EnumMember(Value = "CompanyDunsNumber")]
        CompanyDunsNumber,
        [EnumMember(Value = "Country")]
        Country,
        [EnumMember(Value = "created")]
        created,
        [EnumMember(Value = "CurrentGenerators__c")]
        CurrentGeneratorsc,
        [EnumMember(Value = "DandbCompany")]
        DandbCompany,
        [EnumMember(Value = "Description")]
        Description,
        [EnumMember(Value = "DoNotCall")]
        DoNotCall,
        [EnumMember(Value = "Email")]
        Email,
        [EnumMember(Value = "EmailBouncedDate")]
        EmailBouncedDate,
        [EnumMember(Value = "EmailBouncedReason")]
        EmailBouncedReason,
        [EnumMember(Value = "Fax")]
        Fax,
        [EnumMember(Value = "feedEvent")]
        feedEvent,
        [EnumMember(Value = "FirstName")]
        FirstName,
        [EnumMember(Value = "GeocodeAccuracy")]
        GeocodeAccuracy,
        [EnumMember(Value = "HasOptedOutOfEmail")]
        HasOptedOutOfEmail,
        [EnumMember(Value = "HasOptedOutOfFax")]
        HasOptedOutOfFax,
        [EnumMember(Value = "Industry")]
        Industry,
        [EnumMember(Value = "IsUnreadByOwner")]
        IsUnreadByOwner,
        [EnumMember(Value = "Jigsaw")]
        Jigsaw,
        [EnumMember(Value = "LastName")]
        LastName,
        [EnumMember(Value = "Latitude")]
        Latitude,
        [EnumMember(Value = "leadConverted")]
        leadConverted,
        [EnumMember(Value = "leadMerged")]
        leadMerged,
        [EnumMember(Value = "LeadSource")]
        LeadSource,
        [EnumMember(Value = "Longitude")]
        Longitude,
        [EnumMember(Value = "MobilePhone")]
        MobilePhone,
        [EnumMember(Value = "Name")]
        Name,
        [EnumMember(Value = "NumberOfEmployees")]
        NumberOfEmployees,
        [EnumMember(Value = "NumberofLocations__c")]
        NumberofLocationsc,
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "ownerAccepted")]
        ownerAccepted,
        [EnumMember(Value = "ownerAssignment")]
        ownerAssignment,
        [EnumMember(Value = "Phone")]
        Phone,
        [EnumMember(Value = "PostalCode")]
        PostalCode,
        [EnumMember(Value = "Primary__c")]
        Primaryc,
        [EnumMember(Value = "ProductInterest__c")]
        ProductInterestc,
        [EnumMember(Value = "Rating")]
        Rating,
        [EnumMember(Value = "locked")]
        locked,
        [EnumMember(Value = "unlocked")]
        unlocked,
        [EnumMember(Value = "Salutation")]
        Salutation,
        [EnumMember(Value = "SICCode__c")]
        SICCodec,
        [EnumMember(Value = "State")]
        State,
        [EnumMember(Value = "Status")]
        Status,
        [EnumMember(Value = "Street")]
        Street,
        [EnumMember(Value = "Title")]
        Title,
        [EnumMember(Value = "Website")]
        Website
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickLeadShareLeadAccessLevel
    {
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit,
        [EnumMember(Value = "All")]
        All
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickLeadShareRowCause
    {
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "Manual")]
        Manual,
        [EnumMember(Value = "Rule")]
        Rule,
        [EnumMember(Value = "ImplicitChild")]
        ImplicitChild,
        [EnumMember(Value = "ImplicitParent")]
        ImplicitParent,
        [EnumMember(Value = "ImplicitPerson")]
        ImplicitPerson,
        [EnumMember(Value = "Team")]
        Team,
        [EnumMember(Value = "Territory")]
        Territory,
        [EnumMember(Value = "TerritoryManual")]
        TerritoryManual,
        [EnumMember(Value = "TerritoryRule")]
        TerritoryRule,
        [EnumMember(Value = "Territory2Forecast")]
        Territory2Forecast
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickNameType
    {
        [EnumMember(Value = "Account")]
        Account,
        [EnumMember(Value = "AccountContactRole")]
        AccountContactRole,
        [EnumMember(Value = "Asset")]
        Asset,
        [EnumMember(Value = "Campaign")]
        Campaign,
        [EnumMember(Value = "Case")]
        Case,
        [EnumMember(Value = "CollaborationGroup")]
        CollaborationGroup,
        [EnumMember(Value = "Contact")]
        Contact,
        [EnumMember(Value = "ContentDocument")]
        ContentDocument,
        [EnumMember(Value = "ContentVersion")]
        ContentVersion,
        [EnumMember(Value = "Contract")]
        Contract,
        [EnumMember(Value = "Dashboard")]
        Dashboard,
        [EnumMember(Value = "Document")]
        Document,
        [EnumMember(Value = "EmailMessage")]
        EmailMessage,
        [EnumMember(Value = "Event")]
        Event,
        [EnumMember(Value = "Idea")]
        Idea,
        [EnumMember(Value = "IdeaComment")]
        IdeaComment,
        [EnumMember(Value = "Lead")]
        Lead,
        [EnumMember(Value = "Opportunity")]
        Opportunity,
        [EnumMember(Value = "Order")]
        Order,
        [EnumMember(Value = "OrderItem")]
        OrderItem,
        [EnumMember(Value = "Pricebook2")]
        Pricebook2,
        [EnumMember(Value = "Product2")]
        Product2,
        [EnumMember(Value = "Queue")]
        Queue,
        [EnumMember(Value = "Report")]
        Report,
        [EnumMember(Value = "SelfServiceUser")]
        SelfServiceUser,
        [EnumMember(Value = "Solution")]
        Solution,
        [EnumMember(Value = "Task")]
        Task,
        [EnumMember(Value = "User")]
        User
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickNewsFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpenActivityStatus
    {
        [EnumMember(Value = "Not Started")]
        NotStarted,
        [EnumMember(Value = "In Progress")]
        InProgress,
        [EnumMember(Value = "Completed")]
        Completed,
        [EnumMember(Value = "Waiting on someone else")]
        Waitingonsomeoneelse,
        [EnumMember(Value = "Deferred")]
        Deferred
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpenActivityPriority
    {
        [EnumMember(Value = "High")]
        High,
        [EnumMember(Value = "Normal")]
        Normal,
        [EnumMember(Value = "Low")]
        Low
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpenActivityActivityType
    {
        [EnumMember(Value = "Call")]
        Call,
        [EnumMember(Value = "Email")]
        Email,
        [EnumMember(Value = "Meeting")]
        Meeting,
        [EnumMember(Value = "Other")]
        Other
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpenActivityCallType
    {
        [EnumMember(Value = "Internal")]
        Internal,
        [EnumMember(Value = "Inbound")]
        Inbound,
        [EnumMember(Value = "Outbound")]
        Outbound
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpportunityStageName
    {
        [EnumMember(Value = "Prospecting")]
        Prospecting,
        [EnumMember(Value = "Qualification")]
        Qualification,
        [EnumMember(Value = "Needs Analysis")]
        NeedsAnalysis,
        [EnumMember(Value = "Value Proposition")]
        ValueProposition,
        [EnumMember(Value = "Id. Decision Makers")]
        IdDecisionMakers,
        [EnumMember(Value = "Perception Analysis")]
        PerceptionAnalysis,
        [EnumMember(Value = "Proposal/Price Quote")]
        ProposalPriceQuote,
        [EnumMember(Value = "Negotiation/Review")]
        NegotiationReview,
        [EnumMember(Value = "Closed Won")]
        ClosedWon,
        [EnumMember(Value = "Closed Lost")]
        ClosedLost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpportunityType
    {
        [EnumMember(Value = "Existing Customer - Upgrade")]
        ExistingCustomerUpgrade,
        [EnumMember(Value = "Existing Customer - Replacement")]
        ExistingCustomerReplacement,
        [EnumMember(Value = "Existing Customer - Downgrade")]
        ExistingCustomerDowngrade,
        [EnumMember(Value = "New Customer")]
        NewCustomer
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpportunityLeadSource
    {
        [EnumMember(Value = "Web")]
        Web,
        [EnumMember(Value = "Phone Inquiry")]
        PhoneInquiry,
        [EnumMember(Value = "Partner Referral")]
        PartnerReferral,
        [EnumMember(Value = "Purchased List")]
        PurchasedList,
        [EnumMember(Value = "Other")]
        Other
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpportunityForecastCategory
    {
        [EnumMember(Value = "Omitted")]
        Omitted,
        [EnumMember(Value = "Pipeline")]
        Pipeline,
        [EnumMember(Value = "BestCase")]
        BestCase,
        [EnumMember(Value = "Forecast")]
        Forecast,
        [EnumMember(Value = "Closed")]
        Closed
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpportunityForecastCategoryName
    {
        [EnumMember(Value = "Omitted")]
        Omitted,
        [EnumMember(Value = "Pipeline")]
        Pipeline,
        [EnumMember(Value = "Best Case")]
        BestCase,
        [EnumMember(Value = "Commit")]
        Commit,
        [EnumMember(Value = "Closed")]
        Closed
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpportunityDeliveryInstallationStatus__c
    {
        [EnumMember(Value = "In progress")]
        Inprogress,
        [EnumMember(Value = "Yet to begin")]
        Yettobegin,
        [EnumMember(Value = "Completed")]
        Completed
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpportunityContactRoleRole
    {
        [EnumMember(Value = "Business User")]
        BusinessUser,
        [EnumMember(Value = "Decision Maker")]
        DecisionMaker,
        [EnumMember(Value = "Economic Buyer")]
        EconomicBuyer,
        [EnumMember(Value = "Economic Decision Maker")]
        EconomicDecisionMaker,
        [EnumMember(Value = "Evaluator")]
        Evaluator,
        [EnumMember(Value = "Executive Sponsor")]
        ExecutiveSponsor,
        [EnumMember(Value = "Influencer")]
        Influencer,
        [EnumMember(Value = "Technical Buyer")]
        TechnicalBuyer,
        [EnumMember(Value = "Other")]
        Other
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpportunityFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpportunityFieldHistoryField
    {
        [EnumMember(Value = "Account")]
        Account,
        [EnumMember(Value = "Amount")]
        Amount,
        [EnumMember(Value = "Campaign")]
        Campaign,
        [EnumMember(Value = "CloseDate")]
        CloseDate,
        [EnumMember(Value = "Contract")]
        Contract,
        [EnumMember(Value = "created")]
        created,
        [EnumMember(Value = "opportunityCreatedFromLead")]
        opportunityCreatedFromLead,
        [EnumMember(Value = "CurrentGenerators__c")]
        CurrentGeneratorsc,
        [EnumMember(Value = "DeliveryInstallationStatus__c")]
        DeliveryInstallationStatusc,
        [EnumMember(Value = "Description")]
        Description,
        [EnumMember(Value = "feedEvent")]
        feedEvent,
        [EnumMember(Value = "ForecastCategoryName")]
        ForecastCategoryName,
        [EnumMember(Value = "IsPrivate")]
        IsPrivate,
        [EnumMember(Value = "LeadSource")]
        LeadSource,
        [EnumMember(Value = "MainCompetitors__c")]
        MainCompetitorsc,
        [EnumMember(Value = "Name")]
        Name,
        [EnumMember(Value = "NextStep")]
        NextStep,
        [EnumMember(Value = "OrderNumber__c")]
        OrderNumberc,
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "ownerAccepted")]
        ownerAccepted,
        [EnumMember(Value = "ownerAssignment")]
        ownerAssignment,
        [EnumMember(Value = "Probability")]
        Probability,
        [EnumMember(Value = "locked")]
        locked,
        [EnumMember(Value = "unlocked")]
        unlocked,
        [EnumMember(Value = "StageName")]
        StageName,
        [EnumMember(Value = "TotalOpportunityQuantity")]
        TotalOpportunityQuantity,
        [EnumMember(Value = "TrackingNumber__c")]
        TrackingNumberc,
        [EnumMember(Value = "Type")]
        Type
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpportunityHistoryStageName
    {
        [EnumMember(Value = "Prospecting")]
        Prospecting,
        [EnumMember(Value = "Qualification")]
        Qualification,
        [EnumMember(Value = "Needs Analysis")]
        NeedsAnalysis,
        [EnumMember(Value = "Value Proposition")]
        ValueProposition,
        [EnumMember(Value = "Id. Decision Makers")]
        IdDecisionMakers,
        [EnumMember(Value = "Perception Analysis")]
        PerceptionAnalysis,
        [EnumMember(Value = "Proposal/Price Quote")]
        ProposalPriceQuote,
        [EnumMember(Value = "Negotiation/Review")]
        NegotiationReview,
        [EnumMember(Value = "Closed Won")]
        ClosedWon,
        [EnumMember(Value = "Closed Lost")]
        ClosedLost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpportunityHistoryForecastCategory
    {
        [EnumMember(Value = "Omitted")]
        Omitted,
        [EnumMember(Value = "Pipeline")]
        Pipeline,
        [EnumMember(Value = "BestCase")]
        BestCase,
        [EnumMember(Value = "Forecast")]
        Forecast,
        [EnumMember(Value = "Closed")]
        Closed
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpportunityPartnerRole
    {
        [EnumMember(Value = "System Integrator")]
        SystemIntegrator,
        [EnumMember(Value = "Agency")]
        Agency,
        [EnumMember(Value = "Advertiser")]
        Advertiser,
        [EnumMember(Value = "VAR/Reseller")]
        VARReseller,
        [EnumMember(Value = "Distributor")]
        Distributor,
        [EnumMember(Value = "Developer")]
        Developer,
        [EnumMember(Value = "Broker")]
        Broker,
        [EnumMember(Value = "Lender")]
        Lender,
        [EnumMember(Value = "Supplier")]
        Supplier,
        [EnumMember(Value = "Institution")]
        Institution,
        [EnumMember(Value = "Contractor")]
        Contractor,
        [EnumMember(Value = "Dealer")]
        Dealer,
        [EnumMember(Value = "Consultant")]
        Consultant
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpportunityShareOpportunityAccessLevel
    {
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit,
        [EnumMember(Value = "All")]
        All
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpportunityShareRowCause
    {
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "Manual")]
        Manual,
        [EnumMember(Value = "Rule")]
        Rule,
        [EnumMember(Value = "ImplicitChild")]
        ImplicitChild,
        [EnumMember(Value = "ImplicitParent")]
        ImplicitParent,
        [EnumMember(Value = "ImplicitPerson")]
        ImplicitPerson,
        [EnumMember(Value = "Team")]
        Team,
        [EnumMember(Value = "Territory")]
        Territory,
        [EnumMember(Value = "TerritoryManual")]
        TerritoryManual,
        [EnumMember(Value = "TerritoryRule")]
        TerritoryRule,
        [EnumMember(Value = "Territory2Forecast")]
        Territory2Forecast
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpportunityStageForecastCategory
    {
        [EnumMember(Value = "Omitted")]
        Omitted,
        [EnumMember(Value = "Pipeline")]
        Pipeline,
        [EnumMember(Value = "BestCase")]
        BestCase,
        [EnumMember(Value = "Forecast")]
        Forecast,
        [EnumMember(Value = "Closed")]
        Closed
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOpportunityStageForecastCategoryName
    {
        [EnumMember(Value = "Omitted")]
        Omitted,
        [EnumMember(Value = "Pipeline")]
        Pipeline,
        [EnumMember(Value = "Best Case")]
        BestCase,
        [EnumMember(Value = "Commit")]
        Commit,
        [EnumMember(Value = "Closed")]
        Closed
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOrderStatus
    {
        [EnumMember(Value = "Draft")]
        Draft,
        [EnumMember(Value = "Activated")]
        Activated
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOrderType
    {

    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOrderStatusCode
    {
        [EnumMember(Value = "D")]
        D,
        [EnumMember(Value = "A")]
        A,
        [EnumMember(Value = "C")]
        C,
        [EnumMember(Value = "E")]
        E
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOrderHistoryField
    {
        [EnumMember(Value = "Account")]
        Account,
        [EnumMember(Value = "ActivatedBy")]
        ActivatedBy,
        [EnumMember(Value = "ActivatedDate")]
        ActivatedDate,
        [EnumMember(Value = "BillingAddress")]
        BillingAddress,
        [EnumMember(Value = "BillingCity")]
        BillingCity,
        [EnumMember(Value = "BillingCountry")]
        BillingCountry,
        [EnumMember(Value = "BillingGeocodeAccuracy")]
        BillingGeocodeAccuracy,
        [EnumMember(Value = "BillingLatitude")]
        BillingLatitude,
        [EnumMember(Value = "BillingLongitude")]
        BillingLongitude,
        [EnumMember(Value = "BillingPostalCode")]
        BillingPostalCode,
        [EnumMember(Value = "BillingState")]
        BillingState,
        [EnumMember(Value = "BillingStreet")]
        BillingStreet,
        [EnumMember(Value = "BillToContact")]
        BillToContact,
        [EnumMember(Value = "CompanyAuthorizedBy")]
        CompanyAuthorizedBy,
        [EnumMember(Value = "CompanyAuthorizedDate")]
        CompanyAuthorizedDate,
        [EnumMember(Value = "Contract")]
        Contract,
        [EnumMember(Value = "created")]
        created,
        [EnumMember(Value = "CustomerAuthorizedBy")]
        CustomerAuthorizedBy,
        [EnumMember(Value = "CustomerAuthorizedDate")]
        CustomerAuthorizedDate,
        [EnumMember(Value = "Description")]
        Description,
        [EnumMember(Value = "EffectiveDate")]
        EffectiveDate,
        [EnumMember(Value = "EndDate")]
        EndDate,
        [EnumMember(Value = "feedEvent")]
        feedEvent,
        [EnumMember(Value = "Name")]
        Name,
        [EnumMember(Value = "Opportunity")]
        Opportunity,
        [EnumMember(Value = "orderActivated")]
        orderActivated,
        [EnumMember(Value = "orderApproved")]
        orderApproved,
        [EnumMember(Value = "orderCancelled")]
        orderCancelled,
        [EnumMember(Value = "orderDeactivated")]
        orderDeactivated,
        [EnumMember(Value = "orderExpired")]
        orderExpired,
        [EnumMember(Value = "OrderReferenceNumber")]
        OrderReferenceNumber,
        [EnumMember(Value = "orderSubmitted")]
        orderSubmitted,
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "ownerAccepted")]
        ownerAccepted,
        [EnumMember(Value = "ownerAssignment")]
        ownerAssignment,
        [EnumMember(Value = "PoDate")]
        PoDate,
        [EnumMember(Value = "PoNumber")]
        PoNumber,
        [EnumMember(Value = "Pricebook2")]
        Pricebook2,
        [EnumMember(Value = "locked")]
        locked,
        [EnumMember(Value = "unlocked")]
        unlocked,
        [EnumMember(Value = "ShippingAddress")]
        ShippingAddress,
        [EnumMember(Value = "ShippingCity")]
        ShippingCity,
        [EnumMember(Value = "ShippingCountry")]
        ShippingCountry,
        [EnumMember(Value = "ShippingGeocodeAccuracy")]
        ShippingGeocodeAccuracy,
        [EnumMember(Value = "ShippingLatitude")]
        ShippingLatitude,
        [EnumMember(Value = "ShippingLongitude")]
        ShippingLongitude,
        [EnumMember(Value = "ShippingPostalCode")]
        ShippingPostalCode,
        [EnumMember(Value = "ShippingState")]
        ShippingState,
        [EnumMember(Value = "ShippingStreet")]
        ShippingStreet,
        [EnumMember(Value = "ShipToContact")]
        ShipToContact,
        [EnumMember(Value = "Status")]
        Status,
        [EnumMember(Value = "StatusCode")]
        StatusCode,
        [EnumMember(Value = "Type")]
        Type
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOrganizationDefaultLocaleSidKey
    {
        [EnumMember(Value = "ar_BH")]
        arBH,
        [EnumMember(Value = "ar_EG")]
        arEG,
        [EnumMember(Value = "ar_JO")]
        arJO,
        [EnumMember(Value = "ar_KW")]
        arKW,
        [EnumMember(Value = "ar_LB")]
        arLB,
        [EnumMember(Value = "ar_SA")]
        arSA,
        [EnumMember(Value = "ar_AE")]
        arAE,
        [EnumMember(Value = "hy_AM")]
        hyAM,
        [EnumMember(Value = "bg_BG")]
        bgBG,
        [EnumMember(Value = "ca_ES")]
        caES,
        [EnumMember(Value = "zh_CN")]
        zhCN,
        [EnumMember(Value = "zh_HK")]
        zhHK,
        [EnumMember(Value = "zh_TW")]
        zhTW,
        [EnumMember(Value = "hr_HR")]
        hrHR,
        [EnumMember(Value = "cs_CZ")]
        csCZ,
        [EnumMember(Value = "da_DK")]
        daDK,
        [EnumMember(Value = "nl_BE")]
        nlBE,
        [EnumMember(Value = "nl_NL")]
        nlNL,
        [EnumMember(Value = "nl_SR")]
        nlSR,
        [EnumMember(Value = "en_AU")]
        enAU,
        [EnumMember(Value = "en_BB")]
        enBB,
        [EnumMember(Value = "en_BM")]
        enBM,
        [EnumMember(Value = "en_CA")]
        enCA,
        [EnumMember(Value = "en_GH")]
        enGH,
        [EnumMember(Value = "en_IN")]
        enIN,
        [EnumMember(Value = "en_ID")]
        enID,
        [EnumMember(Value = "en_IE")]
        enIE,
        [EnumMember(Value = "en_MY")]
        enMY,
        [EnumMember(Value = "en_NZ")]
        enNZ,
        [EnumMember(Value = "en_NG")]
        enNG,
        [EnumMember(Value = "en_PH")]
        enPH,
        [EnumMember(Value = "en_SG")]
        enSG,
        [EnumMember(Value = "en_ZA")]
        enZA,
        [EnumMember(Value = "en_GB")]
        enGB,
        [EnumMember(Value = "en_US")]
        enUS,
        [EnumMember(Value = "et_EE")]
        etEE,
        [EnumMember(Value = "fi_FI")]
        fiFI,
        [EnumMember(Value = "fr_BE")]
        frBE,
        [EnumMember(Value = "fr_CA")]
        frCA,
        [EnumMember(Value = "fr_FR")]
        frFR,
        [EnumMember(Value = "fr_LU")]
        frLU,
        [EnumMember(Value = "fr_MC")]
        frMC,
        [EnumMember(Value = "fr_CH")]
        frCH,
        [EnumMember(Value = "ka_GE")]
        kaGE,
        [EnumMember(Value = "de_AT")]
        deAT,
        [EnumMember(Value = "de_DE")]
        deDE,
        [EnumMember(Value = "de_LU")]
        deLU,
        [EnumMember(Value = "de_CH")]
        deCH,
        [EnumMember(Value = "el_GR")]
        elGR,
        [EnumMember(Value = "iw_IL")]
        iwIL,
        [EnumMember(Value = "is_IS")]
        isIS,
        [EnumMember(Value = "it_IT")]
        itIT,
        [EnumMember(Value = "it_CH")]
        itCH,
        [EnumMember(Value = "ja_JP")]
        jaJP,
        [EnumMember(Value = "kk_KZ")]
        kkKZ,
        [EnumMember(Value = "km_KH")]
        kmKH,
        [EnumMember(Value = "ko_KR")]
        koKR,
        [EnumMember(Value = "lv_LV")]
        lvLV,
        [EnumMember(Value = "lt_LT")]
        ltLT,
        [EnumMember(Value = "ms_MY")]
        msMY,
        [EnumMember(Value = "no_NO")]
        noNO,
        [EnumMember(Value = "pt_AO")]
        ptAO,
        [EnumMember(Value = "pt_BR")]
        ptBR,
        [EnumMember(Value = "pt_PT")]
        ptPT,
        [EnumMember(Value = "ro_RO")]
        roRO,
        [EnumMember(Value = "ru_RU")]
        ruRU,
        [EnumMember(Value = "sr_BA")]
        srBA,
        [EnumMember(Value = "sh_BA")]
        shBA,
        [EnumMember(Value = "sh_CS")]
        shCS,
        [EnumMember(Value = "sr_CS")]
        srCS,
        [EnumMember(Value = "sk_SK")]
        skSK,
        [EnumMember(Value = "sl_SI")]
        slSI,
        [EnumMember(Value = "es_AR")]
        esAR,
        [EnumMember(Value = "es_BO")]
        esBO,
        [EnumMember(Value = "es_CL")]
        esCL,
        [EnumMember(Value = "es_CO")]
        esCO,
        [EnumMember(Value = "es_CR")]
        esCR,
        [EnumMember(Value = "es_DO")]
        esDO,
        [EnumMember(Value = "es_EC")]
        esEC,
        [EnumMember(Value = "es_SV")]
        esSV,
        [EnumMember(Value = "es_GT")]
        esGT,
        [EnumMember(Value = "es_HN")]
        esHN,
        [EnumMember(Value = "es_MX")]
        esMX,
        [EnumMember(Value = "es_PA")]
        esPA,
        [EnumMember(Value = "es_PY")]
        esPY,
        [EnumMember(Value = "es_PE")]
        esPE,
        [EnumMember(Value = "es_PR")]
        esPR,
        [EnumMember(Value = "es_ES")]
        esES,
        [EnumMember(Value = "es_UY")]
        esUY,
        [EnumMember(Value = "es_VE")]
        esVE,
        [EnumMember(Value = "sv_SE")]
        svSE,
        [EnumMember(Value = "tl_PH")]
        tlPH,
        [EnumMember(Value = "th_TH")]
        thTH,
        [EnumMember(Value = "uk_UA")]
        ukUA,
        [EnumMember(Value = "ur_PK")]
        urPK,
        [EnumMember(Value = "vi_VN")]
        viVN
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOrganizationLanguageLocaleKey
    {
        [EnumMember(Value = "en_US")]
        enUS,
        [EnumMember(Value = "de")]
        de,
        [EnumMember(Value = "es")]
        es,
        [EnumMember(Value = "fr")]
        fr,
        [EnumMember(Value = "it")]
        it,
        [EnumMember(Value = "ja")]
        ja,
        [EnumMember(Value = "sv")]
        sv,
        [EnumMember(Value = "ko")]
        ko,
        [EnumMember(Value = "zh_TW")]
        zhTW,
        [EnumMember(Value = "zh_CN")]
        zhCN,
        [EnumMember(Value = "pt_BR")]
        ptBR,
        [EnumMember(Value = "nl_NL")]
        nlNL,
        [EnumMember(Value = "da")]
        da,
        [EnumMember(Value = "th")]
        th,
        [EnumMember(Value = "fi")]
        fi,
        [EnumMember(Value = "ru")]
        ru,
        [EnumMember(Value = "es_MX")]
        esMX,
        [EnumMember(Value = "no")]
        no
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOrganizationDefaultAccountAccess
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOrganizationDefaultContactAccess
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit,
        [EnumMember(Value = "ControlledByParent")]
        ControlledByParent
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOrganizationDefaultOpportunityAccess
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOrganizationDefaultLeadAccess
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit,
        [EnumMember(Value = "ReadEditTransfer")]
        ReadEditTransfer
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOrganizationDefaultCaseAccess
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit,
        [EnumMember(Value = "ReadEditTransfer")]
        ReadEditTransfer
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOrganizationDefaultCalendarAccess
    {
        [EnumMember(Value = "HideDetails")]
        HideDetails,
        [EnumMember(Value = "HideDetailsInsert")]
        HideDetailsInsert,
        [EnumMember(Value = "ShowDetails")]
        ShowDetails,
        [EnumMember(Value = "ShowDetailsInsert")]
        ShowDetailsInsert,
        [EnumMember(Value = "AllowEdits")]
        AllowEdits
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOrganizationDefaultPricebookAccess
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "ReadSelect")]
        ReadSelect
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOrganizationDefaultCampaignAccess
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit,
        [EnumMember(Value = "All")]
        All
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOrganizationUiSkin
    {
        [EnumMember(Value = "Theme1")]
        Theme1,
        [EnumMember(Value = "Theme2")]
        Theme2,
        [EnumMember(Value = "PortalDefault")]
        PortalDefault,
        [EnumMember(Value = "Webstore")]
        Webstore,
        [EnumMember(Value = "Theme3")]
        Theme3
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickOrganizationOrganizationType
    {
        [EnumMember(Value = "Team Edition")]
        TeamEdition,
        [EnumMember(Value = "Professional Edition")]
        ProfessionalEdition,
        [EnumMember(Value = "Enterprise Edition")]
        EnterpriseEdition,
        [EnumMember(Value = "Developer Edition")]
        DeveloperEdition,
        [EnumMember(Value = "Personal Edition")]
        PersonalEdition,
        [EnumMember(Value = "Unlimited Edition")]
        UnlimitedEdition,
        [EnumMember(Value = "Contact Manager Edition")]
        ContactManagerEdition,
        [EnumMember(Value = "Base Edition")]
        BaseEdition
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickPartnerRole
    {
        [EnumMember(Value = "System Integrator")]
        SystemIntegrator,
        [EnumMember(Value = "Agency")]
        Agency,
        [EnumMember(Value = "Advertiser")]
        Advertiser,
        [EnumMember(Value = "VAR/Reseller")]
        VARReseller,
        [EnumMember(Value = "Distributor")]
        Distributor,
        [EnumMember(Value = "Developer")]
        Developer,
        [EnumMember(Value = "Broker")]
        Broker,
        [EnumMember(Value = "Lender")]
        Lender,
        [EnumMember(Value = "Supplier")]
        Supplier,
        [EnumMember(Value = "Institution")]
        Institution,
        [EnumMember(Value = "Contractor")]
        Contractor,
        [EnumMember(Value = "Dealer")]
        Dealer,
        [EnumMember(Value = "Consultant")]
        Consultant
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickPartnerRoleReverseRole
    {
        [EnumMember(Value = "System Integrator")]
        SystemIntegrator,
        [EnumMember(Value = "Agency")]
        Agency,
        [EnumMember(Value = "Advertiser")]
        Advertiser,
        [EnumMember(Value = "VAR/Reseller")]
        VARReseller,
        [EnumMember(Value = "Distributor")]
        Distributor,
        [EnumMember(Value = "Developer")]
        Developer,
        [EnumMember(Value = "Broker")]
        Broker,
        [EnumMember(Value = "Lender")]
        Lender,
        [EnumMember(Value = "Supplier")]
        Supplier,
        [EnumMember(Value = "Institution")]
        Institution,
        [EnumMember(Value = "Contractor")]
        Contractor,
        [EnumMember(Value = "Dealer")]
        Dealer,
        [EnumMember(Value = "Consultant")]
        Consultant
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickPeriodType
    {
        [EnumMember(Value = "Month")]
        Month,
        [EnumMember(Value = "Quarter")]
        Quarter,
        [EnumMember(Value = "Week")]
        Week,
        [EnumMember(Value = "Year")]
        Year
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickPeriodQuarterLabel
    {
        [EnumMember(Value = "Spring")]
        Spring,
        [EnumMember(Value = "Summer")]
        Summer,
        [EnumMember(Value = "Fall")]
        Fall,
        [EnumMember(Value = "Winter")]
        Winter
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickPeriodPeriodLabel
    {

    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickPricebook2HistoryField
    {
        [EnumMember(Value = "created")]
        created,
        [EnumMember(Value = "Description")]
        Description,
        [EnumMember(Value = "feedEvent")]
        feedEvent,
        [EnumMember(Value = "IsActive")]
        IsActive,
        [EnumMember(Value = "IsArchived")]
        IsArchived,
        [EnumMember(Value = "IsStandard")]
        IsStandard,
        [EnumMember(Value = "Name")]
        Name,
        [EnumMember(Value = "ownerAccepted")]
        ownerAccepted,
        [EnumMember(Value = "ownerAssignment")]
        ownerAssignment,
        [EnumMember(Value = "locked")]
        locked,
        [EnumMember(Value = "unlocked")]
        unlocked
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickProcessDefinitionType
    {
        [EnumMember(Value = "Approval")]
        Approval,
        [EnumMember(Value = "State")]
        State
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickProcessDefinitionTableEnumOrId
    {
        [EnumMember(Value = "Account")]
        Account,
        [EnumMember(Value = "Asset")]
        Asset,
        [EnumMember(Value = "AssistantProgress")]
        AssistantProgress,
        [EnumMember(Value = "Campaign")]
        Campaign,
        [EnumMember(Value = "Case")]
        Case,
        [EnumMember(Value = "Contact")]
        Contact,
        [EnumMember(Value = "Contract")]
        Contract,
        [EnumMember(Value = "DuplicateRecordItem")]
        DuplicateRecordItem,
        [EnumMember(Value = "DuplicateRecordSet")]
        DuplicateRecordSet,
        [EnumMember(Value = "EmailMessage")]
        EmailMessage,
        [EnumMember(Value = "ExchangeUserMapping")]
        ExchangeUserMapping,
        [EnumMember(Value = "Goal")]
        Goal,
        [EnumMember(Value = "KnowledgeArticle")]
        KnowledgeArticle,
        [EnumMember(Value = "KnowledgeArticleVersion")]
        KnowledgeArticleVersion,
        [EnumMember(Value = "Lead")]
        Lead,
        [EnumMember(Value = "Metric")]
        Metric,
        [EnumMember(Value = "Opportunity")]
        Opportunity,
        [EnumMember(Value = "Order")]
        Order,
        [EnumMember(Value = "Product2")]
        Product2,
        [EnumMember(Value = "Solution")]
        Solution,
        [EnumMember(Value = "StreamingChannel")]
        StreamingChannel,
        [EnumMember(Value = "UserProvisioningRequest")]
        UserProvisioningRequest,
        [EnumMember(Value = "WorkCoaching")]
        WorkCoaching,
        [EnumMember(Value = "WorkFeedback")]
        WorkFeedback,
        [EnumMember(Value = "WorkFeedbackQuestion")]
        WorkFeedbackQuestion,
        [EnumMember(Value = "WorkFeedbackQuestionSet")]
        WorkFeedbackQuestionSet,
        [EnumMember(Value = "WorkFeedbackRequest")]
        WorkFeedbackRequest,
        [EnumMember(Value = "WorkFeedbackTemplate")]
        WorkFeedbackTemplate,
        [EnumMember(Value = "WorkPerformanceCycle")]
        WorkPerformanceCycle
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickProcessDefinitionLockType
    {
        [EnumMember(Value = "Total")]
        Total,
        [EnumMember(Value = "Admin")]
        Admin,
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "Workitem")]
        Workitem,
        [EnumMember(Value = "Node")]
        Node,
        [EnumMember(Value = "none")]
        none
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickProcessDefinitionState
    {
        [EnumMember(Value = "Active")]
        Active,
        [EnumMember(Value = "Inactive")]
        Inactive,
        [EnumMember(Value = "Obsolete")]
        Obsolete
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickProcessInstanceStatus
    {
        [EnumMember(Value = "Approved")]
        Approved,
        [EnumMember(Value = "Rejected")]
        Rejected,
        [EnumMember(Value = "Removed")]
        Removed,
        [EnumMember(Value = "Fault")]
        Fault,
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Held")]
        Held,
        [EnumMember(Value = "Reassigned")]
        Reassigned,
        [EnumMember(Value = "Started")]
        Started,
        [EnumMember(Value = "NoResponse")]
        NoResponse
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickProcessInstanceHistoryStepStatus
    {
        [EnumMember(Value = "Approved")]
        Approved,
        [EnumMember(Value = "Rejected")]
        Rejected,
        [EnumMember(Value = "Removed")]
        Removed,
        [EnumMember(Value = "Fault")]
        Fault,
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Held")]
        Held,
        [EnumMember(Value = "Reassigned")]
        Reassigned,
        [EnumMember(Value = "Started")]
        Started,
        [EnumMember(Value = "NoResponse")]
        NoResponse
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickProcessInstanceStepStepStatus
    {
        [EnumMember(Value = "Approved")]
        Approved,
        [EnumMember(Value = "Rejected")]
        Rejected,
        [EnumMember(Value = "Removed")]
        Removed,
        [EnumMember(Value = "Fault")]
        Fault,
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Held")]
        Held,
        [EnumMember(Value = "Reassigned")]
        Reassigned,
        [EnumMember(Value = "Started")]
        Started,
        [EnumMember(Value = "NoResponse")]
        NoResponse
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickProduct2Family
    {
        [EnumMember(Value = "None")]
        None
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickProduct2FeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickProfileUserType
    {
        [EnumMember(Value = "Standard")]
        Standard,
        [EnumMember(Value = "PowerPartner")]
        PowerPartner,
        [EnumMember(Value = "PowerCustomerSuccess")]
        PowerCustomerSuccess,
        [EnumMember(Value = "CustomerSuccess")]
        CustomerSuccess,
        [EnumMember(Value = "Guest")]
        Guest,
        [EnumMember(Value = "CSPLitePortal")]
        CSPLitePortal,
        [EnumMember(Value = "CSNOnly")]
        CSNOnly,
        [EnumMember(Value = "SelfService")]
        SelfService
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickQueueSobjectSobjectType
    {
        [EnumMember(Value = "Case")]
        Case,
        [EnumMember(Value = "Goal")]
        Goal,
        [EnumMember(Value = "Lead")]
        Lead,
        [EnumMember(Value = "Macro")]
        Macro,
        [EnumMember(Value = "Metric")]
        Metric,
        [EnumMember(Value = "Order")]
        Order,
        [EnumMember(Value = "UserProvisioningRequest")]
        UserProvisioningRequest,
        [EnumMember(Value = "WorkCoaching")]
        WorkCoaching,
        [EnumMember(Value = "WorkFeedback")]
        WorkFeedback,
        [EnumMember(Value = "WorkFeedbackQuestion")]
        WorkFeedbackQuestion,
        [EnumMember(Value = "WorkFeedbackQuestionSet")]
        WorkFeedbackQuestionSet,
        [EnumMember(Value = "WorkFeedbackRequest")]
        WorkFeedbackRequest,
        [EnumMember(Value = "WorkFeedbackTemplate")]
        WorkFeedbackTemplate,
        [EnumMember(Value = "WorkPerformanceCycle")]
        WorkPerformanceCycle
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickRecordTypeSobjectType
    {
        [EnumMember(Value = "Account")]
        Account,
        [EnumMember(Value = "Announcement")]
        Announcement,
        [EnumMember(Value = "AssistantProgress")]
        AssistantProgress,
        [EnumMember(Value = "Campaign")]
        Campaign,
        [EnumMember(Value = "CampaignMember")]
        CampaignMember,
        [EnumMember(Value = "Case")]
        Case,
        [EnumMember(Value = "CollaborationGroupRecord")]
        CollaborationGroupRecord,
        [EnumMember(Value = "Contact")]
        Contact,
        [EnumMember(Value = "ContentVersion")]
        ContentVersion,
        [EnumMember(Value = "Contract")]
        Contract,
        [EnumMember(Value = "DuplicateErrorLog")]
        DuplicateErrorLog,
        [EnumMember(Value = "DuplicateRecordItem")]
        DuplicateRecordItem,
        [EnumMember(Value = "DuplicateRecordSet")]
        DuplicateRecordSet,
        [EnumMember(Value = "Event")]
        Event,
        [EnumMember(Value = "FileSearchActivity")]
        FileSearchActivity,
        [EnumMember(Value = "Goal")]
        Goal,
        [EnumMember(Value = "GoalLink")]
        GoalLink,
        [EnumMember(Value = "Idea")]
        Idea,
        [EnumMember(Value = "InboundSocialPost")]
        InboundSocialPost,
        [EnumMember(Value = "Lead")]
        Lead,
        [EnumMember(Value = "Macro")]
        Macro,
        [EnumMember(Value = "MacroAction")]
        MacroAction,
        [EnumMember(Value = "MacroInstruction")]
        MacroInstruction,
        [EnumMember(Value = "Metric")]
        Metric,
        [EnumMember(Value = "MetricDataLink")]
        MetricDataLink,
        [EnumMember(Value = "Opportunity")]
        Opportunity,
        [EnumMember(Value = "Order")]
        Order,
        [EnumMember(Value = "Pricebook2")]
        Pricebook2,
        [EnumMember(Value = "Product2")]
        Product2,
        [EnumMember(Value = "RecordOrigin")]
        RecordOrigin,
        [EnumMember(Value = "SearchActivity")]
        SearchActivity,
        [EnumMember(Value = "SearchPromotionRule")]
        SearchPromotionRule,
        [EnumMember(Value = "SetupAssistantAnswer")]
        SetupAssistantAnswer,
        [EnumMember(Value = "Solution")]
        Solution,
        [EnumMember(Value = "Task")]
        Task,
        [EnumMember(Value = "TransactionSecurityAction")]
        TransactionSecurityAction,
        [EnumMember(Value = "TransactionSecurityActionEvent")]
        TransactionSecurityActionEvent,
        [EnumMember(Value = "WorkCoaching")]
        WorkCoaching,
        [EnumMember(Value = "WorkFeedback")]
        WorkFeedback,
        [EnumMember(Value = "WorkFeedbackQuestion")]
        WorkFeedbackQuestion,
        [EnumMember(Value = "WorkFeedbackQuestionSet")]
        WorkFeedbackQuestionSet,
        [EnumMember(Value = "WorkFeedbackRequest")]
        WorkFeedbackRequest,
        [EnumMember(Value = "WorkFeedbackTemplate")]
        WorkFeedbackTemplate,
        [EnumMember(Value = "WorkPerformanceCycle")]
        WorkPerformanceCycle
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickReportFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickSiteStatus
    {
        [EnumMember(Value = "Active")]
        Active,
        [EnumMember(Value = "Inactive")]
        Inactive
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickSiteFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickSiteHistoryField
    {
        [EnumMember(Value = "siteActive")]
        siteActive,
        [EnumMember(Value = "Admin")]
        Admin,
        [EnumMember(Value = "AnalyticsTrackingCode")]
        AnalyticsTrackingCode,
        [EnumMember(Value = "siteOverride401")]
        siteOverride401,
        [EnumMember(Value = "siteOverrideChangePassword")]
        siteOverrideChangePassword,
        [EnumMember(Value = "ClickjackProtectionLevel")]
        ClickjackProtectionLevel,
        [EnumMember(Value = "created")]
        created,
        [EnumMember(Value = "SiteDeleteDomain")]
        SiteDeleteDomain,
        [EnumMember(Value = "siteNewDomain")]
        siteNewDomain,
        [EnumMember(Value = "DefaultDomain")]
        DefaultDomain,
        [EnumMember(Value = "siteSetPrimaryDomain")]
        siteSetPrimaryDomain,
        [EnumMember(Value = "Description")]
        Description,
        [EnumMember(Value = "siteBTDisabled")]
        siteBTDisabled,
        [EnumMember(Value = "siteEnableFeeds")]
        siteEnableFeeds,
        [EnumMember(Value = "siteAllowStandardAnswersPages")]
        siteAllowStandardAnswersPages,
        [EnumMember(Value = "siteAllowHomePage")]
        siteAllowHomePage,
        [EnumMember(Value = "siteAllowStandardIdeasPages")]
        siteAllowStandardIdeasPages,
        [EnumMember(Value = "siteAllowStandardSearch")]
        siteAllowStandardSearch,
        [EnumMember(Value = "siteAllowStandardLookups")]
        siteAllowStandardLookups,
        [EnumMember(Value = "FavoriteIcon")]
        FavoriteIcon,
        [EnumMember(Value = "feedEvent")]
        feedEvent,
        [EnumMember(Value = "siteOverrideForgotPassword")]
        siteOverrideForgotPassword,
        [EnumMember(Value = "siteOverride500")]
        siteOverride500,
        [EnumMember(Value = "GuestUser")]
        GuestUser,
        [EnumMember(Value = "Guid")]
        Guid,
        [EnumMember(Value = "siteOverrideInactive")]
        siteOverrideInactive,
        [EnumMember(Value = "IndexPage")]
        IndexPage,
        [EnumMember(Value = "Language")]
        Language,
        [EnumMember(Value = "siteOverride509")]
        siteOverride509,
        [EnumMember(Value = "siteOverride503")]
        siteOverride503,
        [EnumMember(Value = "MasterLabel")]
        MasterLabel,
        [EnumMember(Value = "sitePageLimitExceeded")]
        sitePageLimitExceeded,
        [EnumMember(Value = "siteOverrideMyProfile")]
        siteOverrideMyProfile,
        [EnumMember(Value = "Name")]
        Name,
        [EnumMember(Value = "NewPassTemplate")]
        NewPassTemplate,
        [EnumMember(Value = "NewUserTemplate")]
        NewUserTemplate,
        [EnumMember(Value = "Options")]
        Options,
        [EnumMember(Value = "ownerAccepted")]
        ownerAccepted,
        [EnumMember(Value = "ownerAssignment")]
        ownerAssignment,
        [EnumMember(Value = "siteOverride404")]
        siteOverride404,
        [EnumMember(Value = "Portal")]
        Portal,
        [EnumMember(Value = "locked")]
        locked,
        [EnumMember(Value = "unlocked")]
        unlocked,
        [EnumMember(Value = "siteNewRedirect")]
        siteNewRedirect,
        [EnumMember(Value = "siteDeleteRedirect")]
        siteDeleteRedirect,
        [EnumMember(Value = "siteChangeRedirect")]
        siteChangeRedirect,
        [EnumMember(Value = "siteRequireInsecurePortalAccess")]
        siteRequireInsecurePortalAccess,
        [EnumMember(Value = "siteRequireHttps")]
        siteRequireHttps,
        [EnumMember(Value = "siteOverrideSelfReg")]
        siteOverrideSelfReg,
        [EnumMember(Value = "ServerIsDown")]
        ServerIsDown,
        [EnumMember(Value = "siteOverrideRobotsTxt")]
        siteOverrideRobotsTxt,
        [EnumMember(Value = "siteOverrideTemplate")]
        siteOverrideTemplate,
        [EnumMember(Value = "SiteType")]
        SiteType,
        [EnumMember(Value = "Status")]
        Status,
        [EnumMember(Value = "Subdomain")]
        Subdomain,
        [EnumMember(Value = "TopLevelDomain")]
        TopLevelDomain,
        [EnumMember(Value = "UrlPathPrefix")]
        UrlPathPrefix,
        [EnumMember(Value = "UrlRewriterClass")]
        UrlRewriterClass
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickSolutionStatus
    {
        [EnumMember(Value = "Draft")]
        Draft,
        [EnumMember(Value = "Reviewed")]
        Reviewed,
        [EnumMember(Value = "Duplicate")]
        Duplicate
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickSolutionFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickSolutionHistoryField
    {
        [EnumMember(Value = "created")]
        created,
        [EnumMember(Value = "feedEvent")]
        feedEvent,
        [EnumMember(Value = "IsPublished")]
        IsPublished,
        [EnumMember(Value = "IsPublishedInPublicKb")]
        IsPublishedInPublicKb,
        [EnumMember(Value = "ownerAccepted")]
        ownerAccepted,
        [EnumMember(Value = "ownerAssignment")]
        ownerAssignment,
        [EnumMember(Value = "locked")]
        locked,
        [EnumMember(Value = "unlocked")]
        unlocked,
        [EnumMember(Value = "SolutionName")]
        SolutionName,
        [EnumMember(Value = "SolutionNote")]
        SolutionNote,
        [EnumMember(Value = "Status")]
        Status
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickStaticResourceCacheControl
    {
        [EnumMember(Value = "Private")]
        Private,
        [EnumMember(Value = "Public")]
        Public
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickTaskStatus
    {
        [EnumMember(Value = "Not Started")]
        NotStarted,
        [EnumMember(Value = "In Progress")]
        InProgress,
        [EnumMember(Value = "Completed")]
        Completed,
        [EnumMember(Value = "Waiting on someone else")]
        Waitingonsomeoneelse,
        [EnumMember(Value = "Deferred")]
        Deferred
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickTaskPriority
    {
        [EnumMember(Value = "High")]
        High,
        [EnumMember(Value = "Normal")]
        Normal,
        [EnumMember(Value = "Low")]
        Low
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickTaskCallType
    {
        [EnumMember(Value = "Internal")]
        Internal,
        [EnumMember(Value = "Inbound")]
        Inbound,
        [EnumMember(Value = "Outbound")]
        Outbound
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickTaskRecurrenceTimeZoneSidKey
    {
        [EnumMember(Value = "Pacific/Kiritimati")]
        PacificKiritimati,
        [EnumMember(Value = "Pacific/Tongatapu")]
        PacificTongatapu,
        [EnumMember(Value = "Pacific/Chatham")]
        PacificChatham,
        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland,
        [EnumMember(Value = "Pacific/Enderbury")]
        PacificEnderbury,
        [EnumMember(Value = "Pacific/Fiji")]
        PacificFiji,
        [EnumMember(Value = "Asia/Kamchatka")]
        AsiaKamchatka,
        [EnumMember(Value = "Australia/Lord_Howe")]
        AustraliaLordHowe,
        [EnumMember(Value = "Australia/Sydney")]
        AustraliaSydney,
        [EnumMember(Value = "Pacific/Guadalcanal")]
        PacificGuadalcanal,
        [EnumMember(Value = "Pacific/Norfolk")]
        PacificNorfolk,
        [EnumMember(Value = "Australia/Adelaide")]
        AustraliaAdelaide,
        [EnumMember(Value = "Australia/Brisbane")]
        AustraliaBrisbane,
        [EnumMember(Value = "Australia/Darwin")]
        AustraliaDarwin,
        [EnumMember(Value = "Asia/Seoul")]
        AsiaSeoul,
        [EnumMember(Value = "Asia/Tokyo")]
        AsiaTokyo,
        [EnumMember(Value = "Asia/Hong_Kong")]
        AsiaHongKong,
        [EnumMember(Value = "Asia/Kuala_Lumpur")]
        AsiaKualaLumpur,
        [EnumMember(Value = "Asia/Manila")]
        AsiaManila,
        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai,
        [EnumMember(Value = "Asia/Singapore")]
        AsiaSingapore,
        [EnumMember(Value = "Asia/Taipei")]
        AsiaTaipei,
        [EnumMember(Value = "Australia/Perth")]
        AustraliaPerth,
        [EnumMember(Value = "Asia/Bangkok")]
        AsiaBangkok,
        [EnumMember(Value = "Asia/Ho_Chi_Minh")]
        AsiaHoChiMinh,
        [EnumMember(Value = "Asia/Jakarta")]
        AsiaJakarta,
        [EnumMember(Value = "Asia/Rangoon")]
        AsiaRangoon,
        [EnumMember(Value = "Asia/Dhaka")]
        AsiaDhaka,
        [EnumMember(Value = "Asia/Kathmandu")]
        AsiaKathmandu,
        [EnumMember(Value = "Asia/Colombo")]
        AsiaColombo,
        [EnumMember(Value = "Asia/Kolkata")]
        AsiaKolkata,
        [EnumMember(Value = "Asia/Karachi")]
        AsiaKarachi,
        [EnumMember(Value = "Asia/Tashkent")]
        AsiaTashkent,
        [EnumMember(Value = "Asia/Yekaterinburg")]
        AsiaYekaterinburg,
        [EnumMember(Value = "Asia/Kabul")]
        AsiaKabul,
        [EnumMember(Value = "Asia/Dubai")]
        AsiaDubai,
        [EnumMember(Value = "Asia/Tbilisi")]
        AsiaTbilisi,
        [EnumMember(Value = "Asia/Tehran")]
        AsiaTehran,
        [EnumMember(Value = "Africa/Nairobi")]
        AfricaNairobi,
        [EnumMember(Value = "Asia/Baghdad")]
        AsiaBaghdad,
        [EnumMember(Value = "Asia/Kuwait")]
        AsiaKuwait,
        [EnumMember(Value = "Asia/Riyadh")]
        AsiaRiyadh,
        [EnumMember(Value = "Europe/Istanbul")]
        EuropeIstanbul,
        [EnumMember(Value = "Europe/Minsk")]
        EuropeMinsk,
        [EnumMember(Value = "Europe/Moscow")]
        EuropeMoscow,
        [EnumMember(Value = "Africa/Cairo")]
        AfricaCairo,
        [EnumMember(Value = "Africa/Johannesburg")]
        AfricaJohannesburg,
        [EnumMember(Value = "Asia/Jerusalem")]
        AsiaJerusalem,
        [EnumMember(Value = "Europe/Athens")]
        EuropeAthens,
        [EnumMember(Value = "Europe/Bucharest")]
        EuropeBucharest,
        [EnumMember(Value = "Europe/Helsinki")]
        EuropeHelsinki,
        [EnumMember(Value = "Africa/Algiers")]
        AfricaAlgiers,
        [EnumMember(Value = "Europe/Amsterdam")]
        EuropeAmsterdam,
        [EnumMember(Value = "Europe/Berlin")]
        EuropeBerlin,
        [EnumMember(Value = "Europe/Brussels")]
        EuropeBrussels,
        [EnumMember(Value = "Europe/Paris")]
        EuropeParis,
        [EnumMember(Value = "Europe/Prague")]
        EuropePrague,
        [EnumMember(Value = "Europe/Rome")]
        EuropeRome,
        [EnumMember(Value = "Europe/Dublin")]
        EuropeDublin,
        [EnumMember(Value = "Europe/Lisbon")]
        EuropeLisbon,
        [EnumMember(Value = "Europe/London")]
        EuropeLondon,
        [EnumMember(Value = "GMT")]
        GMT,
        [EnumMember(Value = "Atlantic/Cape_Verde")]
        AtlanticCapeVerde,
        [EnumMember(Value = "America/Sao_Paulo")]
        AmericaSaoPaulo,
        [EnumMember(Value = "Atlantic/South_Georgia")]
        AtlanticSouthGeorgia,
        [EnumMember(Value = "America/Argentina/Buenos_Aires")]
        AmericaArgentinaBuenosAires,
        [EnumMember(Value = "America/Santiago")]
        AmericaSantiago,
        [EnumMember(Value = "America/St_Johns")]
        AmericaStJohns,
        [EnumMember(Value = "America/Caracas")]
        AmericaCaracas,
        [EnumMember(Value = "America/Halifax")]
        AmericaHalifax,
        [EnumMember(Value = "America/Puerto_Rico")]
        AmericaPuertoRico,
        [EnumMember(Value = "Atlantic/Bermuda")]
        AtlanticBermuda,
        [EnumMember(Value = "America/Bogota")]
        AmericaBogota,
        [EnumMember(Value = "America/Indiana/Indianapolis")]
        AmericaIndianaIndianapolis,
        [EnumMember(Value = "America/Lima")]
        AmericaLima,
        [EnumMember(Value = "America/New_York")]
        AmericaNewYork,
        [EnumMember(Value = "America/Panama")]
        AmericaPanama,
        [EnumMember(Value = "America/Chicago")]
        AmericaChicago,
        [EnumMember(Value = "America/El_Salvador")]
        AmericaElSalvador,
        [EnumMember(Value = "America/Mexico_City")]
        AmericaMexicoCity,
        [EnumMember(Value = "America/Denver")]
        AmericaDenver,
        [EnumMember(Value = "America/Phoenix")]
        AmericaPhoenix,
        [EnumMember(Value = "America/Los_Angeles")]
        AmericaLosAngeles,
        [EnumMember(Value = "America/Tijuana")]
        AmericaTijuana,
        [EnumMember(Value = "America/Anchorage")]
        AmericaAnchorage,
        [EnumMember(Value = "Pacific/Honolulu")]
        PacificHonolulu,
        [EnumMember(Value = "Pacific/Niue")]
        PacificNiue,
        [EnumMember(Value = "Pacific/Pago_Pago")]
        PacificPagoPago
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickTaskRecurrenceType
    {
        [EnumMember(Value = "RecursDaily")]
        RecursDaily,
        [EnumMember(Value = "RecursEveryWeekday")]
        RecursEveryWeekday,
        [EnumMember(Value = "RecursMonthly")]
        RecursMonthly,
        [EnumMember(Value = "RecursMonthlyNth")]
        RecursMonthlyNth,
        [EnumMember(Value = "RecursWeekly")]
        RecursWeekly,
        [EnumMember(Value = "RecursYearly")]
        RecursYearly,
        [EnumMember(Value = "RecursYearlyNth")]
        RecursYearlyNth
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickTaskRecurrenceInstance
    {
        [EnumMember(Value = "First")]
        First,
        [EnumMember(Value = "Second")]
        Second,
        [EnumMember(Value = "Third")]
        Third,
        [EnumMember(Value = "Fourth")]
        Fourth,
        [EnumMember(Value = "Last")]
        Last
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickTaskRecurrenceMonthOfYear
    {
        [EnumMember(Value = "January")]
        January,
        [EnumMember(Value = "February")]
        February,
        [EnumMember(Value = "March")]
        March,
        [EnumMember(Value = "April")]
        April,
        [EnumMember(Value = "May")]
        May,
        [EnumMember(Value = "June")]
        June,
        [EnumMember(Value = "July")]
        July,
        [EnumMember(Value = "August")]
        August,
        [EnumMember(Value = "September")]
        September,
        [EnumMember(Value = "October")]
        October,
        [EnumMember(Value = "November")]
        November,
        [EnumMember(Value = "December")]
        December
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickTaskFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickUserTimeZoneSidKey
    {
        [EnumMember(Value = "Pacific/Kiritimati")]
        PacificKiritimati,
        [EnumMember(Value = "Pacific/Tongatapu")]
        PacificTongatapu,
        [EnumMember(Value = "Pacific/Chatham")]
        PacificChatham,
        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland,
        [EnumMember(Value = "Pacific/Enderbury")]
        PacificEnderbury,
        [EnumMember(Value = "Pacific/Fiji")]
        PacificFiji,
        [EnumMember(Value = "Asia/Kamchatka")]
        AsiaKamchatka,
        [EnumMember(Value = "Australia/Lord_Howe")]
        AustraliaLordHowe,
        [EnumMember(Value = "Australia/Sydney")]
        AustraliaSydney,
        [EnumMember(Value = "Pacific/Guadalcanal")]
        PacificGuadalcanal,
        [EnumMember(Value = "Pacific/Norfolk")]
        PacificNorfolk,
        [EnumMember(Value = "Australia/Adelaide")]
        AustraliaAdelaide,
        [EnumMember(Value = "Australia/Brisbane")]
        AustraliaBrisbane,
        [EnumMember(Value = "Australia/Darwin")]
        AustraliaDarwin,
        [EnumMember(Value = "Asia/Seoul")]
        AsiaSeoul,
        [EnumMember(Value = "Asia/Tokyo")]
        AsiaTokyo,
        [EnumMember(Value = "Asia/Hong_Kong")]
        AsiaHongKong,
        [EnumMember(Value = "Asia/Kuala_Lumpur")]
        AsiaKualaLumpur,
        [EnumMember(Value = "Asia/Manila")]
        AsiaManila,
        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai,
        [EnumMember(Value = "Asia/Singapore")]
        AsiaSingapore,
        [EnumMember(Value = "Asia/Taipei")]
        AsiaTaipei,
        [EnumMember(Value = "Australia/Perth")]
        AustraliaPerth,
        [EnumMember(Value = "Asia/Bangkok")]
        AsiaBangkok,
        [EnumMember(Value = "Asia/Ho_Chi_Minh")]
        AsiaHoChiMinh,
        [EnumMember(Value = "Asia/Jakarta")]
        AsiaJakarta,
        [EnumMember(Value = "Asia/Rangoon")]
        AsiaRangoon,
        [EnumMember(Value = "Asia/Dhaka")]
        AsiaDhaka,
        [EnumMember(Value = "Asia/Kathmandu")]
        AsiaKathmandu,
        [EnumMember(Value = "Asia/Colombo")]
        AsiaColombo,
        [EnumMember(Value = "Asia/Kolkata")]
        AsiaKolkata,
        [EnumMember(Value = "Asia/Karachi")]
        AsiaKarachi,
        [EnumMember(Value = "Asia/Tashkent")]
        AsiaTashkent,
        [EnumMember(Value = "Asia/Yekaterinburg")]
        AsiaYekaterinburg,
        [EnumMember(Value = "Asia/Kabul")]
        AsiaKabul,
        [EnumMember(Value = "Asia/Dubai")]
        AsiaDubai,
        [EnumMember(Value = "Asia/Tbilisi")]
        AsiaTbilisi,
        [EnumMember(Value = "Asia/Tehran")]
        AsiaTehran,
        [EnumMember(Value = "Africa/Nairobi")]
        AfricaNairobi,
        [EnumMember(Value = "Asia/Baghdad")]
        AsiaBaghdad,
        [EnumMember(Value = "Asia/Kuwait")]
        AsiaKuwait,
        [EnumMember(Value = "Asia/Riyadh")]
        AsiaRiyadh,
        [EnumMember(Value = "Europe/Istanbul")]
        EuropeIstanbul,
        [EnumMember(Value = "Europe/Minsk")]
        EuropeMinsk,
        [EnumMember(Value = "Europe/Moscow")]
        EuropeMoscow,
        [EnumMember(Value = "Africa/Cairo")]
        AfricaCairo,
        [EnumMember(Value = "Africa/Johannesburg")]
        AfricaJohannesburg,
        [EnumMember(Value = "Asia/Jerusalem")]
        AsiaJerusalem,
        [EnumMember(Value = "Europe/Athens")]
        EuropeAthens,
        [EnumMember(Value = "Europe/Bucharest")]
        EuropeBucharest,
        [EnumMember(Value = "Europe/Helsinki")]
        EuropeHelsinki,
        [EnumMember(Value = "Africa/Algiers")]
        AfricaAlgiers,
        [EnumMember(Value = "Europe/Amsterdam")]
        EuropeAmsterdam,
        [EnumMember(Value = "Europe/Berlin")]
        EuropeBerlin,
        [EnumMember(Value = "Europe/Brussels")]
        EuropeBrussels,
        [EnumMember(Value = "Europe/Paris")]
        EuropeParis,
        [EnumMember(Value = "Europe/Prague")]
        EuropePrague,
        [EnumMember(Value = "Europe/Rome")]
        EuropeRome,
        [EnumMember(Value = "Europe/Dublin")]
        EuropeDublin,
        [EnumMember(Value = "Europe/Lisbon")]
        EuropeLisbon,
        [EnumMember(Value = "Europe/London")]
        EuropeLondon,
        [EnumMember(Value = "GMT")]
        GMT,
        [EnumMember(Value = "Atlantic/Cape_Verde")]
        AtlanticCapeVerde,
        [EnumMember(Value = "America/Sao_Paulo")]
        AmericaSaoPaulo,
        [EnumMember(Value = "Atlantic/South_Georgia")]
        AtlanticSouthGeorgia,
        [EnumMember(Value = "America/Argentina/Buenos_Aires")]
        AmericaArgentinaBuenosAires,
        [EnumMember(Value = "America/Santiago")]
        AmericaSantiago,
        [EnumMember(Value = "America/St_Johns")]
        AmericaStJohns,
        [EnumMember(Value = "America/Caracas")]
        AmericaCaracas,
        [EnumMember(Value = "America/Halifax")]
        AmericaHalifax,
        [EnumMember(Value = "America/Puerto_Rico")]
        AmericaPuertoRico,
        [EnumMember(Value = "Atlantic/Bermuda")]
        AtlanticBermuda,
        [EnumMember(Value = "America/Bogota")]
        AmericaBogota,
        [EnumMember(Value = "America/Indiana/Indianapolis")]
        AmericaIndianaIndianapolis,
        [EnumMember(Value = "America/Lima")]
        AmericaLima,
        [EnumMember(Value = "America/New_York")]
        AmericaNewYork,
        [EnumMember(Value = "America/Panama")]
        AmericaPanama,
        [EnumMember(Value = "America/Chicago")]
        AmericaChicago,
        [EnumMember(Value = "America/El_Salvador")]
        AmericaElSalvador,
        [EnumMember(Value = "America/Mexico_City")]
        AmericaMexicoCity,
        [EnumMember(Value = "America/Denver")]
        AmericaDenver,
        [EnumMember(Value = "America/Phoenix")]
        AmericaPhoenix,
        [EnumMember(Value = "America/Los_Angeles")]
        AmericaLosAngeles,
        [EnumMember(Value = "America/Tijuana")]
        AmericaTijuana,
        [EnumMember(Value = "America/Anchorage")]
        AmericaAnchorage,
        [EnumMember(Value = "Pacific/Honolulu")]
        PacificHonolulu,
        [EnumMember(Value = "Pacific/Niue")]
        PacificNiue,
        [EnumMember(Value = "Pacific/Pago_Pago")]
        PacificPagoPago
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickUserLocaleSidKey
    {
        [EnumMember(Value = "ar_BH")]
        arBH,
        [EnumMember(Value = "ar_EG")]
        arEG,
        [EnumMember(Value = "ar_JO")]
        arJO,
        [EnumMember(Value = "ar_KW")]
        arKW,
        [EnumMember(Value = "ar_LB")]
        arLB,
        [EnumMember(Value = "ar_SA")]
        arSA,
        [EnumMember(Value = "ar_AE")]
        arAE,
        [EnumMember(Value = "hy_AM")]
        hyAM,
        [EnumMember(Value = "bg_BG")]
        bgBG,
        [EnumMember(Value = "ca_ES")]
        caES,
        [EnumMember(Value = "zh_CN")]
        zhCN,
        [EnumMember(Value = "zh_HK")]
        zhHK,
        [EnumMember(Value = "zh_TW")]
        zhTW,
        [EnumMember(Value = "hr_HR")]
        hrHR,
        [EnumMember(Value = "cs_CZ")]
        csCZ,
        [EnumMember(Value = "da_DK")]
        daDK,
        [EnumMember(Value = "nl_BE")]
        nlBE,
        [EnumMember(Value = "nl_NL")]
        nlNL,
        [EnumMember(Value = "nl_SR")]
        nlSR,
        [EnumMember(Value = "en_AU")]
        enAU,
        [EnumMember(Value = "en_BB")]
        enBB,
        [EnumMember(Value = "en_BM")]
        enBM,
        [EnumMember(Value = "en_CA")]
        enCA,
        [EnumMember(Value = "en_GH")]
        enGH,
        [EnumMember(Value = "en_IN")]
        enIN,
        [EnumMember(Value = "en_ID")]
        enID,
        [EnumMember(Value = "en_IE")]
        enIE,
        [EnumMember(Value = "en_MY")]
        enMY,
        [EnumMember(Value = "en_NZ")]
        enNZ,
        [EnumMember(Value = "en_NG")]
        enNG,
        [EnumMember(Value = "en_PH")]
        enPH,
        [EnumMember(Value = "en_SG")]
        enSG,
        [EnumMember(Value = "en_ZA")]
        enZA,
        [EnumMember(Value = "en_GB")]
        enGB,
        [EnumMember(Value = "en_US")]
        enUS,
        [EnumMember(Value = "et_EE")]
        etEE,
        [EnumMember(Value = "fi_FI")]
        fiFI,
        [EnumMember(Value = "fr_BE")]
        frBE,
        [EnumMember(Value = "fr_CA")]
        frCA,
        [EnumMember(Value = "fr_FR")]
        frFR,
        [EnumMember(Value = "fr_LU")]
        frLU,
        [EnumMember(Value = "fr_MC")]
        frMC,
        [EnumMember(Value = "fr_CH")]
        frCH,
        [EnumMember(Value = "ka_GE")]
        kaGE,
        [EnumMember(Value = "de_AT")]
        deAT,
        [EnumMember(Value = "de_DE")]
        deDE,
        [EnumMember(Value = "de_LU")]
        deLU,
        [EnumMember(Value = "de_CH")]
        deCH,
        [EnumMember(Value = "el_GR")]
        elGR,
        [EnumMember(Value = "iw_IL")]
        iwIL,
        [EnumMember(Value = "is_IS")]
        isIS,
        [EnumMember(Value = "it_IT")]
        itIT,
        [EnumMember(Value = "it_CH")]
        itCH,
        [EnumMember(Value = "ja_JP")]
        jaJP,
        [EnumMember(Value = "kk_KZ")]
        kkKZ,
        [EnumMember(Value = "km_KH")]
        kmKH,
        [EnumMember(Value = "ko_KR")]
        koKR,
        [EnumMember(Value = "lv_LV")]
        lvLV,
        [EnumMember(Value = "lt_LT")]
        ltLT,
        [EnumMember(Value = "ms_MY")]
        msMY,
        [EnumMember(Value = "no_NO")]
        noNO,
        [EnumMember(Value = "pt_AO")]
        ptAO,
        [EnumMember(Value = "pt_BR")]
        ptBR,
        [EnumMember(Value = "pt_PT")]
        ptPT,
        [EnumMember(Value = "ro_RO")]
        roRO,
        [EnumMember(Value = "ru_RU")]
        ruRU,
        [EnumMember(Value = "sr_BA")]
        srBA,
        [EnumMember(Value = "sh_BA")]
        shBA,
        [EnumMember(Value = "sh_CS")]
        shCS,
        [EnumMember(Value = "sr_CS")]
        srCS,
        [EnumMember(Value = "sk_SK")]
        skSK,
        [EnumMember(Value = "sl_SI")]
        slSI,
        [EnumMember(Value = "es_AR")]
        esAR,
        [EnumMember(Value = "es_BO")]
        esBO,
        [EnumMember(Value = "es_CL")]
        esCL,
        [EnumMember(Value = "es_CO")]
        esCO,
        [EnumMember(Value = "es_CR")]
        esCR,
        [EnumMember(Value = "es_DO")]
        esDO,
        [EnumMember(Value = "es_EC")]
        esEC,
        [EnumMember(Value = "es_SV")]
        esSV,
        [EnumMember(Value = "es_GT")]
        esGT,
        [EnumMember(Value = "es_HN")]
        esHN,
        [EnumMember(Value = "es_MX")]
        esMX,
        [EnumMember(Value = "es_PA")]
        esPA,
        [EnumMember(Value = "es_PY")]
        esPY,
        [EnumMember(Value = "es_PE")]
        esPE,
        [EnumMember(Value = "es_PR")]
        esPR,
        [EnumMember(Value = "es_ES")]
        esES,
        [EnumMember(Value = "es_UY")]
        esUY,
        [EnumMember(Value = "es_VE")]
        esVE,
        [EnumMember(Value = "sv_SE")]
        svSE,
        [EnumMember(Value = "tl_PH")]
        tlPH,
        [EnumMember(Value = "th_TH")]
        thTH,
        [EnumMember(Value = "uk_UA")]
        ukUA,
        [EnumMember(Value = "ur_PK")]
        urPK,
        [EnumMember(Value = "vi_VN")]
        viVN
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickUserEmailEncodingKey
    {
        [EnumMember(Value = "UTF-8")]
        UTF8,
        [EnumMember(Value = "ISO-8859-1")]
        ISO88591,
        [EnumMember(Value = "Shift_JIS")]
        ShiftJIS,
        [EnumMember(Value = "ISO-2022-JP")]
        ISO2022JP,
        [EnumMember(Value = "EUC-JP")]
        EUCJP,
        [EnumMember(Value = "ks_c_5601-1987")]
        ksc56011987,
        [EnumMember(Value = "Big5")]
        Big5,
        [EnumMember(Value = "GB2312")]
        GB2312
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickUserUserType
    {
        [EnumMember(Value = "Standard")]
        Standard,
        [EnumMember(Value = "PowerPartner")]
        PowerPartner,
        [EnumMember(Value = "PowerCustomerSuccess")]
        PowerCustomerSuccess,
        [EnumMember(Value = "CustomerSuccess")]
        CustomerSuccess,
        [EnumMember(Value = "Guest")]
        Guest,
        [EnumMember(Value = "CSPLitePortal")]
        CSPLitePortal,
        [EnumMember(Value = "CSNOnly")]
        CSNOnly,
        [EnumMember(Value = "SelfService")]
        SelfService
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickUserLanguageLocaleKey
    {
        [EnumMember(Value = "en_US")]
        enUS,
        [EnumMember(Value = "de")]
        de,
        [EnumMember(Value = "es")]
        es,
        [EnumMember(Value = "fr")]
        fr,
        [EnumMember(Value = "it")]
        it,
        [EnumMember(Value = "ja")]
        ja,
        [EnumMember(Value = "sv")]
        sv,
        [EnumMember(Value = "ko")]
        ko,
        [EnumMember(Value = "zh_TW")]
        zhTW,
        [EnumMember(Value = "zh_CN")]
        zhCN,
        [EnumMember(Value = "pt_BR")]
        ptBR,
        [EnumMember(Value = "nl_NL")]
        nlNL,
        [EnumMember(Value = "da")]
        da,
        [EnumMember(Value = "th")]
        th,
        [EnumMember(Value = "fi")]
        fi,
        [EnumMember(Value = "ru")]
        ru,
        [EnumMember(Value = "es_MX")]
        esMX,
        [EnumMember(Value = "no")]
        no
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickUserDigestFrequency
    {
        [EnumMember(Value = "D")]
        D,
        [EnumMember(Value = "W")]
        W,
        [EnumMember(Value = "N")]
        N
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickUserFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickUserPreferencePreference
    {
        [EnumMember(Value = "57")]
        _57,
        [EnumMember(Value = "58")]
        _58,
        [EnumMember(Value = "91")]
        _91,
        [EnumMember(Value = "92")]
        _92,
        [EnumMember(Value = "93")]
        _93,
        [EnumMember(Value = "94")]
        _94,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "97")]
        _97,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickUserProfileFeedType
    {
        [EnumMember(Value = "TrackedChange")]
        TrackedChange,
        [EnumMember(Value = "UserStatus")]
        UserStatus,
        [EnumMember(Value = "TextPost")]
        TextPost,
        [EnumMember(Value = "AdvancedTextPost")]
        AdvancedTextPost,
        [EnumMember(Value = "LinkPost")]
        LinkPost,
        [EnumMember(Value = "ContentPost")]
        ContentPost,
        [EnumMember(Value = "PollPost")]
        PollPost,
        [EnumMember(Value = "RypplePost")]
        RypplePost,
        [EnumMember(Value = "ProfileSkillPost")]
        ProfileSkillPost,
        [EnumMember(Value = "DashboardComponentSnapshot")]
        DashboardComponentSnapshot,
        [EnumMember(Value = "ApprovalPost")]
        ApprovalPost,
        [EnumMember(Value = "CaseCommentPost")]
        CaseCommentPost,
        [EnumMember(Value = "ReplyPost")]
        ReplyPost,
        [EnumMember(Value = "EmailMessageEvent")]
        EmailMessageEvent,
        [EnumMember(Value = "CallLogPost")]
        CallLogPost,
        [EnumMember(Value = "ChangeStatusPost")]
        ChangeStatusPost,
        [EnumMember(Value = "AttachArticleEvent")]
        AttachArticleEvent,
        [EnumMember(Value = "MilestoneEvent")]
        MilestoneEvent,
        [EnumMember(Value = "ActivityEvent")]
        ActivityEvent,
        [EnumMember(Value = "ChatTranscriptPost")]
        ChatTranscriptPost,
        [EnumMember(Value = "CollaborationGroupCreated")]
        CollaborationGroupCreated,
        [EnumMember(Value = "CollaborationGroupUnarchived")]
        CollaborationGroupUnarchived,
        [EnumMember(Value = "SocialPost")]
        SocialPost,
        [EnumMember(Value = "QuestionPost")]
        QuestionPost,
        [EnumMember(Value = "FacebookPost")]
        FacebookPost,
        [EnumMember(Value = "BasicTemplateFeedItem")]
        BasicTemplateFeedItem,
        [EnumMember(Value = "CreateRecordEvent")]
        CreateRecordEvent,
        [EnumMember(Value = "CanvasPost")]
        CanvasPost,
        [EnumMember(Value = "AnnouncementPost")]
        AnnouncementPost
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickUserRoleOpportunityAccessForAccountOwner
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickUserRoleCaseAccessForAccountOwner
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickUserRoleContactAccessForAccountOwner
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Edit")]
        Edit
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickUserRolePortalType
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "CustomerPortal")]
        CustomerPortal,
        [EnumMember(Value = "Partner")]
        Partner
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickVoteType
    {
        [EnumMember(Value = "Up")]
        Up,
        [EnumMember(Value = "Down")]
        Down,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickWebLinkPageOrSobjectType
    {
        [EnumMember(Value = "Account")]
        Account,
        [EnumMember(Value = "Activity")]
        Activity,
        [EnumMember(Value = "Asset")]
        Asset,
        [EnumMember(Value = "Campaign")]
        Campaign,
        [EnumMember(Value = "CampaignMember")]
        CampaignMember,
        [EnumMember(Value = "Case")]
        Case,
        [EnumMember(Value = "Contact")]
        Contact,
        [EnumMember(Value = "ContentVersion")]
        ContentVersion,
        [EnumMember(Value = "Contract")]
        Contract,
        [EnumMember(Value = "CustomPageItem")]
        CustomPageItem,
        [EnumMember(Value = "DandBCompany")]
        DandBCompany,
        [EnumMember(Value = "DashboardComponent")]
        DashboardComponent,
        [EnumMember(Value = "DuplicateRecordItem")]
        DuplicateRecordItem,
        [EnumMember(Value = "DuplicateRecordSet")]
        DuplicateRecordSet,
        [EnumMember(Value = "EmailMessage")]
        EmailMessage,
        [EnumMember(Value = "Event")]
        Event,
        [EnumMember(Value = "Goal")]
        Goal,
        [EnumMember(Value = "GoalLink")]
        GoalLink,
        [EnumMember(Value = "Idea")]
        Idea,
        [EnumMember(Value = "Lead")]
        Lead,
        [EnumMember(Value = "Macro")]
        Macro,
        [EnumMember(Value = "Metric")]
        Metric,
        [EnumMember(Value = "Opportunity")]
        Opportunity,
        [EnumMember(Value = "OpportunityLineItem")]
        OpportunityLineItem,
        [EnumMember(Value = "Order")]
        Order,
        [EnumMember(Value = "OrderItem")]
        OrderItem,
        [EnumMember(Value = "Product2")]
        Product2,
        [EnumMember(Value = "SocialPersona")]
        SocialPersona,
        [EnumMember(Value = "Solution")]
        Solution,
        [EnumMember(Value = "Task")]
        Task,
        [EnumMember(Value = "User")]
        User,
        [EnumMember(Value = "UserProvisioningRequest")]
        UserProvisioningRequest,
        [EnumMember(Value = "WorkCoaching")]
        WorkCoaching,
        [EnumMember(Value = "WorkFeedback")]
        WorkFeedback,
        [EnumMember(Value = "WorkFeedbackQuestion")]
        WorkFeedbackQuestion,
        [EnumMember(Value = "WorkFeedbackQuestionSet")]
        WorkFeedbackQuestionSet,
        [EnumMember(Value = "WorkFeedbackRequest")]
        WorkFeedbackRequest,
        [EnumMember(Value = "WorkFeedbackTemplate")]
        WorkFeedbackTemplate,
        [EnumMember(Value = "WorkPerformanceCycle")]
        WorkPerformanceCycle
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickWebLinkEncodingKey
    {
        [EnumMember(Value = "UTF-8")]
        UTF8,
        [EnumMember(Value = "ISO-8859-1")]
        ISO88591,
        [EnumMember(Value = "Shift_JIS")]
        ShiftJIS,
        [EnumMember(Value = "ISO-2022-JP")]
        ISO2022JP,
        [EnumMember(Value = "EUC-JP")]
        EUCJP,
        [EnumMember(Value = "ks_c_5601-1987")]
        ksc56011987,
        [EnumMember(Value = "Big5")]
        Big5,
        [EnumMember(Value = "GB2312")]
        GB2312
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickWebLinkLinkType
    {
        [EnumMember(Value = "url")]
        url,
        [EnumMember(Value = "sControl")]
        sControl,
        [EnumMember(Value = "javascript")]
        javascript,
        [EnumMember(Value = "page")]
        page,
        [EnumMember(Value = "flow")]
        flow
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickWebLinkOpenType
    {
        [EnumMember(Value = "newWindow")]
        newWindow,
        [EnumMember(Value = "sidebar")]
        sidebar,
        [EnumMember(Value = "noSidebar")]
        noSidebar,
        [EnumMember(Value = "replace")]
        replace,
        [EnumMember(Value = "onClickJavaScript")]
        onClickJavaScript
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickWebLinkPosition
    {
        [EnumMember(Value = "fullScreen")]
        fullScreen,
        [EnumMember(Value = "none")]
        none,
        [EnumMember(Value = "topLeft")]
        topLeft
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickWebLinkDisplayType
    {
        [EnumMember(Value = "L")]
        L,
        [EnumMember(Value = "B")]
        B,
        [EnumMember(Value = "M")]
        M
    }
    public class Account : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __MasterRecordId;
        [EntityField]
        public System.String MasterRecordId
        {
            get { return __MasterRecordId; }
            set { SetField(ref __MasterRecordId, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private PickAccountType? __Type;
        [EntityField]
        public PickAccountType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __BillingStreet;
        [EntityField]
        public System.String BillingStreet
        {
            get { return __BillingStreet; }
            set { SetField(ref __BillingStreet, value); }
        }
        private System.String __BillingCity;
        [EntityField]
        public System.String BillingCity
        {
            get { return __BillingCity; }
            set { SetField(ref __BillingCity, value); }
        }
        private System.String __BillingState;
        [EntityField]
        public System.String BillingState
        {
            get { return __BillingState; }
            set { SetField(ref __BillingState, value); }
        }
        private System.String __BillingPostalCode;
        [EntityField]
        public System.String BillingPostalCode
        {
            get { return __BillingPostalCode; }
            set { SetField(ref __BillingPostalCode, value); }
        }
        private System.String __BillingCountry;
        [EntityField]
        public System.String BillingCountry
        {
            get { return __BillingCountry; }
            set { SetField(ref __BillingCountry, value); }
        }
        private System.String __ShippingStreet;
        [EntityField]
        public System.String ShippingStreet
        {
            get { return __ShippingStreet; }
            set { SetField(ref __ShippingStreet, value); }
        }
        private System.String __ShippingCity;
        [EntityField]
        public System.String ShippingCity
        {
            get { return __ShippingCity; }
            set { SetField(ref __ShippingCity, value); }
        }
        private System.String __ShippingState;
        [EntityField]
        public System.String ShippingState
        {
            get { return __ShippingState; }
            set { SetField(ref __ShippingState, value); }
        }
        private System.String __ShippingPostalCode;
        [EntityField]
        public System.String ShippingPostalCode
        {
            get { return __ShippingPostalCode; }
            set { SetField(ref __ShippingPostalCode, value); }
        }
        private System.String __ShippingCountry;
        [EntityField]
        public System.String ShippingCountry
        {
            get { return __ShippingCountry; }
            set { SetField(ref __ShippingCountry, value); }
        }
        private System.String __Phone;
        [EntityField]
        public System.String Phone
        {
            get { return __Phone; }
            set { SetField(ref __Phone, value); }
        }
        private System.String __Fax;
        [EntityField]
        public System.String Fax
        {
            get { return __Fax; }
            set { SetField(ref __Fax, value); }
        }
        private System.String __AccountNumber;
        [EntityField]
        public System.String AccountNumber
        {
            get { return __AccountNumber; }
            set { SetField(ref __AccountNumber, value); }
        }
        private System.String __Website;
        [EntityField]
        public System.String Website
        {
            get { return __Website; }
            set { SetField(ref __Website, value); }
        }
        private System.String __Sic;
        [EntityField]
        public System.String Sic
        {
            get { return __Sic; }
            set { SetField(ref __Sic, value); }
        }
        private PickAccountIndustry? __Industry;
        [EntityField]
        public PickAccountIndustry? Industry
        {
            get { return __Industry; }
            set { SetField(ref __Industry, value); }
        }
        private System.String __AnnualRevenue;
        [EntityField]
        public System.String AnnualRevenue
        {
            get { return __AnnualRevenue; }
            set { SetField(ref __AnnualRevenue, value); }
        }
        private System.String __NumberOfEmployees;
        [EntityField]
        public System.String NumberOfEmployees
        {
            get { return __NumberOfEmployees; }
            set { SetField(ref __NumberOfEmployees, value); }
        }
        private PickAccountOwnership? __Ownership;
        [EntityField]
        public PickAccountOwnership? Ownership
        {
            get { return __Ownership; }
            set { SetField(ref __Ownership, value); }
        }
        private System.String __TickerSymbol;
        [EntityField]
        public System.String TickerSymbol
        {
            get { return __TickerSymbol; }
            set { SetField(ref __TickerSymbol, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickAccountRating? __Rating;
        [EntityField]
        public PickAccountRating? Rating
        {
            get { return __Rating; }
            set { SetField(ref __Rating, value); }
        }
        private System.String __Site;
        [EntityField]
        public System.String Site
        {
            get { return __Site; }
            set { SetField(ref __Site, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime? __LastActivityDate;
        [EntityField]
        public System.DateTime? LastActivityDate
        {
            get { return __LastActivityDate; }
            set { SetField(ref __LastActivityDate, value); }
        }
        private PickAccountCustomerPriority__c? __CustomerPriorityc;
        [JsonProperty(PropertyName = "CustomerPriority__c")]
        [EntityField]
        public PickAccountCustomerPriority__c? CustomerPriorityc
        {
            get { return __CustomerPriorityc; }
            set { SetField(ref __CustomerPriorityc, value); }
        }
        private PickAccountSLA__c? __SLAc;
        [JsonProperty(PropertyName = "SLA__c")]
        [EntityField]
        public PickAccountSLA__c? SLAc
        {
            get { return __SLAc; }
            set { SetField(ref __SLAc, value); }
        }
        private PickAccountActive__c? __Activec;
        [JsonProperty(PropertyName = "Active__c")]
        [EntityField]
        public PickAccountActive__c? Activec
        {
            get { return __Activec; }
            set { SetField(ref __Activec, value); }
        }
        private System.String __NumberofLocationsc;
        [JsonProperty(PropertyName = "NumberofLocations__c")]
        [EntityField]
        public System.String NumberofLocationsc
        {
            get { return __NumberofLocationsc; }
            set { SetField(ref __NumberofLocationsc, value); }
        }
        private PickAccountUpsellOpportunity__c? __UpsellOpportunityc;
        [JsonProperty(PropertyName = "UpsellOpportunity__c")]
        [EntityField]
        public PickAccountUpsellOpportunity__c? UpsellOpportunityc
        {
            get { return __UpsellOpportunityc; }
            set { SetField(ref __UpsellOpportunityc, value); }
        }
        private System.String __SLASerialNumberc;
        [JsonProperty(PropertyName = "SLASerialNumber__c")]
        [EntityField]
        public System.String SLASerialNumberc
        {
            get { return __SLASerialNumberc; }
            set { SetField(ref __SLASerialNumberc, value); }
        }
        private System.DateTime? __SLAExpirationDatec;
        [JsonProperty(PropertyName = "SLAExpirationDate__c")]
        [EntityField]
        public System.DateTime? SLAExpirationDatec
        {
            get { return __SLAExpirationDatec; }
            set { SetField(ref __SLAExpirationDatec, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Account, Account> ChildAccounts
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, AccountContactRole> AccountContactRoles
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Account, AccountFeed> Feeds
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, AccountHistory> Histories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountFromId")]
        public RelationShip<Account, AccountPartner> AccountPartnersFrom
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountToId")]
        public RelationShip<Account, AccountPartner> AccountPartnersTo
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, AccountShare> Shares
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, ActivityHistory> ActivityHistories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, Asset> Assets
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Account, Attachment> Attachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, Case> Cases
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, Contact> Contacts
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, Contract> Contracts
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Account, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Account, Event> Events
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Account, Note> Notes
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Account, NoteAndAttachment> NotesAndAttachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, OpenActivity> OpenActivities
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, Opportunity> Opportunities
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountToId")]
        public RelationShip<Account, OpportunityPartner> OpportunityPartnersTo
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, Order> Orders
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountFromId")]
        public RelationShip<Account, Partner> PartnersFrom
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountToId")]
        public RelationShip<Account, Partner> PartnersTo
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Account, ProcessInstance> ProcessInstances
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Account, ProcessInstanceHistory> ProcessSteps
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Account, Task> Tasks
        {
            get; set;
        }
    }
    public class AccountContactRole : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __AccountId;
        [EntityField]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __ContactId;
        [EntityField]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private PickAccountContactRoleRole? __Role;
        [EntityField]
        public PickAccountContactRoleRole? Role
        {
            get { return __Role; }
            set { SetField(ref __Role, value); }
        }
        private System.Boolean __IsPrimary;
        [EntityField]
        public System.Boolean IsPrimary
        {
            get { return __IsPrimary; }
            set { SetField(ref __IsPrimary, value); }
        }
    }
    public class AccountFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickAccountFeedType? __Type;
        [EntityField]
        public PickAccountFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<AccountFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<AccountFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class AccountHistory : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __AccountId;
        [EntityField]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickAccountHistoryField __Field;
        [EntityField]
        public PickAccountHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class AccountPartner : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __AccountFromId;
        [EntityField]
        public System.String AccountFromId
        {
            get { return __AccountFromId; }
            set { SetField(ref __AccountFromId, value); }
        }
        private System.String __AccountToId;
        [EntityField]
        public System.String AccountToId
        {
            get { return __AccountToId; }
            set { SetField(ref __AccountToId, value); }
        }
        private System.String __OpportunityId;
        [EntityField]
        public System.String OpportunityId
        {
            get { return __OpportunityId; }
            set { SetField(ref __OpportunityId, value); }
        }
        private PickAccountPartnerRole? __Role;
        [EntityField]
        public PickAccountPartnerRole? Role
        {
            get { return __Role; }
            set { SetField(ref __Role, value); }
        }
        private System.Boolean __IsPrimary;
        [EntityField]
        public System.Boolean IsPrimary
        {
            get { return __IsPrimary; }
            set { SetField(ref __IsPrimary, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ReversePartnerId;
        [EntityField]
        public System.String ReversePartnerId
        {
            get { return __ReversePartnerId; }
            set { SetField(ref __ReversePartnerId, value); }
        }
    }
    public class AccountShare : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __AccountId;
        [EntityField]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __UserOrGroupId;
        [EntityField]
        public System.String UserOrGroupId
        {
            get { return __UserOrGroupId; }
            set { SetField(ref __UserOrGroupId, value); }
        }
        private PickAccountShareAccountAccessLevel __AccountAccessLevel;
        [EntityField]
        public PickAccountShareAccountAccessLevel AccountAccessLevel
        {
            get { return __AccountAccessLevel; }
            set { SetField(ref __AccountAccessLevel, value); }
        }
        private PickAccountShareOpportunityAccessLevel __OpportunityAccessLevel;
        [EntityField]
        public PickAccountShareOpportunityAccessLevel OpportunityAccessLevel
        {
            get { return __OpportunityAccessLevel; }
            set { SetField(ref __OpportunityAccessLevel, value); }
        }
        private PickAccountShareCaseAccessLevel __CaseAccessLevel;
        [EntityField]
        public PickAccountShareCaseAccessLevel CaseAccessLevel
        {
            get { return __CaseAccessLevel; }
            set { SetField(ref __CaseAccessLevel, value); }
        }
        private PickAccountShareContactAccessLevel? __ContactAccessLevel;
        [EntityField]
        public PickAccountShareContactAccessLevel? ContactAccessLevel
        {
            get { return __ContactAccessLevel; }
            set { SetField(ref __ContactAccessLevel, value); }
        }
        private PickAccountShareRowCause? __RowCause;
        [EntityField]
        public PickAccountShareRowCause? RowCause
        {
            get { return __RowCause; }
            set { SetField(ref __RowCause, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class ActivityHistory : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __AccountId;
        [EntityField]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __WhoId;
        [EntityField]
        public System.String WhoId
        {
            get { return __WhoId; }
            set { SetField(ref __WhoId, value); }
        }
        private System.String __WhatId;
        [EntityField]
        public System.String WhatId
        {
            get { return __WhatId; }
            set { SetField(ref __WhatId, value); }
        }
        private System.String __Subject;
        [EntityField]
        public System.String Subject
        {
            get { return __Subject; }
            set { SetField(ref __Subject, value); }
        }
        private System.Boolean __IsTask;
        [EntityField]
        public System.Boolean IsTask
        {
            get { return __IsTask; }
            set { SetField(ref __IsTask, value); }
        }
        private System.DateTime? __ActivityDate;
        [EntityField]
        public System.DateTime? ActivityDate
        {
            get { return __ActivityDate; }
            set { SetField(ref __ActivityDate, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private PickActivityHistoryStatus? __Status;
        [EntityField]
        public PickActivityHistoryStatus? Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private PickActivityHistoryPriority? __Priority;
        [EntityField]
        public PickActivityHistoryPriority? Priority
        {
            get { return __Priority; }
            set { SetField(ref __Priority, value); }
        }
        private PickActivityHistoryActivityType? __ActivityType;
        [EntityField]
        public PickActivityHistoryActivityType? ActivityType
        {
            get { return __ActivityType; }
            set { SetField(ref __ActivityType, value); }
        }
        private System.Boolean __IsClosed;
        [EntityField]
        public System.Boolean IsClosed
        {
            get { return __IsClosed; }
            set { SetField(ref __IsClosed, value); }
        }
        private System.Boolean __IsAllDayEvent;
        [EntityField]
        public System.Boolean IsAllDayEvent
        {
            get { return __IsAllDayEvent; }
            set { SetField(ref __IsAllDayEvent, value); }
        }
        private System.Boolean __IsVisibleInSelfService;
        [EntityField]
        public System.Boolean IsVisibleInSelfService
        {
            get { return __IsVisibleInSelfService; }
            set { SetField(ref __IsVisibleInSelfService, value); }
        }
        private System.String __DurationInMinutes;
        [EntityField]
        public System.String DurationInMinutes
        {
            get { return __DurationInMinutes; }
            set { SetField(ref __DurationInMinutes, value); }
        }
        private System.String __Location;
        [EntityField]
        public System.String Location
        {
            get { return __Location; }
            set { SetField(ref __Location, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __CallDurationInSeconds;
        [EntityField]
        public System.String CallDurationInSeconds
        {
            get { return __CallDurationInSeconds; }
            set { SetField(ref __CallDurationInSeconds, value); }
        }
        private PickActivityHistoryCallType? __CallType;
        [EntityField]
        public PickActivityHistoryCallType? CallType
        {
            get { return __CallType; }
            set { SetField(ref __CallType, value); }
        }
        private System.String __CallDisposition;
        [EntityField]
        public System.String CallDisposition
        {
            get { return __CallDisposition; }
            set { SetField(ref __CallDisposition, value); }
        }
        private System.String __CallObject;
        [EntityField]
        public System.String CallObject
        {
            get { return __CallObject; }
            set { SetField(ref __CallObject, value); }
        }
        private System.DateTime? __ReminderDateTime;
        [EntityField]
        public System.DateTime? ReminderDateTime
        {
            get { return __ReminderDateTime; }
            set { SetField(ref __ReminderDateTime, value); }
        }
        private System.Boolean __IsReminderSet;
        [EntityField]
        public System.Boolean IsReminderSet
        {
            get { return __IsReminderSet; }
            set { SetField(ref __IsReminderSet, value); }
        }
    }
    public class AdditionalNumber : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __CallCenterId;
        [EntityField]
        public System.String CallCenterId
        {
            get { return __CallCenterId; }
            set { SetField(ref __CallCenterId, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __Phone;
        [EntityField]
        public System.String Phone
        {
            get { return __Phone; }
            set { SetField(ref __Phone, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class AggregateResult : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
    }
    public class ApexClass : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __ApiVersion;
        [EntityField]
        public System.String ApiVersion
        {
            get { return __ApiVersion; }
            set { SetField(ref __ApiVersion, value); }
        }
        private PickApexClassStatus __Status;
        [EntityField]
        public PickApexClassStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.Boolean __IsValid;
        [EntityField]
        public System.Boolean IsValid
        {
            get { return __IsValid; }
            set { SetField(ref __IsValid, value); }
        }
        private System.String __BodyCrc;
        [EntityField]
        public System.String BodyCrc
        {
            get { return __BodyCrc; }
            set { SetField(ref __BodyCrc, value); }
        }
        private System.String __Body;
        [EntityField]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.String __LengthWithoutComments;
        [EntityField]
        public System.String LengthWithoutComments
        {
            get { return __LengthWithoutComments; }
            set { SetField(ref __LengthWithoutComments, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class ApexComponent : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __ApiVersion;
        [EntityField]
        public System.String ApiVersion
        {
            get { return __ApiVersion; }
            set { SetField(ref __ApiVersion, value); }
        }
        private System.String __MasterLabel;
        [EntityField]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickApexComponentControllerType __ControllerType;
        [EntityField]
        public PickApexComponentControllerType ControllerType
        {
            get { return __ControllerType; }
            set { SetField(ref __ControllerType, value); }
        }
        private System.String __ControllerKey;
        [EntityField]
        public System.String ControllerKey
        {
            get { return __ControllerKey; }
            set { SetField(ref __ControllerKey, value); }
        }
        private System.String __Markup;
        [EntityField]
        public System.String Markup
        {
            get { return __Markup; }
            set { SetField(ref __Markup, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class ApexLog : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __LogUserId;
        [EntityField]
        public System.String LogUserId
        {
            get { return __LogUserId; }
            set { SetField(ref __LogUserId, value); }
        }
        private System.String __LogLength;
        [EntityField]
        public System.String LogLength
        {
            get { return __LogLength; }
            set { SetField(ref __LogLength, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __Request;
        [EntityField]
        public System.String Request
        {
            get { return __Request; }
            set { SetField(ref __Request, value); }
        }
        private System.String __Operation;
        [EntityField]
        public System.String Operation
        {
            get { return __Operation; }
            set { SetField(ref __Operation, value); }
        }
        private System.String __Application;
        [EntityField]
        public System.String Application
        {
            get { return __Application; }
            set { SetField(ref __Application, value); }
        }
        private System.String __Status;
        [EntityField]
        public System.String Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.String __DurationMilliseconds;
        [EntityField]
        public System.String DurationMilliseconds
        {
            get { return __DurationMilliseconds; }
            set { SetField(ref __DurationMilliseconds, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime __StartTime;
        [EntityField]
        public System.DateTime StartTime
        {
            get { return __StartTime; }
            set { SetField(ref __StartTime, value); }
        }
        private PickApexLogLocation? __Location;
        [EntityField]
        public PickApexLogLocation? Location
        {
            get { return __Location; }
            set { SetField(ref __Location, value); }
        }
    }
    public class ApexPage : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __ApiVersion;
        [EntityField]
        public System.String ApiVersion
        {
            get { return __ApiVersion; }
            set { SetField(ref __ApiVersion, value); }
        }
        private System.String __MasterLabel;
        [EntityField]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickApexPageControllerType __ControllerType;
        [EntityField]
        public PickApexPageControllerType ControllerType
        {
            get { return __ControllerType; }
            set { SetField(ref __ControllerType, value); }
        }
        private System.String __ControllerKey;
        [EntityField]
        public System.String ControllerKey
        {
            get { return __ControllerKey; }
            set { SetField(ref __ControllerKey, value); }
        }
        private System.String __Markup;
        [EntityField]
        public System.String Markup
        {
            get { return __Markup; }
            set { SetField(ref __Markup, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class ApexTrigger : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private PickApexTriggerTableEnumOrId? __TableEnumOrId;
        [EntityField]
        public PickApexTriggerTableEnumOrId? TableEnumOrId
        {
            get { return __TableEnumOrId; }
            set { SetField(ref __TableEnumOrId, value); }
        }
        private System.Boolean __UsageBeforeInsert;
        [EntityField]
        public System.Boolean UsageBeforeInsert
        {
            get { return __UsageBeforeInsert; }
            set { SetField(ref __UsageBeforeInsert, value); }
        }
        private System.Boolean __UsageAfterInsert;
        [EntityField]
        public System.Boolean UsageAfterInsert
        {
            get { return __UsageAfterInsert; }
            set { SetField(ref __UsageAfterInsert, value); }
        }
        private System.Boolean __UsageBeforeUpdate;
        [EntityField]
        public System.Boolean UsageBeforeUpdate
        {
            get { return __UsageBeforeUpdate; }
            set { SetField(ref __UsageBeforeUpdate, value); }
        }
        private System.Boolean __UsageAfterUpdate;
        [EntityField]
        public System.Boolean UsageAfterUpdate
        {
            get { return __UsageAfterUpdate; }
            set { SetField(ref __UsageAfterUpdate, value); }
        }
        private System.Boolean __UsageBeforeDelete;
        [EntityField]
        public System.Boolean UsageBeforeDelete
        {
            get { return __UsageBeforeDelete; }
            set { SetField(ref __UsageBeforeDelete, value); }
        }
        private System.Boolean __UsageAfterDelete;
        [EntityField]
        public System.Boolean UsageAfterDelete
        {
            get { return __UsageAfterDelete; }
            set { SetField(ref __UsageAfterDelete, value); }
        }
        private System.Boolean __UsageIsBulk;
        [EntityField]
        public System.Boolean UsageIsBulk
        {
            get { return __UsageIsBulk; }
            set { SetField(ref __UsageIsBulk, value); }
        }
        private System.Boolean __UsageAfterUndelete;
        [EntityField]
        public System.Boolean UsageAfterUndelete
        {
            get { return __UsageAfterUndelete; }
            set { SetField(ref __UsageAfterUndelete, value); }
        }
        private System.String __ApiVersion;
        [EntityField]
        public System.String ApiVersion
        {
            get { return __ApiVersion; }
            set { SetField(ref __ApiVersion, value); }
        }
        private PickApexTriggerStatus __Status;
        [EntityField]
        public PickApexTriggerStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.Boolean __IsValid;
        [EntityField]
        public System.Boolean IsValid
        {
            get { return __IsValid; }
            set { SetField(ref __IsValid, value); }
        }
        private System.String __BodyCrc;
        [EntityField]
        public System.String BodyCrc
        {
            get { return __BodyCrc; }
            set { SetField(ref __BodyCrc, value); }
        }
        private System.String __Body;
        [EntityField]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.String __LengthWithoutComments;
        [EntityField]
        public System.String LengthWithoutComments
        {
            get { return __LengthWithoutComments; }
            set { SetField(ref __LengthWithoutComments, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class Asset : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ContactId;
        [EntityField]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private System.String __AccountId;
        [EntityField]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __Product2Id;
        [EntityField]
        public System.String Product2Id
        {
            get { return __Product2Id; }
            set { SetField(ref __Product2Id, value); }
        }
        private System.Boolean __IsCompetitorProduct;
        [EntityField]
        public System.Boolean IsCompetitorProduct
        {
            get { return __IsCompetitorProduct; }
            set { SetField(ref __IsCompetitorProduct, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __SerialNumber;
        [EntityField]
        public System.String SerialNumber
        {
            get { return __SerialNumber; }
            set { SetField(ref __SerialNumber, value); }
        }
        private System.DateTime? __InstallDate;
        [EntityField]
        public System.DateTime? InstallDate
        {
            get { return __InstallDate; }
            set { SetField(ref __InstallDate, value); }
        }
        private System.DateTime? __PurchaseDate;
        [EntityField]
        public System.DateTime? PurchaseDate
        {
            get { return __PurchaseDate; }
            set { SetField(ref __PurchaseDate, value); }
        }
        private System.DateTime? __UsageEndDate;
        [EntityField]
        public System.DateTime? UsageEndDate
        {
            get { return __UsageEndDate; }
            set { SetField(ref __UsageEndDate, value); }
        }
        private PickAssetStatus? __Status;
        [EntityField]
        public PickAssetStatus? Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.String __Price;
        [EntityField]
        public System.String Price
        {
            get { return __Price; }
            set { SetField(ref __Price, value); }
        }
        private System.String __Quantity;
        [EntityField]
        public System.String Quantity
        {
            get { return __Quantity; }
            set { SetField(ref __Quantity, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Asset, ActivityHistory> ActivityHistories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Asset, AssetFeed> Feeds
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AssetId")]
        public RelationShip<Asset, AssetHistory> Histories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Asset, Attachment> Attachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AssetId")]
        public RelationShip<Asset, Case> Cases
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Asset, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Asset, Event> Events
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Asset, Note> Notes
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Asset, NoteAndAttachment> NotesAndAttachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Asset, OpenActivity> OpenActivities
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Asset, ProcessInstance> ProcessInstances
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Asset, ProcessInstanceHistory> ProcessSteps
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Asset, Task> Tasks
        {
            get; set;
        }
    }
    public class AssetFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickAssetFeedType? __Type;
        [EntityField]
        public PickAssetFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<AssetFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<AssetFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class AssetHistory : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __AssetId;
        [EntityField]
        public System.String AssetId
        {
            get { return __AssetId; }
            set { SetField(ref __AssetId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickAssetHistoryField __Field;
        [EntityField]
        public PickAssetHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class AssignmentRule : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private PickAssignmentRuleSobjectType? __SobjectType;
        [EntityField]
        public PickAssignmentRuleSobjectType? SobjectType
        {
            get { return __SobjectType; }
            set { SetField(ref __SobjectType, value); }
        }
        private System.Boolean __Active;
        [EntityField]
        public System.Boolean Active
        {
            get { return __Active; }
            set { SetField(ref __Active, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class AsyncApexJob : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private PickAsyncApexJobJobType __JobType;
        [EntityField]
        public PickAsyncApexJobJobType JobType
        {
            get { return __JobType; }
            set { SetField(ref __JobType, value); }
        }
        private System.String __ApexClassId;
        [EntityField]
        public System.String ApexClassId
        {
            get { return __ApexClassId; }
            set { SetField(ref __ApexClassId, value); }
        }
        private PickAsyncApexJobStatus __Status;
        [EntityField]
        public PickAsyncApexJobStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.String __JobItemsProcessed;
        [EntityField]
        public System.String JobItemsProcessed
        {
            get { return __JobItemsProcessed; }
            set { SetField(ref __JobItemsProcessed, value); }
        }
        private System.String __TotalJobItems;
        [EntityField]
        public System.String TotalJobItems
        {
            get { return __TotalJobItems; }
            set { SetField(ref __TotalJobItems, value); }
        }
        private System.String __NumberOfErrors;
        [EntityField]
        public System.String NumberOfErrors
        {
            get { return __NumberOfErrors; }
            set { SetField(ref __NumberOfErrors, value); }
        }
        private System.DateTime? __CompletedDate;
        [EntityField]
        public System.DateTime? CompletedDate
        {
            get { return __CompletedDate; }
            set { SetField(ref __CompletedDate, value); }
        }
        private System.String __MethodName;
        [EntityField]
        public System.String MethodName
        {
            get { return __MethodName; }
            set { SetField(ref __MethodName, value); }
        }
        private System.String __ExtendedStatus;
        [EntityField]
        public System.String ExtendedStatus
        {
            get { return __ExtendedStatus; }
            set { SetField(ref __ExtendedStatus, value); }
        }
        private System.String __ParentJobId;
        [EntityField]
        public System.String ParentJobId
        {
            get { return __ParentJobId; }
            set { SetField(ref __ParentJobId, value); }
        }
        private System.String __LastProcessed;
        [EntityField]
        public System.String LastProcessed
        {
            get { return __LastProcessed; }
            set { SetField(ref __LastProcessed, value); }
        }
        private System.String __LastProcessedOffset;
        [EntityField]
        public System.String LastProcessedOffset
        {
            get { return __LastProcessedOffset; }
            set { SetField(ref __LastProcessedOffset, value); }
        }
    }
    public class Attachment : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.Boolean __IsPrivate;
        [EntityField]
        public System.Boolean IsPrivate
        {
            get { return __IsPrivate; }
            set { SetField(ref __IsPrivate, value); }
        }
        private System.String __ContentType;
        [EntityField]
        public System.String ContentType
        {
            get { return __ContentType; }
            set { SetField(ref __ContentType, value); }
        }
        private System.String __BodyLength;
        [EntityField]
        public System.String BodyLength
        {
            get { return __BodyLength; }
            set { SetField(ref __BodyLength, value); }
        }
        private System.String __Body;
        [EntityField]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
    }
    public class BrandTemplate : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __DeveloperName;
        [EntityField]
        public System.String DeveloperName
        {
            get { return __DeveloperName; }
            set { SetField(ref __DeveloperName, value); }
        }
        private System.Boolean __IsActive;
        [EntityField]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __Value;
        [EntityField]
        public System.String Value
        {
            get { return __Value; }
            set { SetField(ref __Value, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class BusinessHours : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.Boolean __IsActive;
        [EntityField]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.Boolean __IsDefault;
        [EntityField]
        public System.Boolean IsDefault
        {
            get { return __IsDefault; }
            set { SetField(ref __IsDefault, value); }
        }
        private System.String __SundayStartTime;
        [EntityField]
        public System.String SundayStartTime
        {
            get { return __SundayStartTime; }
            set { SetField(ref __SundayStartTime, value); }
        }
        private System.String __SundayEndTime;
        [EntityField]
        public System.String SundayEndTime
        {
            get { return __SundayEndTime; }
            set { SetField(ref __SundayEndTime, value); }
        }
        private System.String __MondayStartTime;
        [EntityField]
        public System.String MondayStartTime
        {
            get { return __MondayStartTime; }
            set { SetField(ref __MondayStartTime, value); }
        }
        private System.String __MondayEndTime;
        [EntityField]
        public System.String MondayEndTime
        {
            get { return __MondayEndTime; }
            set { SetField(ref __MondayEndTime, value); }
        }
        private System.String __TuesdayStartTime;
        [EntityField]
        public System.String TuesdayStartTime
        {
            get { return __TuesdayStartTime; }
            set { SetField(ref __TuesdayStartTime, value); }
        }
        private System.String __TuesdayEndTime;
        [EntityField]
        public System.String TuesdayEndTime
        {
            get { return __TuesdayEndTime; }
            set { SetField(ref __TuesdayEndTime, value); }
        }
        private System.String __WednesdayStartTime;
        [EntityField]
        public System.String WednesdayStartTime
        {
            get { return __WednesdayStartTime; }
            set { SetField(ref __WednesdayStartTime, value); }
        }
        private System.String __WednesdayEndTime;
        [EntityField]
        public System.String WednesdayEndTime
        {
            get { return __WednesdayEndTime; }
            set { SetField(ref __WednesdayEndTime, value); }
        }
        private System.String __ThursdayStartTime;
        [EntityField]
        public System.String ThursdayStartTime
        {
            get { return __ThursdayStartTime; }
            set { SetField(ref __ThursdayStartTime, value); }
        }
        private System.String __ThursdayEndTime;
        [EntityField]
        public System.String ThursdayEndTime
        {
            get { return __ThursdayEndTime; }
            set { SetField(ref __ThursdayEndTime, value); }
        }
        private System.String __FridayStartTime;
        [EntityField]
        public System.String FridayStartTime
        {
            get { return __FridayStartTime; }
            set { SetField(ref __FridayStartTime, value); }
        }
        private System.String __FridayEndTime;
        [EntityField]
        public System.String FridayEndTime
        {
            get { return __FridayEndTime; }
            set { SetField(ref __FridayEndTime, value); }
        }
        private System.String __SaturdayStartTime;
        [EntityField]
        public System.String SaturdayStartTime
        {
            get { return __SaturdayStartTime; }
            set { SetField(ref __SaturdayStartTime, value); }
        }
        private System.String __SaturdayEndTime;
        [EntityField]
        public System.String SaturdayEndTime
        {
            get { return __SaturdayEndTime; }
            set { SetField(ref __SaturdayEndTime, value); }
        }
        private PickBusinessHoursTimeZoneSidKey __TimeZoneSidKey;
        [EntityField]
        public PickBusinessHoursTimeZoneSidKey TimeZoneSidKey
        {
            get { return __TimeZoneSidKey; }
            set { SetField(ref __TimeZoneSidKey, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
    }
    public class BusinessProcess : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickBusinessProcessTableEnumOrId __TableEnumOrId;
        [EntityField]
        public PickBusinessProcessTableEnumOrId TableEnumOrId
        {
            get { return __TableEnumOrId; }
            set { SetField(ref __TableEnumOrId, value); }
        }
        private System.Boolean __IsActive;
        [EntityField]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CallCenter : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __InternalName;
        [EntityField]
        public System.String InternalName
        {
            get { return __InternalName; }
            set { SetField(ref __InternalName, value); }
        }
        private System.String __Version;
        [EntityField]
        public System.String Version
        {
            get { return __Version; }
            set { SetField(ref __Version, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
    }
    public class Campaign : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private PickCampaignType? __Type;
        [EntityField]
        public PickCampaignType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private PickCampaignStatus? __Status;
        [EntityField]
        public PickCampaignStatus? Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.DateTime? __StartDate;
        [EntityField]
        public System.DateTime? StartDate
        {
            get { return __StartDate; }
            set { SetField(ref __StartDate, value); }
        }
        private System.DateTime? __EndDate;
        [EntityField]
        public System.DateTime? EndDate
        {
            get { return __EndDate; }
            set { SetField(ref __EndDate, value); }
        }
        private System.String __ExpectedRevenue;
        [EntityField]
        public System.String ExpectedRevenue
        {
            get { return __ExpectedRevenue; }
            set { SetField(ref __ExpectedRevenue, value); }
        }
        private System.String __BudgetedCost;
        [EntityField]
        public System.String BudgetedCost
        {
            get { return __BudgetedCost; }
            set { SetField(ref __BudgetedCost, value); }
        }
        private System.String __ActualCost;
        [EntityField]
        public System.String ActualCost
        {
            get { return __ActualCost; }
            set { SetField(ref __ActualCost, value); }
        }
        private System.String __ExpectedResponse;
        [EntityField]
        public System.String ExpectedResponse
        {
            get { return __ExpectedResponse; }
            set { SetField(ref __ExpectedResponse, value); }
        }
        private System.String __NumberSent;
        [EntityField]
        public System.String NumberSent
        {
            get { return __NumberSent; }
            set { SetField(ref __NumberSent, value); }
        }
        private System.Boolean __IsActive;
        [EntityField]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __NumberOfLeads;
        [EntityField]
        public System.String NumberOfLeads
        {
            get { return __NumberOfLeads; }
            set { SetField(ref __NumberOfLeads, value); }
        }
        private System.String __NumberOfConvertedLeads;
        [EntityField]
        public System.String NumberOfConvertedLeads
        {
            get { return __NumberOfConvertedLeads; }
            set { SetField(ref __NumberOfConvertedLeads, value); }
        }
        private System.String __NumberOfContacts;
        [EntityField]
        public System.String NumberOfContacts
        {
            get { return __NumberOfContacts; }
            set { SetField(ref __NumberOfContacts, value); }
        }
        private System.String __NumberOfResponses;
        [EntityField]
        public System.String NumberOfResponses
        {
            get { return __NumberOfResponses; }
            set { SetField(ref __NumberOfResponses, value); }
        }
        private System.String __NumberOfOpportunities;
        [EntityField]
        public System.String NumberOfOpportunities
        {
            get { return __NumberOfOpportunities; }
            set { SetField(ref __NumberOfOpportunities, value); }
        }
        private System.String __NumberOfWonOpportunities;
        [EntityField]
        public System.String NumberOfWonOpportunities
        {
            get { return __NumberOfWonOpportunities; }
            set { SetField(ref __NumberOfWonOpportunities, value); }
        }
        private System.String __AmountAllOpportunities;
        [EntityField]
        public System.String AmountAllOpportunities
        {
            get { return __AmountAllOpportunities; }
            set { SetField(ref __AmountAllOpportunities, value); }
        }
        private System.String __AmountWonOpportunities;
        [EntityField]
        public System.String AmountWonOpportunities
        {
            get { return __AmountWonOpportunities; }
            set { SetField(ref __AmountWonOpportunities, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime? __LastActivityDate;
        [EntityField]
        public System.DateTime? LastActivityDate
        {
            get { return __LastActivityDate; }
            set { SetField(ref __LastActivityDate, value); }
        }
        private System.String __CampaignMemberRecordTypeId;
        [EntityField]
        public System.String CampaignMemberRecordTypeId
        {
            get { return __CampaignMemberRecordTypeId; }
            set { SetField(ref __CampaignMemberRecordTypeId, value); }
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Campaign, ActivityHistory> ActivityHistories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Campaign, Attachment> Attachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Campaign, Campaign> ChildCampaigns
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Campaign, CampaignFeed> Feeds
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("CampaignId")]
        public RelationShip<Campaign, CampaignMember> CampaignMembers
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("CampaignId")]
        public RelationShip<Campaign, CampaignShare> Shares
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Campaign, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Campaign, Event> Events
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Campaign, OpenActivity> OpenActivities
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("CampaignId")]
        public RelationShip<Campaign, Opportunity> Opportunities
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Campaign, ProcessInstance> ProcessInstances
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Campaign, ProcessInstanceHistory> ProcessSteps
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Campaign, Task> Tasks
        {
            get; set;
        }
    }
    public class CampaignFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickCampaignFeedType? __Type;
        [EntityField]
        public PickCampaignFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<CampaignFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<CampaignFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class CampaignMember : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __CampaignId;
        [EntityField]
        public System.String CampaignId
        {
            get { return __CampaignId; }
            set { SetField(ref __CampaignId, value); }
        }
        private System.String __LeadId;
        [EntityField]
        public System.String LeadId
        {
            get { return __LeadId; }
            set { SetField(ref __LeadId, value); }
        }
        private System.String __ContactId;
        [EntityField]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private PickCampaignMemberStatus? __Status;
        [EntityField]
        public PickCampaignMemberStatus? Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.Boolean __HasResponded;
        [EntityField]
        public System.Boolean HasResponded
        {
            get { return __HasResponded; }
            set { SetField(ref __HasResponded, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime? __FirstRespondedDate;
        [EntityField]
        public System.DateTime? FirstRespondedDate
        {
            get { return __FirstRespondedDate; }
            set { SetField(ref __FirstRespondedDate, value); }
        }
    }
    public class CampaignMemberStatus : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __CampaignId;
        [EntityField]
        public System.String CampaignId
        {
            get { return __CampaignId; }
            set { SetField(ref __CampaignId, value); }
        }
        private System.String __Label;
        [EntityField]
        public System.String Label
        {
            get { return __Label; }
            set { SetField(ref __Label, value); }
        }
        private System.String __SortOrder;
        [EntityField]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private System.Boolean __IsDefault;
        [EntityField]
        public System.Boolean IsDefault
        {
            get { return __IsDefault; }
            set { SetField(ref __IsDefault, value); }
        }
        private System.Boolean __HasResponded;
        [EntityField]
        public System.Boolean HasResponded
        {
            get { return __HasResponded; }
            set { SetField(ref __HasResponded, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CampaignShare : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __CampaignId;
        [EntityField]
        public System.String CampaignId
        {
            get { return __CampaignId; }
            set { SetField(ref __CampaignId, value); }
        }
        private System.String __UserOrGroupId;
        [EntityField]
        public System.String UserOrGroupId
        {
            get { return __UserOrGroupId; }
            set { SetField(ref __UserOrGroupId, value); }
        }
        private PickCampaignShareCampaignAccessLevel __CampaignAccessLevel;
        [EntityField]
        public PickCampaignShareCampaignAccessLevel CampaignAccessLevel
        {
            get { return __CampaignAccessLevel; }
            set { SetField(ref __CampaignAccessLevel, value); }
        }
        private PickCampaignShareRowCause? __RowCause;
        [EntityField]
        public PickCampaignShareRowCause? RowCause
        {
            get { return __RowCause; }
            set { SetField(ref __RowCause, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class Case : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __CaseNumber;
        [EntityField]
        public System.String CaseNumber
        {
            get { return __CaseNumber; }
            set { SetField(ref __CaseNumber, value); }
        }
        private System.String __ContactId;
        [EntityField]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private System.String __AccountId;
        [EntityField]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __AssetId;
        [EntityField]
        public System.String AssetId
        {
            get { return __AssetId; }
            set { SetField(ref __AssetId, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __SuppliedName;
        [EntityField]
        public System.String SuppliedName
        {
            get { return __SuppliedName; }
            set { SetField(ref __SuppliedName, value); }
        }
        private System.String __SuppliedEmail;
        [EntityField]
        public System.String SuppliedEmail
        {
            get { return __SuppliedEmail; }
            set { SetField(ref __SuppliedEmail, value); }
        }
        private System.String __SuppliedPhone;
        [EntityField]
        public System.String SuppliedPhone
        {
            get { return __SuppliedPhone; }
            set { SetField(ref __SuppliedPhone, value); }
        }
        private System.String __SuppliedCompany;
        [EntityField]
        public System.String SuppliedCompany
        {
            get { return __SuppliedCompany; }
            set { SetField(ref __SuppliedCompany, value); }
        }
        private PickCaseType? __Type;
        [EntityField]
        public PickCaseType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private PickCaseStatus? __Status;
        [EntityField]
        public PickCaseStatus? Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private PickCaseReason? __Reason;
        [EntityField]
        public PickCaseReason? Reason
        {
            get { return __Reason; }
            set { SetField(ref __Reason, value); }
        }
        private PickCaseOrigin? __Origin;
        [EntityField]
        public PickCaseOrigin? Origin
        {
            get { return __Origin; }
            set { SetField(ref __Origin, value); }
        }
        private System.String __Subject;
        [EntityField]
        public System.String Subject
        {
            get { return __Subject; }
            set { SetField(ref __Subject, value); }
        }
        private PickCasePriority? __Priority;
        [EntityField]
        public PickCasePriority? Priority
        {
            get { return __Priority; }
            set { SetField(ref __Priority, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.Boolean __IsClosed;
        [EntityField]
        public System.Boolean IsClosed
        {
            get { return __IsClosed; }
            set { SetField(ref __IsClosed, value); }
        }
        private System.DateTime? __ClosedDate;
        [EntityField]
        public System.DateTime? ClosedDate
        {
            get { return __ClosedDate; }
            set { SetField(ref __ClosedDate, value); }
        }
        private System.Boolean __IsEscalated;
        [EntityField]
        public System.Boolean IsEscalated
        {
            get { return __IsEscalated; }
            set { SetField(ref __IsEscalated, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __EngineeringReqNumberc;
        [JsonProperty(PropertyName = "EngineeringReqNumber__c")]
        [EntityField]
        public System.String EngineeringReqNumberc
        {
            get { return __EngineeringReqNumberc; }
            set { SetField(ref __EngineeringReqNumberc, value); }
        }
        private PickCaseSLAViolation__c? __SLAViolationc;
        [JsonProperty(PropertyName = "SLAViolation__c")]
        [EntityField]
        public PickCaseSLAViolation__c? SLAViolationc
        {
            get { return __SLAViolationc; }
            set { SetField(ref __SLAViolationc, value); }
        }
        private PickCaseProduct__c? __Productc;
        [JsonProperty(PropertyName = "Product__c")]
        [EntityField]
        public PickCaseProduct__c? Productc
        {
            get { return __Productc; }
            set { SetField(ref __Productc, value); }
        }
        private PickCasePotentialLiability__c? __PotentialLiabilityc;
        [JsonProperty(PropertyName = "PotentialLiability__c")]
        [EntityField]
        public PickCasePotentialLiability__c? PotentialLiabilityc
        {
            get { return __PotentialLiabilityc; }
            set { SetField(ref __PotentialLiabilityc, value); }
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Case, ActivityHistory> ActivityHistories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Case, Attachment> Attachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Case, Case> Cases
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Case, CaseComment> CaseComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("CasesId")]
        public RelationShip<Case, CaseContactRole> CaseContactRoles
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Case, CaseFeed> Feeds
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("CaseId")]
        public RelationShip<Case, CaseHistory> Histories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("CaseId")]
        public RelationShip<Case, CaseShare> Shares
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("CaseId")]
        public RelationShip<Case, CaseSolution> CaseSolutions
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Case, CaseTeamMember> TeamMembers
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Case, CaseTeamTemplateRecord> TeamTemplateRecords
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Case, EmailMessage> EmailMessages
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Case, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Case, Event> Events
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Case, OpenActivity> OpenActivities
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Case, ProcessInstance> ProcessInstances
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Case, ProcessInstanceHistory> ProcessSteps
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Case, Task> Tasks
        {
            get; set;
        }
    }
    public class CaseComment : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.Boolean __IsPublished;
        [EntityField]
        public System.Boolean IsPublished
        {
            get { return __IsPublished; }
            set { SetField(ref __IsPublished, value); }
        }
        private System.String __CommentBody;
        [EntityField]
        public System.String CommentBody
        {
            get { return __CommentBody; }
            set { SetField(ref __CommentBody, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class CaseContactRole : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __CasesId;
        [EntityField]
        public System.String CasesId
        {
            get { return __CasesId; }
            set { SetField(ref __CasesId, value); }
        }
        private System.String __ContactId;
        [EntityField]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private PickCaseContactRoleRole? __Role;
        [EntityField]
        public PickCaseContactRoleRole? Role
        {
            get { return __Role; }
            set { SetField(ref __Role, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class CaseFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickCaseFeedType? __Type;
        [EntityField]
        public PickCaseFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<CaseFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<CaseFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class CaseHistory : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __CaseId;
        [EntityField]
        public System.String CaseId
        {
            get { return __CaseId; }
            set { SetField(ref __CaseId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickCaseHistoryField __Field;
        [EntityField]
        public PickCaseHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class CaseShare : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __CaseId;
        [EntityField]
        public System.String CaseId
        {
            get { return __CaseId; }
            set { SetField(ref __CaseId, value); }
        }
        private System.String __UserOrGroupId;
        [EntityField]
        public System.String UserOrGroupId
        {
            get { return __UserOrGroupId; }
            set { SetField(ref __UserOrGroupId, value); }
        }
        private PickCaseShareCaseAccessLevel __CaseAccessLevel;
        [EntityField]
        public PickCaseShareCaseAccessLevel CaseAccessLevel
        {
            get { return __CaseAccessLevel; }
            set { SetField(ref __CaseAccessLevel, value); }
        }
        private PickCaseShareRowCause? __RowCause;
        [EntityField]
        public PickCaseShareRowCause? RowCause
        {
            get { return __RowCause; }
            set { SetField(ref __RowCause, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class CaseSolution : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __CaseId;
        [EntityField]
        public System.String CaseId
        {
            get { return __CaseId; }
            set { SetField(ref __CaseId, value); }
        }
        private System.String __SolutionId;
        [EntityField]
        public System.String SolutionId
        {
            get { return __SolutionId; }
            set { SetField(ref __SolutionId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class CaseStatus : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __MasterLabel;
        [EntityField]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __SortOrder;
        [EntityField]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private System.Boolean __IsDefault;
        [EntityField]
        public System.Boolean IsDefault
        {
            get { return __IsDefault; }
            set { SetField(ref __IsDefault, value); }
        }
        private System.Boolean __IsClosed;
        [EntityField]
        public System.Boolean IsClosed
        {
            get { return __IsClosed; }
            set { SetField(ref __IsClosed, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CaseTeamMember : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __MemberId;
        [EntityField]
        public System.String MemberId
        {
            get { return __MemberId; }
            set { SetField(ref __MemberId, value); }
        }
        private System.String __TeamTemplateMemberId;
        [EntityField]
        public System.String TeamTemplateMemberId
        {
            get { return __TeamTemplateMemberId; }
            set { SetField(ref __TeamTemplateMemberId, value); }
        }
        private System.String __TeamRoleId;
        [EntityField]
        public System.String TeamRoleId
        {
            get { return __TeamRoleId; }
            set { SetField(ref __TeamRoleId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CaseTeamRole : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private PickCaseTeamRoleAccessLevel __AccessLevel;
        [EntityField]
        public PickCaseTeamRoleAccessLevel AccessLevel
        {
            get { return __AccessLevel; }
            set { SetField(ref __AccessLevel, value); }
        }
        private System.Boolean __PreferencesVisibleInCSP;
        [EntityField]
        public System.Boolean PreferencesVisibleInCSP
        {
            get { return __PreferencesVisibleInCSP; }
            set { SetField(ref __PreferencesVisibleInCSP, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CaseTeamTemplate : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CaseTeamTemplateMember : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __TeamTemplateId;
        [EntityField]
        public System.String TeamTemplateId
        {
            get { return __TeamTemplateId; }
            set { SetField(ref __TeamTemplateId, value); }
        }
        private System.String __MemberId;
        [EntityField]
        public System.String MemberId
        {
            get { return __MemberId; }
            set { SetField(ref __MemberId, value); }
        }
        private System.String __TeamRoleId;
        [EntityField]
        public System.String TeamRoleId
        {
            get { return __TeamRoleId; }
            set { SetField(ref __TeamRoleId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CaseTeamTemplateRecord : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __TeamTemplateId;
        [EntityField]
        public System.String TeamTemplateId
        {
            get { return __TeamTemplateId; }
            set { SetField(ref __TeamTemplateId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CategoryData : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __CategoryNodeId;
        [EntityField]
        public System.String CategoryNodeId
        {
            get { return __CategoryNodeId; }
            set { SetField(ref __CategoryNodeId, value); }
        }
        private System.String __RelatedSobjectId;
        [EntityField]
        public System.String RelatedSobjectId
        {
            get { return __RelatedSobjectId; }
            set { SetField(ref __RelatedSobjectId, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CategoryNode : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __MasterLabel;
        [EntityField]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __SortOrder;
        [EntityField]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private PickCategoryNodeSortStyle __SortStyle;
        [EntityField]
        public PickCategoryNodeSortStyle SortStyle
        {
            get { return __SortStyle; }
            set { SetField(ref __SortStyle, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class ClientBrowser : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __UsersId;
        [EntityField]
        public System.String UsersId
        {
            get { return __UsersId; }
            set { SetField(ref __UsersId, value); }
        }
        private System.String __FullUserAgent;
        [EntityField]
        public System.String FullUserAgent
        {
            get { return __FullUserAgent; }
            set { SetField(ref __FullUserAgent, value); }
        }
        private System.String __ProxyInfo;
        [EntityField]
        public System.String ProxyInfo
        {
            get { return __ProxyInfo; }
            set { SetField(ref __ProxyInfo, value); }
        }
        private System.DateTime? __LastUpdate;
        [EntityField]
        public System.DateTime? LastUpdate
        {
            get { return __LastUpdate; }
            set { SetField(ref __LastUpdate, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
    }
    public class CollaborationGroup : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __MemberCount;
        [EntityField]
        public System.String MemberCount
        {
            get { return __MemberCount; }
            set { SetField(ref __MemberCount, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private PickCollaborationGroupCollaborationType __CollaborationType;
        [EntityField]
        public PickCollaborationGroupCollaborationType CollaborationType
        {
            get { return __CollaborationType; }
            set { SetField(ref __CollaborationType, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __FullPhotoUrl;
        [EntityField]
        public System.String FullPhotoUrl
        {
            get { return __FullPhotoUrl; }
            set { SetField(ref __FullPhotoUrl, value); }
        }
        private System.String __SmallPhotoUrl;
        [EntityField]
        public System.String SmallPhotoUrl
        {
            get { return __SmallPhotoUrl; }
            set { SetField(ref __SmallPhotoUrl, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<CollaborationGroup, CollaborationGroupFeed> Feeds
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("CollaborationGroupId")]
        public RelationShip<CollaborationGroup, CollaborationGroupMember> GroupMembers
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<CollaborationGroup, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
    }
    public class CollaborationGroupFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickCollaborationGroupFeedType? __Type;
        [EntityField]
        public PickCollaborationGroupFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<CollaborationGroupFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<CollaborationGroupFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class CollaborationGroupMember : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __CollaborationGroupId;
        [EntityField]
        public System.String CollaborationGroupId
        {
            get { return __CollaborationGroupId; }
            set { SetField(ref __CollaborationGroupId, value); }
        }
        private System.String __MemberId;
        [EntityField]
        public System.String MemberId
        {
            get { return __MemberId; }
            set { SetField(ref __MemberId, value); }
        }
        private PickCollaborationGroupMemberNotificationFrequency? __NotificationFrequency;
        [EntityField]
        public PickCollaborationGroupMemberNotificationFrequency? NotificationFrequency
        {
            get { return __NotificationFrequency; }
            set { SetField(ref __NotificationFrequency, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CollaborationInvitation : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __SharedEntityId;
        [EntityField]
        public System.String SharedEntityId
        {
            get { return __SharedEntityId; }
            set { SetField(ref __SharedEntityId, value); }
        }
        private System.String __InviterId;
        [EntityField]
        public System.String InviterId
        {
            get { return __InviterId; }
            set { SetField(ref __InviterId, value); }
        }
        private System.String __InvitedUserEmail;
        [EntityField]
        public System.String InvitedUserEmail
        {
            get { return __InvitedUserEmail; }
            set { SetField(ref __InvitedUserEmail, value); }
        }
        private System.String __InvitedUserEmailNormalized;
        [EntityField]
        public System.String InvitedUserEmailNormalized
        {
            get { return __InvitedUserEmailNormalized; }
            set { SetField(ref __InvitedUserEmailNormalized, value); }
        }
        private PickCollaborationInvitationStatus __Status;
        [EntityField]
        public PickCollaborationInvitationStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.String __OptionalMessage;
        [EntityField]
        public System.String OptionalMessage
        {
            get { return __OptionalMessage; }
            set { SetField(ref __OptionalMessage, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class Community : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.Boolean __IsActive;
        [EntityField]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
    }
    public class Contact : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __MasterRecordId;
        [EntityField]
        public System.String MasterRecordId
        {
            get { return __MasterRecordId; }
            set { SetField(ref __MasterRecordId, value); }
        }
        private System.String __AccountId;
        [EntityField]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __LastName;
        [EntityField]
        public System.String LastName
        {
            get { return __LastName; }
            set { SetField(ref __LastName, value); }
        }
        private System.String __FirstName;
        [EntityField]
        public System.String FirstName
        {
            get { return __FirstName; }
            set { SetField(ref __FirstName, value); }
        }
        private PickContactSalutation? __Salutation;
        [EntityField]
        public PickContactSalutation? Salutation
        {
            get { return __Salutation; }
            set { SetField(ref __Salutation, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __OtherStreet;
        [EntityField]
        public System.String OtherStreet
        {
            get { return __OtherStreet; }
            set { SetField(ref __OtherStreet, value); }
        }
        private System.String __OtherCity;
        [EntityField]
        public System.String OtherCity
        {
            get { return __OtherCity; }
            set { SetField(ref __OtherCity, value); }
        }
        private System.String __OtherState;
        [EntityField]
        public System.String OtherState
        {
            get { return __OtherState; }
            set { SetField(ref __OtherState, value); }
        }
        private System.String __OtherPostalCode;
        [EntityField]
        public System.String OtherPostalCode
        {
            get { return __OtherPostalCode; }
            set { SetField(ref __OtherPostalCode, value); }
        }
        private System.String __OtherCountry;
        [EntityField]
        public System.String OtherCountry
        {
            get { return __OtherCountry; }
            set { SetField(ref __OtherCountry, value); }
        }
        private System.String __MailingStreet;
        [EntityField]
        public System.String MailingStreet
        {
            get { return __MailingStreet; }
            set { SetField(ref __MailingStreet, value); }
        }
        private System.String __MailingCity;
        [EntityField]
        public System.String MailingCity
        {
            get { return __MailingCity; }
            set { SetField(ref __MailingCity, value); }
        }
        private System.String __MailingState;
        [EntityField]
        public System.String MailingState
        {
            get { return __MailingState; }
            set { SetField(ref __MailingState, value); }
        }
        private System.String __MailingPostalCode;
        [EntityField]
        public System.String MailingPostalCode
        {
            get { return __MailingPostalCode; }
            set { SetField(ref __MailingPostalCode, value); }
        }
        private System.String __MailingCountry;
        [EntityField]
        public System.String MailingCountry
        {
            get { return __MailingCountry; }
            set { SetField(ref __MailingCountry, value); }
        }
        private System.String __Phone;
        [EntityField]
        public System.String Phone
        {
            get { return __Phone; }
            set { SetField(ref __Phone, value); }
        }
        private System.String __Fax;
        [EntityField]
        public System.String Fax
        {
            get { return __Fax; }
            set { SetField(ref __Fax, value); }
        }
        private System.String __MobilePhone;
        [EntityField]
        public System.String MobilePhone
        {
            get { return __MobilePhone; }
            set { SetField(ref __MobilePhone, value); }
        }
        private System.String __HomePhone;
        [EntityField]
        public System.String HomePhone
        {
            get { return __HomePhone; }
            set { SetField(ref __HomePhone, value); }
        }
        private System.String __OtherPhone;
        [EntityField]
        public System.String OtherPhone
        {
            get { return __OtherPhone; }
            set { SetField(ref __OtherPhone, value); }
        }
        private System.String __AssistantPhone;
        [EntityField]
        public System.String AssistantPhone
        {
            get { return __AssistantPhone; }
            set { SetField(ref __AssistantPhone, value); }
        }
        private System.String __ReportsToId;
        [EntityField]
        public System.String ReportsToId
        {
            get { return __ReportsToId; }
            set { SetField(ref __ReportsToId, value); }
        }
        private System.String __Email;
        [EntityField]
        public System.String Email
        {
            get { return __Email; }
            set { SetField(ref __Email, value); }
        }
        private System.String __Title;
        [EntityField]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.String __Department;
        [EntityField]
        public System.String Department
        {
            get { return __Department; }
            set { SetField(ref __Department, value); }
        }
        private System.String __AssistantName;
        [EntityField]
        public System.String AssistantName
        {
            get { return __AssistantName; }
            set { SetField(ref __AssistantName, value); }
        }
        private PickContactLeadSource? __LeadSource;
        [EntityField]
        public PickContactLeadSource? LeadSource
        {
            get { return __LeadSource; }
            set { SetField(ref __LeadSource, value); }
        }
        private System.DateTime? __Birthdate;
        [EntityField]
        public System.DateTime? Birthdate
        {
            get { return __Birthdate; }
            set { SetField(ref __Birthdate, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime? __LastActivityDate;
        [EntityField]
        public System.DateTime? LastActivityDate
        {
            get { return __LastActivityDate; }
            set { SetField(ref __LastActivityDate, value); }
        }
        private System.DateTime? __LastCURequestDate;
        [EntityField]
        public System.DateTime? LastCURequestDate
        {
            get { return __LastCURequestDate; }
            set { SetField(ref __LastCURequestDate, value); }
        }
        private System.DateTime? __LastCUUpdateDate;
        [EntityField]
        public System.DateTime? LastCUUpdateDate
        {
            get { return __LastCUUpdateDate; }
            set { SetField(ref __LastCUUpdateDate, value); }
        }
        private System.String __EmailBouncedReason;
        [EntityField]
        public System.String EmailBouncedReason
        {
            get { return __EmailBouncedReason; }
            set { SetField(ref __EmailBouncedReason, value); }
        }
        private System.DateTime? __EmailBouncedDate;
        [EntityField]
        public System.DateTime? EmailBouncedDate
        {
            get { return __EmailBouncedDate; }
            set { SetField(ref __EmailBouncedDate, value); }
        }
        private PickContactLevel__c? __Levelc;
        [JsonProperty(PropertyName = "Level__c")]
        [EntityField]
        public PickContactLevel__c? Levelc
        {
            get { return __Levelc; }
            set { SetField(ref __Levelc, value); }
        }
        private System.String __Languagesc;
        [JsonProperty(PropertyName = "Languages__c")]
        [EntityField]
        public System.String Languagesc
        {
            get { return __Languagesc; }
            set { SetField(ref __Languagesc, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ContactId")]
        public RelationShip<Contact, AccountContactRole> AccountContactRoles
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Contact, ActivityHistory> ActivityHistories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ContactId")]
        public RelationShip<Contact, Asset> Assets
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contact, Attachment> Attachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ContactId")]
        public RelationShip<Contact, CampaignMember> CampaignMembers
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ContactId")]
        public RelationShip<Contact, Case> Cases
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ContactId")]
        public RelationShip<Contact, CaseContactRole> CaseContactRoles
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contact, ContactFeed> Feeds
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ContactId")]
        public RelationShip<Contact, ContactHistory> Histories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ContactId")]
        public RelationShip<Contact, ContactShare> Shares
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("CustomerSignedId")]
        public RelationShip<Contact, Contract> ContractsSigned
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ContactId")]
        public RelationShip<Contact, ContractContactRole> ContractContactRoles
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Contact, EmailStatus> EmailStatuses
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contact, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Contact, Event> Events
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contact, Note> Notes
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contact, NoteAndAttachment> NotesAndAttachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Contact, OpenActivity> OpenActivities
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ContactId")]
        public RelationShip<Contact, OpportunityContactRole> OpportunityContactRoles
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Contact, ProcessInstance> ProcessInstances
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Contact, ProcessInstanceHistory> ProcessSteps
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Contact, Task> Tasks
        {
            get; set;
        }
    }
    public class ContactFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickContactFeedType? __Type;
        [EntityField]
        public PickContactFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<ContactFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<ContactFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class ContactHistory : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ContactId;
        [EntityField]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickContactHistoryField __Field;
        [EntityField]
        public PickContactHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class ContactShare : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ContactId;
        [EntityField]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private System.String __UserOrGroupId;
        [EntityField]
        public System.String UserOrGroupId
        {
            get { return __UserOrGroupId; }
            set { SetField(ref __UserOrGroupId, value); }
        }
        private PickContactShareContactAccessLevel __ContactAccessLevel;
        [EntityField]
        public PickContactShareContactAccessLevel ContactAccessLevel
        {
            get { return __ContactAccessLevel; }
            set { SetField(ref __ContactAccessLevel, value); }
        }
        private PickContactShareRowCause? __RowCause;
        [EntityField]
        public PickContactShareRowCause? RowCause
        {
            get { return __RowCause; }
            set { SetField(ref __RowCause, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class ContentDocument : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __Title;
        [EntityField]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private PickContentDocumentPublishStatus __PublishStatus;
        [EntityField]
        public PickContentDocumentPublishStatus PublishStatus
        {
            get { return __PublishStatus; }
            set { SetField(ref __PublishStatus, value); }
        }
        private System.String __LatestPublishedVersionId;
        [EntityField]
        public System.String LatestPublishedVersionId
        {
            get { return __LatestPublishedVersionId; }
            set { SetField(ref __LatestPublishedVersionId, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<ContentDocument, ContentDocumentFeed> Feeds
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ContentDocumentId")]
        public RelationShip<ContentDocument, ContentDocumentHistory> Histories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ContentDocumentId")]
        public RelationShip<ContentDocument, ContentVersion> ContentVersions
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<ContentDocument, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
    }
    public class ContentDocumentFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickContentDocumentFeedType? __Type;
        [EntityField]
        public PickContentDocumentFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<ContentDocumentFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<ContentDocumentFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class ContentDocumentHistory : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ContentDocumentId;
        [EntityField]
        public System.String ContentDocumentId
        {
            get { return __ContentDocumentId; }
            set { SetField(ref __ContentDocumentId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickContentDocumentHistoryField __Field;
        [EntityField]
        public PickContentDocumentHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class ContentVersion : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ContentDocumentId;
        [EntityField]
        public System.String ContentDocumentId
        {
            get { return __ContentDocumentId; }
            set { SetField(ref __ContentDocumentId, value); }
        }
        private System.Boolean __IsLatest;
        [EntityField]
        public System.Boolean IsLatest
        {
            get { return __IsLatest; }
            set { SetField(ref __IsLatest, value); }
        }
        private System.String __ContentUrl;
        [EntityField]
        public System.String ContentUrl
        {
            get { return __ContentUrl; }
            set { SetField(ref __ContentUrl, value); }
        }
        private System.String __VersionNumber;
        [EntityField]
        public System.String VersionNumber
        {
            get { return __VersionNumber; }
            set { SetField(ref __VersionNumber, value); }
        }
        private System.String __Title;
        [EntityField]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __ReasonForChange;
        [EntityField]
        public System.String ReasonForChange
        {
            get { return __ReasonForChange; }
            set { SetField(ref __ReasonForChange, value); }
        }
        private System.String __PathOnClient;
        [EntityField]
        public System.String PathOnClient
        {
            get { return __PathOnClient; }
            set { SetField(ref __PathOnClient, value); }
        }
        private System.String __RatingCount;
        [EntityField]
        public System.String RatingCount
        {
            get { return __RatingCount; }
            set { SetField(ref __RatingCount, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime? __ContentModifiedDate;
        [EntityField]
        public System.DateTime? ContentModifiedDate
        {
            get { return __ContentModifiedDate; }
            set { SetField(ref __ContentModifiedDate, value); }
        }
        private System.String __ContentModifiedById;
        [EntityField]
        public System.String ContentModifiedById
        {
            get { return __ContentModifiedById; }
            set { SetField(ref __ContentModifiedById, value); }
        }
        private System.String __PositiveRatingCount;
        [EntityField]
        public System.String PositiveRatingCount
        {
            get { return __PositiveRatingCount; }
            set { SetField(ref __PositiveRatingCount, value); }
        }
        private System.String __NegativeRatingCount;
        [EntityField]
        public System.String NegativeRatingCount
        {
            get { return __NegativeRatingCount; }
            set { SetField(ref __NegativeRatingCount, value); }
        }
        private System.String __FeaturedContentBoost;
        [EntityField]
        public System.String FeaturedContentBoost
        {
            get { return __FeaturedContentBoost; }
            set { SetField(ref __FeaturedContentBoost, value); }
        }
        private System.DateTime? __FeaturedContentDate;
        [EntityField]
        public System.DateTime? FeaturedContentDate
        {
            get { return __FeaturedContentDate; }
            set { SetField(ref __FeaturedContentDate, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __TagCsv;
        [EntityField]
        public System.String TagCsv
        {
            get { return __TagCsv; }
            set { SetField(ref __TagCsv, value); }
        }
        private System.String __FileType;
        [EntityField]
        public System.String FileType
        {
            get { return __FileType; }
            set { SetField(ref __FileType, value); }
        }
        private PickContentVersionPublishStatus __PublishStatus;
        [EntityField]
        public PickContentVersionPublishStatus PublishStatus
        {
            get { return __PublishStatus; }
            set { SetField(ref __PublishStatus, value); }
        }
        private System.String __VersionData;
        [EntityField]
        public System.String VersionData
        {
            get { return __VersionData; }
            set { SetField(ref __VersionData, value); }
        }
        private System.String __ContentSize;
        [EntityField]
        public System.String ContentSize
        {
            get { return __ContentSize; }
            set { SetField(ref __ContentSize, value); }
        }
        private System.String __FirstPublishLocationId;
        [EntityField]
        public System.String FirstPublishLocationId
        {
            get { return __FirstPublishLocationId; }
            set { SetField(ref __FirstPublishLocationId, value); }
        }
        private PickContentVersionOrigin __Origin;
        [EntityField]
        public PickContentVersionOrigin Origin
        {
            get { return __Origin; }
            set { SetField(ref __Origin, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ContentVersionId")]
        public RelationShip<ContentVersion, ContentVersionHistory> Histories
        {
            get; set;
        }
    }
    public class ContentVersionHistory : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ContentVersionId;
        [EntityField]
        public System.String ContentVersionId
        {
            get { return __ContentVersionId; }
            set { SetField(ref __ContentVersionId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickContentVersionHistoryField __Field;
        [EntityField]
        public PickContentVersionHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class ContentWorkspace : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickContentWorkspaceTagModel? __TagModel;
        [EntityField]
        public PickContentWorkspaceTagModel? TagModel
        {
            get { return __TagModel; }
            set { SetField(ref __TagModel, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __DefaultRecordTypeId;
        [EntityField]
        public System.String DefaultRecordTypeId
        {
            get { return __DefaultRecordTypeId; }
            set { SetField(ref __DefaultRecordTypeId, value); }
        }
        private System.Boolean __IsRestrictContentTypes;
        [EntityField]
        public System.Boolean IsRestrictContentTypes
        {
            get { return __IsRestrictContentTypes; }
            set { SetField(ref __IsRestrictContentTypes, value); }
        }
        private System.Boolean __IsRestrictLinkedContentTypes;
        [EntityField]
        public System.Boolean IsRestrictLinkedContentTypes
        {
            get { return __IsRestrictLinkedContentTypes; }
            set { SetField(ref __IsRestrictLinkedContentTypes, value); }
        }
    }
    public class ContentWorkspaceDoc : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ContentWorkspaceId;
        [EntityField]
        public System.String ContentWorkspaceId
        {
            get { return __ContentWorkspaceId; }
            set { SetField(ref __ContentWorkspaceId, value); }
        }
        private System.String __ContentDocumentId;
        [EntityField]
        public System.String ContentDocumentId
        {
            get { return __ContentDocumentId; }
            set { SetField(ref __ContentDocumentId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsOwner;
        [EntityField]
        public System.Boolean IsOwner
        {
            get { return __IsOwner; }
            set { SetField(ref __IsOwner, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class Contract : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __AccountId;
        [EntityField]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __Pricebook2Id;
        [EntityField]
        public System.String Pricebook2Id
        {
            get { return __Pricebook2Id; }
            set { SetField(ref __Pricebook2Id, value); }
        }
        private PickContractOwnerExpirationNotice? __OwnerExpirationNotice;
        [EntityField]
        public PickContractOwnerExpirationNotice? OwnerExpirationNotice
        {
            get { return __OwnerExpirationNotice; }
            set { SetField(ref __OwnerExpirationNotice, value); }
        }
        private System.DateTime? __StartDate;
        [EntityField]
        public System.DateTime? StartDate
        {
            get { return __StartDate; }
            set { SetField(ref __StartDate, value); }
        }
        private System.DateTime? __EndDate;
        [EntityField]
        public System.DateTime? EndDate
        {
            get { return __EndDate; }
            set { SetField(ref __EndDate, value); }
        }
        private System.String __BillingStreet;
        [EntityField]
        public System.String BillingStreet
        {
            get { return __BillingStreet; }
            set { SetField(ref __BillingStreet, value); }
        }
        private System.String __BillingCity;
        [EntityField]
        public System.String BillingCity
        {
            get { return __BillingCity; }
            set { SetField(ref __BillingCity, value); }
        }
        private System.String __BillingState;
        [EntityField]
        public System.String BillingState
        {
            get { return __BillingState; }
            set { SetField(ref __BillingState, value); }
        }
        private System.String __BillingPostalCode;
        [EntityField]
        public System.String BillingPostalCode
        {
            get { return __BillingPostalCode; }
            set { SetField(ref __BillingPostalCode, value); }
        }
        private System.String __BillingCountry;
        [EntityField]
        public System.String BillingCountry
        {
            get { return __BillingCountry; }
            set { SetField(ref __BillingCountry, value); }
        }
        private System.String __ContractTerm;
        [EntityField]
        public System.String ContractTerm
        {
            get { return __ContractTerm; }
            set { SetField(ref __ContractTerm, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private PickContractStatus __Status;
        [EntityField]
        public PickContractStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.String __CompanySignedId;
        [EntityField]
        public System.String CompanySignedId
        {
            get { return __CompanySignedId; }
            set { SetField(ref __CompanySignedId, value); }
        }
        private System.DateTime? __CompanySignedDate;
        [EntityField]
        public System.DateTime? CompanySignedDate
        {
            get { return __CompanySignedDate; }
            set { SetField(ref __CompanySignedDate, value); }
        }
        private System.String __CustomerSignedId;
        [EntityField]
        public System.String CustomerSignedId
        {
            get { return __CustomerSignedId; }
            set { SetField(ref __CustomerSignedId, value); }
        }
        private System.String __CustomerSignedTitle;
        [EntityField]
        public System.String CustomerSignedTitle
        {
            get { return __CustomerSignedTitle; }
            set { SetField(ref __CustomerSignedTitle, value); }
        }
        private System.DateTime? __CustomerSignedDate;
        [EntityField]
        public System.DateTime? CustomerSignedDate
        {
            get { return __CustomerSignedDate; }
            set { SetField(ref __CustomerSignedDate, value); }
        }
        private System.String __SpecialTerms;
        [EntityField]
        public System.String SpecialTerms
        {
            get { return __SpecialTerms; }
            set { SetField(ref __SpecialTerms, value); }
        }
        private System.String __ActivatedById;
        [EntityField]
        public System.String ActivatedById
        {
            get { return __ActivatedById; }
            set { SetField(ref __ActivatedById, value); }
        }
        private System.DateTime? __ActivatedDate;
        [EntityField]
        public System.DateTime? ActivatedDate
        {
            get { return __ActivatedDate; }
            set { SetField(ref __ActivatedDate, value); }
        }
        private PickContractStatusCode __StatusCode;
        [EntityField]
        public PickContractStatusCode StatusCode
        {
            get { return __StatusCode; }
            set { SetField(ref __StatusCode, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ContractNumber;
        [EntityField]
        public System.String ContractNumber
        {
            get { return __ContractNumber; }
            set { SetField(ref __ContractNumber, value); }
        }
        private System.DateTime? __LastApprovedDate;
        [EntityField]
        public System.DateTime? LastApprovedDate
        {
            get { return __LastApprovedDate; }
            set { SetField(ref __LastApprovedDate, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime? __LastActivityDate;
        [EntityField]
        public System.DateTime? LastActivityDate
        {
            get { return __LastActivityDate; }
            set { SetField(ref __LastActivityDate, value); }
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Contract, ActivityHistory> ActivityHistories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contract, Attachment> Attachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ContractId")]
        public RelationShip<Contract, ContractContactRole> ContractContactRoles
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contract, ContractFeed> Feeds
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ContractId")]
        public RelationShip<Contract, ContractHistory> Histories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contract, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Contract, Event> Events
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contract, Note> Notes
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contract, NoteAndAttachment> NotesAndAttachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Contract, OpenActivity> OpenActivities
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ContractId")]
        public RelationShip<Contract, Order> Orders
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Contract, ProcessInstance> ProcessInstances
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Contract, ProcessInstanceHistory> ProcessSteps
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Contract, Task> Tasks
        {
            get; set;
        }
    }
    public class ContractContactRole : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ContractId;
        [EntityField]
        public System.String ContractId
        {
            get { return __ContractId; }
            set { SetField(ref __ContractId, value); }
        }
        private System.String __ContactId;
        [EntityField]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private PickContractContactRoleRole? __Role;
        [EntityField]
        public PickContractContactRoleRole? Role
        {
            get { return __Role; }
            set { SetField(ref __Role, value); }
        }
        private System.Boolean __IsPrimary;
        [EntityField]
        public System.Boolean IsPrimary
        {
            get { return __IsPrimary; }
            set { SetField(ref __IsPrimary, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class ContractFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickContractFeedType? __Type;
        [EntityField]
        public PickContractFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<ContractFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<ContractFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class ContractHistory : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ContractId;
        [EntityField]
        public System.String ContractId
        {
            get { return __ContractId; }
            set { SetField(ref __ContractId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickContractHistoryField __Field;
        [EntityField]
        public PickContractHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class ContractStatus : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __MasterLabel;
        [EntityField]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __SortOrder;
        [EntityField]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private System.Boolean __IsDefault;
        [EntityField]
        public System.Boolean IsDefault
        {
            get { return __IsDefault; }
            set { SetField(ref __IsDefault, value); }
        }
        private PickContractStatusStatusCode? __StatusCode;
        [EntityField]
        public PickContractStatusStatusCode? StatusCode
        {
            get { return __StatusCode; }
            set { SetField(ref __StatusCode, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CronTrigger : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.DateTime? __NextFireTime;
        [EntityField]
        public System.DateTime? NextFireTime
        {
            get { return __NextFireTime; }
            set { SetField(ref __NextFireTime, value); }
        }
        private System.DateTime? __PreviousFireTime;
        [EntityField]
        public System.DateTime? PreviousFireTime
        {
            get { return __PreviousFireTime; }
            set { SetField(ref __PreviousFireTime, value); }
        }
        private System.String __State;
        [EntityField]
        public System.String State
        {
            get { return __State; }
            set { SetField(ref __State, value); }
        }
        private System.DateTime? __StartTime;
        [EntityField]
        public System.DateTime? StartTime
        {
            get { return __StartTime; }
            set { SetField(ref __StartTime, value); }
        }
        private System.DateTime? __EndTime;
        [EntityField]
        public System.DateTime? EndTime
        {
            get { return __EndTime; }
            set { SetField(ref __EndTime, value); }
        }
        private System.String __CronExpression;
        [EntityField]
        public System.String CronExpression
        {
            get { return __CronExpression; }
            set { SetField(ref __CronExpression, value); }
        }
        private PickCronTriggerTimeZoneSidKey? __TimeZoneSidKey;
        [EntityField]
        public PickCronTriggerTimeZoneSidKey? TimeZoneSidKey
        {
            get { return __TimeZoneSidKey; }
            set { SetField(ref __TimeZoneSidKey, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __TimesTriggered;
        [EntityField]
        public System.String TimesTriggered
        {
            get { return __TimesTriggered; }
            set { SetField(ref __TimesTriggered, value); }
        }
    }
    public class Dashboard : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __FolderId;
        [EntityField]
        public System.String FolderId
        {
            get { return __FolderId; }
            set { SetField(ref __FolderId, value); }
        }
        private System.String __Title;
        [EntityField]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.String __DeveloperName;
        [EntityField]
        public System.String DeveloperName
        {
            get { return __DeveloperName; }
            set { SetField(ref __DeveloperName, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickDashboardLeftSize __LeftSize;
        [EntityField]
        public PickDashboardLeftSize LeftSize
        {
            get { return __LeftSize; }
            set { SetField(ref __LeftSize, value); }
        }
        private PickDashboardMiddleSize? __MiddleSize;
        [EntityField]
        public PickDashboardMiddleSize? MiddleSize
        {
            get { return __MiddleSize; }
            set { SetField(ref __MiddleSize, value); }
        }
        private PickDashboardRightSize __RightSize;
        [EntityField]
        public PickDashboardRightSize RightSize
        {
            get { return __RightSize; }
            set { SetField(ref __RightSize, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __RunningUserId;
        [EntityField]
        public System.String RunningUserId
        {
            get { return __RunningUserId; }
            set { SetField(ref __RunningUserId, value); }
        }
        private System.String __TitleColor;
        [EntityField]
        public System.String TitleColor
        {
            get { return __TitleColor; }
            set { SetField(ref __TitleColor, value); }
        }
        private System.String __TitleSize;
        [EntityField]
        public System.String TitleSize
        {
            get { return __TitleSize; }
            set { SetField(ref __TitleSize, value); }
        }
        private System.String __TextColor;
        [EntityField]
        public System.String TextColor
        {
            get { return __TextColor; }
            set { SetField(ref __TextColor, value); }
        }
        private System.String __BackgroundStart;
        [EntityField]
        public System.String BackgroundStart
        {
            get { return __BackgroundStart; }
            set { SetField(ref __BackgroundStart, value); }
        }
        private System.String __BackgroundEnd;
        [EntityField]
        public System.String BackgroundEnd
        {
            get { return __BackgroundEnd; }
            set { SetField(ref __BackgroundEnd, value); }
        }
        private PickDashboardBackgroundDirection __BackgroundDirection;
        [EntityField]
        public PickDashboardBackgroundDirection BackgroundDirection
        {
            get { return __BackgroundDirection; }
            set { SetField(ref __BackgroundDirection, value); }
        }
        private PickDashboardType __Type;
        [EntityField]
        public PickDashboardType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Dashboard, DashboardFeed> Feeds
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Dashboard, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
    }
    public class DashboardFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickDashboardFeedType? __Type;
        [EntityField]
        public PickDashboardFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<DashboardFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<DashboardFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class Document : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __FolderId;
        [EntityField]
        public System.String FolderId
        {
            get { return __FolderId; }
            set { SetField(ref __FolderId, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __DeveloperName;
        [EntityField]
        public System.String DeveloperName
        {
            get { return __DeveloperName; }
            set { SetField(ref __DeveloperName, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __ContentType;
        [EntityField]
        public System.String ContentType
        {
            get { return __ContentType; }
            set { SetField(ref __ContentType, value); }
        }
        private System.String __Type;
        [EntityField]
        public System.String Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.Boolean __IsPublic;
        [EntityField]
        public System.Boolean IsPublic
        {
            get { return __IsPublic; }
            set { SetField(ref __IsPublic, value); }
        }
        private System.String __BodyLength;
        [EntityField]
        public System.String BodyLength
        {
            get { return __BodyLength; }
            set { SetField(ref __BodyLength, value); }
        }
        private System.String __Body;
        [EntityField]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.String __Url;
        [EntityField]
        public System.String Url
        {
            get { return __Url; }
            set { SetField(ref __Url, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __Keywords;
        [EntityField]
        public System.String Keywords
        {
            get { return __Keywords; }
            set { SetField(ref __Keywords, value); }
        }
        private System.Boolean __IsInternalUseOnly;
        [EntityField]
        public System.Boolean IsInternalUseOnly
        {
            get { return __IsInternalUseOnly; }
            set { SetField(ref __IsInternalUseOnly, value); }
        }
        private System.String __AuthorId;
        [EntityField]
        public System.String AuthorId
        {
            get { return __AuthorId; }
            set { SetField(ref __AuthorId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsBodySearchable;
        [EntityField]
        public System.Boolean IsBodySearchable
        {
            get { return __IsBodySearchable; }
            set { SetField(ref __IsBodySearchable, value); }
        }
    }
    public class DocumentAttachmentMap : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __DocumentId;
        [EntityField]
        public System.String DocumentId
        {
            get { return __DocumentId; }
            set { SetField(ref __DocumentId, value); }
        }
        private System.String __DocumentSequence;
        [EntityField]
        public System.String DocumentSequence
        {
            get { return __DocumentSequence; }
            set { SetField(ref __DocumentSequence, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
    }
    public class EmailMessage : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __ActivityId;
        [EntityField]
        public System.String ActivityId
        {
            get { return __ActivityId; }
            set { SetField(ref __ActivityId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __TextBody;
        [EntityField]
        public System.String TextBody
        {
            get { return __TextBody; }
            set { SetField(ref __TextBody, value); }
        }
        private System.String __HtmlBody;
        [EntityField]
        public System.String HtmlBody
        {
            get { return __HtmlBody; }
            set { SetField(ref __HtmlBody, value); }
        }
        private System.String __Headers;
        [EntityField]
        public System.String Headers
        {
            get { return __Headers; }
            set { SetField(ref __Headers, value); }
        }
        private System.String __Subject;
        [EntityField]
        public System.String Subject
        {
            get { return __Subject; }
            set { SetField(ref __Subject, value); }
        }
        private System.String __FromName;
        [EntityField]
        public System.String FromName
        {
            get { return __FromName; }
            set { SetField(ref __FromName, value); }
        }
        private System.String __FromAddress;
        [EntityField]
        public System.String FromAddress
        {
            get { return __FromAddress; }
            set { SetField(ref __FromAddress, value); }
        }
        private System.String __ToAddress;
        [EntityField]
        public System.String ToAddress
        {
            get { return __ToAddress; }
            set { SetField(ref __ToAddress, value); }
        }
        private System.String __CcAddress;
        [EntityField]
        public System.String CcAddress
        {
            get { return __CcAddress; }
            set { SetField(ref __CcAddress, value); }
        }
        private System.String __BccAddress;
        [EntityField]
        public System.String BccAddress
        {
            get { return __BccAddress; }
            set { SetField(ref __BccAddress, value); }
        }
        private System.Boolean __Incoming;
        [EntityField]
        public System.Boolean Incoming
        {
            get { return __Incoming; }
            set { SetField(ref __Incoming, value); }
        }
        private System.Boolean __HasAttachment;
        [EntityField]
        public System.Boolean HasAttachment
        {
            get { return __HasAttachment; }
            set { SetField(ref __HasAttachment, value); }
        }
        private PickEmailMessageStatus __Status;
        [EntityField]
        public PickEmailMessageStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.DateTime? __MessageDate;
        [EntityField]
        public System.DateTime? MessageDate
        {
            get { return __MessageDate; }
            set { SetField(ref __MessageDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<EmailMessage, Attachment> Attachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<EmailMessage, ProcessInstance> ProcessInstances
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<EmailMessage, ProcessInstanceHistory> ProcessSteps
        {
            get; set;
        }
    }
    public class EmailServicesAddress : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsActive;
        [EntityField]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.String __LocalPart;
        [EntityField]
        public System.String LocalPart
        {
            get { return __LocalPart; }
            set { SetField(ref __LocalPart, value); }
        }
        private System.String __EmailDomainName;
        [EntityField]
        public System.String EmailDomainName
        {
            get { return __EmailDomainName; }
            set { SetField(ref __EmailDomainName, value); }
        }
        private System.String __AuthorizedSenders;
        [EntityField]
        public System.String AuthorizedSenders
        {
            get { return __AuthorizedSenders; }
            set { SetField(ref __AuthorizedSenders, value); }
        }
        private System.String __RunAsUserId;
        [EntityField]
        public System.String RunAsUserId
        {
            get { return __RunAsUserId; }
            set { SetField(ref __RunAsUserId, value); }
        }
        private System.String __FunctionId;
        [EntityField]
        public System.String FunctionId
        {
            get { return __FunctionId; }
            set { SetField(ref __FunctionId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class EmailServicesFunction : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsActive;
        [EntityField]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.String __FunctionName;
        [EntityField]
        public System.String FunctionName
        {
            get { return __FunctionName; }
            set { SetField(ref __FunctionName, value); }
        }
        private System.String __AuthorizedSenders;
        [EntityField]
        public System.String AuthorizedSenders
        {
            get { return __AuthorizedSenders; }
            set { SetField(ref __AuthorizedSenders, value); }
        }
        private System.Boolean __IsAuthenticationRequired;
        [EntityField]
        public System.Boolean IsAuthenticationRequired
        {
            get { return __IsAuthenticationRequired; }
            set { SetField(ref __IsAuthenticationRequired, value); }
        }
        private System.Boolean __IsTlsRequired;
        [EntityField]
        public System.Boolean IsTlsRequired
        {
            get { return __IsTlsRequired; }
            set { SetField(ref __IsTlsRequired, value); }
        }
        private PickEmailServicesFunctionAttachmentOption __AttachmentOption;
        [EntityField]
        public PickEmailServicesFunctionAttachmentOption AttachmentOption
        {
            get { return __AttachmentOption; }
            set { SetField(ref __AttachmentOption, value); }
        }
        private System.String __ApexClassId;
        [EntityField]
        public System.String ApexClassId
        {
            get { return __ApexClassId; }
            set { SetField(ref __ApexClassId, value); }
        }
        private PickEmailServicesFunctionOverLimitAction? __OverLimitAction;
        [EntityField]
        public PickEmailServicesFunctionOverLimitAction? OverLimitAction
        {
            get { return __OverLimitAction; }
            set { SetField(ref __OverLimitAction, value); }
        }
        private PickEmailServicesFunctionFunctionInactiveAction? __FunctionInactiveAction;
        [EntityField]
        public PickEmailServicesFunctionFunctionInactiveAction? FunctionInactiveAction
        {
            get { return __FunctionInactiveAction; }
            set { SetField(ref __FunctionInactiveAction, value); }
        }
        private PickEmailServicesFunctionAddressInactiveAction? __AddressInactiveAction;
        [EntityField]
        public PickEmailServicesFunctionAddressInactiveAction? AddressInactiveAction
        {
            get { return __AddressInactiveAction; }
            set { SetField(ref __AddressInactiveAction, value); }
        }
        private PickEmailServicesFunctionAuthenticationFailureAction? __AuthenticationFailureAction;
        [EntityField]
        public PickEmailServicesFunctionAuthenticationFailureAction? AuthenticationFailureAction
        {
            get { return __AuthenticationFailureAction; }
            set { SetField(ref __AuthenticationFailureAction, value); }
        }
        private PickEmailServicesFunctionAuthorizationFailureAction? __AuthorizationFailureAction;
        [EntityField]
        public PickEmailServicesFunctionAuthorizationFailureAction? AuthorizationFailureAction
        {
            get { return __AuthorizationFailureAction; }
            set { SetField(ref __AuthorizationFailureAction, value); }
        }
        private System.Boolean __IsTextTruncated;
        [EntityField]
        public System.Boolean IsTextTruncated
        {
            get { return __IsTextTruncated; }
            set { SetField(ref __IsTextTruncated, value); }
        }
        private System.Boolean __IsErrorRoutingEnabled;
        [EntityField]
        public System.Boolean IsErrorRoutingEnabled
        {
            get { return __IsErrorRoutingEnabled; }
            set { SetField(ref __IsErrorRoutingEnabled, value); }
        }
        private System.String __ErrorRoutingAddress;
        [EntityField]
        public System.String ErrorRoutingAddress
        {
            get { return __ErrorRoutingAddress; }
            set { SetField(ref __ErrorRoutingAddress, value); }
        }
        private System.Boolean __IsTextAttachmentsAsBinary;
        [EntityField]
        public System.Boolean IsTextAttachmentsAsBinary
        {
            get { return __IsTextAttachmentsAsBinary; }
            set { SetField(ref __IsTextAttachmentsAsBinary, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FunctionId")]
        public RelationShip<EmailServicesFunction, EmailServicesAddress> Addresses
        {
            get; set;
        }
    }
    public class EmailStatus : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __TaskId;
        [EntityField]
        public System.String TaskId
        {
            get { return __TaskId; }
            set { SetField(ref __TaskId, value); }
        }
        private System.String __WhoId;
        [EntityField]
        public System.String WhoId
        {
            get { return __WhoId; }
            set { SetField(ref __WhoId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.String __TimesOpened;
        [EntityField]
        public System.String TimesOpened
        {
            get { return __TimesOpened; }
            set { SetField(ref __TimesOpened, value); }
        }
        private System.DateTime? __FirstOpenDate;
        [EntityField]
        public System.DateTime? FirstOpenDate
        {
            get { return __FirstOpenDate; }
            set { SetField(ref __FirstOpenDate, value); }
        }
        private System.DateTime? __LastOpenDate;
        [EntityField]
        public System.DateTime? LastOpenDate
        {
            get { return __LastOpenDate; }
            set { SetField(ref __LastOpenDate, value); }
        }
        private System.String __EmailTemplateName;
        [EntityField]
        public System.String EmailTemplateName
        {
            get { return __EmailTemplateName; }
            set { SetField(ref __EmailTemplateName, value); }
        }
    }
    public class EmailTemplate : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __DeveloperName;
        [EntityField]
        public System.String DeveloperName
        {
            get { return __DeveloperName; }
            set { SetField(ref __DeveloperName, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.String __FolderId;
        [EntityField]
        public System.String FolderId
        {
            get { return __FolderId; }
            set { SetField(ref __FolderId, value); }
        }
        private System.String __BrandTemplateId;
        [EntityField]
        public System.String BrandTemplateId
        {
            get { return __BrandTemplateId; }
            set { SetField(ref __BrandTemplateId, value); }
        }
        private PickEmailTemplateTemplateStyle __TemplateStyle;
        [EntityField]
        public PickEmailTemplateTemplateStyle TemplateStyle
        {
            get { return __TemplateStyle; }
            set { SetField(ref __TemplateStyle, value); }
        }
        private System.Boolean __IsActive;
        [EntityField]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private PickEmailTemplateTemplateType __TemplateType;
        [EntityField]
        public PickEmailTemplateTemplateType TemplateType
        {
            get { return __TemplateType; }
            set { SetField(ref __TemplateType, value); }
        }
        private PickEmailTemplateEncoding? __Encoding;
        [EntityField]
        public PickEmailTemplateEncoding? Encoding
        {
            get { return __Encoding; }
            set { SetField(ref __Encoding, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __Subject;
        [EntityField]
        public System.String Subject
        {
            get { return __Subject; }
            set { SetField(ref __Subject, value); }
        }
        private System.String __HtmlValue;
        [EntityField]
        public System.String HtmlValue
        {
            get { return __HtmlValue; }
            set { SetField(ref __HtmlValue, value); }
        }
        private System.String __Body;
        [EntityField]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.String __TimesUsed;
        [EntityField]
        public System.String TimesUsed
        {
            get { return __TimesUsed; }
            set { SetField(ref __TimesUsed, value); }
        }
        private System.DateTime? __LastUsedDate;
        [EntityField]
        public System.DateTime? LastUsedDate
        {
            get { return __LastUsedDate; }
            set { SetField(ref __LastUsedDate, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __ApiVersion;
        [EntityField]
        public System.String ApiVersion
        {
            get { return __ApiVersion; }
            set { SetField(ref __ApiVersion, value); }
        }
        private System.String __Markup;
        [EntityField]
        public System.String Markup
        {
            get { return __Markup; }
            set { SetField(ref __Markup, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<EmailTemplate, Attachment> Attachments
        {
            get; set;
        }
    }
    public class EntitySubscription : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __SubscriberId;
        [EntityField]
        public System.String SubscriberId
        {
            get { return __SubscriberId; }
            set { SetField(ref __SubscriberId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class Event : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __WhoId;
        [EntityField]
        public System.String WhoId
        {
            get { return __WhoId; }
            set { SetField(ref __WhoId, value); }
        }
        private System.String __WhatId;
        [EntityField]
        public System.String WhatId
        {
            get { return __WhatId; }
            set { SetField(ref __WhatId, value); }
        }
        private System.String __Subject;
        [EntityField]
        public System.String Subject
        {
            get { return __Subject; }
            set { SetField(ref __Subject, value); }
        }
        private System.String __Location;
        [EntityField]
        public System.String Location
        {
            get { return __Location; }
            set { SetField(ref __Location, value); }
        }
        private System.Boolean __IsAllDayEvent;
        [EntityField]
        public System.Boolean IsAllDayEvent
        {
            get { return __IsAllDayEvent; }
            set { SetField(ref __IsAllDayEvent, value); }
        }
        private System.DateTime? __ActivityDateTime;
        [EntityField]
        public System.DateTime? ActivityDateTime
        {
            get { return __ActivityDateTime; }
            set { SetField(ref __ActivityDateTime, value); }
        }
        private System.DateTime? __ActivityDate;
        [EntityField]
        public System.DateTime? ActivityDate
        {
            get { return __ActivityDate; }
            set { SetField(ref __ActivityDate, value); }
        }
        private System.String __DurationInMinutes;
        [EntityField]
        public System.String DurationInMinutes
        {
            get { return __DurationInMinutes; }
            set { SetField(ref __DurationInMinutes, value); }
        }
        private System.DateTime? __StartDateTime;
        [EntityField]
        public System.DateTime? StartDateTime
        {
            get { return __StartDateTime; }
            set { SetField(ref __StartDateTime, value); }
        }
        private System.DateTime? __EndDateTime;
        [EntityField]
        public System.DateTime? EndDateTime
        {
            get { return __EndDateTime; }
            set { SetField(ref __EndDateTime, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __AccountId;
        [EntityField]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.Boolean __IsPrivate;
        [EntityField]
        public System.Boolean IsPrivate
        {
            get { return __IsPrivate; }
            set { SetField(ref __IsPrivate, value); }
        }
        private PickEventShowAs? __ShowAs;
        [EntityField]
        public PickEventShowAs? ShowAs
        {
            get { return __ShowAs; }
            set { SetField(ref __ShowAs, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.Boolean __IsChild;
        [EntityField]
        public System.Boolean IsChild
        {
            get { return __IsChild; }
            set { SetField(ref __IsChild, value); }
        }
        private System.Boolean __IsGroupEvent;
        [EntityField]
        public System.Boolean IsGroupEvent
        {
            get { return __IsGroupEvent; }
            set { SetField(ref __IsGroupEvent, value); }
        }
        private PickEventGroupEventType? __GroupEventType;
        [EntityField]
        public PickEventGroupEventType? GroupEventType
        {
            get { return __GroupEventType; }
            set { SetField(ref __GroupEventType, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsArchived;
        [EntityField]
        public System.Boolean IsArchived
        {
            get { return __IsArchived; }
            set { SetField(ref __IsArchived, value); }
        }
        private System.String __RecurrenceActivityId;
        [EntityField]
        public System.String RecurrenceActivityId
        {
            get { return __RecurrenceActivityId; }
            set { SetField(ref __RecurrenceActivityId, value); }
        }
        private System.Boolean __IsRecurrence;
        [EntityField]
        public System.Boolean IsRecurrence
        {
            get { return __IsRecurrence; }
            set { SetField(ref __IsRecurrence, value); }
        }
        private System.DateTime? __RecurrenceStartDateTime;
        [EntityField]
        public System.DateTime? RecurrenceStartDateTime
        {
            get { return __RecurrenceStartDateTime; }
            set { SetField(ref __RecurrenceStartDateTime, value); }
        }
        private System.DateTime? __RecurrenceEndDateOnly;
        [EntityField]
        public System.DateTime? RecurrenceEndDateOnly
        {
            get { return __RecurrenceEndDateOnly; }
            set { SetField(ref __RecurrenceEndDateOnly, value); }
        }
        private PickEventRecurrenceTimeZoneSidKey? __RecurrenceTimeZoneSidKey;
        [EntityField]
        public PickEventRecurrenceTimeZoneSidKey? RecurrenceTimeZoneSidKey
        {
            get { return __RecurrenceTimeZoneSidKey; }
            set { SetField(ref __RecurrenceTimeZoneSidKey, value); }
        }
        private PickEventRecurrenceType? __RecurrenceType;
        [EntityField]
        public PickEventRecurrenceType? RecurrenceType
        {
            get { return __RecurrenceType; }
            set { SetField(ref __RecurrenceType, value); }
        }
        private System.String __RecurrenceInterval;
        [EntityField]
        public System.String RecurrenceInterval
        {
            get { return __RecurrenceInterval; }
            set { SetField(ref __RecurrenceInterval, value); }
        }
        private System.String __RecurrenceDayOfWeekMask;
        [EntityField]
        public System.String RecurrenceDayOfWeekMask
        {
            get { return __RecurrenceDayOfWeekMask; }
            set { SetField(ref __RecurrenceDayOfWeekMask, value); }
        }
        private System.String __RecurrenceDayOfMonth;
        [EntityField]
        public System.String RecurrenceDayOfMonth
        {
            get { return __RecurrenceDayOfMonth; }
            set { SetField(ref __RecurrenceDayOfMonth, value); }
        }
        private PickEventRecurrenceInstance? __RecurrenceInstance;
        [EntityField]
        public PickEventRecurrenceInstance? RecurrenceInstance
        {
            get { return __RecurrenceInstance; }
            set { SetField(ref __RecurrenceInstance, value); }
        }
        private PickEventRecurrenceMonthOfYear? __RecurrenceMonthOfYear;
        [EntityField]
        public PickEventRecurrenceMonthOfYear? RecurrenceMonthOfYear
        {
            get { return __RecurrenceMonthOfYear; }
            set { SetField(ref __RecurrenceMonthOfYear, value); }
        }
        private System.DateTime? __ReminderDateTime;
        [EntityField]
        public System.DateTime? ReminderDateTime
        {
            get { return __ReminderDateTime; }
            set { SetField(ref __ReminderDateTime, value); }
        }
        private System.Boolean __IsReminderSet;
        [EntityField]
        public System.Boolean IsReminderSet
        {
            get { return __IsReminderSet; }
            set { SetField(ref __IsReminderSet, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Event, Attachment> Attachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Event, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("RecurrenceActivityId")]
        public RelationShip<Event, Event> RecurringEvents
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("EventId")]
        public RelationShip<Event, EventAttendee> EventAttendees
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Event, EventFeed> Feeds
        {
            get; set;
        }
    }
    public class EventAttendee : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __EventId;
        [EntityField]
        public System.String EventId
        {
            get { return __EventId; }
            set { SetField(ref __EventId, value); }
        }
        private System.String __AttendeeId;
        [EntityField]
        public System.String AttendeeId
        {
            get { return __AttendeeId; }
            set { SetField(ref __AttendeeId, value); }
        }
        private PickEventAttendeeStatus __Status;
        [EntityField]
        public PickEventAttendeeStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.DateTime? __RespondedDate;
        [EntityField]
        public System.DateTime? RespondedDate
        {
            get { return __RespondedDate; }
            set { SetField(ref __RespondedDate, value); }
        }
        private System.String __Response;
        [EntityField]
        public System.String Response
        {
            get { return __Response; }
            set { SetField(ref __Response, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class EventFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickEventFeedType? __Type;
        [EntityField]
        public PickEventFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<EventFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<EventFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class FeedComment : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __FeedItemId;
        [EntityField]
        public System.String FeedItemId
        {
            get { return __FeedItemId; }
            set { SetField(ref __FeedItemId, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CommentBody;
        [EntityField]
        public System.String CommentBody
        {
            get { return __CommentBody; }
            set { SetField(ref __CommentBody, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class FeedPost : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __FeedItemId;
        [EntityField]
        public System.String FeedItemId
        {
            get { return __FeedItemId; }
            set { SetField(ref __FeedItemId, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private PickFeedPostType __Type;
        [EntityField]
        public PickFeedPostType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __Title;
        [EntityField]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.String __Body;
        [EntityField]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.String __LinkUrl;
        [EntityField]
        public System.String LinkUrl
        {
            get { return __LinkUrl; }
            set { SetField(ref __LinkUrl, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ContentData;
        [EntityField]
        public System.String ContentData
        {
            get { return __ContentData; }
            set { SetField(ref __ContentData, value); }
        }
        private System.String __ContentFileName;
        [EntityField]
        public System.String ContentFileName
        {
            get { return __ContentFileName; }
            set { SetField(ref __ContentFileName, value); }
        }
        private System.String __ContentDescription;
        [EntityField]
        public System.String ContentDescription
        {
            get { return __ContentDescription; }
            set { SetField(ref __ContentDescription, value); }
        }
        private System.String __ContentType;
        [EntityField]
        public System.String ContentType
        {
            get { return __ContentType; }
            set { SetField(ref __ContentType, value); }
        }
        private System.String __ContentSize;
        [EntityField]
        public System.String ContentSize
        {
            get { return __ContentSize; }
            set { SetField(ref __ContentSize, value); }
        }
    }
    public class FeedTrackedChange : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __FeedItemId;
        [EntityField]
        public System.String FeedItemId
        {
            get { return __FeedItemId; }
            set { SetField(ref __FeedItemId, value); }
        }
        private System.String __FieldName;
        [EntityField]
        public System.String FieldName
        {
            get { return __FieldName; }
            set { SetField(ref __FieldName, value); }
        }
        private System.String __OldValue;
        [EntityField]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class FiscalYearSettings : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __PeriodId;
        [EntityField]
        public System.String PeriodId
        {
            get { return __PeriodId; }
            set { SetField(ref __PeriodId, value); }
        }
        private System.DateTime? __StartDate;
        [EntityField]
        public System.DateTime? StartDate
        {
            get { return __StartDate; }
            set { SetField(ref __StartDate, value); }
        }
        private System.DateTime? __EndDate;
        [EntityField]
        public System.DateTime? EndDate
        {
            get { return __EndDate; }
            set { SetField(ref __EndDate, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.Boolean __IsStandardYear;
        [EntityField]
        public System.Boolean IsStandardYear
        {
            get { return __IsStandardYear; }
            set { SetField(ref __IsStandardYear, value); }
        }
        private PickFiscalYearSettingsYearType? __YearType;
        [EntityField]
        public PickFiscalYearSettingsYearType? YearType
        {
            get { return __YearType; }
            set { SetField(ref __YearType, value); }
        }
        private PickFiscalYearSettingsQuarterLabelScheme? __QuarterLabelScheme;
        [EntityField]
        public PickFiscalYearSettingsQuarterLabelScheme? QuarterLabelScheme
        {
            get { return __QuarterLabelScheme; }
            set { SetField(ref __QuarterLabelScheme, value); }
        }
        private PickFiscalYearSettingsPeriodLabelScheme? __PeriodLabelScheme;
        [EntityField]
        public PickFiscalYearSettingsPeriodLabelScheme? PeriodLabelScheme
        {
            get { return __PeriodLabelScheme; }
            set { SetField(ref __PeriodLabelScheme, value); }
        }
        private PickFiscalYearSettingsWeekLabelScheme? __WeekLabelScheme;
        [EntityField]
        public PickFiscalYearSettingsWeekLabelScheme? WeekLabelScheme
        {
            get { return __WeekLabelScheme; }
            set { SetField(ref __WeekLabelScheme, value); }
        }
        private PickFiscalYearSettingsQuarterPrefix? __QuarterPrefix;
        [EntityField]
        public PickFiscalYearSettingsQuarterPrefix? QuarterPrefix
        {
            get { return __QuarterPrefix; }
            set { SetField(ref __QuarterPrefix, value); }
        }
        private PickFiscalYearSettingsPeriodPrefix? __PeriodPrefix;
        [EntityField]
        public PickFiscalYearSettingsPeriodPrefix? PeriodPrefix
        {
            get { return __PeriodPrefix; }
            set { SetField(ref __PeriodPrefix, value); }
        }
        private System.String __WeekStartDay;
        [EntityField]
        public System.String WeekStartDay
        {
            get { return __WeekStartDay; }
            set { SetField(ref __WeekStartDay, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FiscalYearSettingsId")]
        public RelationShip<FiscalYearSettings, Period> Periods
        {
            get; set;
        }
    }
    public class Folder : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __DeveloperName;
        [EntityField]
        public System.String DeveloperName
        {
            get { return __DeveloperName; }
            set { SetField(ref __DeveloperName, value); }
        }
        private PickFolderAccessType __AccessType;
        [EntityField]
        public PickFolderAccessType AccessType
        {
            get { return __AccessType; }
            set { SetField(ref __AccessType, value); }
        }
        private System.Boolean __IsReadonly;
        [EntityField]
        public System.Boolean IsReadonly
        {
            get { return __IsReadonly; }
            set { SetField(ref __IsReadonly, value); }
        }
        private PickFolderType __Type;
        [EntityField]
        public PickFolderType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class ForecastShare : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __UserRoleId;
        [EntityField]
        public System.String UserRoleId
        {
            get { return __UserRoleId; }
            set { SetField(ref __UserRoleId, value); }
        }
        private System.String __UserOrGroupId;
        [EntityField]
        public System.String UserOrGroupId
        {
            get { return __UserOrGroupId; }
            set { SetField(ref __UserOrGroupId, value); }
        }
        private PickForecastShareAccessLevel __AccessLevel;
        [EntityField]
        public PickForecastShareAccessLevel AccessLevel
        {
            get { return __AccessLevel; }
            set { SetField(ref __AccessLevel, value); }
        }
        private System.Boolean __CanSubmit;
        [EntityField]
        public System.Boolean CanSubmit
        {
            get { return __CanSubmit; }
            set { SetField(ref __CanSubmit, value); }
        }
        private PickForecastShareRowCause __RowCause;
        [EntityField]
        public PickForecastShareRowCause RowCause
        {
            get { return __RowCause; }
            set { SetField(ref __RowCause, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
    }
    public class Group : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __RelatedId;
        [EntityField]
        public System.String RelatedId
        {
            get { return __RelatedId; }
            set { SetField(ref __RelatedId, value); }
        }
        private PickGroupType __Type;
        [EntityField]
        public PickGroupType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __Email;
        [EntityField]
        public System.String Email
        {
            get { return __Email; }
            set { SetField(ref __Email, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.Boolean __DoesSendEmailToMembers;
        [EntityField]
        public System.Boolean DoesSendEmailToMembers
        {
            get { return __DoesSendEmailToMembers; }
            set { SetField(ref __DoesSendEmailToMembers, value); }
        }
        private System.Boolean __DoesIncludeBosses;
        [EntityField]
        public System.Boolean DoesIncludeBosses
        {
            get { return __DoesIncludeBosses; }
            set { SetField(ref __DoesIncludeBosses, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("GroupId")]
        public RelationShip<Group, GroupMember> GroupMembers
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("QueueId")]
        public RelationShip<Group, QueueSobject> QueueSobjects
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("DelegatedApproverId")]
        public RelationShip<Group, User> DelegatedUsers
        {
            get; set;
        }
    }
    public class GroupMember : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __GroupId;
        [EntityField]
        public System.String GroupId
        {
            get { return __GroupId; }
            set { SetField(ref __GroupId, value); }
        }
        private System.String __UserOrGroupId;
        [EntityField]
        public System.String UserOrGroupId
        {
            get { return __UserOrGroupId; }
            set { SetField(ref __UserOrGroupId, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class Holiday : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.Boolean __IsAllDay;
        [EntityField]
        public System.Boolean IsAllDay
        {
            get { return __IsAllDay; }
            set { SetField(ref __IsAllDay, value); }
        }
        private System.DateTime? __ActivityDate;
        [EntityField]
        public System.DateTime? ActivityDate
        {
            get { return __ActivityDate; }
            set { SetField(ref __ActivityDate, value); }
        }
        private System.String __StartTimeInMinutes;
        [EntityField]
        public System.String StartTimeInMinutes
        {
            get { return __StartTimeInMinutes; }
            set { SetField(ref __StartTimeInMinutes, value); }
        }
        private System.String __EndTimeInMinutes;
        [EntityField]
        public System.String EndTimeInMinutes
        {
            get { return __EndTimeInMinutes; }
            set { SetField(ref __EndTimeInMinutes, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsRecurrence;
        [EntityField]
        public System.Boolean IsRecurrence
        {
            get { return __IsRecurrence; }
            set { SetField(ref __IsRecurrence, value); }
        }
        private System.DateTime? __RecurrenceStartDate;
        [EntityField]
        public System.DateTime? RecurrenceStartDate
        {
            get { return __RecurrenceStartDate; }
            set { SetField(ref __RecurrenceStartDate, value); }
        }
        private System.DateTime? __RecurrenceEndDateOnly;
        [EntityField]
        public System.DateTime? RecurrenceEndDateOnly
        {
            get { return __RecurrenceEndDateOnly; }
            set { SetField(ref __RecurrenceEndDateOnly, value); }
        }
        private PickHolidayRecurrenceType? __RecurrenceType;
        [EntityField]
        public PickHolidayRecurrenceType? RecurrenceType
        {
            get { return __RecurrenceType; }
            set { SetField(ref __RecurrenceType, value); }
        }
        private System.String __RecurrenceInterval;
        [EntityField]
        public System.String RecurrenceInterval
        {
            get { return __RecurrenceInterval; }
            set { SetField(ref __RecurrenceInterval, value); }
        }
        private System.String __RecurrenceDayOfWeekMask;
        [EntityField]
        public System.String RecurrenceDayOfWeekMask
        {
            get { return __RecurrenceDayOfWeekMask; }
            set { SetField(ref __RecurrenceDayOfWeekMask, value); }
        }
        private System.String __RecurrenceDayOfMonth;
        [EntityField]
        public System.String RecurrenceDayOfMonth
        {
            get { return __RecurrenceDayOfMonth; }
            set { SetField(ref __RecurrenceDayOfMonth, value); }
        }
        private PickHolidayRecurrenceInstance? __RecurrenceInstance;
        [EntityField]
        public PickHolidayRecurrenceInstance? RecurrenceInstance
        {
            get { return __RecurrenceInstance; }
            set { SetField(ref __RecurrenceInstance, value); }
        }
        private PickHolidayRecurrenceMonthOfYear? __RecurrenceMonthOfYear;
        [EntityField]
        public PickHolidayRecurrenceMonthOfYear? RecurrenceMonthOfYear
        {
            get { return __RecurrenceMonthOfYear; }
            set { SetField(ref __RecurrenceMonthOfYear, value); }
        }
    }
    public class Idea : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __Title;
        [EntityField]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.String __RecordTypeId;
        [EntityField]
        public System.String RecordTypeId
        {
            get { return __RecordTypeId; }
            set { SetField(ref __RecordTypeId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsLocked;
        [EntityField]
        public System.Boolean IsLocked
        {
            get { return __IsLocked; }
            set { SetField(ref __IsLocked, value); }
        }
        private System.String __CommunityId;
        [EntityField]
        public System.String CommunityId
        {
            get { return __CommunityId; }
            set { SetField(ref __CommunityId, value); }
        }
        private System.String __Body;
        [EntityField]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.String __NumComments;
        [EntityField]
        public System.String NumComments
        {
            get { return __NumComments; }
            set { SetField(ref __NumComments, value); }
        }
        private System.String __VoteScore;
        [EntityField]
        public System.String VoteScore
        {
            get { return __VoteScore; }
            set { SetField(ref __VoteScore, value); }
        }
        private System.String __VoteTotal;
        [EntityField]
        public System.String VoteTotal
        {
            get { return __VoteTotal; }
            set { SetField(ref __VoteTotal, value); }
        }
        private System.String __Categories;
        [EntityField]
        public System.String Categories
        {
            get { return __Categories; }
            set { SetField(ref __Categories, value); }
        }
        private PickIdeaStatus? __Status;
        [EntityField]
        public PickIdeaStatus? Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.DateTime? __LastCommentDate;
        [EntityField]
        public System.DateTime? LastCommentDate
        {
            get { return __LastCommentDate; }
            set { SetField(ref __LastCommentDate, value); }
        }
        private System.String __LastCommentId;
        [EntityField]
        public System.String LastCommentId
        {
            get { return __LastCommentId; }
            set { SetField(ref __LastCommentId, value); }
        }
        private System.String __ParentIdeaId;
        [EntityField]
        public System.String ParentIdeaId
        {
            get { return __ParentIdeaId; }
            set { SetField(ref __ParentIdeaId, value); }
        }
        private System.Boolean __IsHtml;
        [EntityField]
        public System.Boolean IsHtml
        {
            get { return __IsHtml; }
            set { SetField(ref __IsHtml, value); }
        }
        [JsonIgnore]
        [ReferencedByField("IdeaId")]
        public RelationShip<Idea, IdeaComment> Comments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Idea, Vote> Votes
        {
            get; set;
        }
    }
    public class IdeaComment : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __IdeaId;
        [EntityField]
        public System.String IdeaId
        {
            get { return __IdeaId; }
            set { SetField(ref __IdeaId, value); }
        }
        private System.String __CommentBody;
        [EntityField]
        public System.String CommentBody
        {
            get { return __CommentBody; }
            set { SetField(ref __CommentBody, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.Boolean __IsHtml;
        [EntityField]
        public System.Boolean IsHtml
        {
            get { return __IsHtml; }
            set { SetField(ref __IsHtml, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<IdeaComment, Vote> Votes
        {
            get; set;
        }
    }
    public class Lead : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __MasterRecordId;
        [EntityField]
        public System.String MasterRecordId
        {
            get { return __MasterRecordId; }
            set { SetField(ref __MasterRecordId, value); }
        }
        private System.String __LastName;
        [EntityField]
        public System.String LastName
        {
            get { return __LastName; }
            set { SetField(ref __LastName, value); }
        }
        private System.String __FirstName;
        [EntityField]
        public System.String FirstName
        {
            get { return __FirstName; }
            set { SetField(ref __FirstName, value); }
        }
        private PickLeadSalutation? __Salutation;
        [EntityField]
        public PickLeadSalutation? Salutation
        {
            get { return __Salutation; }
            set { SetField(ref __Salutation, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Title;
        [EntityField]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.String __Company;
        [EntityField]
        public System.String Company
        {
            get { return __Company; }
            set { SetField(ref __Company, value); }
        }
        private System.String __Street;
        [EntityField]
        public System.String Street
        {
            get { return __Street; }
            set { SetField(ref __Street, value); }
        }
        private System.String __City;
        [EntityField]
        public System.String City
        {
            get { return __City; }
            set { SetField(ref __City, value); }
        }
        private System.String __State;
        [EntityField]
        public System.String State
        {
            get { return __State; }
            set { SetField(ref __State, value); }
        }
        private System.String __PostalCode;
        [EntityField]
        public System.String PostalCode
        {
            get { return __PostalCode; }
            set { SetField(ref __PostalCode, value); }
        }
        private System.String __Country;
        [EntityField]
        public System.String Country
        {
            get { return __Country; }
            set { SetField(ref __Country, value); }
        }
        private System.String __Phone;
        [EntityField]
        public System.String Phone
        {
            get { return __Phone; }
            set { SetField(ref __Phone, value); }
        }
        private System.String __MobilePhone;
        [EntityField]
        public System.String MobilePhone
        {
            get { return __MobilePhone; }
            set { SetField(ref __MobilePhone, value); }
        }
        private System.String __Fax;
        [EntityField]
        public System.String Fax
        {
            get { return __Fax; }
            set { SetField(ref __Fax, value); }
        }
        private System.String __Email;
        [EntityField]
        public System.String Email
        {
            get { return __Email; }
            set { SetField(ref __Email, value); }
        }
        private System.String __Website;
        [EntityField]
        public System.String Website
        {
            get { return __Website; }
            set { SetField(ref __Website, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickLeadLeadSource? __LeadSource;
        [EntityField]
        public PickLeadLeadSource? LeadSource
        {
            get { return __LeadSource; }
            set { SetField(ref __LeadSource, value); }
        }
        private PickLeadStatus __Status;
        [EntityField]
        public PickLeadStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private PickLeadIndustry? __Industry;
        [EntityField]
        public PickLeadIndustry? Industry
        {
            get { return __Industry; }
            set { SetField(ref __Industry, value); }
        }
        private PickLeadRating? __Rating;
        [EntityField]
        public PickLeadRating? Rating
        {
            get { return __Rating; }
            set { SetField(ref __Rating, value); }
        }
        private System.String __AnnualRevenue;
        [EntityField]
        public System.String AnnualRevenue
        {
            get { return __AnnualRevenue; }
            set { SetField(ref __AnnualRevenue, value); }
        }
        private System.String __NumberOfEmployees;
        [EntityField]
        public System.String NumberOfEmployees
        {
            get { return __NumberOfEmployees; }
            set { SetField(ref __NumberOfEmployees, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.Boolean __IsConverted;
        [EntityField]
        public System.Boolean IsConverted
        {
            get { return __IsConverted; }
            set { SetField(ref __IsConverted, value); }
        }
        private System.DateTime? __ConvertedDate;
        [EntityField]
        public System.DateTime? ConvertedDate
        {
            get { return __ConvertedDate; }
            set { SetField(ref __ConvertedDate, value); }
        }
        private System.String __ConvertedAccountId;
        [EntityField]
        public System.String ConvertedAccountId
        {
            get { return __ConvertedAccountId; }
            set { SetField(ref __ConvertedAccountId, value); }
        }
        private System.String __ConvertedContactId;
        [EntityField]
        public System.String ConvertedContactId
        {
            get { return __ConvertedContactId; }
            set { SetField(ref __ConvertedContactId, value); }
        }
        private System.String __ConvertedOpportunityId;
        [EntityField]
        public System.String ConvertedOpportunityId
        {
            get { return __ConvertedOpportunityId; }
            set { SetField(ref __ConvertedOpportunityId, value); }
        }
        private System.Boolean __IsUnreadByOwner;
        [EntityField]
        public System.Boolean IsUnreadByOwner
        {
            get { return __IsUnreadByOwner; }
            set { SetField(ref __IsUnreadByOwner, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime? __LastActivityDate;
        [EntityField]
        public System.DateTime? LastActivityDate
        {
            get { return __LastActivityDate; }
            set { SetField(ref __LastActivityDate, value); }
        }
        private System.String __EmailBouncedReason;
        [EntityField]
        public System.String EmailBouncedReason
        {
            get { return __EmailBouncedReason; }
            set { SetField(ref __EmailBouncedReason, value); }
        }
        private System.DateTime? __EmailBouncedDate;
        [EntityField]
        public System.DateTime? EmailBouncedDate
        {
            get { return __EmailBouncedDate; }
            set { SetField(ref __EmailBouncedDate, value); }
        }
        private System.String __SICCodec;
        [JsonProperty(PropertyName = "SICCode__c")]
        [EntityField]
        public System.String SICCodec
        {
            get { return __SICCodec; }
            set { SetField(ref __SICCodec, value); }
        }
        private PickLeadProductInterest__c? __ProductInterestc;
        [JsonProperty(PropertyName = "ProductInterest__c")]
        [EntityField]
        public PickLeadProductInterest__c? ProductInterestc
        {
            get { return __ProductInterestc; }
            set { SetField(ref __ProductInterestc, value); }
        }
        private PickLeadPrimary__c? __Primaryc;
        [JsonProperty(PropertyName = "Primary__c")]
        [EntityField]
        public PickLeadPrimary__c? Primaryc
        {
            get { return __Primaryc; }
            set { SetField(ref __Primaryc, value); }
        }
        private System.String __CurrentGeneratorsc;
        [JsonProperty(PropertyName = "CurrentGenerators__c")]
        [EntityField]
        public System.String CurrentGeneratorsc
        {
            get { return __CurrentGeneratorsc; }
            set { SetField(ref __CurrentGeneratorsc, value); }
        }
        private System.String __NumberofLocationsc;
        [JsonProperty(PropertyName = "NumberofLocations__c")]
        [EntityField]
        public System.String NumberofLocationsc
        {
            get { return __NumberofLocationsc; }
            set { SetField(ref __NumberofLocationsc, value); }
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Lead, ActivityHistory> ActivityHistories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Lead, Attachment> Attachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("LeadId")]
        public RelationShip<Lead, CampaignMember> CampaignMembers
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Lead, EmailStatus> EmailStatuses
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Lead, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Lead, Event> Events
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Lead, LeadFeed> Feeds
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("LeadId")]
        public RelationShip<Lead, LeadHistory> Histories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("LeadId")]
        public RelationShip<Lead, LeadShare> Shares
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Lead, Note> Notes
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Lead, NoteAndAttachment> NotesAndAttachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Lead, OpenActivity> OpenActivities
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Lead, ProcessInstance> ProcessInstances
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Lead, ProcessInstanceHistory> ProcessSteps
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Lead, Task> Tasks
        {
            get; set;
        }
    }
    public class LeadFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickLeadFeedType? __Type;
        [EntityField]
        public PickLeadFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<LeadFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<LeadFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class LeadHistory : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __LeadId;
        [EntityField]
        public System.String LeadId
        {
            get { return __LeadId; }
            set { SetField(ref __LeadId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickLeadHistoryField __Field;
        [EntityField]
        public PickLeadHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class LeadShare : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __LeadId;
        [EntityField]
        public System.String LeadId
        {
            get { return __LeadId; }
            set { SetField(ref __LeadId, value); }
        }
        private System.String __UserOrGroupId;
        [EntityField]
        public System.String UserOrGroupId
        {
            get { return __UserOrGroupId; }
            set { SetField(ref __UserOrGroupId, value); }
        }
        private PickLeadShareLeadAccessLevel __LeadAccessLevel;
        [EntityField]
        public PickLeadShareLeadAccessLevel LeadAccessLevel
        {
            get { return __LeadAccessLevel; }
            set { SetField(ref __LeadAccessLevel, value); }
        }
        private PickLeadShareRowCause? __RowCause;
        [EntityField]
        public PickLeadShareRowCause? RowCause
        {
            get { return __RowCause; }
            set { SetField(ref __RowCause, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class LeadStatus : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __MasterLabel;
        [EntityField]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __SortOrder;
        [EntityField]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private System.Boolean __IsDefault;
        [EntityField]
        public System.Boolean IsDefault
        {
            get { return __IsDefault; }
            set { SetField(ref __IsDefault, value); }
        }
        private System.Boolean __IsConverted;
        [EntityField]
        public System.Boolean IsConverted
        {
            get { return __IsConverted; }
            set { SetField(ref __IsConverted, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class LoginIp : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __UsersId;
        [EntityField]
        public System.String UsersId
        {
            get { return __UsersId; }
            set { SetField(ref __UsersId, value); }
        }
        private System.String __SourceIp;
        [EntityField]
        public System.String SourceIp
        {
            get { return __SourceIp; }
            set { SetField(ref __SourceIp, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsAuthenticated;
        [EntityField]
        public System.Boolean IsAuthenticated
        {
            get { return __IsAuthenticated; }
            set { SetField(ref __IsAuthenticated, value); }
        }
        private System.DateTime? __ChallengeSentDate;
        [EntityField]
        public System.DateTime? ChallengeSentDate
        {
            get { return __ChallengeSentDate; }
            set { SetField(ref __ChallengeSentDate, value); }
        }
    }
    public class MailmergeTemplate : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __Filename;
        [EntityField]
        public System.String Filename
        {
            get { return __Filename; }
            set { SetField(ref __Filename, value); }
        }
        private System.String __BodyLength;
        [EntityField]
        public System.String BodyLength
        {
            get { return __BodyLength; }
            set { SetField(ref __BodyLength, value); }
        }
        private System.String __Body;
        [EntityField]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.DateTime? __LastUsedDate;
        [EntityField]
        public System.DateTime? LastUsedDate
        {
            get { return __LastUsedDate; }
            set { SetField(ref __LastUsedDate, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __SecurityOptionsAttachmentScannedForXSS;
        [EntityField]
        public System.Boolean SecurityOptionsAttachmentScannedForXSS
        {
            get { return __SecurityOptionsAttachmentScannedForXSS; }
            set { SetField(ref __SecurityOptionsAttachmentScannedForXSS, value); }
        }
        private System.Boolean __SecurityOptionsAttachmentHasXSSThreat;
        [EntityField]
        public System.Boolean SecurityOptionsAttachmentHasXSSThreat
        {
            get { return __SecurityOptionsAttachmentHasXSSThreat; }
            set { SetField(ref __SecurityOptionsAttachmentHasXSSThreat, value); }
        }
        private System.Boolean __SecurityOptionsAttachmentScannedforFlash;
        [EntityField]
        public System.Boolean SecurityOptionsAttachmentScannedforFlash
        {
            get { return __SecurityOptionsAttachmentScannedforFlash; }
            set { SetField(ref __SecurityOptionsAttachmentScannedforFlash, value); }
        }
        private System.Boolean __SecurityOptionsAttachmentHasFlash;
        [EntityField]
        public System.Boolean SecurityOptionsAttachmentHasFlash
        {
            get { return __SecurityOptionsAttachmentHasFlash; }
            set { SetField(ref __SecurityOptionsAttachmentHasFlash, value); }
        }
    }
    public class Name : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String ___Name;
        [JsonProperty(PropertyName = "Name")]
        [EntityField]
        public System.String _Name
        {
            get { return ___Name; }
            set { SetField(ref ___Name, value); }
        }
        private System.String __LastName;
        [EntityField]
        public System.String LastName
        {
            get { return __LastName; }
            set { SetField(ref __LastName, value); }
        }
        private System.String __FirstName;
        [EntityField]
        public System.String FirstName
        {
            get { return __FirstName; }
            set { SetField(ref __FirstName, value); }
        }
        private PickNameType? __Type;
        [EntityField]
        public PickNameType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __Alias;
        [EntityField]
        public System.String Alias
        {
            get { return __Alias; }
            set { SetField(ref __Alias, value); }
        }
        private System.String __UserRoleId;
        [EntityField]
        public System.String UserRoleId
        {
            get { return __UserRoleId; }
            set { SetField(ref __UserRoleId, value); }
        }
        private System.Boolean __IsActive;
        [EntityField]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.String __ProfileId;
        [EntityField]
        public System.String ProfileId
        {
            get { return __ProfileId; }
            set { SetField(ref __ProfileId, value); }
        }
        private System.String __Title;
        [EntityField]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.String __Email;
        [EntityField]
        public System.String Email
        {
            get { return __Email; }
            set { SetField(ref __Email, value); }
        }
        private System.String __Phone;
        [EntityField]
        public System.String Phone
        {
            get { return __Phone; }
            set { SetField(ref __Phone, value); }
        }
        private System.String __Username;
        [EntityField]
        public System.String Username
        {
            get { return __Username; }
            set { SetField(ref __Username, value); }
        }
    }
    public class NewsFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickNewsFeedType? __Type;
        [EntityField]
        public PickNewsFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<NewsFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<NewsFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class Note : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __Title;
        [EntityField]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.Boolean __IsPrivate;
        [EntityField]
        public System.Boolean IsPrivate
        {
            get { return __IsPrivate; }
            set { SetField(ref __IsPrivate, value); }
        }
        private System.String __Body;
        [EntityField]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class NoteAndAttachment : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.Boolean __IsNote;
        [EntityField]
        public System.Boolean IsNote
        {
            get { return __IsNote; }
            set { SetField(ref __IsNote, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __Title;
        [EntityField]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.Boolean __IsPrivate;
        [EntityField]
        public System.Boolean IsPrivate
        {
            get { return __IsPrivate; }
            set { SetField(ref __IsPrivate, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class OpenActivity : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __AccountId;
        [EntityField]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __WhoId;
        [EntityField]
        public System.String WhoId
        {
            get { return __WhoId; }
            set { SetField(ref __WhoId, value); }
        }
        private System.String __WhatId;
        [EntityField]
        public System.String WhatId
        {
            get { return __WhatId; }
            set { SetField(ref __WhatId, value); }
        }
        private System.String __Subject;
        [EntityField]
        public System.String Subject
        {
            get { return __Subject; }
            set { SetField(ref __Subject, value); }
        }
        private System.Boolean __IsTask;
        [EntityField]
        public System.Boolean IsTask
        {
            get { return __IsTask; }
            set { SetField(ref __IsTask, value); }
        }
        private System.DateTime? __ActivityDate;
        [EntityField]
        public System.DateTime? ActivityDate
        {
            get { return __ActivityDate; }
            set { SetField(ref __ActivityDate, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private PickOpenActivityStatus? __Status;
        [EntityField]
        public PickOpenActivityStatus? Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private PickOpenActivityPriority? __Priority;
        [EntityField]
        public PickOpenActivityPriority? Priority
        {
            get { return __Priority; }
            set { SetField(ref __Priority, value); }
        }
        private PickOpenActivityActivityType? __ActivityType;
        [EntityField]
        public PickOpenActivityActivityType? ActivityType
        {
            get { return __ActivityType; }
            set { SetField(ref __ActivityType, value); }
        }
        private System.Boolean __IsClosed;
        [EntityField]
        public System.Boolean IsClosed
        {
            get { return __IsClosed; }
            set { SetField(ref __IsClosed, value); }
        }
        private System.Boolean __IsAllDayEvent;
        [EntityField]
        public System.Boolean IsAllDayEvent
        {
            get { return __IsAllDayEvent; }
            set { SetField(ref __IsAllDayEvent, value); }
        }
        private System.Boolean __IsVisibleInSelfService;
        [EntityField]
        public System.Boolean IsVisibleInSelfService
        {
            get { return __IsVisibleInSelfService; }
            set { SetField(ref __IsVisibleInSelfService, value); }
        }
        private System.String __DurationInMinutes;
        [EntityField]
        public System.String DurationInMinutes
        {
            get { return __DurationInMinutes; }
            set { SetField(ref __DurationInMinutes, value); }
        }
        private System.String __Location;
        [EntityField]
        public System.String Location
        {
            get { return __Location; }
            set { SetField(ref __Location, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __CallDurationInSeconds;
        [EntityField]
        public System.String CallDurationInSeconds
        {
            get { return __CallDurationInSeconds; }
            set { SetField(ref __CallDurationInSeconds, value); }
        }
        private PickOpenActivityCallType? __CallType;
        [EntityField]
        public PickOpenActivityCallType? CallType
        {
            get { return __CallType; }
            set { SetField(ref __CallType, value); }
        }
        private System.String __CallDisposition;
        [EntityField]
        public System.String CallDisposition
        {
            get { return __CallDisposition; }
            set { SetField(ref __CallDisposition, value); }
        }
        private System.String __CallObject;
        [EntityField]
        public System.String CallObject
        {
            get { return __CallObject; }
            set { SetField(ref __CallObject, value); }
        }
        private System.DateTime? __ReminderDateTime;
        [EntityField]
        public System.DateTime? ReminderDateTime
        {
            get { return __ReminderDateTime; }
            set { SetField(ref __ReminderDateTime, value); }
        }
        private System.Boolean __IsReminderSet;
        [EntityField]
        public System.Boolean IsReminderSet
        {
            get { return __IsReminderSet; }
            set { SetField(ref __IsReminderSet, value); }
        }
    }
    public class Opportunity : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __AccountId;
        [EntityField]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.Boolean __IsPrivate;
        [EntityField]
        public System.Boolean IsPrivate
        {
            get { return __IsPrivate; }
            set { SetField(ref __IsPrivate, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickOpportunityStageName __StageName;
        [EntityField]
        public PickOpportunityStageName StageName
        {
            get { return __StageName; }
            set { SetField(ref __StageName, value); }
        }
        private System.String __Amount;
        [EntityField]
        public System.String Amount
        {
            get { return __Amount; }
            set { SetField(ref __Amount, value); }
        }
        private System.String __Probability;
        [EntityField]
        public System.String Probability
        {
            get { return __Probability; }
            set { SetField(ref __Probability, value); }
        }
        private System.String __ExpectedRevenue;
        [EntityField]
        public System.String ExpectedRevenue
        {
            get { return __ExpectedRevenue; }
            set { SetField(ref __ExpectedRevenue, value); }
        }
        private System.String __TotalOpportunityQuantity;
        [EntityField]
        public System.String TotalOpportunityQuantity
        {
            get { return __TotalOpportunityQuantity; }
            set { SetField(ref __TotalOpportunityQuantity, value); }
        }
        private System.DateTime __CloseDate;
        [EntityField]
        public System.DateTime CloseDate
        {
            get { return __CloseDate; }
            set { SetField(ref __CloseDate, value); }
        }
        private PickOpportunityType? __Type;
        [EntityField]
        public PickOpportunityType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __NextStep;
        [EntityField]
        public System.String NextStep
        {
            get { return __NextStep; }
            set { SetField(ref __NextStep, value); }
        }
        private PickOpportunityLeadSource? __LeadSource;
        [EntityField]
        public PickOpportunityLeadSource? LeadSource
        {
            get { return __LeadSource; }
            set { SetField(ref __LeadSource, value); }
        }
        private System.Boolean __IsClosed;
        [EntityField]
        public System.Boolean IsClosed
        {
            get { return __IsClosed; }
            set { SetField(ref __IsClosed, value); }
        }
        private System.Boolean __IsWon;
        [EntityField]
        public System.Boolean IsWon
        {
            get { return __IsWon; }
            set { SetField(ref __IsWon, value); }
        }
        private PickOpportunityForecastCategory __ForecastCategory;
        [EntityField]
        public PickOpportunityForecastCategory ForecastCategory
        {
            get { return __ForecastCategory; }
            set { SetField(ref __ForecastCategory, value); }
        }
        private PickOpportunityForecastCategoryName? __ForecastCategoryName;
        [EntityField]
        public PickOpportunityForecastCategoryName? ForecastCategoryName
        {
            get { return __ForecastCategoryName; }
            set { SetField(ref __ForecastCategoryName, value); }
        }
        private System.String __CampaignId;
        [EntityField]
        public System.String CampaignId
        {
            get { return __CampaignId; }
            set { SetField(ref __CampaignId, value); }
        }
        private System.Boolean __HasOpportunityLineItem;
        [EntityField]
        public System.Boolean HasOpportunityLineItem
        {
            get { return __HasOpportunityLineItem; }
            set { SetField(ref __HasOpportunityLineItem, value); }
        }
        private System.String __Pricebook2Id;
        [EntityField]
        public System.String Pricebook2Id
        {
            get { return __Pricebook2Id; }
            set { SetField(ref __Pricebook2Id, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime? __LastActivityDate;
        [EntityField]
        public System.DateTime? LastActivityDate
        {
            get { return __LastActivityDate; }
            set { SetField(ref __LastActivityDate, value); }
        }
        private System.String __FiscalQuarter;
        [EntityField]
        public System.String FiscalQuarter
        {
            get { return __FiscalQuarter; }
            set { SetField(ref __FiscalQuarter, value); }
        }
        private System.String __FiscalYear;
        [EntityField]
        public System.String FiscalYear
        {
            get { return __FiscalYear; }
            set { SetField(ref __FiscalYear, value); }
        }
        private System.String __Fiscal;
        [EntityField]
        public System.String Fiscal
        {
            get { return __Fiscal; }
            set { SetField(ref __Fiscal, value); }
        }
        private PickOpportunityDeliveryInstallationStatus__c? __DeliveryInstallationStatusc;
        [JsonProperty(PropertyName = "DeliveryInstallationStatus__c")]
        [EntityField]
        public PickOpportunityDeliveryInstallationStatus__c? DeliveryInstallationStatusc
        {
            get { return __DeliveryInstallationStatusc; }
            set { SetField(ref __DeliveryInstallationStatusc, value); }
        }
        private System.String __TrackingNumberc;
        [JsonProperty(PropertyName = "TrackingNumber__c")]
        [EntityField]
        public System.String TrackingNumberc
        {
            get { return __TrackingNumberc; }
            set { SetField(ref __TrackingNumberc, value); }
        }
        private System.String __OrderNumberc;
        [JsonProperty(PropertyName = "OrderNumber__c")]
        [EntityField]
        public System.String OrderNumberc
        {
            get { return __OrderNumberc; }
            set { SetField(ref __OrderNumberc, value); }
        }
        private System.String __CurrentGeneratorsc;
        [JsonProperty(PropertyName = "CurrentGenerators__c")]
        [EntityField]
        public System.String CurrentGeneratorsc
        {
            get { return __CurrentGeneratorsc; }
            set { SetField(ref __CurrentGeneratorsc, value); }
        }
        private System.String __MainCompetitorsc;
        [JsonProperty(PropertyName = "MainCompetitors__c")]
        [EntityField]
        public System.String MainCompetitorsc
        {
            get { return __MainCompetitorsc; }
            set { SetField(ref __MainCompetitorsc, value); }
        }
        [JsonIgnore]
        [ReferencedByField("OpportunityId")]
        public RelationShip<Opportunity, AccountPartner> AccountPartners
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Opportunity, ActivityHistory> ActivityHistories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Opportunity, Attachment> Attachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Opportunity, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Opportunity, Event> Events
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Opportunity, Note> Notes
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Opportunity, NoteAndAttachment> NotesAndAttachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Opportunity, OpenActivity> OpenActivities
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("OpportunityId")]
        public RelationShip<Opportunity, OpportunityCompetitor> OpportunityCompetitors
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("OpportunityId")]
        public RelationShip<Opportunity, OpportunityContactRole> OpportunityContactRoles
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Opportunity, OpportunityFeed> Feeds
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("OpportunityId")]
        public RelationShip<Opportunity, OpportunityFieldHistory> Histories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("OpportunityId")]
        public RelationShip<Opportunity, OpportunityHistory> OpportunityHistories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("OpportunityId")]
        public RelationShip<Opportunity, OpportunityLineItem> OpportunityLineItems
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("OpportunityId")]
        public RelationShip<Opportunity, OpportunityPartner> OpportunityPartnersFrom
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("OpportunityId")]
        public RelationShip<Opportunity, OpportunityShare> Shares
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("OpportunityId")]
        public RelationShip<Opportunity, Partner> Partners
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Opportunity, ProcessInstance> ProcessInstances
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Opportunity, ProcessInstanceHistory> ProcessSteps
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Opportunity, Task> Tasks
        {
            get; set;
        }
    }
    public class OpportunityCompetitor : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __OpportunityId;
        [EntityField]
        public System.String OpportunityId
        {
            get { return __OpportunityId; }
            set { SetField(ref __OpportunityId, value); }
        }
        private System.String __CompetitorName;
        [EntityField]
        public System.String CompetitorName
        {
            get { return __CompetitorName; }
            set { SetField(ref __CompetitorName, value); }
        }
        private System.String __Strengths;
        [EntityField]
        public System.String Strengths
        {
            get { return __Strengths; }
            set { SetField(ref __Strengths, value); }
        }
        private System.String __Weaknesses;
        [EntityField]
        public System.String Weaknesses
        {
            get { return __Weaknesses; }
            set { SetField(ref __Weaknesses, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class OpportunityContactRole : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __OpportunityId;
        [EntityField]
        public System.String OpportunityId
        {
            get { return __OpportunityId; }
            set { SetField(ref __OpportunityId, value); }
        }
        private System.String __ContactId;
        [EntityField]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private PickOpportunityContactRoleRole? __Role;
        [EntityField]
        public PickOpportunityContactRoleRole? Role
        {
            get { return __Role; }
            set { SetField(ref __Role, value); }
        }
        private System.Boolean __IsPrimary;
        [EntityField]
        public System.Boolean IsPrimary
        {
            get { return __IsPrimary; }
            set { SetField(ref __IsPrimary, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class OpportunityFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickOpportunityFeedType? __Type;
        [EntityField]
        public PickOpportunityFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<OpportunityFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<OpportunityFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class OpportunityFieldHistory : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __OpportunityId;
        [EntityField]
        public System.String OpportunityId
        {
            get { return __OpportunityId; }
            set { SetField(ref __OpportunityId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickOpportunityFieldHistoryField __Field;
        [EntityField]
        public PickOpportunityFieldHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class OpportunityHistory : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __OpportunityId;
        [EntityField]
        public System.String OpportunityId
        {
            get { return __OpportunityId; }
            set { SetField(ref __OpportunityId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickOpportunityHistoryStageName __StageName;
        [EntityField]
        public PickOpportunityHistoryStageName StageName
        {
            get { return __StageName; }
            set { SetField(ref __StageName, value); }
        }
        private System.String __Amount;
        [EntityField]
        public System.String Amount
        {
            get { return __Amount; }
            set { SetField(ref __Amount, value); }
        }
        private System.String __ExpectedRevenue;
        [EntityField]
        public System.String ExpectedRevenue
        {
            get { return __ExpectedRevenue; }
            set { SetField(ref __ExpectedRevenue, value); }
        }
        private System.DateTime? __CloseDate;
        [EntityField]
        public System.DateTime? CloseDate
        {
            get { return __CloseDate; }
            set { SetField(ref __CloseDate, value); }
        }
        private System.String __Probability;
        [EntityField]
        public System.String Probability
        {
            get { return __Probability; }
            set { SetField(ref __Probability, value); }
        }
        private PickOpportunityHistoryForecastCategory? __ForecastCategory;
        [EntityField]
        public PickOpportunityHistoryForecastCategory? ForecastCategory
        {
            get { return __ForecastCategory; }
            set { SetField(ref __ForecastCategory, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class OpportunityLineItem : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __OpportunityId;
        [EntityField]
        public System.String OpportunityId
        {
            get { return __OpportunityId; }
            set { SetField(ref __OpportunityId, value); }
        }
        private System.String __SortOrder;
        [EntityField]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private System.String __PricebookEntryId;
        [EntityField]
        public System.String PricebookEntryId
        {
            get { return __PricebookEntryId; }
            set { SetField(ref __PricebookEntryId, value); }
        }
        private System.String __Quantity;
        [EntityField]
        public System.String Quantity
        {
            get { return __Quantity; }
            set { SetField(ref __Quantity, value); }
        }
        private System.String __TotalPrice;
        [EntityField]
        public System.String TotalPrice
        {
            get { return __TotalPrice; }
            set { SetField(ref __TotalPrice, value); }
        }
        private System.String __UnitPrice;
        [EntityField]
        public System.String UnitPrice
        {
            get { return __UnitPrice; }
            set { SetField(ref __UnitPrice, value); }
        }
        private System.String __ListPrice;
        [EntityField]
        public System.String ListPrice
        {
            get { return __ListPrice; }
            set { SetField(ref __ListPrice, value); }
        }
        private System.DateTime? __ServiceDate;
        [EntityField]
        public System.DateTime? ServiceDate
        {
            get { return __ServiceDate; }
            set { SetField(ref __ServiceDate, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class OpportunityPartner : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __OpportunityId;
        [EntityField]
        public System.String OpportunityId
        {
            get { return __OpportunityId; }
            set { SetField(ref __OpportunityId, value); }
        }
        private System.String __AccountToId;
        [EntityField]
        public System.String AccountToId
        {
            get { return __AccountToId; }
            set { SetField(ref __AccountToId, value); }
        }
        private PickOpportunityPartnerRole? __Role;
        [EntityField]
        public PickOpportunityPartnerRole? Role
        {
            get { return __Role; }
            set { SetField(ref __Role, value); }
        }
        private System.Boolean __IsPrimary;
        [EntityField]
        public System.Boolean IsPrimary
        {
            get { return __IsPrimary; }
            set { SetField(ref __IsPrimary, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ReversePartnerId;
        [EntityField]
        public System.String ReversePartnerId
        {
            get { return __ReversePartnerId; }
            set { SetField(ref __ReversePartnerId, value); }
        }
    }
    public class OpportunityShare : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __OpportunityId;
        [EntityField]
        public System.String OpportunityId
        {
            get { return __OpportunityId; }
            set { SetField(ref __OpportunityId, value); }
        }
        private System.String __UserOrGroupId;
        [EntityField]
        public System.String UserOrGroupId
        {
            get { return __UserOrGroupId; }
            set { SetField(ref __UserOrGroupId, value); }
        }
        private PickOpportunityShareOpportunityAccessLevel __OpportunityAccessLevel;
        [EntityField]
        public PickOpportunityShareOpportunityAccessLevel OpportunityAccessLevel
        {
            get { return __OpportunityAccessLevel; }
            set { SetField(ref __OpportunityAccessLevel, value); }
        }
        private PickOpportunityShareRowCause? __RowCause;
        [EntityField]
        public PickOpportunityShareRowCause? RowCause
        {
            get { return __RowCause; }
            set { SetField(ref __RowCause, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class OpportunityStage : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __MasterLabel;
        [EntityField]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.Boolean __IsActive;
        [EntityField]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.String __SortOrder;
        [EntityField]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private System.Boolean __IsClosed;
        [EntityField]
        public System.Boolean IsClosed
        {
            get { return __IsClosed; }
            set { SetField(ref __IsClosed, value); }
        }
        private System.Boolean __IsWon;
        [EntityField]
        public System.Boolean IsWon
        {
            get { return __IsWon; }
            set { SetField(ref __IsWon, value); }
        }
        private PickOpportunityStageForecastCategory __ForecastCategory;
        [EntityField]
        public PickOpportunityStageForecastCategory ForecastCategory
        {
            get { return __ForecastCategory; }
            set { SetField(ref __ForecastCategory, value); }
        }
        private PickOpportunityStageForecastCategoryName __ForecastCategoryName;
        [EntityField]
        public PickOpportunityStageForecastCategoryName ForecastCategoryName
        {
            get { return __ForecastCategoryName; }
            set { SetField(ref __ForecastCategoryName, value); }
        }
        private System.String __DefaultProbability;
        [EntityField]
        public System.String DefaultProbability
        {
            get { return __DefaultProbability; }
            set { SetField(ref __DefaultProbability, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class Order : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ContractId;
        [EntityField]
        public System.String ContractId
        {
            get { return __ContractId; }
            set { SetField(ref __ContractId, value); }
        }
        private System.String __AccountId;
        [EntityField]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.DateTime __EffectiveDate;
        [EntityField]
        public System.DateTime EffectiveDate
        {
            get { return __EffectiveDate; }
            set { SetField(ref __EffectiveDate, value); }
        }
        private System.Boolean __IsReductionOrder;
        [EntityField]
        public System.Boolean IsReductionOrder
        {
            get { return __IsReductionOrder; }
            set { SetField(ref __IsReductionOrder, value); }
        }
        private PickOrderStatus __Status;
        [EntityField]
        public PickOrderStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __CustomerAuthorizedById;
        [EntityField]
        public System.String CustomerAuthorizedById
        {
            get { return __CustomerAuthorizedById; }
            set { SetField(ref __CustomerAuthorizedById, value); }
        }
        private System.DateTime? __CustomerAuthorizedDate;
        [EntityField]
        public System.DateTime? CustomerAuthorizedDate
        {
            get { return __CustomerAuthorizedDate; }
            set { SetField(ref __CustomerAuthorizedDate, value); }
        }
        private System.String __CompanyAuthorizedById;
        [EntityField]
        public System.String CompanyAuthorizedById
        {
            get { return __CompanyAuthorizedById; }
            set { SetField(ref __CompanyAuthorizedById, value); }
        }
        private System.DateTime? __CompanyAuthorizedDate;
        [EntityField]
        public System.DateTime? CompanyAuthorizedDate
        {
            get { return __CompanyAuthorizedDate; }
            set { SetField(ref __CompanyAuthorizedDate, value); }
        }
        private PickOrderType? __Type;
        [EntityField]
        public PickOrderType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __BillingStreet;
        [EntityField]
        public System.String BillingStreet
        {
            get { return __BillingStreet; }
            set { SetField(ref __BillingStreet, value); }
        }
        private System.String __BillingCity;
        [EntityField]
        public System.String BillingCity
        {
            get { return __BillingCity; }
            set { SetField(ref __BillingCity, value); }
        }
        private System.String __BillingState;
        [EntityField]
        public System.String BillingState
        {
            get { return __BillingState; }
            set { SetField(ref __BillingState, value); }
        }
        private System.String __BillingPostalCode;
        [EntityField]
        public System.String BillingPostalCode
        {
            get { return __BillingPostalCode; }
            set { SetField(ref __BillingPostalCode, value); }
        }
        private System.String __BillingCountry;
        [EntityField]
        public System.String BillingCountry
        {
            get { return __BillingCountry; }
            set { SetField(ref __BillingCountry, value); }
        }
        private System.String __ShippingStreet;
        [EntityField]
        public System.String ShippingStreet
        {
            get { return __ShippingStreet; }
            set { SetField(ref __ShippingStreet, value); }
        }
        private System.String __ShippingCity;
        [EntityField]
        public System.String ShippingCity
        {
            get { return __ShippingCity; }
            set { SetField(ref __ShippingCity, value); }
        }
        private System.String __ShippingState;
        [EntityField]
        public System.String ShippingState
        {
            get { return __ShippingState; }
            set { SetField(ref __ShippingState, value); }
        }
        private System.String __ShippingPostalCode;
        [EntityField]
        public System.String ShippingPostalCode
        {
            get { return __ShippingPostalCode; }
            set { SetField(ref __ShippingPostalCode, value); }
        }
        private System.String __ShippingCountry;
        [EntityField]
        public System.String ShippingCountry
        {
            get { return __ShippingCountry; }
            set { SetField(ref __ShippingCountry, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.DateTime? __PoDate;
        [EntityField]
        public System.DateTime? PoDate
        {
            get { return __PoDate; }
            set { SetField(ref __PoDate, value); }
        }
        private System.String __PoNumber;
        [EntityField]
        public System.String PoNumber
        {
            get { return __PoNumber; }
            set { SetField(ref __PoNumber, value); }
        }
        private System.String __OrderReferenceNumber;
        [EntityField]
        public System.String OrderReferenceNumber
        {
            get { return __OrderReferenceNumber; }
            set { SetField(ref __OrderReferenceNumber, value); }
        }
        private System.String __BillToContactId;
        [EntityField]
        public System.String BillToContactId
        {
            get { return __BillToContactId; }
            set { SetField(ref __BillToContactId, value); }
        }
        private System.String __ShipToContactId;
        [EntityField]
        public System.String ShipToContactId
        {
            get { return __ShipToContactId; }
            set { SetField(ref __ShipToContactId, value); }
        }
        private System.DateTime? __ActivatedDate;
        [EntityField]
        public System.DateTime? ActivatedDate
        {
            get { return __ActivatedDate; }
            set { SetField(ref __ActivatedDate, value); }
        }
        private System.String __ActivatedById;
        [EntityField]
        public System.String ActivatedById
        {
            get { return __ActivatedById; }
            set { SetField(ref __ActivatedById, value); }
        }
        private PickOrderStatusCode __StatusCode;
        [EntityField]
        public PickOrderStatusCode StatusCode
        {
            get { return __StatusCode; }
            set { SetField(ref __StatusCode, value); }
        }
        private System.String __OrderNumber;
        [EntityField]
        public System.String OrderNumber
        {
            get { return __OrderNumber; }
            set { SetField(ref __OrderNumber, value); }
        }
        private System.String __TotalAmount;
        [EntityField]
        public System.String TotalAmount
        {
            get { return __TotalAmount; }
            set { SetField(ref __TotalAmount, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Order, ActivityHistory> ActivityHistories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Order, Attachment> Attachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Order, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Order, Event> Events
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Order, Note> Notes
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Order, NoteAndAttachment> NotesAndAttachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Order, OpenActivity> OpenActivities
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("OrderId")]
        public RelationShip<Order, OrderHistory> Histories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("OrderId")]
        public RelationShip<Order, OrderItem> OrderItems
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Order, ProcessInstance> ProcessInstances
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Order, ProcessInstanceHistory> ProcessSteps
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Order, Task> Tasks
        {
            get; set;
        }
    }
    public class OrderHistory : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __OrderId;
        [EntityField]
        public System.String OrderId
        {
            get { return __OrderId; }
            set { SetField(ref __OrderId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickOrderHistoryField __Field;
        [EntityField]
        public PickOrderHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class OrderItem : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __OrderId;
        [EntityField]
        public System.String OrderId
        {
            get { return __OrderId; }
            set { SetField(ref __OrderId, value); }
        }
        private System.String __PricebookEntryId;
        [EntityField]
        public System.String PricebookEntryId
        {
            get { return __PricebookEntryId; }
            set { SetField(ref __PricebookEntryId, value); }
        }
        private System.String __OriginalOrderItemId;
        [EntityField]
        public System.String OriginalOrderItemId
        {
            get { return __OriginalOrderItemId; }
            set { SetField(ref __OriginalOrderItemId, value); }
        }
        private System.String __Quantity;
        [EntityField]
        public System.String Quantity
        {
            get { return __Quantity; }
            set { SetField(ref __Quantity, value); }
        }
        private System.String __UnitPrice;
        [EntityField]
        public System.String UnitPrice
        {
            get { return __UnitPrice; }
            set { SetField(ref __UnitPrice, value); }
        }
        private System.String __ListPrice;
        [EntityField]
        public System.String ListPrice
        {
            get { return __ListPrice; }
            set { SetField(ref __ListPrice, value); }
        }
        private System.DateTime? __ServiceDate;
        [EntityField]
        public System.DateTime? ServiceDate
        {
            get { return __ServiceDate; }
            set { SetField(ref __ServiceDate, value); }
        }
        private System.DateTime? __EndDate;
        [EntityField]
        public System.DateTime? EndDate
        {
            get { return __EndDate; }
            set { SetField(ref __EndDate, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __OrderItemNumber;
        [EntityField]
        public System.String OrderItemNumber
        {
            get { return __OrderItemNumber; }
            set { SetField(ref __OrderItemNumber, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<OrderItem, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("OriginalOrderItemId")]
        public RelationShip<OrderItem, OrderItem> ChildOrderItems
        {
            get; set;
        }
    }
    public class OrgWideEmailAddress : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __Address;
        [EntityField]
        public System.String Address
        {
            get { return __Address; }
            set { SetField(ref __Address, value); }
        }
        private System.String __DisplayName;
        [EntityField]
        public System.String DisplayName
        {
            get { return __DisplayName; }
            set { SetField(ref __DisplayName, value); }
        }
        private System.Boolean __IsAllowAllProfiles;
        [EntityField]
        public System.Boolean IsAllowAllProfiles
        {
            get { return __IsAllowAllProfiles; }
            set { SetField(ref __IsAllowAllProfiles, value); }
        }
    }
    public class Organization : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Division;
        [EntityField]
        public System.String Division
        {
            get { return __Division; }
            set { SetField(ref __Division, value); }
        }
        private System.String __Street;
        [EntityField]
        public System.String Street
        {
            get { return __Street; }
            set { SetField(ref __Street, value); }
        }
        private System.String __City;
        [EntityField]
        public System.String City
        {
            get { return __City; }
            set { SetField(ref __City, value); }
        }
        private System.String __State;
        [EntityField]
        public System.String State
        {
            get { return __State; }
            set { SetField(ref __State, value); }
        }
        private System.String __PostalCode;
        [EntityField]
        public System.String PostalCode
        {
            get { return __PostalCode; }
            set { SetField(ref __PostalCode, value); }
        }
        private System.String __Country;
        [EntityField]
        public System.String Country
        {
            get { return __Country; }
            set { SetField(ref __Country, value); }
        }
        private System.String __Phone;
        [EntityField]
        public System.String Phone
        {
            get { return __Phone; }
            set { SetField(ref __Phone, value); }
        }
        private System.String __Fax;
        [EntityField]
        public System.String Fax
        {
            get { return __Fax; }
            set { SetField(ref __Fax, value); }
        }
        private System.String __PrimaryContact;
        [EntityField]
        public System.String PrimaryContact
        {
            get { return __PrimaryContact; }
            set { SetField(ref __PrimaryContact, value); }
        }
        private PickOrganizationDefaultLocaleSidKey __DefaultLocaleSidKey;
        [EntityField]
        public PickOrganizationDefaultLocaleSidKey DefaultLocaleSidKey
        {
            get { return __DefaultLocaleSidKey; }
            set { SetField(ref __DefaultLocaleSidKey, value); }
        }
        private PickOrganizationLanguageLocaleKey __LanguageLocaleKey;
        [EntityField]
        public PickOrganizationLanguageLocaleKey LanguageLocaleKey
        {
            get { return __LanguageLocaleKey; }
            set { SetField(ref __LanguageLocaleKey, value); }
        }
        private System.Boolean __ReceivesInfoEmails;
        [EntityField]
        public System.Boolean ReceivesInfoEmails
        {
            get { return __ReceivesInfoEmails; }
            set { SetField(ref __ReceivesInfoEmails, value); }
        }
        private System.Boolean __ReceivesAdminInfoEmails;
        [EntityField]
        public System.Boolean ReceivesAdminInfoEmails
        {
            get { return __ReceivesAdminInfoEmails; }
            set { SetField(ref __ReceivesAdminInfoEmails, value); }
        }
        private System.Boolean __PreferencesRequireOpportunityProducts;
        [EntityField]
        public System.Boolean PreferencesRequireOpportunityProducts
        {
            get { return __PreferencesRequireOpportunityProducts; }
            set { SetField(ref __PreferencesRequireOpportunityProducts, value); }
        }
        private System.Boolean __PreferencesTransactionSecurityPolicy;
        [EntityField]
        public System.Boolean PreferencesTransactionSecurityPolicy
        {
            get { return __PreferencesTransactionSecurityPolicy; }
            set { SetField(ref __PreferencesTransactionSecurityPolicy, value); }
        }
        private System.Boolean __PreferencesTerminateOldestSession;
        [EntityField]
        public System.Boolean PreferencesTerminateOldestSession
        {
            get { return __PreferencesTerminateOldestSession; }
            set { SetField(ref __PreferencesTerminateOldestSession, value); }
        }
        private System.String __FiscalYearStartMonth;
        [EntityField]
        public System.String FiscalYearStartMonth
        {
            get { return __FiscalYearStartMonth; }
            set { SetField(ref __FiscalYearStartMonth, value); }
        }
        private System.Boolean __UsesStartDateAsFiscalYearName;
        [EntityField]
        public System.Boolean UsesStartDateAsFiscalYearName
        {
            get { return __UsesStartDateAsFiscalYearName; }
            set { SetField(ref __UsesStartDateAsFiscalYearName, value); }
        }
        private PickOrganizationDefaultAccountAccess? __DefaultAccountAccess;
        [EntityField]
        public PickOrganizationDefaultAccountAccess? DefaultAccountAccess
        {
            get { return __DefaultAccountAccess; }
            set { SetField(ref __DefaultAccountAccess, value); }
        }
        private PickOrganizationDefaultContactAccess? __DefaultContactAccess;
        [EntityField]
        public PickOrganizationDefaultContactAccess? DefaultContactAccess
        {
            get { return __DefaultContactAccess; }
            set { SetField(ref __DefaultContactAccess, value); }
        }
        private PickOrganizationDefaultOpportunityAccess? __DefaultOpportunityAccess;
        [EntityField]
        public PickOrganizationDefaultOpportunityAccess? DefaultOpportunityAccess
        {
            get { return __DefaultOpportunityAccess; }
            set { SetField(ref __DefaultOpportunityAccess, value); }
        }
        private PickOrganizationDefaultLeadAccess? __DefaultLeadAccess;
        [EntityField]
        public PickOrganizationDefaultLeadAccess? DefaultLeadAccess
        {
            get { return __DefaultLeadAccess; }
            set { SetField(ref __DefaultLeadAccess, value); }
        }
        private PickOrganizationDefaultCaseAccess? __DefaultCaseAccess;
        [EntityField]
        public PickOrganizationDefaultCaseAccess? DefaultCaseAccess
        {
            get { return __DefaultCaseAccess; }
            set { SetField(ref __DefaultCaseAccess, value); }
        }
        private PickOrganizationDefaultCalendarAccess? __DefaultCalendarAccess;
        [EntityField]
        public PickOrganizationDefaultCalendarAccess? DefaultCalendarAccess
        {
            get { return __DefaultCalendarAccess; }
            set { SetField(ref __DefaultCalendarAccess, value); }
        }
        private PickOrganizationDefaultPricebookAccess? __DefaultPricebookAccess;
        [EntityField]
        public PickOrganizationDefaultPricebookAccess? DefaultPricebookAccess
        {
            get { return __DefaultPricebookAccess; }
            set { SetField(ref __DefaultPricebookAccess, value); }
        }
        private PickOrganizationDefaultCampaignAccess? __DefaultCampaignAccess;
        [EntityField]
        public PickOrganizationDefaultCampaignAccess? DefaultCampaignAccess
        {
            get { return __DefaultCampaignAccess; }
            set { SetField(ref __DefaultCampaignAccess, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __ComplianceBccEmail;
        [EntityField]
        public System.String ComplianceBccEmail
        {
            get { return __ComplianceBccEmail; }
            set { SetField(ref __ComplianceBccEmail, value); }
        }
        private PickOrganizationUiSkin? __UiSkin;
        [EntityField]
        public PickOrganizationUiSkin? UiSkin
        {
            get { return __UiSkin; }
            set { SetField(ref __UiSkin, value); }
        }
        private System.String __SignupCountryIsoCode;
        [EntityField]
        public System.String SignupCountryIsoCode
        {
            get { return __SignupCountryIsoCode; }
            set { SetField(ref __SignupCountryIsoCode, value); }
        }
        private System.DateTime? __TrialExpirationDate;
        [EntityField]
        public System.DateTime? TrialExpirationDate
        {
            get { return __TrialExpirationDate; }
            set { SetField(ref __TrialExpirationDate, value); }
        }
        private PickOrganizationOrganizationType? __OrganizationType;
        [EntityField]
        public PickOrganizationOrganizationType? OrganizationType
        {
            get { return __OrganizationType; }
            set { SetField(ref __OrganizationType, value); }
        }
        private System.String __WebToCaseDefaultOrigin;
        [EntityField]
        public System.String WebToCaseDefaultOrigin
        {
            get { return __WebToCaseDefaultOrigin; }
            set { SetField(ref __WebToCaseDefaultOrigin, value); }
        }
        private System.String __MonthlyPageViewsUsed;
        [EntityField]
        public System.String MonthlyPageViewsUsed
        {
            get { return __MonthlyPageViewsUsed; }
            set { SetField(ref __MonthlyPageViewsUsed, value); }
        }
        private System.String __MonthlyPageViewsEntitlement;
        [EntityField]
        public System.String MonthlyPageViewsEntitlement
        {
            get { return __MonthlyPageViewsEntitlement; }
            set { SetField(ref __MonthlyPageViewsEntitlement, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
    }
    public class Partner : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __OpportunityId;
        [EntityField]
        public System.String OpportunityId
        {
            get { return __OpportunityId; }
            set { SetField(ref __OpportunityId, value); }
        }
        private System.String __AccountFromId;
        [EntityField]
        public System.String AccountFromId
        {
            get { return __AccountFromId; }
            set { SetField(ref __AccountFromId, value); }
        }
        private System.String __AccountToId;
        [EntityField]
        public System.String AccountToId
        {
            get { return __AccountToId; }
            set { SetField(ref __AccountToId, value); }
        }
        private PickPartnerRole? __Role;
        [EntityField]
        public PickPartnerRole? Role
        {
            get { return __Role; }
            set { SetField(ref __Role, value); }
        }
        private System.Boolean __IsPrimary;
        [EntityField]
        public System.Boolean IsPrimary
        {
            get { return __IsPrimary; }
            set { SetField(ref __IsPrimary, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ReversePartnerId;
        [EntityField]
        public System.String ReversePartnerId
        {
            get { return __ReversePartnerId; }
            set { SetField(ref __ReversePartnerId, value); }
        }
    }
    public class PartnerRole : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __MasterLabel;
        [EntityField]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __SortOrder;
        [EntityField]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private PickPartnerRoleReverseRole? __ReverseRole;
        [EntityField]
        public PickPartnerRoleReverseRole? ReverseRole
        {
            get { return __ReverseRole; }
            set { SetField(ref __ReverseRole, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class Period : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __FiscalYearSettingsId;
        [EntityField]
        public System.String FiscalYearSettingsId
        {
            get { return __FiscalYearSettingsId; }
            set { SetField(ref __FiscalYearSettingsId, value); }
        }
        private PickPeriodType? __Type;
        [EntityField]
        public PickPeriodType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.DateTime __StartDate;
        [EntityField]
        public System.DateTime StartDate
        {
            get { return __StartDate; }
            set { SetField(ref __StartDate, value); }
        }
        private System.DateTime __EndDate;
        [EntityField]
        public System.DateTime EndDate
        {
            get { return __EndDate; }
            set { SetField(ref __EndDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsForecastPeriod;
        [EntityField]
        public System.Boolean IsForecastPeriod
        {
            get { return __IsForecastPeriod; }
            set { SetField(ref __IsForecastPeriod, value); }
        }
        private PickPeriodQuarterLabel? __QuarterLabel;
        [EntityField]
        public PickPeriodQuarterLabel? QuarterLabel
        {
            get { return __QuarterLabel; }
            set { SetField(ref __QuarterLabel, value); }
        }
        private PickPeriodPeriodLabel? __PeriodLabel;
        [EntityField]
        public PickPeriodPeriodLabel? PeriodLabel
        {
            get { return __PeriodLabel; }
            set { SetField(ref __PeriodLabel, value); }
        }
        private System.String __Number;
        [EntityField]
        public System.String Number
        {
            get { return __Number; }
            set { SetField(ref __Number, value); }
        }
    }
    public class Pricebook2 : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsActive;
        [EntityField]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.Boolean __IsStandard;
        [EntityField]
        public System.Boolean IsStandard
        {
            get { return __IsStandard; }
            set { SetField(ref __IsStandard, value); }
        }
        [JsonIgnore]
        [ReferencedByField("Pricebook2Id")]
        public RelationShip<Pricebook2, Contract> Contracts
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("Pricebook2Id")]
        public RelationShip<Pricebook2, Opportunity> Opportunities
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("Pricebook2Id")]
        public RelationShip<Pricebook2, Pricebook2History> Histories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("Pricebook2Id")]
        public RelationShip<Pricebook2, PricebookEntry> PricebookEntries
        {
            get; set;
        }
    }
    public class Pricebook2History : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __Pricebook2Id;
        [EntityField]
        public System.String Pricebook2Id
        {
            get { return __Pricebook2Id; }
            set { SetField(ref __Pricebook2Id, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickPricebook2HistoryField __Field;
        [EntityField]
        public PickPricebook2HistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class PricebookEntry : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Pricebook2Id;
        [EntityField]
        public System.String Pricebook2Id
        {
            get { return __Pricebook2Id; }
            set { SetField(ref __Pricebook2Id, value); }
        }
        private System.String __Product2Id;
        [EntityField]
        public System.String Product2Id
        {
            get { return __Product2Id; }
            set { SetField(ref __Product2Id, value); }
        }
        private System.String __UnitPrice;
        [EntityField]
        public System.String UnitPrice
        {
            get { return __UnitPrice; }
            set { SetField(ref __UnitPrice, value); }
        }
        private System.Boolean __IsActive;
        [EntityField]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.Boolean __UseStandardPrice;
        [EntityField]
        public System.Boolean UseStandardPrice
        {
            get { return __UseStandardPrice; }
            set { SetField(ref __UseStandardPrice, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __ProductCode;
        [EntityField]
        public System.String ProductCode
        {
            get { return __ProductCode; }
            set { SetField(ref __ProductCode, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        [JsonIgnore]
        [ReferencedByField("PricebookEntryId")]
        public RelationShip<PricebookEntry, OpportunityLineItem> OpportunityLineItems
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("PricebookEntryId")]
        public RelationShip<PricebookEntry, OrderItem> OrderItems
        {
            get; set;
        }
    }
    public class ProcessDefinition : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __DeveloperName;
        [EntityField]
        public System.String DeveloperName
        {
            get { return __DeveloperName; }
            set { SetField(ref __DeveloperName, value); }
        }
        private PickProcessDefinitionType __Type;
        [EntityField]
        public PickProcessDefinitionType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickProcessDefinitionTableEnumOrId __TableEnumOrId;
        [EntityField]
        public PickProcessDefinitionTableEnumOrId TableEnumOrId
        {
            get { return __TableEnumOrId; }
            set { SetField(ref __TableEnumOrId, value); }
        }
        private PickProcessDefinitionLockType __LockType;
        [EntityField]
        public PickProcessDefinitionLockType LockType
        {
            get { return __LockType; }
            set { SetField(ref __LockType, value); }
        }
        private PickProcessDefinitionState __State;
        [EntityField]
        public PickProcessDefinitionState State
        {
            get { return __State; }
            set { SetField(ref __State, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class ProcessInstance : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ProcessDefinitionId;
        [EntityField]
        public System.String ProcessDefinitionId
        {
            get { return __ProcessDefinitionId; }
            set { SetField(ref __ProcessDefinitionId, value); }
        }
        private System.String __TargetObjectId;
        [EntityField]
        public System.String TargetObjectId
        {
            get { return __TargetObjectId; }
            set { SetField(ref __TargetObjectId, value); }
        }
        private PickProcessInstanceStatus __Status;
        [EntityField]
        public PickProcessInstanceStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ProcessInstanceId")]
        public RelationShip<ProcessInstance, ProcessInstanceHistory> StepsAndWorkitems
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ProcessInstanceId")]
        public RelationShip<ProcessInstance, ProcessInstanceStep> Steps
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ProcessInstanceId")]
        public RelationShip<ProcessInstance, ProcessInstanceWorkitem> Workitems
        {
            get; set;
        }
    }
    public class ProcessInstanceHistory : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsPending;
        [EntityField]
        public System.Boolean IsPending
        {
            get { return __IsPending; }
            set { SetField(ref __IsPending, value); }
        }
        private System.String __ProcessInstanceId;
        [EntityField]
        public System.String ProcessInstanceId
        {
            get { return __ProcessInstanceId; }
            set { SetField(ref __ProcessInstanceId, value); }
        }
        private System.String __TargetObjectId;
        [EntityField]
        public System.String TargetObjectId
        {
            get { return __TargetObjectId; }
            set { SetField(ref __TargetObjectId, value); }
        }
        private PickProcessInstanceHistoryStepStatus? __StepStatus;
        [EntityField]
        public PickProcessInstanceHistoryStepStatus? StepStatus
        {
            get { return __StepStatus; }
            set { SetField(ref __StepStatus, value); }
        }
        private System.String __OriginalActorId;
        [EntityField]
        public System.String OriginalActorId
        {
            get { return __OriginalActorId; }
            set { SetField(ref __OriginalActorId, value); }
        }
        private System.String __ActorId;
        [EntityField]
        public System.String ActorId
        {
            get { return __ActorId; }
            set { SetField(ref __ActorId, value); }
        }
        private System.String __RemindersSent;
        [EntityField]
        public System.String RemindersSent
        {
            get { return __RemindersSent; }
            set { SetField(ref __RemindersSent, value); }
        }
        private System.String __Comments;
        [EntityField]
        public System.String Comments
        {
            get { return __Comments; }
            set { SetField(ref __Comments, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class ProcessInstanceStep : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ProcessInstanceId;
        [EntityField]
        public System.String ProcessInstanceId
        {
            get { return __ProcessInstanceId; }
            set { SetField(ref __ProcessInstanceId, value); }
        }
        private PickProcessInstanceStepStepStatus? __StepStatus;
        [EntityField]
        public PickProcessInstanceStepStepStatus? StepStatus
        {
            get { return __StepStatus; }
            set { SetField(ref __StepStatus, value); }
        }
        private System.String __OriginalActorId;
        [EntityField]
        public System.String OriginalActorId
        {
            get { return __OriginalActorId; }
            set { SetField(ref __OriginalActorId, value); }
        }
        private System.String __ActorId;
        [EntityField]
        public System.String ActorId
        {
            get { return __ActorId; }
            set { SetField(ref __ActorId, value); }
        }
        private System.String __Comments;
        [EntityField]
        public System.String Comments
        {
            get { return __Comments; }
            set { SetField(ref __Comments, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class ProcessInstanceWorkitem : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ProcessInstanceId;
        [EntityField]
        public System.String ProcessInstanceId
        {
            get { return __ProcessInstanceId; }
            set { SetField(ref __ProcessInstanceId, value); }
        }
        private System.String __OriginalActorId;
        [EntityField]
        public System.String OriginalActorId
        {
            get { return __OriginalActorId; }
            set { SetField(ref __OriginalActorId, value); }
        }
        private System.String __ActorId;
        [EntityField]
        public System.String ActorId
        {
            get { return __ActorId; }
            set { SetField(ref __ActorId, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class ProcessNode : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __DeveloperName;
        [EntityField]
        public System.String DeveloperName
        {
            get { return __DeveloperName; }
            set { SetField(ref __DeveloperName, value); }
        }
        private System.String __ProcessDefinitionId;
        [EntityField]
        public System.String ProcessDefinitionId
        {
            get { return __ProcessDefinitionId; }
            set { SetField(ref __ProcessDefinitionId, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class Product2 : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __ProductCode;
        [EntityField]
        public System.String ProductCode
        {
            get { return __ProductCode; }
            set { SetField(ref __ProductCode, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.Boolean __IsActive;
        [EntityField]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private PickProduct2Family? __Family;
        [EntityField]
        public PickProduct2Family? Family
        {
            get { return __Family; }
            set { SetField(ref __Family, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Product2, ActivityHistory> ActivityHistories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("Product2Id")]
        public RelationShip<Product2, Asset> Assets
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Product2, Attachment> Attachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Product2, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Product2, Event> Events
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Product2, Note> Notes
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Product2, NoteAndAttachment> NotesAndAttachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Product2, OpenActivity> OpenActivities
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("Product2Id")]
        public RelationShip<Product2, PricebookEntry> PricebookEntries
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Product2, ProcessInstance> ProcessInstances
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Product2, ProcessInstanceHistory> ProcessSteps
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Product2, Product2Feed> Feeds
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Product2, Task> Tasks
        {
            get; set;
        }
    }
    public class Product2Feed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickProduct2FeedType? __Type;
        [EntityField]
        public PickProduct2FeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<Product2Feed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<Product2Feed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class Profile : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.Boolean __PermissionsEmailSingle;
        [EntityField]
        public System.Boolean PermissionsEmailSingle
        {
            get { return __PermissionsEmailSingle; }
            set { SetField(ref __PermissionsEmailSingle, value); }
        }
        private System.Boolean __PermissionsEmailMass;
        [EntityField]
        public System.Boolean PermissionsEmailMass
        {
            get { return __PermissionsEmailMass; }
            set { SetField(ref __PermissionsEmailMass, value); }
        }
        private System.Boolean __PermissionsEditTask;
        [EntityField]
        public System.Boolean PermissionsEditTask
        {
            get { return __PermissionsEditTask; }
            set { SetField(ref __PermissionsEditTask, value); }
        }
        private System.Boolean __PermissionsEditEvent;
        [EntityField]
        public System.Boolean PermissionsEditEvent
        {
            get { return __PermissionsEditEvent; }
            set { SetField(ref __PermissionsEditEvent, value); }
        }
        private System.Boolean __PermissionsExportReport;
        [EntityField]
        public System.Boolean PermissionsExportReport
        {
            get { return __PermissionsExportReport; }
            set { SetField(ref __PermissionsExportReport, value); }
        }
        private System.Boolean __PermissionsImportPersonal;
        [EntityField]
        public System.Boolean PermissionsImportPersonal
        {
            get { return __PermissionsImportPersonal; }
            set { SetField(ref __PermissionsImportPersonal, value); }
        }
        private System.Boolean __PermissionsManageUsers;
        [EntityField]
        public System.Boolean PermissionsManageUsers
        {
            get { return __PermissionsManageUsers; }
            set { SetField(ref __PermissionsManageUsers, value); }
        }
        private System.Boolean __PermissionsEditPublicTemplates;
        [EntityField]
        public System.Boolean PermissionsEditPublicTemplates
        {
            get { return __PermissionsEditPublicTemplates; }
            set { SetField(ref __PermissionsEditPublicTemplates, value); }
        }
        private System.Boolean __PermissionsModifyAllData;
        [EntityField]
        public System.Boolean PermissionsModifyAllData
        {
            get { return __PermissionsModifyAllData; }
            set { SetField(ref __PermissionsModifyAllData, value); }
        }
        private System.Boolean __PermissionsManageCases;
        [EntityField]
        public System.Boolean PermissionsManageCases
        {
            get { return __PermissionsManageCases; }
            set { SetField(ref __PermissionsManageCases, value); }
        }
        private System.Boolean __PermissionsMassInlineEdit;
        [EntityField]
        public System.Boolean PermissionsMassInlineEdit
        {
            get { return __PermissionsMassInlineEdit; }
            set { SetField(ref __PermissionsMassInlineEdit, value); }
        }
        private System.Boolean __PermissionsViewKnowledge;
        [EntityField]
        public System.Boolean PermissionsViewKnowledge
        {
            get { return __PermissionsViewKnowledge; }
            set { SetField(ref __PermissionsViewKnowledge, value); }
        }
        private System.Boolean __PermissionsEditKnowledge;
        [EntityField]
        public System.Boolean PermissionsEditKnowledge
        {
            get { return __PermissionsEditKnowledge; }
            set { SetField(ref __PermissionsEditKnowledge, value); }
        }
        private System.Boolean __PermissionsManageKnowledge;
        [EntityField]
        public System.Boolean PermissionsManageKnowledge
        {
            get { return __PermissionsManageKnowledge; }
            set { SetField(ref __PermissionsManageKnowledge, value); }
        }
        private System.Boolean __PermissionsManageSolutions;
        [EntityField]
        public System.Boolean PermissionsManageSolutions
        {
            get { return __PermissionsManageSolutions; }
            set { SetField(ref __PermissionsManageSolutions, value); }
        }
        private System.Boolean __PermissionsCustomizeApplication;
        [EntityField]
        public System.Boolean PermissionsCustomizeApplication
        {
            get { return __PermissionsCustomizeApplication; }
            set { SetField(ref __PermissionsCustomizeApplication, value); }
        }
        private System.Boolean __PermissionsEditReadonlyFields;
        [EntityField]
        public System.Boolean PermissionsEditReadonlyFields
        {
            get { return __PermissionsEditReadonlyFields; }
            set { SetField(ref __PermissionsEditReadonlyFields, value); }
        }
        private System.Boolean __PermissionsRunReports;
        [EntityField]
        public System.Boolean PermissionsRunReports
        {
            get { return __PermissionsRunReports; }
            set { SetField(ref __PermissionsRunReports, value); }
        }
        private System.Boolean __PermissionsViewSetup;
        [EntityField]
        public System.Boolean PermissionsViewSetup
        {
            get { return __PermissionsViewSetup; }
            set { SetField(ref __PermissionsViewSetup, value); }
        }
        private System.Boolean __PermissionsTransferAnyEntity;
        [EntityField]
        public System.Boolean PermissionsTransferAnyEntity
        {
            get { return __PermissionsTransferAnyEntity; }
            set { SetField(ref __PermissionsTransferAnyEntity, value); }
        }
        private System.Boolean __PermissionsNewReportBuilder;
        [EntityField]
        public System.Boolean PermissionsNewReportBuilder
        {
            get { return __PermissionsNewReportBuilder; }
            set { SetField(ref __PermissionsNewReportBuilder, value); }
        }
        private System.Boolean __PermissionsActivateContract;
        [EntityField]
        public System.Boolean PermissionsActivateContract
        {
            get { return __PermissionsActivateContract; }
            set { SetField(ref __PermissionsActivateContract, value); }
        }
        private System.Boolean __PermissionsActivateOrder;
        [EntityField]
        public System.Boolean PermissionsActivateOrder
        {
            get { return __PermissionsActivateOrder; }
            set { SetField(ref __PermissionsActivateOrder, value); }
        }
        private System.Boolean __PermissionsImportLeads;
        [EntityField]
        public System.Boolean PermissionsImportLeads
        {
            get { return __PermissionsImportLeads; }
            set { SetField(ref __PermissionsImportLeads, value); }
        }
        private System.Boolean __PermissionsManageLeads;
        [EntityField]
        public System.Boolean PermissionsManageLeads
        {
            get { return __PermissionsManageLeads; }
            set { SetField(ref __PermissionsManageLeads, value); }
        }
        private System.Boolean __PermissionsTransferAnyLead;
        [EntityField]
        public System.Boolean PermissionsTransferAnyLead
        {
            get { return __PermissionsTransferAnyLead; }
            set { SetField(ref __PermissionsTransferAnyLead, value); }
        }
        private System.Boolean __PermissionsViewAllData;
        [EntityField]
        public System.Boolean PermissionsViewAllData
        {
            get { return __PermissionsViewAllData; }
            set { SetField(ref __PermissionsViewAllData, value); }
        }
        private System.Boolean __PermissionsEditPublicDocuments;
        [EntityField]
        public System.Boolean PermissionsEditPublicDocuments
        {
            get { return __PermissionsEditPublicDocuments; }
            set { SetField(ref __PermissionsEditPublicDocuments, value); }
        }
        private System.Boolean __PermissionsViewEncryptedData;
        [EntityField]
        public System.Boolean PermissionsViewEncryptedData
        {
            get { return __PermissionsViewEncryptedData; }
            set { SetField(ref __PermissionsViewEncryptedData, value); }
        }
        private System.Boolean __PermissionsEditBrandTemplates;
        [EntityField]
        public System.Boolean PermissionsEditBrandTemplates
        {
            get { return __PermissionsEditBrandTemplates; }
            set { SetField(ref __PermissionsEditBrandTemplates, value); }
        }
        private System.Boolean __PermissionsEditHtmlTemplates;
        [EntityField]
        public System.Boolean PermissionsEditHtmlTemplates
        {
            get { return __PermissionsEditHtmlTemplates; }
            set { SetField(ref __PermissionsEditHtmlTemplates, value); }
        }
        private System.Boolean __PermissionsDeleteActivatedContract;
        [EntityField]
        public System.Boolean PermissionsDeleteActivatedContract
        {
            get { return __PermissionsDeleteActivatedContract; }
            set { SetField(ref __PermissionsDeleteActivatedContract, value); }
        }
        private System.Boolean __PermissionsSendSitRequests;
        [EntityField]
        public System.Boolean PermissionsSendSitRequests
        {
            get { return __PermissionsSendSitRequests; }
            set { SetField(ref __PermissionsSendSitRequests, value); }
        }
        private System.Boolean __PermissionsManageRemoteAccess;
        [EntityField]
        public System.Boolean PermissionsManageRemoteAccess
        {
            get { return __PermissionsManageRemoteAccess; }
            set { SetField(ref __PermissionsManageRemoteAccess, value); }
        }
        private System.Boolean __PermissionsCanUseNewDashboardBuilder;
        [EntityField]
        public System.Boolean PermissionsCanUseNewDashboardBuilder
        {
            get { return __PermissionsCanUseNewDashboardBuilder; }
            set { SetField(ref __PermissionsCanUseNewDashboardBuilder, value); }
        }
        private System.Boolean __PermissionsManageCategories;
        [EntityField]
        public System.Boolean PermissionsManageCategories
        {
            get { return __PermissionsManageCategories; }
            set { SetField(ref __PermissionsManageCategories, value); }
        }
        private System.Boolean __PermissionsConvertLeads;
        [EntityField]
        public System.Boolean PermissionsConvertLeads
        {
            get { return __PermissionsConvertLeads; }
            set { SetField(ref __PermissionsConvertLeads, value); }
        }
        private System.Boolean __PermissionsPasswordNeverExpires;
        [EntityField]
        public System.Boolean PermissionsPasswordNeverExpires
        {
            get { return __PermissionsPasswordNeverExpires; }
            set { SetField(ref __PermissionsPasswordNeverExpires, value); }
        }
        private System.Boolean __PermissionsUseTeamReassignWizards;
        [EntityField]
        public System.Boolean PermissionsUseTeamReassignWizards
        {
            get { return __PermissionsUseTeamReassignWizards; }
            set { SetField(ref __PermissionsUseTeamReassignWizards, value); }
        }
        private System.Boolean __PermissionsEditActivatedOrders;
        [EntityField]
        public System.Boolean PermissionsEditActivatedOrders
        {
            get { return __PermissionsEditActivatedOrders; }
            set { SetField(ref __PermissionsEditActivatedOrders, value); }
        }
        private System.Boolean __PermissionsInstallMultiforce;
        [EntityField]
        public System.Boolean PermissionsInstallMultiforce
        {
            get { return __PermissionsInstallMultiforce; }
            set { SetField(ref __PermissionsInstallMultiforce, value); }
        }
        private System.Boolean __PermissionsPublishMultiforce;
        [EntityField]
        public System.Boolean PermissionsPublishMultiforce
        {
            get { return __PermissionsPublishMultiforce; }
            set { SetField(ref __PermissionsPublishMultiforce, value); }
        }
        private System.Boolean __PermissionsEditOppLineItemUnitPrice;
        [EntityField]
        public System.Boolean PermissionsEditOppLineItemUnitPrice
        {
            get { return __PermissionsEditOppLineItemUnitPrice; }
            set { SetField(ref __PermissionsEditOppLineItemUnitPrice, value); }
        }
        private System.Boolean __PermissionsCreateMultiforce;
        [EntityField]
        public System.Boolean PermissionsCreateMultiforce
        {
            get { return __PermissionsCreateMultiforce; }
            set { SetField(ref __PermissionsCreateMultiforce, value); }
        }
        private System.Boolean __PermissionsBulkApiHardDelete;
        [EntityField]
        public System.Boolean PermissionsBulkApiHardDelete
        {
            get { return __PermissionsBulkApiHardDelete; }
            set { SetField(ref __PermissionsBulkApiHardDelete, value); }
        }
        private System.Boolean __PermissionsSolutionImport;
        [EntityField]
        public System.Boolean PermissionsSolutionImport
        {
            get { return __PermissionsSolutionImport; }
            set { SetField(ref __PermissionsSolutionImport, value); }
        }
        private System.Boolean __PermissionsManageCallCenters;
        [EntityField]
        public System.Boolean PermissionsManageCallCenters
        {
            get { return __PermissionsManageCallCenters; }
            set { SetField(ref __PermissionsManageCallCenters, value); }
        }
        private System.Boolean __PermissionsManageSynonyms;
        [EntityField]
        public System.Boolean PermissionsManageSynonyms
        {
            get { return __PermissionsManageSynonyms; }
            set { SetField(ref __PermissionsManageSynonyms, value); }
        }
        private System.Boolean __PermissionsViewContent;
        [EntityField]
        public System.Boolean PermissionsViewContent
        {
            get { return __PermissionsViewContent; }
            set { SetField(ref __PermissionsViewContent, value); }
        }
        private System.Boolean __PermissionsManageEmailClientConfig;
        [EntityField]
        public System.Boolean PermissionsManageEmailClientConfig
        {
            get { return __PermissionsManageEmailClientConfig; }
            set { SetField(ref __PermissionsManageEmailClientConfig, value); }
        }
        private System.Boolean __PermissionsEnableNotifications;
        [EntityField]
        public System.Boolean PermissionsEnableNotifications
        {
            get { return __PermissionsEnableNotifications; }
            set { SetField(ref __PermissionsEnableNotifications, value); }
        }
        private System.Boolean __PermissionsManageDataIntegrations;
        [EntityField]
        public System.Boolean PermissionsManageDataIntegrations
        {
            get { return __PermissionsManageDataIntegrations; }
            set { SetField(ref __PermissionsManageDataIntegrations, value); }
        }
        private System.Boolean __PermissionsDistributeFromPersWksp;
        [EntityField]
        public System.Boolean PermissionsDistributeFromPersWksp
        {
            get { return __PermissionsDistributeFromPersWksp; }
            set { SetField(ref __PermissionsDistributeFromPersWksp, value); }
        }
        private System.Boolean __PermissionsViewDataCategories;
        [EntityField]
        public System.Boolean PermissionsViewDataCategories
        {
            get { return __PermissionsViewDataCategories; }
            set { SetField(ref __PermissionsViewDataCategories, value); }
        }
        private System.Boolean __PermissionsManageDataCategories;
        [EntityField]
        public System.Boolean PermissionsManageDataCategories
        {
            get { return __PermissionsManageDataCategories; }
            set { SetField(ref __PermissionsManageDataCategories, value); }
        }
        private System.Boolean __PermissionsAuthorApex;
        [EntityField]
        public System.Boolean PermissionsAuthorApex
        {
            get { return __PermissionsAuthorApex; }
            set { SetField(ref __PermissionsAuthorApex, value); }
        }
        private System.Boolean __PermissionsManageMobile;
        [EntityField]
        public System.Boolean PermissionsManageMobile
        {
            get { return __PermissionsManageMobile; }
            set { SetField(ref __PermissionsManageMobile, value); }
        }
        private System.Boolean __PermissionsApiEnabled;
        [EntityField]
        public System.Boolean PermissionsApiEnabled
        {
            get { return __PermissionsApiEnabled; }
            set { SetField(ref __PermissionsApiEnabled, value); }
        }
        private System.Boolean __PermissionsManageCustomReportTypes;
        [EntityField]
        public System.Boolean PermissionsManageCustomReportTypes
        {
            get { return __PermissionsManageCustomReportTypes; }
            set { SetField(ref __PermissionsManageCustomReportTypes, value); }
        }
        private System.Boolean __PermissionsEditCaseComments;
        [EntityField]
        public System.Boolean PermissionsEditCaseComments
        {
            get { return __PermissionsEditCaseComments; }
            set { SetField(ref __PermissionsEditCaseComments, value); }
        }
        private System.Boolean __PermissionsTransferAnyCase;
        [EntityField]
        public System.Boolean PermissionsTransferAnyCase
        {
            get { return __PermissionsTransferAnyCase; }
            set { SetField(ref __PermissionsTransferAnyCase, value); }
        }
        private System.Boolean __PermissionsContentAdministrator;
        [EntityField]
        public System.Boolean PermissionsContentAdministrator
        {
            get { return __PermissionsContentAdministrator; }
            set { SetField(ref __PermissionsContentAdministrator, value); }
        }
        private System.Boolean __PermissionsCreateWorkspaces;
        [EntityField]
        public System.Boolean PermissionsCreateWorkspaces
        {
            get { return __PermissionsCreateWorkspaces; }
            set { SetField(ref __PermissionsCreateWorkspaces, value); }
        }
        private System.Boolean __PermissionsManageContentPermissions;
        [EntityField]
        public System.Boolean PermissionsManageContentPermissions
        {
            get { return __PermissionsManageContentPermissions; }
            set { SetField(ref __PermissionsManageContentPermissions, value); }
        }
        private System.Boolean __PermissionsManageContentProperties;
        [EntityField]
        public System.Boolean PermissionsManageContentProperties
        {
            get { return __PermissionsManageContentProperties; }
            set { SetField(ref __PermissionsManageContentProperties, value); }
        }
        private System.Boolean __PermissionsManageContentTypes;
        [EntityField]
        public System.Boolean PermissionsManageContentTypes
        {
            get { return __PermissionsManageContentTypes; }
            set { SetField(ref __PermissionsManageContentTypes, value); }
        }
        private System.Boolean __PermissionsManageAnalyticSnapshots;
        [EntityField]
        public System.Boolean PermissionsManageAnalyticSnapshots
        {
            get { return __PermissionsManageAnalyticSnapshots; }
            set { SetField(ref __PermissionsManageAnalyticSnapshots, value); }
        }
        private System.Boolean __PermissionsScheduleReports;
        [EntityField]
        public System.Boolean PermissionsScheduleReports
        {
            get { return __PermissionsScheduleReports; }
            set { SetField(ref __PermissionsScheduleReports, value); }
        }
        private System.Boolean __PermissionsManageBusinessHourHolidays;
        [EntityField]
        public System.Boolean PermissionsManageBusinessHourHolidays
        {
            get { return __PermissionsManageBusinessHourHolidays; }
            set { SetField(ref __PermissionsManageBusinessHourHolidays, value); }
        }
        private System.Boolean __PermissionsManageDynamicDashboards;
        [EntityField]
        public System.Boolean PermissionsManageDynamicDashboards
        {
            get { return __PermissionsManageDynamicDashboards; }
            set { SetField(ref __PermissionsManageDynamicDashboards, value); }
        }
        private System.Boolean __PermissionsCustomSidebarOnAllPages;
        [EntityField]
        public System.Boolean PermissionsCustomSidebarOnAllPages
        {
            get { return __PermissionsCustomSidebarOnAllPages; }
            set { SetField(ref __PermissionsCustomSidebarOnAllPages, value); }
        }
        private System.Boolean __PermissionsManageInteraction;
        [EntityField]
        public System.Boolean PermissionsManageInteraction
        {
            get { return __PermissionsManageInteraction; }
            set { SetField(ref __PermissionsManageInteraction, value); }
        }
        private System.Boolean __PermissionsViewMyTeamsDashboards;
        [EntityField]
        public System.Boolean PermissionsViewMyTeamsDashboards
        {
            get { return __PermissionsViewMyTeamsDashboards; }
            set { SetField(ref __PermissionsViewMyTeamsDashboards, value); }
        }
        private System.Boolean __PermissionsModerateChatter;
        [EntityField]
        public System.Boolean PermissionsModerateChatter
        {
            get { return __PermissionsModerateChatter; }
            set { SetField(ref __PermissionsModerateChatter, value); }
        }
        private System.Boolean __PermissionsManageNetworks;
        [EntityField]
        public System.Boolean PermissionsManageNetworks
        {
            get { return __PermissionsManageNetworks; }
            set { SetField(ref __PermissionsManageNetworks, value); }
        }
        private System.String __UserLicenseId;
        [EntityField]
        public System.String UserLicenseId
        {
            get { return __UserLicenseId; }
            set { SetField(ref __UserLicenseId, value); }
        }
        private PickProfileUserType? __UserType;
        [EntityField]
        public PickProfileUserType? UserType
        {
            get { return __UserType; }
            set { SetField(ref __UserType, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ProfileId")]
        public RelationShip<Profile, User> Users
        {
            get; set;
        }
    }
    public class QueueSobject : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __QueueId;
        [EntityField]
        public System.String QueueId
        {
            get { return __QueueId; }
            set { SetField(ref __QueueId, value); }
        }
        private PickQueueSobjectSobjectType __SobjectType;
        [EntityField]
        public PickQueueSobjectSobjectType SobjectType
        {
            get { return __SobjectType; }
            set { SetField(ref __SobjectType, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class RecordType : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __DeveloperName;
        [EntityField]
        public System.String DeveloperName
        {
            get { return __DeveloperName; }
            set { SetField(ref __DeveloperName, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __BusinessProcessId;
        [EntityField]
        public System.String BusinessProcessId
        {
            get { return __BusinessProcessId; }
            set { SetField(ref __BusinessProcessId, value); }
        }
        private PickRecordTypeSobjectType __SobjectType;
        [EntityField]
        public PickRecordTypeSobjectType SobjectType
        {
            get { return __SobjectType; }
            set { SetField(ref __SobjectType, value); }
        }
        private System.Boolean __IsActive;
        [EntityField]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class Report : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __DeveloperName;
        [EntityField]
        public System.String DeveloperName
        {
            get { return __DeveloperName; }
            set { SetField(ref __DeveloperName, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.DateTime? __LastRunDate;
        [EntityField]
        public System.DateTime? LastRunDate
        {
            get { return __LastRunDate; }
            set { SetField(ref __LastRunDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Report, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Report, ReportFeed> Feeds
        {
            get; set;
        }
    }
    public class ReportFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickReportFeedType? __Type;
        [EntityField]
        public PickReportFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<ReportFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<ReportFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class SetupAuditTrail : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Action;
        [EntityField]
        public System.String Action
        {
            get { return __Action; }
            set { SetField(ref __Action, value); }
        }
        private System.String __Section;
        [EntityField]
        public System.String Section
        {
            get { return __Section; }
            set { SetField(ref __Section, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.String __Display;
        [EntityField]
        public System.String Display
        {
            get { return __Display; }
            set { SetField(ref __Display, value); }
        }
    }
    public class Site : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Subdomain;
        [EntityField]
        public System.String Subdomain
        {
            get { return __Subdomain; }
            set { SetField(ref __Subdomain, value); }
        }
        private System.String __TopLevelDomain;
        [EntityField]
        public System.String TopLevelDomain
        {
            get { return __TopLevelDomain; }
            set { SetField(ref __TopLevelDomain, value); }
        }
        private System.String __UrlPathPrefix;
        [EntityField]
        public System.String UrlPathPrefix
        {
            get { return __UrlPathPrefix; }
            set { SetField(ref __UrlPathPrefix, value); }
        }
        private PickSiteStatus __Status;
        [EntityField]
        public PickSiteStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.String __AdminId;
        [EntityField]
        public System.String AdminId
        {
            get { return __AdminId; }
            set { SetField(ref __AdminId, value); }
        }
        private System.Boolean __OptionsEnableFeeds;
        [EntityField]
        public System.Boolean OptionsEnableFeeds
        {
            get { return __OptionsEnableFeeds; }
            set { SetField(ref __OptionsEnableFeeds, value); }
        }
        private System.Boolean __OptionsAllowHomePage;
        [EntityField]
        public System.Boolean OptionsAllowHomePage
        {
            get { return __OptionsAllowHomePage; }
            set { SetField(ref __OptionsAllowHomePage, value); }
        }
        private System.Boolean __OptionsAllowStandardIdeasPages;
        [EntityField]
        public System.Boolean OptionsAllowStandardIdeasPages
        {
            get { return __OptionsAllowStandardIdeasPages; }
            set { SetField(ref __OptionsAllowStandardIdeasPages, value); }
        }
        private System.Boolean __OptionsAllowStandardSearch;
        [EntityField]
        public System.Boolean OptionsAllowStandardSearch
        {
            get { return __OptionsAllowStandardSearch; }
            set { SetField(ref __OptionsAllowStandardSearch, value); }
        }
        private System.Boolean __OptionsAllowStandardLookups;
        [EntityField]
        public System.Boolean OptionsAllowStandardLookups
        {
            get { return __OptionsAllowStandardLookups; }
            set { SetField(ref __OptionsAllowStandardLookups, value); }
        }
        private System.Boolean __OptionsAllowStandardAnswersPages;
        [EntityField]
        public System.Boolean OptionsAllowStandardAnswersPages
        {
            get { return __OptionsAllowStandardAnswersPages; }
            set { SetField(ref __OptionsAllowStandardAnswersPages, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __MasterLabel;
        [EntityField]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __AnalyticsTrackingCode;
        [EntityField]
        public System.String AnalyticsTrackingCode
        {
            get { return __AnalyticsTrackingCode; }
            set { SetField(ref __AnalyticsTrackingCode, value); }
        }
        private System.String __DailyBandwidthLimit;
        [EntityField]
        public System.String DailyBandwidthLimit
        {
            get { return __DailyBandwidthLimit; }
            set { SetField(ref __DailyBandwidthLimit, value); }
        }
        private System.String __DailyBandwidthUsed;
        [EntityField]
        public System.String DailyBandwidthUsed
        {
            get { return __DailyBandwidthUsed; }
            set { SetField(ref __DailyBandwidthUsed, value); }
        }
        private System.String __DailyRequestTimeLimit;
        [EntityField]
        public System.String DailyRequestTimeLimit
        {
            get { return __DailyRequestTimeLimit; }
            set { SetField(ref __DailyRequestTimeLimit, value); }
        }
        private System.String __DailyRequestTimeUsed;
        [EntityField]
        public System.String DailyRequestTimeUsed
        {
            get { return __DailyRequestTimeUsed; }
            set { SetField(ref __DailyRequestTimeUsed, value); }
        }
        private System.String __MonthlyPageViewsEntitlement;
        [EntityField]
        public System.String MonthlyPageViewsEntitlement
        {
            get { return __MonthlyPageViewsEntitlement; }
            set { SetField(ref __MonthlyPageViewsEntitlement, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Site, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Site, SiteFeed> Feeds
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("SiteId")]
        public RelationShip<Site, SiteHistory> Histories
        {
            get; set;
        }
    }
    public class SiteFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickSiteFeedType? __Type;
        [EntityField]
        public PickSiteFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<SiteFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<SiteFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class SiteHistory : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __SiteId;
        [EntityField]
        public System.String SiteId
        {
            get { return __SiteId; }
            set { SetField(ref __SiteId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickSiteHistoryField __Field;
        [EntityField]
        public PickSiteHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class Solution : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __SolutionNumber;
        [EntityField]
        public System.String SolutionNumber
        {
            get { return __SolutionNumber; }
            set { SetField(ref __SolutionNumber, value); }
        }
        private System.String __SolutionName;
        [EntityField]
        public System.String SolutionName
        {
            get { return __SolutionName; }
            set { SetField(ref __SolutionName, value); }
        }
        private System.Boolean __IsPublished;
        [EntityField]
        public System.Boolean IsPublished
        {
            get { return __IsPublished; }
            set { SetField(ref __IsPublished, value); }
        }
        private System.Boolean __IsPublishedInPublicKb;
        [EntityField]
        public System.Boolean IsPublishedInPublicKb
        {
            get { return __IsPublishedInPublicKb; }
            set { SetField(ref __IsPublishedInPublicKb, value); }
        }
        private PickSolutionStatus __Status;
        [EntityField]
        public PickSolutionStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.Boolean __IsReviewed;
        [EntityField]
        public System.Boolean IsReviewed
        {
            get { return __IsReviewed; }
            set { SetField(ref __IsReviewed, value); }
        }
        private System.String __SolutionNote;
        [EntityField]
        public System.String SolutionNote
        {
            get { return __SolutionNote; }
            set { SetField(ref __SolutionNote, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __TimesUsed;
        [EntityField]
        public System.String TimesUsed
        {
            get { return __TimesUsed; }
            set { SetField(ref __TimesUsed, value); }
        }
        private System.Boolean __IsHtml;
        [EntityField]
        public System.Boolean IsHtml
        {
            get { return __IsHtml; }
            set { SetField(ref __IsHtml, value); }
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Solution, ActivityHistory> ActivityHistories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Solution, Attachment> Attachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("SolutionId")]
        public RelationShip<Solution, CaseSolution> CaseSolutions
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Solution, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Solution, Event> Events
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Solution, OpenActivity> OpenActivities
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Solution, ProcessInstance> ProcessInstances
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Solution, ProcessInstanceHistory> ProcessSteps
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Solution, SolutionFeed> Feeds
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("SolutionId")]
        public RelationShip<Solution, SolutionHistory> Histories
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Solution, Task> Tasks
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Solution, Vote> Votes
        {
            get; set;
        }
    }
    public class SolutionFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickSolutionFeedType? __Type;
        [EntityField]
        public PickSolutionFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<SolutionFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<SolutionFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class SolutionHistory : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __SolutionId;
        [EntityField]
        public System.String SolutionId
        {
            get { return __SolutionId; }
            set { SetField(ref __SolutionId, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickSolutionHistoryField __Field;
        [EntityField]
        public PickSolutionHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class SolutionStatus : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __MasterLabel;
        [EntityField]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __SortOrder;
        [EntityField]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private System.Boolean __IsDefault;
        [EntityField]
        public System.Boolean IsDefault
        {
            get { return __IsDefault; }
            set { SetField(ref __IsDefault, value); }
        }
        private System.Boolean __IsReviewed;
        [EntityField]
        public System.Boolean IsReviewed
        {
            get { return __IsReviewed; }
            set { SetField(ref __IsReviewed, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class StaticResource : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __ContentType;
        [EntityField]
        public System.String ContentType
        {
            get { return __ContentType; }
            set { SetField(ref __ContentType, value); }
        }
        private System.String __BodyLength;
        [EntityField]
        public System.String BodyLength
        {
            get { return __BodyLength; }
            set { SetField(ref __BodyLength, value); }
        }
        private System.String __Body;
        [EntityField]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private PickStaticResourceCacheControl __CacheControl;
        [EntityField]
        public PickStaticResourceCacheControl CacheControl
        {
            get { return __CacheControl; }
            set { SetField(ref __CacheControl, value); }
        }
    }
    public class Task : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __WhoId;
        [EntityField]
        public System.String WhoId
        {
            get { return __WhoId; }
            set { SetField(ref __WhoId, value); }
        }
        private System.String __WhatId;
        [EntityField]
        public System.String WhatId
        {
            get { return __WhatId; }
            set { SetField(ref __WhatId, value); }
        }
        private System.String __Subject;
        [EntityField]
        public System.String Subject
        {
            get { return __Subject; }
            set { SetField(ref __Subject, value); }
        }
        private System.DateTime? __ActivityDate;
        [EntityField]
        public System.DateTime? ActivityDate
        {
            get { return __ActivityDate; }
            set { SetField(ref __ActivityDate, value); }
        }
        private PickTaskStatus __Status;
        [EntityField]
        public PickTaskStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private PickTaskPriority __Priority;
        [EntityField]
        public PickTaskPriority Priority
        {
            get { return __Priority; }
            set { SetField(ref __Priority, value); }
        }
        private System.String __OwnerId;
        [EntityField]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __AccountId;
        [EntityField]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.Boolean __IsClosed;
        [EntityField]
        public System.Boolean IsClosed
        {
            get { return __IsClosed; }
            set { SetField(ref __IsClosed, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsArchived;
        [EntityField]
        public System.Boolean IsArchived
        {
            get { return __IsArchived; }
            set { SetField(ref __IsArchived, value); }
        }
        private System.String __CallDurationInSeconds;
        [EntityField]
        public System.String CallDurationInSeconds
        {
            get { return __CallDurationInSeconds; }
            set { SetField(ref __CallDurationInSeconds, value); }
        }
        private PickTaskCallType? __CallType;
        [EntityField]
        public PickTaskCallType? CallType
        {
            get { return __CallType; }
            set { SetField(ref __CallType, value); }
        }
        private System.String __CallDisposition;
        [EntityField]
        public System.String CallDisposition
        {
            get { return __CallDisposition; }
            set { SetField(ref __CallDisposition, value); }
        }
        private System.String __CallObject;
        [EntityField]
        public System.String CallObject
        {
            get { return __CallObject; }
            set { SetField(ref __CallObject, value); }
        }
        private System.DateTime? __ReminderDateTime;
        [EntityField]
        public System.DateTime? ReminderDateTime
        {
            get { return __ReminderDateTime; }
            set { SetField(ref __ReminderDateTime, value); }
        }
        private System.Boolean __IsReminderSet;
        [EntityField]
        public System.Boolean IsReminderSet
        {
            get { return __IsReminderSet; }
            set { SetField(ref __IsReminderSet, value); }
        }
        private System.String __RecurrenceActivityId;
        [EntityField]
        public System.String RecurrenceActivityId
        {
            get { return __RecurrenceActivityId; }
            set { SetField(ref __RecurrenceActivityId, value); }
        }
        private System.Boolean __IsRecurrence;
        [EntityField]
        public System.Boolean IsRecurrence
        {
            get { return __IsRecurrence; }
            set { SetField(ref __IsRecurrence, value); }
        }
        private System.DateTime? __RecurrenceStartDateOnly;
        [EntityField]
        public System.DateTime? RecurrenceStartDateOnly
        {
            get { return __RecurrenceStartDateOnly; }
            set { SetField(ref __RecurrenceStartDateOnly, value); }
        }
        private System.DateTime? __RecurrenceEndDateOnly;
        [EntityField]
        public System.DateTime? RecurrenceEndDateOnly
        {
            get { return __RecurrenceEndDateOnly; }
            set { SetField(ref __RecurrenceEndDateOnly, value); }
        }
        private PickTaskRecurrenceTimeZoneSidKey? __RecurrenceTimeZoneSidKey;
        [EntityField]
        public PickTaskRecurrenceTimeZoneSidKey? RecurrenceTimeZoneSidKey
        {
            get { return __RecurrenceTimeZoneSidKey; }
            set { SetField(ref __RecurrenceTimeZoneSidKey, value); }
        }
        private PickTaskRecurrenceType? __RecurrenceType;
        [EntityField]
        public PickTaskRecurrenceType? RecurrenceType
        {
            get { return __RecurrenceType; }
            set { SetField(ref __RecurrenceType, value); }
        }
        private System.String __RecurrenceInterval;
        [EntityField]
        public System.String RecurrenceInterval
        {
            get { return __RecurrenceInterval; }
            set { SetField(ref __RecurrenceInterval, value); }
        }
        private System.String __RecurrenceDayOfWeekMask;
        [EntityField]
        public System.String RecurrenceDayOfWeekMask
        {
            get { return __RecurrenceDayOfWeekMask; }
            set { SetField(ref __RecurrenceDayOfWeekMask, value); }
        }
        private System.String __RecurrenceDayOfMonth;
        [EntityField]
        public System.String RecurrenceDayOfMonth
        {
            get { return __RecurrenceDayOfMonth; }
            set { SetField(ref __RecurrenceDayOfMonth, value); }
        }
        private PickTaskRecurrenceInstance? __RecurrenceInstance;
        [EntityField]
        public PickTaskRecurrenceInstance? RecurrenceInstance
        {
            get { return __RecurrenceInstance; }
            set { SetField(ref __RecurrenceInstance, value); }
        }
        private PickTaskRecurrenceMonthOfYear? __RecurrenceMonthOfYear;
        [EntityField]
        public PickTaskRecurrenceMonthOfYear? RecurrenceMonthOfYear
        {
            get { return __RecurrenceMonthOfYear; }
            set { SetField(ref __RecurrenceMonthOfYear, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Task, Attachment> Attachments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Task, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("RecurrenceActivityId")]
        public RelationShip<Task, Task> RecurringTasks
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Task, TaskFeed> Feeds
        {
            get; set;
        }
    }
    public class TaskFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickTaskFeedType? __Type;
        [EntityField]
        public PickTaskFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<TaskFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<TaskFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class TaskPriority : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __MasterLabel;
        [EntityField]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __SortOrder;
        [EntityField]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private System.Boolean __IsDefault;
        [EntityField]
        public System.Boolean IsDefault
        {
            get { return __IsDefault; }
            set { SetField(ref __IsDefault, value); }
        }
        private System.Boolean __IsHighPriority;
        [EntityField]
        public System.Boolean IsHighPriority
        {
            get { return __IsHighPriority; }
            set { SetField(ref __IsHighPriority, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class TaskStatus : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __MasterLabel;
        [EntityField]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __SortOrder;
        [EntityField]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private System.Boolean __IsDefault;
        [EntityField]
        public System.Boolean IsDefault
        {
            get { return __IsDefault; }
            set { SetField(ref __IsDefault, value); }
        }
        private System.Boolean __IsClosed;
        [EntityField]
        public System.Boolean IsClosed
        {
            get { return __IsClosed; }
            set { SetField(ref __IsClosed, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class User : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Username;
        [EntityField]
        public System.String Username
        {
            get { return __Username; }
            set { SetField(ref __Username, value); }
        }
        private System.String __LastName;
        [EntityField]
        public System.String LastName
        {
            get { return __LastName; }
            set { SetField(ref __LastName, value); }
        }
        private System.String __FirstName;
        [EntityField]
        public System.String FirstName
        {
            get { return __FirstName; }
            set { SetField(ref __FirstName, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __CompanyName;
        [EntityField]
        public System.String CompanyName
        {
            get { return __CompanyName; }
            set { SetField(ref __CompanyName, value); }
        }
        private System.String __Division;
        [EntityField]
        public System.String Division
        {
            get { return __Division; }
            set { SetField(ref __Division, value); }
        }
        private System.String __Department;
        [EntityField]
        public System.String Department
        {
            get { return __Department; }
            set { SetField(ref __Department, value); }
        }
        private System.String __Title;
        [EntityField]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.String __Street;
        [EntityField]
        public System.String Street
        {
            get { return __Street; }
            set { SetField(ref __Street, value); }
        }
        private System.String __City;
        [EntityField]
        public System.String City
        {
            get { return __City; }
            set { SetField(ref __City, value); }
        }
        private System.String __State;
        [EntityField]
        public System.String State
        {
            get { return __State; }
            set { SetField(ref __State, value); }
        }
        private System.String __PostalCode;
        [EntityField]
        public System.String PostalCode
        {
            get { return __PostalCode; }
            set { SetField(ref __PostalCode, value); }
        }
        private System.String __Country;
        [EntityField]
        public System.String Country
        {
            get { return __Country; }
            set { SetField(ref __Country, value); }
        }
        private System.String __Email;
        [EntityField]
        public System.String Email
        {
            get { return __Email; }
            set { SetField(ref __Email, value); }
        }
        private System.String __Phone;
        [EntityField]
        public System.String Phone
        {
            get { return __Phone; }
            set { SetField(ref __Phone, value); }
        }
        private System.String __Fax;
        [EntityField]
        public System.String Fax
        {
            get { return __Fax; }
            set { SetField(ref __Fax, value); }
        }
        private System.String __MobilePhone;
        [EntityField]
        public System.String MobilePhone
        {
            get { return __MobilePhone; }
            set { SetField(ref __MobilePhone, value); }
        }
        private System.String __Alias;
        [EntityField]
        public System.String Alias
        {
            get { return __Alias; }
            set { SetField(ref __Alias, value); }
        }
        private System.String __CommunityNickname;
        [EntityField]
        public System.String CommunityNickname
        {
            get { return __CommunityNickname; }
            set { SetField(ref __CommunityNickname, value); }
        }
        private System.Boolean __IsActive;
        [EntityField]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private PickUserTimeZoneSidKey __TimeZoneSidKey;
        [EntityField]
        public PickUserTimeZoneSidKey TimeZoneSidKey
        {
            get { return __TimeZoneSidKey; }
            set { SetField(ref __TimeZoneSidKey, value); }
        }
        private System.String __UserRoleId;
        [EntityField]
        public System.String UserRoleId
        {
            get { return __UserRoleId; }
            set { SetField(ref __UserRoleId, value); }
        }
        private PickUserLocaleSidKey __LocaleSidKey;
        [EntityField]
        public PickUserLocaleSidKey LocaleSidKey
        {
            get { return __LocaleSidKey; }
            set { SetField(ref __LocaleSidKey, value); }
        }
        private System.Boolean __ReceivesInfoEmails;
        [EntityField]
        public System.Boolean ReceivesInfoEmails
        {
            get { return __ReceivesInfoEmails; }
            set { SetField(ref __ReceivesInfoEmails, value); }
        }
        private System.Boolean __ReceivesAdminInfoEmails;
        [EntityField]
        public System.Boolean ReceivesAdminInfoEmails
        {
            get { return __ReceivesAdminInfoEmails; }
            set { SetField(ref __ReceivesAdminInfoEmails, value); }
        }
        private PickUserEmailEncodingKey __EmailEncodingKey;
        [EntityField]
        public PickUserEmailEncodingKey EmailEncodingKey
        {
            get { return __EmailEncodingKey; }
            set { SetField(ref __EmailEncodingKey, value); }
        }
        private System.String __ProfileId;
        [EntityField]
        public System.String ProfileId
        {
            get { return __ProfileId; }
            set { SetField(ref __ProfileId, value); }
        }
        private PickUserUserType? __UserType;
        [EntityField]
        public PickUserUserType? UserType
        {
            get { return __UserType; }
            set { SetField(ref __UserType, value); }
        }
        private PickUserLanguageLocaleKey __LanguageLocaleKey;
        [EntityField]
        public PickUserLanguageLocaleKey LanguageLocaleKey
        {
            get { return __LanguageLocaleKey; }
            set { SetField(ref __LanguageLocaleKey, value); }
        }
        private System.String __EmployeeNumber;
        [EntityField]
        public System.String EmployeeNumber
        {
            get { return __EmployeeNumber; }
            set { SetField(ref __EmployeeNumber, value); }
        }
        private System.String __DelegatedApproverId;
        [EntityField]
        public System.String DelegatedApproverId
        {
            get { return __DelegatedApproverId; }
            set { SetField(ref __DelegatedApproverId, value); }
        }
        private System.String __ManagerId;
        [EntityField]
        public System.String ManagerId
        {
            get { return __ManagerId; }
            set { SetField(ref __ManagerId, value); }
        }
        private System.DateTime? __LastLoginDate;
        [EntityField]
        public System.DateTime? LastLoginDate
        {
            get { return __LastLoginDate; }
            set { SetField(ref __LastLoginDate, value); }
        }
        private System.DateTime? __LastPasswordChangeDate;
        [EntityField]
        public System.DateTime? LastPasswordChangeDate
        {
            get { return __LastPasswordChangeDate; }
            set { SetField(ref __LastPasswordChangeDate, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime? __OfflineTrialExpirationDate;
        [EntityField]
        public System.DateTime? OfflineTrialExpirationDate
        {
            get { return __OfflineTrialExpirationDate; }
            set { SetField(ref __OfflineTrialExpirationDate, value); }
        }
        private System.DateTime? __OfflinePdaTrialExpirationDate;
        [EntityField]
        public System.DateTime? OfflinePdaTrialExpirationDate
        {
            get { return __OfflinePdaTrialExpirationDate; }
            set { SetField(ref __OfflinePdaTrialExpirationDate, value); }
        }
        private System.Boolean __UserPermissionsMarketingUser;
        [EntityField]
        public System.Boolean UserPermissionsMarketingUser
        {
            get { return __UserPermissionsMarketingUser; }
            set { SetField(ref __UserPermissionsMarketingUser, value); }
        }
        private System.Boolean __UserPermissionsOfflineUser;
        [EntityField]
        public System.Boolean UserPermissionsOfflineUser
        {
            get { return __UserPermissionsOfflineUser; }
            set { SetField(ref __UserPermissionsOfflineUser, value); }
        }
        private System.Boolean __UserPermissionsCallCenterAutoLogin;
        [EntityField]
        public System.Boolean UserPermissionsCallCenterAutoLogin
        {
            get { return __UserPermissionsCallCenterAutoLogin; }
            set { SetField(ref __UserPermissionsCallCenterAutoLogin, value); }
        }
        private System.Boolean __UserPermissionsMobileUser;
        [EntityField]
        public System.Boolean UserPermissionsMobileUser
        {
            get { return __UserPermissionsMobileUser; }
            set { SetField(ref __UserPermissionsMobileUser, value); }
        }
        private System.Boolean __UserPermissionsSFContentUser;
        [EntityField]
        public System.Boolean UserPermissionsSFContentUser
        {
            get { return __UserPermissionsSFContentUser; }
            set { SetField(ref __UserPermissionsSFContentUser, value); }
        }
        private System.Boolean __UserPermissionsKnowledgeUser;
        [EntityField]
        public System.Boolean UserPermissionsKnowledgeUser
        {
            get { return __UserPermissionsKnowledgeUser; }
            set { SetField(ref __UserPermissionsKnowledgeUser, value); }
        }
        private System.Boolean __UserPermissionsInteractionUser;
        [EntityField]
        public System.Boolean UserPermissionsInteractionUser
        {
            get { return __UserPermissionsInteractionUser; }
            set { SetField(ref __UserPermissionsInteractionUser, value); }
        }
        private System.Boolean __UserPermissionsSupportUser;
        [EntityField]
        public System.Boolean UserPermissionsSupportUser
        {
            get { return __UserPermissionsSupportUser; }
            set { SetField(ref __UserPermissionsSupportUser, value); }
        }
        private System.Boolean __ForecastEnabled;
        [EntityField]
        public System.Boolean ForecastEnabled
        {
            get { return __ForecastEnabled; }
            set { SetField(ref __ForecastEnabled, value); }
        }
        private System.Boolean __UserPreferencesActivityRemindersPopup;
        [EntityField]
        public System.Boolean UserPreferencesActivityRemindersPopup
        {
            get { return __UserPreferencesActivityRemindersPopup; }
            set { SetField(ref __UserPreferencesActivityRemindersPopup, value); }
        }
        private System.Boolean __UserPreferencesEventRemindersCheckboxDefault;
        [EntityField]
        public System.Boolean UserPreferencesEventRemindersCheckboxDefault
        {
            get { return __UserPreferencesEventRemindersCheckboxDefault; }
            set { SetField(ref __UserPreferencesEventRemindersCheckboxDefault, value); }
        }
        private System.Boolean __UserPreferencesTaskRemindersCheckboxDefault;
        [EntityField]
        public System.Boolean UserPreferencesTaskRemindersCheckboxDefault
        {
            get { return __UserPreferencesTaskRemindersCheckboxDefault; }
            set { SetField(ref __UserPreferencesTaskRemindersCheckboxDefault, value); }
        }
        private System.Boolean __UserPreferencesReminderSoundOff;
        [EntityField]
        public System.Boolean UserPreferencesReminderSoundOff
        {
            get { return __UserPreferencesReminderSoundOff; }
            set { SetField(ref __UserPreferencesReminderSoundOff, value); }
        }
        private System.Boolean __UserPreferencesDisableAutoSubForFeeds;
        [EntityField]
        public System.Boolean UserPreferencesDisableAutoSubForFeeds
        {
            get { return __UserPreferencesDisableAutoSubForFeeds; }
            set { SetField(ref __UserPreferencesDisableAutoSubForFeeds, value); }
        }
        private System.Boolean __UserPreferencesApexPagesDeveloperMode;
        [EntityField]
        public System.Boolean UserPreferencesApexPagesDeveloperMode
        {
            get { return __UserPreferencesApexPagesDeveloperMode; }
            set { SetField(ref __UserPreferencesApexPagesDeveloperMode, value); }
        }
        private System.Boolean __UserPreferencesHideCSNGetChatterMobileTask;
        [EntityField]
        public System.Boolean UserPreferencesHideCSNGetChatterMobileTask
        {
            get { return __UserPreferencesHideCSNGetChatterMobileTask; }
            set { SetField(ref __UserPreferencesHideCSNGetChatterMobileTask, value); }
        }
        private System.Boolean __UserPreferencesHideCSNDesktopTask;
        [EntityField]
        public System.Boolean UserPreferencesHideCSNDesktopTask
        {
            get { return __UserPreferencesHideCSNDesktopTask; }
            set { SetField(ref __UserPreferencesHideCSNDesktopTask, value); }
        }
        private System.Boolean __UserPreferencesSortFeedByComment;
        [EntityField]
        public System.Boolean UserPreferencesSortFeedByComment
        {
            get { return __UserPreferencesSortFeedByComment; }
            set { SetField(ref __UserPreferencesSortFeedByComment, value); }
        }
        private System.Boolean __UserPreferencesOptOutOfTouch;
        [EntityField]
        public System.Boolean UserPreferencesOptOutOfTouch
        {
            get { return __UserPreferencesOptOutOfTouch; }
            set { SetField(ref __UserPreferencesOptOutOfTouch, value); }
        }
        private System.Boolean __UserPreferencesLightningExperiencePreferred;
        [EntityField]
        public System.Boolean UserPreferencesLightningExperiencePreferred
        {
            get { return __UserPreferencesLightningExperiencePreferred; }
            set { SetField(ref __UserPreferencesLightningExperiencePreferred, value); }
        }
        private System.String __ContactId;
        [EntityField]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private System.String __AccountId;
        [EntityField]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __CallCenterId;
        [EntityField]
        public System.String CallCenterId
        {
            get { return __CallCenterId; }
            set { SetField(ref __CallCenterId, value); }
        }
        private System.String __Extension;
        [EntityField]
        public System.String Extension
        {
            get { return __Extension; }
            set { SetField(ref __Extension, value); }
        }
        private System.String __FederationIdentifier;
        [EntityField]
        public System.String FederationIdentifier
        {
            get { return __FederationIdentifier; }
            set { SetField(ref __FederationIdentifier, value); }
        }
        private System.String __AboutMe;
        [EntityField]
        public System.String AboutMe
        {
            get { return __AboutMe; }
            set { SetField(ref __AboutMe, value); }
        }
        private System.String __CurrentStatus;
        [EntityField]
        public System.String CurrentStatus
        {
            get { return __CurrentStatus; }
            set { SetField(ref __CurrentStatus, value); }
        }
        private System.String __FullPhotoUrl;
        [EntityField]
        public System.String FullPhotoUrl
        {
            get { return __FullPhotoUrl; }
            set { SetField(ref __FullPhotoUrl, value); }
        }
        private System.String __SmallPhotoUrl;
        [EntityField]
        public System.String SmallPhotoUrl
        {
            get { return __SmallPhotoUrl; }
            set { SetField(ref __SmallPhotoUrl, value); }
        }
        private PickUserDigestFrequency __DigestFrequency;
        [EntityField]
        public PickUserDigestFrequency DigestFrequency
        {
            get { return __DigestFrequency; }
            set { SetField(ref __DigestFrequency, value); }
        }
        [JsonIgnore]
        [ReferencedByField("MemberId")]
        public RelationShip<User, CollaborationGroupMember> GroupMemberships
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("CompanySignedId")]
        public RelationShip<User, Contract> ContractsSigned
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<User, EntitySubscription> FeedSubscriptionsForEntity
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("SubscriberId")]
        public RelationShip<User, EntitySubscription> FeedSubscriptions
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("AdminId")]
        public RelationShip<User, Site> UserSites
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("DelegatedApproverId")]
        public RelationShip<User, User> DelegatedUsers
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ManagerId")]
        public RelationShip<User, User> ManagedUsers
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<User, UserFeed> Feeds
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("UserId")]
        public RelationShip<User, UserPreference> UserPreferences
        {
            get; set;
        }
    }
    public class UserFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickUserFeedType? __Type;
        [EntityField]
        public PickUserFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<UserFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<UserFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class UserLicense : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __LicenseDefinitionKey;
        [EntityField]
        public System.String LicenseDefinitionKey
        {
            get { return __LicenseDefinitionKey; }
            set { SetField(ref __LicenseDefinitionKey, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __MonthlyLoginsUsed;
        [EntityField]
        public System.String MonthlyLoginsUsed
        {
            get { return __MonthlyLoginsUsed; }
            set { SetField(ref __MonthlyLoginsUsed, value); }
        }
        private System.String __MonthlyLoginsEntitlement;
        [EntityField]
        public System.String MonthlyLoginsEntitlement
        {
            get { return __MonthlyLoginsEntitlement; }
            set { SetField(ref __MonthlyLoginsEntitlement, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class UserPreference : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __UserId;
        [EntityField]
        public System.String UserId
        {
            get { return __UserId; }
            set { SetField(ref __UserId, value); }
        }
        private PickUserPreferencePreference __Preference;
        [EntityField]
        public PickUserPreferencePreference Preference
        {
            get { return __Preference; }
            set { SetField(ref __Preference, value); }
        }
        private System.String __Value;
        [EntityField]
        public System.String Value
        {
            get { return __Value; }
            set { SetField(ref __Value, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class UserProfileFeed : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickUserProfileFeedType? __Type;
        [EntityField]
        public PickUserProfileFeedType? Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<UserProfileFeed, FeedComment> FeedComments
        {
            get; set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<UserProfileFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get; set;
        }
    }
    public class UserRole : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __ParentRoleId;
        [EntityField]
        public System.String ParentRoleId
        {
            get { return __ParentRoleId; }
            set { SetField(ref __ParentRoleId, value); }
        }
        private System.String __RollupDescription;
        [EntityField]
        public System.String RollupDescription
        {
            get { return __RollupDescription; }
            set { SetField(ref __RollupDescription, value); }
        }
        private PickUserRoleOpportunityAccessForAccountOwner __OpportunityAccessForAccountOwner;
        [EntityField]
        public PickUserRoleOpportunityAccessForAccountOwner OpportunityAccessForAccountOwner
        {
            get { return __OpportunityAccessForAccountOwner; }
            set { SetField(ref __OpportunityAccessForAccountOwner, value); }
        }
        private PickUserRoleCaseAccessForAccountOwner? __CaseAccessForAccountOwner;
        [EntityField]
        public PickUserRoleCaseAccessForAccountOwner? CaseAccessForAccountOwner
        {
            get { return __CaseAccessForAccountOwner; }
            set { SetField(ref __CaseAccessForAccountOwner, value); }
        }
        private PickUserRoleContactAccessForAccountOwner? __ContactAccessForAccountOwner;
        [EntityField]
        public PickUserRoleContactAccessForAccountOwner? ContactAccessForAccountOwner
        {
            get { return __ContactAccessForAccountOwner; }
            set { SetField(ref __ContactAccessForAccountOwner, value); }
        }
        private System.String __ForecastUserId;
        [EntityField]
        public System.String ForecastUserId
        {
            get { return __ForecastUserId; }
            set { SetField(ref __ForecastUserId, value); }
        }
        private System.Boolean __MayForecastManagerShare;
        [EntityField]
        public System.Boolean MayForecastManagerShare
        {
            get { return __MayForecastManagerShare; }
            set { SetField(ref __MayForecastManagerShare, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __PortalAccountId;
        [EntityField]
        public System.String PortalAccountId
        {
            get { return __PortalAccountId; }
            set { SetField(ref __PortalAccountId, value); }
        }
        private PickUserRolePortalType? __PortalType;
        [EntityField]
        public PickUserRolePortalType? PortalType
        {
            get { return __PortalType; }
            set { SetField(ref __PortalType, value); }
        }
        private System.String __PortalAccountOwnerId;
        [EntityField]
        public System.String PortalAccountOwnerId
        {
            get { return __PortalAccountOwnerId; }
            set { SetField(ref __PortalAccountOwnerId, value); }
        }
        [JsonIgnore]
        [ReferencedByField("UserRoleId")]
        public RelationShip<UserRole, User> Users
        {
            get; set;
        }
    }
    public class Vote : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ParentId;
        [EntityField]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private PickVoteType __Type;
        [EntityField]
        public PickVoteType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class WebLink : ISalesforceEntity
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private PickWebLinkPageOrSobjectType __PageOrSobjectType;
        [EntityField]
        public PickWebLinkPageOrSobjectType PageOrSobjectType
        {
            get { return __PageOrSobjectType; }
            set { SetField(ref __PageOrSobjectType, value); }
        }
        private System.String __Name;
        [EntityField]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.Boolean __IsProtected;
        [EntityField]
        public System.Boolean IsProtected
        {
            get { return __IsProtected; }
            set { SetField(ref __IsProtected, value); }
        }
        private System.String __Url;
        [EntityField]
        public System.String Url
        {
            get { return __Url; }
            set { SetField(ref __Url, value); }
        }
        private PickWebLinkEncodingKey __EncodingKey;
        [EntityField]
        public PickWebLinkEncodingKey EncodingKey
        {
            get { return __EncodingKey; }
            set { SetField(ref __EncodingKey, value); }
        }
        private PickWebLinkLinkType __LinkType;
        [EntityField]
        public PickWebLinkLinkType LinkType
        {
            get { return __LinkType; }
            set { SetField(ref __LinkType, value); }
        }
        private PickWebLinkOpenType __OpenType;
        [EntityField]
        public PickWebLinkOpenType OpenType
        {
            get { return __OpenType; }
            set { SetField(ref __OpenType, value); }
        }
        private System.String __Height;
        [EntityField]
        public System.String Height
        {
            get { return __Height; }
            set { SetField(ref __Height, value); }
        }
        private System.String __Width;
        [EntityField]
        public System.String Width
        {
            get { return __Width; }
            set { SetField(ref __Width, value); }
        }
        private System.Boolean __ShowsLocation;
        [EntityField]
        public System.Boolean ShowsLocation
        {
            get { return __ShowsLocation; }
            set { SetField(ref __ShowsLocation, value); }
        }
        private System.Boolean __HasScrollbars;
        [EntityField]
        public System.Boolean HasScrollbars
        {
            get { return __HasScrollbars; }
            set { SetField(ref __HasScrollbars, value); }
        }
        private System.Boolean __HasToolbar;
        [EntityField]
        public System.Boolean HasToolbar
        {
            get { return __HasToolbar; }
            set { SetField(ref __HasToolbar, value); }
        }
        private System.Boolean __HasMenubar;
        [EntityField]
        public System.Boolean HasMenubar
        {
            get { return __HasMenubar; }
            set { SetField(ref __HasMenubar, value); }
        }
        private System.Boolean __ShowsStatus;
        [EntityField]
        public System.Boolean ShowsStatus
        {
            get { return __ShowsStatus; }
            set { SetField(ref __ShowsStatus, value); }
        }
        private System.Boolean __IsResizable;
        [EntityField]
        public System.Boolean IsResizable
        {
            get { return __IsResizable; }
            set { SetField(ref __IsResizable, value); }
        }
        private PickWebLinkPosition? __Position;
        [EntityField]
        public PickWebLinkPosition? Position
        {
            get { return __Position; }
            set { SetField(ref __Position, value); }
        }
        private System.String __ScontrolId;
        [EntityField]
        public System.String ScontrolId
        {
            get { return __ScontrolId; }
            set { SetField(ref __ScontrolId, value); }
        }
        private System.String __MasterLabel;
        [EntityField]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __Description;
        [EntityField]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickWebLinkDisplayType __DisplayType;
        [EntityField]
        public PickWebLinkDisplayType DisplayType
        {
            get { return __DisplayType; }
            set { SetField(ref __DisplayType, value); }
        }
        private System.Boolean __RequireRowSelection;
        [EntityField]
        public System.Boolean RequireRowSelection
        {
            get { return __RequireRowSelection; }
            set { SetField(ref __RequireRowSelection, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }

}

