using rtc.plain.net.api.extras.emf.ecore;
using System;

namespace rtc.plain.net.api.repository.common.model
{

    public class RepositoryPackageImpl : RepositoryPackage
    {

        protected String packageFilename = "repository.ecore";

        private EClass externalUserStatusEClass = null;

        private EClass externalRegistryConfigurationDTOEClass = null;

        private EClass externalUsersDTOEClass = null;

        private EClass fetchUserDTOEClass = null;

        private EClass externalGroupEClass = null;

        private EClass externalGroupFacadeEClass = null;

        private EClass detailEntryEClass = null;

        private EClass externalUserEClass = null;

        private EClass externalUserFacadeEClass = null;

        private EClass bigDecimalExtensionEntryEClass = null;

        private EClass virtualTypeEClass = null;

        private EClass virtualTypeFacadeEClass = null;

        private EClass virtualEClass = null;

        private EClass virtualFacadeEClass = null;

        private EClass managedItemEClass = null;

        private EClass managedItemHandleEClass = null;

        private EClass managedItemHandleFacadeEClass = null;

        private EClass managedItemFacadeEClass = null;

        private EClass contributorDetailsEClass = null;

        private EClass contributorDetailsHandleEClass = null;

        private EClass contributorDetailsHandleFacadeEClass = null;

        private EClass contributorDetailsFacadeEClass = null;

        private EClass scoredEClass = null;

        private EClass scoredFacadeEClass = null;

        private EClass textQueryPageEClass = null;

        private EClass textQueryPageFacadeEClass = null;

        private EClass baselineComparisonEClass = null;

        private EClass baselineComparisonFacadeEClass = null;

        private EClass baselineMemberComparisonEClass = null;

        private EClass baselineMemberComparisonFacadeEClass = null;

        private EClass baselineMemberEClass = null;

        private EClass auditableBaselineEClass = null;

        private EClass auditableBaselineHandleEClass = null;

        private EClass auditableBaselineHandleFacadeEClass = null;

        private EClass auditableBaselineFacadeEClass = null;
        private EClass contentEClass = null;

        private EClass contentFacadeEClass = null;
        private EClass repositoryRootEClass = null;
        private EClass repositoryRootHandleEClass = null;

        private EClass repositoryRootHandleFacadeEClass = null;

        private EClass repositoryRootFacadeEClass = null;
        private EClass auditableEClass = null;
        private EClass auditableHandleEClass = null;

        private EClass auditableHandleFacadeEClass = null;

        private EClass auditableFacadeEClass = null;
        private EClass contributorEClass = null;
        private EClass contributorHandleEClass = null;

        private EClass contributorHandleFacadeEClass = null;

        private EClass contributorFacadeEClass = null;
        private EClass itemEClass = null;
        private EClass itemHandleEClass = null;

        private EClass itemHandleFacadeEClass = null;

        private EClass itemFacadeEClass = null;
        private EClass itemTypeEClass = null;

        private EClass itemTypeFacadeEClass = null;

        private EClass unmanagedItemEClass = null;

        private EClass unmanagedItemHandleEClass = null;

        private EClass unmanagedItemHandleFacadeEClass = null;

        private EClass unmanagedItemFacadeEClass = null;
        private EClass reconcileReportEClass = null;

        private EClass reconcileReportFacadeEClass = null;
        private EClass packageDescriptionEClass = null;
        private EClass changeEventEClass = null;
        private EClass changeEventHandleEClass = null;

        private EClass changeEventHandleFacadeEClass = null;

        private EClass changeEventFacadeEClass = null;
        private EClass serverVersionRecordEClass = null;
        private EClass serverVersionRecordHandleEClass = null;
        private EClass simpleItemEClass = null;
        private EClass simpleItemHandleEClass = null;

        private EClass simpleItemHandleFacadeEClass = null;

        private EClass simpleItemFacadeEClass = null;
        private EClass helperEClass = null;

        private EClass helperFacadeEClass = null;
        private EClass serverDescriptionEClass = null;
        private EClass fetchResultEClass = null;

        private EClass fetchResultFacadeEClass = null;
        private EClass queryEClass = null;
        private EClass queryPageEClass = null;

        private EClass queryPageFacadeEClass = null;
        private EClass itemQueryPageEClass = null;

        private EClass itemQueryPageFacadeEClass = null;
        private EClass dataQueryPageEClass = null;

        private EClass dataQueryPageFacadeEClass = null;
        private EClass dataFieldEClass = null;

        private EClass dataFieldFacadeEClass = null;
        private EClass itemQueryEClass = null;
        private EClass dataQueryEClass = null;
        private EClass typeEClass = null;

        private EClass typeFacadeEClass = null;
        private EClass helperTypeEClass = null;

