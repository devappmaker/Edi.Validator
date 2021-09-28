using System.Collections.Generic;

namespace Edi.Validator.Models
{
    public class ISA
    {
        public string AuthorizationInformationQualifier_1 { get; set; }
        public string AuthorizationInformation_2 { get; set; }
        public string SecurityInformationQualifier_3 { get; set; }
        public string SecurityInformation_4 { get; set; }
        public string SenderIDQualifier_5 { get; set; }
        public string InterchangeSenderID_6 { get; set; }
        public string ReceiverIDQualifier_7 { get; set; }
        public string InterchangeReceiverID_8 { get; set; }
        public string InterchangeDate_9 { get; set; }
        public string InterchangeTime_10 { get; set; }
        public string InterchangeControlStandardsIdentifier_11 { get; set; }
        public string InterchangeControlVersionNumber_12 { get; set; }
        public string InterchangeControlNumber_13 { get; set; }
        public string AcknowledgementRequested_14 { get; set; }
        public string UsageIndicator_15 { get; set; }
        public string ComponentElementSeparator_16 { get; set; }
    }

    public class GS
    {
        public string CodeIdentifyingInformationType_1 { get; set; }
        public string SenderIDCode_2 { get; set; }
        public string ReceiverIDCode_3 { get; set; }
        public string Date_4 { get; set; }
        public string Time_5 { get; set; }
        public string GroupControlNumber_6 { get; set; }
        public string TransactionTypeCode_7 { get; set; }
        public string VersionAndRelease_8 { get; set; }
    }

    public class ST
    {
        public string TransactionSetIdentifierCode_01 { get; set; }
        public string TransactionSetControlNumber_02 { get; set; }
        public string ImplementationConventionPreference_03 { get; set; }
    }

    public class BHTBeginningOfHierarchicalTransaction
    {
        public string HierarchicalStructureCode_01 { get; set; }
        public string TransactionSetPurposeCode_02 { get; set; }
        public string SubmitterTransactionIdentifier_03 { get; set; }
        public string TransactionSetCreationDate_04 { get; set; }
        public string TransactionSetCreationTime_05 { get; set; }
        public string TransactionTypeCode_06 { get; set; }
    }

    public class HLInformationSourceLevel
    {
        public string HierarchicalIDNumber_01 { get; set; }
        public object HierarchicalParentIDNumber_02 { get; set; }
        public string HierarchicalLevelCode_03 { get; set; }
        public string HierarchicalChildCode_04 { get; set; }
    }

    public class NM1PayerName
    {
        public string EntityIdentifierCode_01 { get; set; }
        public string EntityTypeQualifier_02 { get; set; }
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        public object ResponseContactFirstName_04 { get; set; }
        public object ResponseContactMiddleName_05 { get; set; }
        public object NamePrefix_06 { get; set; }
        public object ResponseContactNameSuffix_07 { get; set; }
        public string IdentificationCodeQualifier_08 { get; set; }
        public string ResponseContactIdentifier_09 { get; set; }
        public object EntityRelationshipCode_10 { get; set; }
        public object EntityIdentifierCode_11 { get; set; }
        public object NameLastorOrganizationName_12 { get; set; }
    }

    public class PERPayerContactInformation
    {
        public string ContactFunctionCode_01 { get; set; }
        public string ResponseContactName_02 { get; set; }
        public string CommunicationNumberQualifier_03 { get; set; }
        public string ResponseContactCommunicationNumber_04 { get; set; }
        public object CommunicationNumberQualifier_05 { get; set; }
        public object ResponseContactCommunicationNumber_06 { get; set; }
        public object CommunicationNumberQualifier_07 { get; set; }
        public object ResponseContactCommunicationNumber_08 { get; set; }
        public object ContactInquiryReference_09 { get; set; }
    }

    public class Loop2100A
    {
        public NM1PayerName NM1_PayerName { get; set; }
        public PERPayerContactInformation PER_PayerContactInformation { get; set; }
    }

    public class HLInformationReceiverLevel
    {
        public string HierarchicalIDNumber_01 { get; set; }
        public string HierarchicalParentIDNumber_02 { get; set; }
        public string HierarchicalLevelCode_03 { get; set; }
        public string HierarchicalChildCode_04 { get; set; }
    }

    public class NM1InformationReceiverName
    {
        public string EntityIdentifierCode_01 { get; set; }
        public string EntityTypeQualifier_02 { get; set; }
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        public object ResponseContactFirstName_04 { get; set; }
        public object ResponseContactMiddleName_05 { get; set; }
        public object NamePrefix_06 { get; set; }
        public object ResponseContactNameSuffix_07 { get; set; }
        public string IdentificationCodeQualifier_08 { get; set; }
        public string ResponseContactIdentifier_09 { get; set; }
        public object EntityRelationshipCode_10 { get; set; }
        public object EntityIdentifierCode_11 { get; set; }
        public object NameLastorOrganizationName_12 { get; set; }
    }