        private EClass helperTypeFacadeEClass = null;

        private EClass intExtensionEntryEClass = null;

        private EClass stringExtensionEntryEClass = null;

        private EClass boolExtensionEntryEClass = null;

        private EClass timestampExtensionEntryEClass = null;

        private EClass longExtensionEntryEClass = null;

        private EClass largeStringExtensionEntryEClass = null;

        private EClass mediumStringExtensionEntryEClass = null;

        private EClass licenseTypeEClass = null;

        private EClass licenseTypeHandleEClass = null;

        private EClass licenseAssignmentEClass = null;

        private EClass licenseAssignmentHandleEClass = null;

        private EClass licenseTypeDTOEClass = null;

        private EClass contributorLicenseTypeDTOEClass = null;

        private EClass contributorLicenseTypeDTOFacadeEClass = null;

        private EClass serverLicenseTypeDTOEClass = null;

        private EClass serverLicenseTypeDTOFacadeEClass = null;

        private EClass licensesInfoDTOEClass = null;

        private EClass licensesInfoDTOFacadeEClass = null;

        private EClass licensePurchaseEClass = null;

        private EClass licensesInfo2DTOEClass = null;

        private EClass licensesInfo2DTOFacadeEClass = null;

        private EClass licenseLeaseDTOEClass = null;

        private EClass usedLicenseInfoDTOEClass = null;

        private EClass licenseOperationCheckDTOEClass = null;

        private EClass floatingSetupStatusDTOEClass = null;

        private EClass oAuthServiceProviderInfoEClass = null;

        private EClass oAuthConsumerRegistrationEClass = null;

        private EClass oAuthConsumerRegistrationHandleEClass = null;

        private EClass licenseKeyEClass = null;

        private EClass licenseKeyHandleEClass = null;

        private EClass floatingLicenseLeaseEClass = null;

        private EClass floatingLicenseLeaseHandleEClass = null;

        private EClass externalLicenseCheckoutEClass = null;

        private EClass floatingLicensePolicyEClass = null;

        private EClass floatingLicensePolicyHandleEClass = null;

        private EClass contributorRecordEClass = null;

        private EClass contributorRecordHandleEClass = null;

        private EClass contributorRecordHandleFacadeEClass = null;

        private EClass contributorRecordFacadeEClass = null;

        private EClass contributorUserIdEClass = null;

        private EClass contributorUserIdFacadeEClass = null;

        private EClass contributorIdentityEClass = null;

        private EClass contributorIdentityFacadeEClass = null;

        private EClass licenseNoticeDTOEClass = null;

        private EClass contributorGroupEClass = null;

        private EClass contributorGroupHandleEClass = null;

        private EClass contributorGroupHandleFacadeEClass = null;

        private EClass contributorGroupFacadeEClass = null;

        private EClass serverVersionCheckExceptionDTOEClass = null;

        private EClass stringDTOEClass = null;

        private EClass jpiMappingEClass = null;

        private EClass jpiMappingHandleEClass = null;

        private EClass dbTableSizeDTOEClass = null;

        private EClass mappingEventEClass = null;

        private EClass mappingEventHandleEClass = null;

        private EClass urlChangeEventEClass = null;

        private EClass serverStateDTOEClass = null;

        private EClass tokenCheckoutEClass = null;

        private EClass nodeDiagnosticTestResultDTOEClass = null;

        private EClass diagnosticTestResultDTOEClass = null;

        private EClass licenseAssignmentResultDTOEClass = null;

        private EClass licenseAssignmentResultDTOFacadeEClass = null;
        private EEnum reconcileKindEEnum = null;

        private EEnum repositoryModeEEnum = null;

        private EEnum oAuthSecretTypeEEnum = null;

        private EEnum appRenameStatusEEnum = null;
        private EDataType timestampEDataType = null;
        private EDataType uuidEDataType = null;
        private EDataType objectEDataType = null;

        private RepositoryPackageImpl() : base("com.ibm.team.repository", RepositoryFactory.eINSTANCE)
        {


        }

        private static bool isInited = false;

        public static RepositoryPackage init()
        {

            throw new NotImplementedException();

        }


        public static RepositoryPackage fixAndFreeze()
        {

            throw new NotImplementedException();

        }


        protected void reallyFreeze()
        {

            base.freeze();

        }
        public override EClass getExternalUserStatus()
        {

            throw new NotImplementedException();

        }

        public override EAttribute getExternalUserStatus_Message()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getExternalUserStatus_Valid()
        {
            throw new NotImplementedException();
        }

        public override EClass getExternalRegistryConfigurationDTO()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getExternalRegistryConfigurationDTO_Writable()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getExternalRegistryConfigurationDTO_Queryable()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getExternalRegistryConfigurationDTO_MaxLimitForUserSearchQuery()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getExternalRegistryConfigurationDTO_ReadOnlyUserAttributes()
        {
            throw new NotImplementedException();
        }

        public override EReference getExternalRegistryConfigurationDTO_Groups()
        {
            throw new NotImplementedException();
        }

        public override EClass getExternalUsersDTO()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getExternalUsersDTO_MaxLimitOfReturnedUsers()
        {
            throw new NotImplementedException();
        }

        public override EReference getExternalUsersDTO_ExternalUsers()
        {
            throw new NotImplementedException();
        }

        public override EClass getFetchUserDTO()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getFetchUserDTO_ReadOnlyProperties()
        {
            throw new NotImplementedException();
        }

        public override EReference getFetchUserDTO_Externaluser()
        {
            throw new NotImplementedException();
        }

        public override EClass getExternalGroup()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getExternalGroup_Description()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getExternalGroup_Name()
        {
            throw new NotImplementedException();
        }

        public override EClass getExternalGroupFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getDetailEntry()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDetailEntry_Key()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDetailEntry_Value()
        {
            throw new NotImplementedException();
        }

        public override EClass getExternalUser()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getExternalUser_FullNames()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getExternalUser_UserIds()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getExternalUser_EmailAddresses()
        {
            throw new NotImplementedException();
        }

        public override EReference getExternalUser_DetailFields()
        {
            throw new NotImplementedException();
        }

        public override EReference getExternalUser_Status()
        {
            throw new NotImplementedException();
        }

        public override EClass getExternalUserFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getBigDecimalExtensionEntry()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getBigDecimalExtensionEntry_Key()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getBigDecimalExtensionEntry_Value()
        {
            throw new NotImplementedException();
        }

        public override EClass getVirtualType()
        {
            throw new NotImplementedException();
        }

        public override EClass getVirtualTypeFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getVirtual()
        {
            throw new NotImplementedException();
        }

        public override EClass getVirtualFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getManagedItem()
        {
            throw new NotImplementedException();
        }

        public override EClass getManagedItemHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getManagedItemHandleFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getManagedItemFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorDetails()
        {
            throw new NotImplementedException();
        }

        public override EReference getContributorDetails_Photo()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorDetailsHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorDetailsHandleFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorDetailsFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getScored()
        {
            throw new NotImplementedException();
        }

        public override EReference getScored_Handle()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getScored_Score()
        {
            throw new NotImplementedException();
        }

        public override EClass getScoredFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getTextQueryPage()
        {
            throw new NotImplementedException();
        }

        public override EReference getTextQueryPage_ScoredHandles()
        {
            throw new NotImplementedException();
        }

        public override EClass getTextQueryPageFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getBaselineComparison()
        {
            throw new NotImplementedException();
        }

        public override EReference getBaselineComparison_AddedItems()
        {
            throw new NotImplementedException();
        }

        public override EReference getBaselineComparison_RemovedItems()
        {
            throw new NotImplementedException();
        }

        public override EReference getBaselineComparison_IdenticalItems()
        {
            throw new NotImplementedException();
        }

        public override EReference getBaselineComparison_ChangedItems()
        {
            throw new NotImplementedException();
        }

        public override EClass getBaselineComparisonFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getBaselineMemberComparison()
        {
            throw new NotImplementedException();
        }

        public override EReference getBaselineMemberComparison_Item()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getBaselineMemberComparison_PriorStateId()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getBaselineMemberComparison_AfterStateId()
        {
            throw new NotImplementedException();
        }

        public override EClass getBaselineMemberComparisonFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getBaselineMember()
        {
            throw new NotImplementedException();
        }

        public override EReference getBaselineMember_Item()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getBaselineMember_StateId()
        {
            throw new NotImplementedException();
        }

        public override EClass getAuditableBaseline()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getAuditableBaseline_Name()
        {
            throw new NotImplementedException();
        }

        public override EReference getAuditableBaseline_Owner()
        {
            throw new NotImplementedException();
        }

        public override EReference getAuditableBaseline_Members()
        {
            throw new NotImplementedException();
        }

        public override EClass getAuditableBaselineHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getAuditableBaselineHandleFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getAuditableBaselineFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getContent()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContent_DeltaPredecessor()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContent_ContentId()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContent_ContentLength()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContent_CharacterEncoding()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContent_ContentType()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContent_Checksum()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContent_LineDelimiterSetting()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContent_LineDelimiterCount()
        {
            throw new NotImplementedException();
        }

        public override EClass getContentFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getRepositoryRoot()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getRepositoryRoot_Name()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getRepositoryRoot_Mode()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getRepositoryRoot_ResetRequired()
        {
            throw new NotImplementedException();
        }