    public class Loop2100B
    {
        public NM1InformationReceiverName NM1_InformationReceiverName { get; set; }
    }

    public class HLServiceProviderLevel
    {
        public string HierarchicalIDNumber_01 { get; set; }
        public string HierarchicalParentIDNumber_02 { get; set; }
        public string HierarchicalLevelCode_03 { get; set; }
        public string HierarchicalChildCode_04 { get; set; }
    }

    public class NM1ProviderName
    {
        public string EntityIdentifierCode_01 { get; set; }
        public string EntityTypeQualifier_02 { get; set; }
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        public object ResponseContactFirstName_04 { get; set; }
        public object ResponseContactMiddleName_05 { get; set; }
        public object NamePrefix_06 { get; set; }
        public object ResponseContactNameSuffix_07 { get; set; }
        public string IdentificationCodeQualifier_08 { get; set; }
        public string ResponseContactIdentifier_09 { get; set; }
        public object EntityRelationshipCode_10 { get; set; }
        public object EntityIdentifierCode_11 { get; set; }
        public object NameLastorOrganizationName_12 { get; set; }
    }

    public class Loop2100C
    {
        public NM1ProviderName NM1_ProviderName { get; set; }
    }

    public class TRNProviderofServiceTraceIdentifier
    {
        public string TraceTypeCode_01 { get; set; }
        public string CurrentTransactionTraceNumber_02 { get; set; }
        public object OriginatingCompanyIdentifier_03 { get; set; }
        public object ReferenceIdentification_04 { get; set; }
    }

    public class HealthCareClaimStatus01
    {
        public string HealthCareClaimStatusCategoryCode_01 { get; set; }
        public string StatusCode_02 { get; set; }
        public string EntityIdentifierCode_03 { get; set; }
        public object CodeListQualifierCode_04 { get; set; }
    }

    public class STCProviderStatusInformation
    {
        public HealthCareClaimStatus01 HealthCareClaimStatus_01 { get; set; }
        public string Date_02 { get; set; }
        public object ActionCode_03 { get; set; }
        public object TotalSubmittedChargesForUnitWork_04 { get; set; }
        public object MonetaryAmount_05 { get; set; }
        public object Date_06 { get; set; }
        public object PaymentMethodCode_07 { get; set; }
        public object Date_08 { get; set; }
        public object CheckNumber_09 { get; set; }
        public object HealthCareClaimStatus_10 { get; set; }
        public object HealthCareClaimStatus_11 { get; set; }
        public object FreeformMessageText_12 { get; set; }
    }

    public class Loop2200C
    {
        public TRNProviderofServiceTraceIdentifier TRN_ProviderofServiceTraceIdentifier { get; set; }
        public List<STCProviderStatusInformation> STC_ProviderStatusInformation { get; set; }
    }

    public class Loop2000C
    {
        public HLServiceProviderLevel HL_ServiceProviderLevel { get; set; }
        public List<Loop2100C> Loop2100C { get; set; }
        public Loop2200C Loop2200C { get; set; }
        public object Loop2000D { get; set; }
    }

    public class Loop2000B
    {
        public HLInformationReceiverLevel HL_InformationReceiverLevel { get; set; }
        public Loop2100B Loop2100B { get; set; }
        public object Loop2200B { get; set; }
        public List<Loop2000C> Loop2000C { get; set; }
    }

    public class Loop2000A
    {
        public HLInformationSourceLevel HL_InformationSourceLevel { get; set; }
        public Loop2100A Loop2100A { get; set; }
        public List<Loop2000B> Loop2000B { get; set; }
    }

    public class SE
    {
        public string NumberofIncludedSegments_01 { get; set; }
        public string TransactionSetControlNumber_02 { get; set; }
    }

    public class Transaction
    {
        public ST ST { get; set; }
        public BHTBeginningOfHierarchicalTransaction BHT_BeginningOfHierarchicalTransaction { get; set; }
        public List<Loop2000A> Loop2000A { get; set; }
        public SE SE { get; set; }
        public string Model { get; set; }
    }

    public class GETrailer
    {
        public string NumberOfIncludedSets_1 { get; set; }
        public string GroupControlNumber_2 { get; set; }
    }

    public class Group
    {
        public GS GS { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<GETrailer> GETrailers { get; set; }
    }

    public class IEATrailer
    {
        public string NumberOfIncludedGroups_1 { get; set; }
        public string InterchangeControlNumber_2 { get; set; }
    }

    public class Result
    {
        public int LastIndex { get; set; }
        public List<object> Details { get; set; }
        public string Status { get; set; }
    }

    public class Root
    {
        public string SegmentDelimiter { get; set; }
        public string DataElementDelimiter { get; set; }
        public ISA ISA { get; set; }
        public object TA1 { get; set; }
        public List<Group> Groups { get; set; }
        public List<IEATrailer> IEATrailers { get; set; }
        public Result Result { get; set; }
    }


}