        public override EReference getRepositoryRoot_LicenseState()
        {
            throw new NotImplementedException();
        }

        public override EClass getRepositoryRootHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getRepositoryRootHandleFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getRepositoryRootFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getAuditable()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getAuditable_MergePredecessor()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getAuditable_WorkingCopyPredecessor()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getAuditable_WorkingCopyMergePredecessor()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getAuditable_Predecessor()
        {
            throw new NotImplementedException();
        }

        public override EClass getAuditableHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getAuditableHandleFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getAuditableFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributor()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributor_EmailAddress()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributor_UserId()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributor_Name()
        {
            throw new NotImplementedException();
        }

        public override EReference getContributor_Details()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributor_Archived()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorHandleFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getItem()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getItem_ContextId()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getItem_Modified()
        {
            throw new NotImplementedException();
        }

        public override EReference getItem_ModifiedBy()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getItem_WorkingCopy()
        {
            throw new NotImplementedException();
        }

        public override EReference getItem_StringExtensions()
        {
            throw new NotImplementedException();
        }

        public override EReference getItem_IntExtensions()
        {
            throw new NotImplementedException();
        }

        public override EReference getItem_BooleanExtensions()
        {
            throw new NotImplementedException();
        }

        public override EReference getItem_TimestampExtensions()
        {
            throw new NotImplementedException();
        }

        public override EReference getItem_LongExtensions()
        {
            throw new NotImplementedException();
        }

        public override EReference getItem_LargeStringExtensions()
        {
            throw new NotImplementedException();
        }

        public override EReference getItem_MediumStringExtensions()
        {
            throw new NotImplementedException();
        }

        public override EReference getItem_BigDecimalExtensions()
        {
            throw new NotImplementedException();
        }

        public override EClass getItemHandle()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getItemHandle_StateId()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getItemHandle_ItemId()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getItemHandle_Origin()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getItemHandle_Immutable()
        {
            throw new NotImplementedException();
        }

        public override EClass getItemHandleFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getItemFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getItemType()
        {
            throw new NotImplementedException();
        }

        public override EClass getItemTypeFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getUnmanagedItem()
        {
            throw new NotImplementedException();
        }

        public override EClass getUnmanagedItemHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getUnmanagedItemHandleFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getUnmanagedItemFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getReconcileReport()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getReconcileReport_InternalKind()
        {
            throw new NotImplementedException();
        }

        public override EReference getReconcileReport_Incoming()
        {
            throw new NotImplementedException();
        }

        public override EReference getReconcileReport_Outgoing()
        {
            throw new NotImplementedException();
        }

        public override EReference getReconcileReport_Base()
        {
            throw new NotImplementedException();
        }

        public override EReference getReconcileReport_MergeResult()
        {
            throw new NotImplementedException();
        }

        public override EClass getReconcileReportFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getPackageDescription()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getPackageDescription_Version()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getPackageDescription_NsURI()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getPackageDescription_JavaURI()
        {
            throw new NotImplementedException();
        }

        public override EClass getChangeEvent()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getChangeEvent_EventState()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getChangeEvent_EventOwnerNS()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getChangeEvent_EventTime()
        {
            throw new NotImplementedException();
        }

        public override EReference getChangeEvent_EventAuthor()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getChangeEvent_EventCategory()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getChangeEvent_EventTitle()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getChangeEvent_EventDescription()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getChangeEvent_EventPriority()
        {
            throw new NotImplementedException();
        }

        public override EReference getChangeEvent_EventContributors()
        {
            throw new NotImplementedException();
        }

        public override EReference getChangeEvent_EventProcessArea()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getChangeEvent_EventExpiration()
        {
            throw new NotImplementedException();
        }

        public override EReference getChangeEvent_Item()
        {
            throw new NotImplementedException();
        }

        public override EClass getChangeEventHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getChangeEventHandleFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getChangeEventFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getServerVersionRecord()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getServerVersionRecord_VerticalVersion()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getServerVersionRecord_VerticalId()
        {
            throw new NotImplementedException();
        }

        public override EClass getServerVersionRecordHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getSimpleItem()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getSimpleItem_Predecessor()
        {
            throw new NotImplementedException();
        }

        public override EClass getSimpleItemHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getSimpleItemHandleFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getSimpleItemFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getHelper()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getHelper_InternalId()
        {
            throw new NotImplementedException();
        }

        public override EClass getHelperFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getServerDescription()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getServerDescription_UserServer()
        {
            throw new NotImplementedException();
        }

        public override EReference getServerDescription_AuthenticatedContributor()
        {
            throw new NotImplementedException();
        }

        public override EReference getServerDescription_RepositoryRoot()
        {
            throw new NotImplementedException();
        }

        public override EReference getServerDescription_PackageDescriptions()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getServerDescription_PublicUriRoot()
        {
            throw new NotImplementedException();
        }

        public override EReference getServerDescription_ServerState()
        {
            throw new NotImplementedException();
        }

        public override EClass getFetchResult()
        {
            throw new NotImplementedException();
        }

        public override EReference getFetchResult_NotFoundItems()
        {
            throw new NotImplementedException();
        }

        public override EReference getFetchResult_RetrievedItems()
        {
            throw new NotImplementedException();
        }

        public override EReference getFetchResult_PermissionDeniedItems()
        {
            throw new NotImplementedException();
        }

        public override EClass getFetchResultFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getQuery()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getQuery_QueryString()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getQuery_InternalParmTypes()
        {
            throw new NotImplementedException();
        }

        public override EClass getQueryPage()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getQueryPage_Size()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getQueryPage_ResultSize()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getQueryPage_StartPosition()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getQueryPage_Token()
        {
            throw new NotImplementedException();
        }

        public override EClass getQueryPageFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getItemQueryPage()
        {
            throw new NotImplementedException();
        }

        public override EReference getItemQueryPage_ItemHandles()
        {
            throw new NotImplementedException();
        }

        public override EClass getItemQueryPageFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getDataQueryPage()
        {
            throw new NotImplementedException();
        }

        public override EReference getDataQueryPage_DataFields()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDataQueryPage_RawData()
        {
            throw new NotImplementedException();
        }

        public override EClass getDataQueryPageFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getDataField()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDataField_Name()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDataField_FieldType()
        {
            throw new NotImplementedException();
        }

        public override EClass getDataFieldFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getItemQuery()
        {
            throw new NotImplementedException();
        }

        public override EReference getItemQuery_ReturnType()
        {
            throw new NotImplementedException();
        }

        public override EClass getDataQuery()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDataQuery_ReturnTypes()
        {
            throw new NotImplementedException();
        }

        public override EClass getType()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getType_NamespaceURI()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getType_Name()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getType_Abstract()
        {
            throw new NotImplementedException();
        }

        public override EClass getTypeFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getHelperType()
        {
            throw new NotImplementedException();
        }

        public override EClass getHelperTypeFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getIntExtensionEntry()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getIntExtensionEntry_Key()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getIntExtensionEntry_Value()
        {
            throw new NotImplementedException();
        }

        public override EClass getStringExtensionEntry()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getStringExtensionEntry_Key()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getStringExtensionEntry_Value()
        {
            throw new NotImplementedException();
        }

        public override EClass getBooleanExtensionEntry()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getBooleanExtensionEntry_Key()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getBooleanExtensionEntry_Value()
        {
            throw new NotImplementedException();
        }

        public override EClass getTimestampExtensionEntry()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getTimestampExtensionEntry_Key()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getTimestampExtensionEntry_Value()
        {
            throw new NotImplementedException();
        }

        public override EClass getLongExtensionEntry()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLongExtensionEntry_Key()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLongExtensionEntry_Value()
        {
            throw new NotImplementedException();
        }

        public override EClass getLargeStringExtensionEntry()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLargeStringExtensionEntry_Key()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLargeStringExtensionEntry_Value()
        {
            throw new NotImplementedException();
        }

        public override EClass getMediumStringExtensionEntry()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getMediumStringExtensionEntry_Key()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getMediumStringExtensionEntry_Value()
        {
            throw new NotImplementedException();
        }

        public override EClass getLicenseType()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseType_Used()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseType_Id()
        {
            throw new NotImplementedException();
        }

        public override EReference getLicenseType_Purchases()
        {
            throw new NotImplementedException();
        }

        public override EClass getLicenseTypeHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getLicenseAssignment()
        {
            throw new NotImplementedException();
        }

        public override EReference getLicenseAssignment_Contributor()
        {
            throw new NotImplementedException();
        }

        public override EReference getLicenseAssignment_License()
        {
            throw new NotImplementedException();
        }

        public override EClass getLicenseAssignmentHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getLicenseTypeDTO()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseTypeDTO_DisabledReason()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseTypeDTO_Id()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseTypeDTO_Description()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseTypeDTO_ProductName()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseTypeDTO_BuyURL()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseTypeDTO_EditionName()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseTypeDTO_VariantName()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseTypeDTO_InfoURL()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseTypeDTO_ExpirationTime()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseTypeDTO_Trial()
        {
            throw new NotImplementedException();
        }

        public override EReference getLicenseTypeDTO_Notices()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseTypeDTO_HasAgreement()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorLicenseTypeDTO()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorLicenseTypeDTO_Max()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorLicenseTypeDTO_Used()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorLicenseTypeDTO_Total()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorLicenseTypeDTO_Free()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorLicenseTypeDTO_Name()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorLicenseTypeDTO_CountedInServerLimit()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorLicenseTypeDTO_Functional()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorLicenseTypeDTO_Floating()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorLicenseTypeDTO_Version()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorLicenseTypeDTO_HasUnactivatedTrial()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorLicenseTypeDTO_UnactivatedTrialExpirationTime()
        {
            throw new NotImplementedException();
        }

        public override EReference getContributorLicenseTypeDTO_Keys()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorLicenseTypeDTO_PurchaseCountLocked()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorLicenseTypeDTO_ActivationNotificationURL()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorLicenseTypeDTO_ActivationNotificationMessage()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorLicenseTypeDTOFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getServerLicenseTypeDTO()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getServerLicenseTypeDTO_MaxContributors()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getServerLicenseTypeDTO_UsedContributors()
        {
            throw new NotImplementedException();
        }

        public override EClass getServerLicenseTypeDTOFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getLicensesInfoDTO()
        {
            throw new NotImplementedException();
        }

        public override EReference getLicensesInfoDTO_ServerLicense()
        {
            throw new NotImplementedException();
        }

        public override EReference getLicensesInfoDTO_Types()
        {
            throw new NotImplementedException();
        }

        public override EClass getLicensesInfoDTOFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getLicensePurchase()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicensePurchase_Purchased()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicensePurchase_Id()
        {
            throw new NotImplementedException();
        }

        public override EClass getLicensesInfo2DTO()
        {
            throw new NotImplementedException();
        }

        public override EReference getLicensesInfo2DTO_FloatingSetupStatus()
        {
            throw new NotImplementedException();
        }

        public override EReference getLicensesInfo2DTO_FloatingLicenseTypes()
        {
            throw new NotImplementedException();
        }

        public override EReference getLicensesInfo2DTO_OperationCheckResults()
        {
            throw new NotImplementedException();
        }

        public override EClass getLicensesInfo2DTOFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getLicenseLeaseDTO()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseLeaseDTO_UserId()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseLeaseDTO_ContributorUUID()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseLeaseDTO_EndDate()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseLeaseDTO_UserName()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseLeaseDTO_LicenseId()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseLeaseDTO_LicenseName()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseLeaseDTO_Id()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseLeaseDTO_Counted()
        {
            throw new NotImplementedException();
        }

        public override EClass getUsedLicenseInfoDTO()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getUsedLicenseInfoDTO_TotalUsedCount()
        {
            throw new NotImplementedException();
        }

        public override EReference getUsedLicenseInfoDTO_ActiveLeases()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getUsedLicenseInfoDTO_CountedActiveLeases()
        {
            throw new NotImplementedException();
        }

        public override EClass getLicenseOperationCheckDTO()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseOperationCheckDTO_OperationId()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseOperationCheckDTO_Allowed()
        {
            throw new NotImplementedException();
        }

        public override EClass getFloatingSetupStatusDTO()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getFloatingSetupStatusDTO_ServerURL()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getFloatingSetupStatusDTO_ConnectionError()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getFloatingSetupStatusDTO_Client()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getFloatingSetupStatusDTO_Server()
        {
            throw new NotImplementedException();
        }

        public override EClass getOAuthServiceProviderInfo()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getOAuthServiceProviderInfo_Realm()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getOAuthServiceProviderInfo_AccessTokenURL()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getOAuthServiceProviderInfo_RequestTokenURL()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getOAuthServiceProviderInfo_ConsumerKey()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getOAuthServiceProviderInfo_ConsumerSecret()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getOAuthServiceProviderInfo_AuthorizeUserURL()
        {
            throw new NotImplementedException();
        }

        public override EClass getOAuthConsumerRegistration()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getOAuthConsumerRegistration_Key()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getOAuthConsumerRegistration_SecretType()
        {
            throw new NotImplementedException();
        }

        public override EReference getOAuthConsumerRegistration_Secret()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getOAuthConsumerRegistration_Trusted()
        {
            throw new NotImplementedException();
        }

        public override EClass getOAuthConsumerRegistrationHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getLicenseKey()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseKey_Id()
        {
            throw new NotImplementedException();
        }

        public override EReference getLicenseKey_Content()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseKey_Type()
        {
            throw new NotImplementedException();
        }

        public override EClass getLicenseKeyHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getFloatingLicenseLease()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getFloatingLicenseLease_Server()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getFloatingLicenseLease_RepoRootId()
        {
            throw new NotImplementedException();
        }

        public override EReference getFloatingLicenseLease_Policy()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getFloatingLicenseLease_ExpirationDate()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getFloatingLicenseLease_OperationId()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getFloatingLicenseLease_UserId()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getFloatingLicenseLease_StartDate()
        {
            throw new NotImplementedException();
        }

        public override EReference getFloatingLicenseLease_ExternalCheckout()
        {
            throw new NotImplementedException();
        }

        public override EReference getFloatingLicenseLease_Tokens()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getFloatingLicenseLease_Application()
        {
            throw new NotImplementedException();
        }

        public override EClass getFloatingLicenseLeaseHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getExternalLicenseCheckout()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getExternalLicenseCheckout_Provider()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getExternalLicenseCheckout_Data()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getExternalLicenseCheckout_ExpirationDate()
        {
            throw new NotImplementedException();
        }

        public override EClass getFloatingLicensePolicy()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getFloatingLicensePolicy_PolicyId()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getFloatingLicensePolicy_ActiveLeases()
        {
            throw new NotImplementedException();
        }

        public override EClass getFloatingLicensePolicyHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorRecord()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorRecord_EmailAddress()
        {
            throw new NotImplementedException();
        }

        public override EReference getContributorRecord_Details()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorRecord_Archived()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorRecord_Name()
        {
            throw new NotImplementedException();
        }

        public override EReference getContributorRecord_UserIds()
        {
            throw new NotImplementedException();
        }

        public override EReference getContributorRecord_Identities()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorRecordHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorRecordHandleFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorRecordFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorUserId()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorUserId_UserId()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorUserIdFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorIdentity()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorIdentity_Id()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorIdentity_StateId()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorIdentityFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getLicenseNoticeDTO()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseNoticeDTO_Name()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseNoticeDTO_Text()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorGroup()
        {
            throw new NotImplementedException();
        }

        public override EReference getContributorGroup_InternalContributors()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorGroup_InternalName()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorGroup_InternalSummary()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getContributorGroup_InternalDescription()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorGroupHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorGroupHandleFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getContributorGroupFacade()
        {
            throw new NotImplementedException();
        }

        public override EClass getServerVersionCheckExceptionDTO()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getServerVersionCheckExceptionDTO_Uri()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getServerVersionCheckExceptionDTO_ServerVersion()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getServerVersionCheckExceptionDTO_ClientVersion()
        {
            throw new NotImplementedException();
        }

        public override EClass getStringDTO()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getStringDTO_String()
        {
            throw new NotImplementedException();
        }

        public override EClass getJPIMapping()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getJPIMapping_Url()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getJPIMapping_Jpi()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getJPIMapping_MappingEventId()
        {
            throw new NotImplementedException();
        }

        public override EClass getJPIMappingHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getDBTableSizeDTO()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDBTableSizeDTO_Component()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDBTableSizeDTO_TypeName()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDBTableSizeDTO_ItemCount()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDBTableSizeDTO_StateCount()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDBTableSizeDTO_ContentSize()
        {
            throw new NotImplementedException();
        }

        public override EClass getMappingEvent()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getMappingEvent_EventId()
        {
            throw new NotImplementedException();
        }

        public override EReference getMappingEvent_URLChanges()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getMappingEvent_AppRenameStatus()
        {
            throw new NotImplementedException();
        }

        public override EClass getMappingEventHandle()
        {
            throw new NotImplementedException();
        }

        public override EClass getURLChangeEvent()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getURLChangeEvent_OldURL()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getURLChangeEvent_NewURL()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getURLChangeEvent_Derived()
        {
            throw new NotImplementedException();
        }

        public override EClass getServerStateDTO()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getServerStateDTO_ServerStateId()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getServerStateDTO_LastStateChangeMessage()
        {
            throw new NotImplementedException();
        }

        public override EClass getTokenCheckout()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getTokenCheckout_Count()
        {
            throw new NotImplementedException();
        }

        public override EClass getNodeDiagnosticTestResultDTO()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getNodeDiagnosticTestResultDTO_Error()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getNodeDiagnosticTestResultDTO_Warning()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getNodeDiagnosticTestResultDTO_ExecutionTime()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getNodeDiagnosticTestResultDTO_ExecutionDuration()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getNodeDiagnosticTestResultDTO_Status()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getNodeDiagnosticTestResultDTO_NodeID()
        {
            throw new NotImplementedException();
        }

        public override EClass getDiagnosticTestResultDTO()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDiagnosticTestResultDTO_Id()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDiagnosticTestResultDTO_Title()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDiagnosticTestResultDTO_Description()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDiagnosticTestResultDTO_Error()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDiagnosticTestResultDTO_Warning()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDiagnosticTestResultDTO_ExecutionTime()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDiagnosticTestResultDTO_ExecutionDuration()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDiagnosticTestResultDTO_Status()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDiagnosticTestResultDTO_CurrentProgress()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDiagnosticTestResultDTO_Disabled()
        {
            throw new NotImplementedException();
        }

        public override EReference getDiagnosticTestResultDTO_NodesResults()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDiagnosticTestResultDTO_NodeScopedTest()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDiagnosticTestResultDTO_InvocationPeriod()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getDiagnosticTestResultDTO_NextInvocation()
        {
            throw new NotImplementedException();
        }

        public override EClass getLicenseAssignmentResultDTO()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseAssignmentResultDTO_Message()
        {
            throw new NotImplementedException();
        }

        public override EAttribute getLicenseAssignmentResultDTO_Status()
        {
            throw new NotImplementedException();
        }

        public override EClass getLicenseAssignmentResultDTOFacade()
        {
            throw new NotImplementedException();
        }

        public override EEnum getReconcileKind()
        {
            throw new NotImplementedException();
        }

        public override EEnum getRepositoryMode()
        {
            throw new NotImplementedException();
        }

        public override EEnum getOAuthSecretType()
        {
            throw new NotImplementedException();
        }

        public override EEnum getAppRenameStatus()
        {
            throw new NotImplementedException();
        }

        public override EDataType getTimestamp()
        {
            throw new NotImplementedException();
        }

        public override EDataType getUUID()
        {
            throw new NotImplementedException();
        }

        public override EDataType getObject()
        {
            throw new NotImplementedException();
        }

        public override RepositoryFactory getRepositoryFactory()
        {
            throw new NotImplementedException();
        }

        public override string getNsURI()
        {
            throw new NotImplementedException();
        }

        public override void setNsURI(string paramString)
        {
            throw new NotImplementedException();
        }

        public override string getNsPrefix()
        {
            throw new NotImplementedException();
        }

        public override void setNsPrefix(string paramString)
        {
            throw new NotImplementedException();
        }

        public override EFactory getEFactoryInstance()
        {
            throw new NotImplementedException();
        }

        public override void setEFactoryInstance(EFactory paramEFactory)
        {
            throw new NotImplementedException();
        }

        public override EList<EClassifier> getEClassifiers()
        {
            throw new NotImplementedException();
        }

        public override EList<EPackage> getESubpackages()
        {
            throw new NotImplementedException();
        }

        public override EPackage getESuperPackage()
        {
            throw new NotImplementedException();
        }

        public override EClassifier getEClassifier(string paramString)
        {
            throw new NotImplementedException();
        }

        public override string getName()
        {
            throw new NotImplementedException();
        }

        public override void setName(string value)
        {
            throw new NotImplementedException();
        }

        public override EList<EAnnotation> getEAnnotations()
        {
            throw new NotImplementedException();
        }

        public override EAnnotation getEAnnotation(string source)
        {
            throw new NotImplementedException();
        }

        public override EClass eClass()
        {
            throw new NotImplementedException();
        }

        public override Resource eResource()
        {
            throw new NotImplementedException();
        }

        public override EObject eContainer()
        {
            throw new NotImplementedException();
        }

        public override EStructuralFeature eContainingFeature()
        {
            throw new NotImplementedException();
        }

        public override EReference eContainmentFeature()
        {
            throw new NotImplementedException();
        }

        public override EList<EObject> eContents()
        {
            throw new NotImplementedException();
        }

        public override TreeIterator<EObject> eAllContents()
        {
            throw new NotImplementedException();
        }

        public override bool eIsProxy()
        {
            throw new NotImplementedException();
        }

        public override EList<EObject> eCrossReferences()
        {
            throw new NotImplementedException();
        }

        public override object eGet(EStructuralFeature paramEStructuralFeature)
        {
            throw new NotImplementedException();
        }

        public override object eGet(EStructuralFeature paramEStructuralFeature, bool parambool)
        {
            throw new NotImplementedException();
        }

        public override void eSet(EStructuralFeature paramEStructuralFeature, object paramObject)
        {
            throw new NotImplementedException();
        }

        public override bool eIsSet(EStructuralFeature paramEStructuralFeature)
        {
            throw new NotImplementedException();
        }

        public override void eUnset(EStructuralFeature paramEStructuralFeature)
        {
            throw new NotImplementedException();
        }

        public override object eInvoke(EOperation paramEOperation, EList<object> paramEList)
        {
            throw new NotImplementedException();
        }
    }
}

/* Location:           C:\RTC40Dev\installs\PlainJavaAPI\com.ibm.team.repository.common_1.3.3000.v20131022_0156.jar
 * Qualified Name:     com.ibm.team.repository.common.model.impl.RepositoryPackageImpl
 * Java Class Version: 6 (50.0)
 * JD-Core Version:    0.7.1
 */
