using rtc.plain.net.api.extras.emf.ecore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtc.plain.net.api.repository.common.model
{
    public abstract class RepositoryPackage : EPackage
    {

        public const String eNAME = "repository";
        public const String eNS_URI = "com.ibm.team.repository";
        public const String eNS_PREFIX = "repository";
        public static RepositoryPackage eINSTANCE = null;

        public static readonly RepositoryPackage eINSTANCE2 = RepositoryPackageImpl.fixAndFreeze();
        public const int TYPE_FACADE = 89;

        public const int HELPER = 72;

        public const int CONTENT = 35;

        public const int ITEM_HANDLE = 50;

        public const int ITEM = 49;

        public const int AUDITABLE = 41;

        public const int REPOSITORY_ROOT = 37;

        public const int AUDITABLE_HANDLE = 42;

        public const int REPOSITORY_ROOT_HANDLE = 38;

        public const int CONTRIBUTOR = 45;

        public const int CONTRIBUTOR_HANDLE = 46;

        public const int TYPE = 88;

        public const int ITEM_TYPE = 53;

        public const int RECONCILE_REPORT = 59;

        public const int PACKAGE_DESCRIPTION = 61;

        public const int SIMPLE_ITEM = 68;

        public const int CHANGE_EVENT = 62;

        public const int SIMPLE_ITEM_HANDLE = 69;

        public const int SCORED = 22;

        public const int CHANGE_EVENT_HANDLE = 63;

        public const int SERVER_VERSION_RECORD = 66;

        public const int SERVER_VERSION_RECORD_HANDLE = 67;

        public const int SERVER_DESCRIPTION = 74;

        public const int FETCH_RESULT = 75;

        public const int QUERY = 77;

        public const int QUERY_PAGE = 78;

        public const int TEXT_QUERY_PAGE = 24;

        public const int MANAGED_ITEM = 14;

        public const int MANAGED_ITEM_HANDLE = 15;

        public const int BASELINE_COMPARISON = 26;

        public const int BASELINE_MEMBER_COMPARISON = 28;

        public const int BASELINE_MEMBER = 30;

        public const int CONTRIBUTOR_DETAILS = 18;

        public const int AUDITABLE_BASELINE = 31;

        public const int CONTRIBUTOR_DETAILS_HANDLE = 19;

        public const int AUDITABLE_BASELINE_HANDLE = 32;

        public const int VIRTUAL_TYPE = 10;

        public const int VIRTUAL_TYPE_FACADE = 11;

        public const int HELPER_FACADE = 73;

        public const int VIRTUAL = 12;

        public const int VIRTUAL_FACADE = 13;

        public const int ITEM_HANDLE_FACADE = 51;

        public const int MANAGED_ITEM_HANDLE_FACADE = 16;

        public const int MANAGED_ITEM_FACADE = 17;

        public const int CONTRIBUTOR_DETAILS_HANDLE_FACADE = 20;

        public const int CONTRIBUTOR_DETAILS_FACADE = 21;

        public const int HELPER_FACADE_FEATURE_COUNT = 0;

        public const int HELPER__INTERNAL_ID = 0;

        public const int HELPER_FEATURE_COUNT = 1;

        public const int EXTERNAL_USER_STATUS = 0;

        public const int EXTERNAL_USER_STATUS__INTERNAL_ID = 0;

        public const int EXTERNAL_USER_STATUS__MESSAGE = 1;

        public const int EXTERNAL_USER_STATUS__VALID = 2;

        public const int EXTERNAL_USER_STATUS_FEATURE_COUNT = 3;

        public const int EXTERNAL_REGISTRY_CONFIGURATION_DTO = 1;

        public const int EXTERNAL_REGISTRY_CONFIGURATION_DTO__INTERNAL_ID = 0;

        public const int EXTERNAL_REGISTRY_CONFIGURATION_DTO__WRITABLE = 1;

        public const int EXTERNAL_REGISTRY_CONFIGURATION_DTO__QUERYABLE = 2;

        public const int EXTERNAL_REGISTRY_CONFIGURATION_DTO__MAX_LIMIT_FOR_USER_SEARCH_QUERY = 3;

        public const int EXTERNAL_REGISTRY_CONFIGURATION_DTO__READ_ONLY_USER_ATTRIBUTES = 4;

        public const int EXTERNAL_REGISTRY_CONFIGURATION_DTO__GROUPS = 5;

        public const int EXTERNAL_REGISTRY_CONFIGURATION_DTO_FEATURE_COUNT = 6;

        public const int EXTERNAL_USERS_DTO = 2;

        public const int EXTERNAL_USERS_DTO__INTERNAL_ID = 0;

        public const int EXTERNAL_USERS_DTO__MAX_LIMIT_OF_RETURNED_USERS = 1;

        public const int EXTERNAL_USERS_DTO__EXTERNAL_USERS = 2;

        public const int EXTERNAL_USERS_DTO_FEATURE_COUNT = 3;

        public const int FETCH_USER_DTO = 3;

        public const int FETCH_USER_DTO__INTERNAL_ID = 0;

        public const int FETCH_USER_DTO__READ_ONLY_PROPERTIES = 1;

        public const int FETCH_USER_DTO__EXTERNALUSER = 2;

        public const int FETCH_USER_DTO_FEATURE_COUNT = 3;

        public const int EXTERNAL_GROUP = 4;

        public const int EXTERNAL_GROUP__INTERNAL_ID = 0;

        public const int EXTERNAL_GROUP__DESCRIPTION = 1;

        public const int EXTERNAL_GROUP__NAME = 2;

        public const int EXTERNAL_GROUP_FEATURE_COUNT = 3;

        public const int EXTERNAL_GROUP_FACADE = 5;

        public const int EXTERNAL_GROUP_FACADE_FEATURE_COUNT = 0;

        public const int DETAIL_ENTRY = 6;

        public const int DETAIL_ENTRY__INTERNAL_ID = 0;

        public const int DETAIL_ENTRY__KEY = 1;

        public const int DETAIL_ENTRY__VALUE = 2;

        public const int DETAIL_ENTRY_FEATURE_COUNT = 3;

        public const int EXTERNAL_USER = 7;

        public const int EXTERNAL_USER__INTERNAL_ID = 0;

        public const int EXTERNAL_USER__FULL_NAMES = 1;

        public const int EXTERNAL_USER__USER_IDS = 2;

        public const int EXTERNAL_USER__EMAIL_ADDRESSES = 3;

        public const int EXTERNAL_USER__DETAIL_FIELDS = 4;

        public const int EXTERNAL_USER__STATUS = 5;

        public const int EXTERNAL_USER_FEATURE_COUNT = 6;

        public const int EXTERNAL_USER_FACADE = 8;

        public const int EXTERNAL_USER_FACADE_FEATURE_COUNT = 0;

        public const int BIG_DECIMAL_EXTENSION_ENTRY = 9;

        public const int BIG_DECIMAL_EXTENSION_ENTRY__INTERNAL_ID = 0;

        public const int BIG_DECIMAL_EXTENSION_ENTRY__KEY = 1;

        public const int BIG_DECIMAL_EXTENSION_ENTRY__VALUE = 2;

        public const int BIG_DECIMAL_EXTENSION_ENTRY_FEATURE_COUNT = 3;

        public const int TYPE_FACADE_FEATURE_COUNT = 0;

        public const int TYPE__NAMESPACE_URI = 0;

        public const int TYPE__NAME = 1;

        public const int TYPE__ABSTRACT = 2;

        public const int TYPE_FEATURE_COUNT = 3;

        public const int VIRTUAL_TYPE__NAMESPACE_URI = 0;

        public const int VIRTUAL_TYPE__NAME = 1;

        public const int VIRTUAL_TYPE__ABSTRACT = 2;

        public const int VIRTUAL_TYPE_FEATURE_COUNT = 3;

        public const int VIRTUAL_TYPE_FACADE_FEATURE_COUNT = 0;

        public const int VIRTUAL_FACADE_FEATURE_COUNT = 0;

        public const int VIRTUAL_FEATURE_COUNT = 0;

        public const int ITEM_HANDLE_FACADE_FEATURE_COUNT = 0;

        public const int ITEM_HANDLE__STATE_ID = 0;

        public const int ITEM_HANDLE__ITEM_ID = 1;

        public const int ITEM_HANDLE__ORIGIN = 2;

        public const int ITEM_HANDLE__IMMUTABLE = 3;

        public const int ITEM_HANDLE_FEATURE_COUNT = 4;

        public const int ITEM__STATE_ID = 0;

        public const int ITEM__ITEM_ID = 1;

        public const int ITEM__ORIGIN = 2;

        public const int ITEM__IMMUTABLE = 3;

        public const int ITEM__CONTEXT_ID = 4;

        public const int ITEM__MODIFIED = 5;

        public const int ITEM__MODIFIED_BY = 6;

        public const int ITEM__WORKING_COPY = 7;

        public const int ITEM__STRING_EXTENSIONS = 8;

        public const int ITEM__INT_EXTENSIONS = 9;

        public const int ITEM__BOOLEAN_EXTENSIONS = 10;

        public const int ITEM__TIMESTAMP_EXTENSIONS = 11;

        public const int ITEM__LONG_EXTENSIONS = 12;

        public const int ITEM__LARGE_STRING_EXTENSIONS = 13;

        public const int ITEM__MEDIUM_STRING_EXTENSIONS = 14;

        public const int ITEM__BIG_DECIMAL_EXTENSIONS = 15;

        public const int ITEM_FEATURE_COUNT = 16;

        public const int MANAGED_ITEM__STATE_ID = 0;

        public const int MANAGED_ITEM__ITEM_ID = 1;

        public const int MANAGED_ITEM__ORIGIN = 2;

        public const int MANAGED_ITEM__IMMUTABLE = 3;

        public const int MANAGED_ITEM__CONTEXT_ID = 4;

        public const int MANAGED_ITEM__MODIFIED = 5;

        public const int MANAGED_ITEM__MODIFIED_BY = 6;

        public const int MANAGED_ITEM__WORKING_COPY = 7;

        public const int MANAGED_ITEM__STRING_EXTENSIONS = 8;

        public const int MANAGED_ITEM__INT_EXTENSIONS = 9;

        public const int MANAGED_ITEM__BOOLEAN_EXTENSIONS = 10;

        public const int MANAGED_ITEM__TIMESTAMP_EXTENSIONS = 11;

        public const int MANAGED_ITEM__LONG_EXTENSIONS = 12;

        public const int MANAGED_ITEM__LARGE_STRING_EXTENSIONS = 13;

        public const int MANAGED_ITEM__MEDIUM_STRING_EXTENSIONS = 14;

        public const int MANAGED_ITEM__BIG_DECIMAL_EXTENSIONS = 15;

        public const int MANAGED_ITEM_FEATURE_COUNT = 16;

        public const int MANAGED_ITEM_HANDLE__STATE_ID = 0;

        public const int MANAGED_ITEM_HANDLE__ITEM_ID = 1;

        public const int MANAGED_ITEM_HANDLE__ORIGIN = 2;

        public const int MANAGED_ITEM_HANDLE__IMMUTABLE = 3;

        public const int MANAGED_ITEM_HANDLE_FEATURE_COUNT = 4;

        public const int MANAGED_ITEM_HANDLE_FACADE_FEATURE_COUNT = 0;

        public const int MANAGED_ITEM_FACADE_FEATURE_COUNT = 0;

        public const int AUDITABLE__STATE_ID = 0;

        public const int AUDITABLE__ITEM_ID = 1;

        public const int AUDITABLE__ORIGIN = 2;

        public const int AUDITABLE__IMMUTABLE = 3;

        public const int AUDITABLE__CONTEXT_ID = 4;

        public const int AUDITABLE__MODIFIED = 5;

        public const int AUDITABLE__MODIFIED_BY = 6;

        public const int AUDITABLE__WORKING_COPY = 7;

        public const int AUDITABLE__STRING_EXTENSIONS = 8;

        public const int AUDITABLE__INT_EXTENSIONS = 9;

        public const int AUDITABLE__BOOLEAN_EXTENSIONS = 10;

        public const int AUDITABLE__TIMESTAMP_EXTENSIONS = 11;

        public const int AUDITABLE__LONG_EXTENSIONS = 12;

        public const int AUDITABLE__LARGE_STRING_EXTENSIONS = 13;

        public const int AUDITABLE__MEDIUM_STRING_EXTENSIONS = 14;

        public const int AUDITABLE__BIG_DECIMAL_EXTENSIONS = 15;

        public const int AUDITABLE__MERGE_PREDECESSOR = 16;

        public const int AUDITABLE__WORKING_COPY_PREDECESSOR = 17;

        public const int AUDITABLE__WORKING_COPY_MERGE_PREDECESSOR = 18;

        public const int AUDITABLE__PREDECESSOR = 19;

        public const int AUDITABLE_FEATURE_COUNT = 20;

        internal void freeze()
        {
            throw new NotImplementedException();
        }

        public const int CONTRIBUTOR_DETAILS__STATE_ID = 0;

        public const int CONTRIBUTOR_DETAILS__ITEM_ID = 1;

        public const int CONTRIBUTOR_DETAILS__ORIGIN = 2;

        public const int CONTRIBUTOR_DETAILS__IMMUTABLE = 3;

        public const int CONTRIBUTOR_DETAILS__CONTEXT_ID = 4;

        public const int CONTRIBUTOR_DETAILS__MODIFIED = 5;

        public const int CONTRIBUTOR_DETAILS__MODIFIED_BY = 6;

        public const int CONTRIBUTOR_DETAILS__WORKING_COPY = 7;

        public const int CONTRIBUTOR_DETAILS__STRING_EXTENSIONS = 8;

        public const int CONTRIBUTOR_DETAILS__INT_EXTENSIONS = 9;

        public const int CONTRIBUTOR_DETAILS__BOOLEAN_EXTENSIONS = 10;

        public const int CONTRIBUTOR_DETAILS__TIMESTAMP_EXTENSIONS = 11;

        public const int CONTRIBUTOR_DETAILS__LONG_EXTENSIONS = 12;

        public const int CONTRIBUTOR_DETAILS__LARGE_STRING_EXTENSIONS = 13;

        public const int CONTRIBUTOR_DETAILS__MEDIUM_STRING_EXTENSIONS = 14;

        public const int CONTRIBUTOR_DETAILS__BIG_DECIMAL_EXTENSIONS = 15;

        public const int CONTRIBUTOR_DETAILS__MERGE_PREDECESSOR = 16;

        public const int CONTRIBUTOR_DETAILS__WORKING_COPY_PREDECESSOR = 17;

        public const int CONTRIBUTOR_DETAILS__WORKING_COPY_MERGE_PREDECESSOR = 18;

        public const int CONTRIBUTOR_DETAILS__PREDECESSOR = 19;

        public const int CONTRIBUTOR_DETAILS__PHOTO = 20;

        public const int CONTRIBUTOR_DETAILS_FEATURE_COUNT = 21;

        public const int AUDITABLE_HANDLE__STATE_ID = 0;

        public const int AUDITABLE_HANDLE__ITEM_ID = 1;

        public const int AUDITABLE_HANDLE__ORIGIN = 2;

        public const int AUDITABLE_HANDLE__IMMUTABLE = 3;

        public const int AUDITABLE_HANDLE_FEATURE_COUNT = 4;

        public const int CONTRIBUTOR_DETAILS_HANDLE__STATE_ID = 0;

        public const int CONTRIBUTOR_DETAILS_HANDLE__ITEM_ID = 1;

        public const int CONTRIBUTOR_DETAILS_HANDLE__ORIGIN = 2;

        public const int CONTRIBUTOR_DETAILS_HANDLE__IMMUTABLE = 3;

        public const int CONTRIBUTOR_DETAILS_HANDLE_FEATURE_COUNT = 4;

        public const int CONTRIBUTOR_DETAILS_HANDLE_FACADE_FEATURE_COUNT = 0;

        public const int CONTRIBUTOR_DETAILS_FACADE_FEATURE_COUNT = 0;

        public const int SCORED__INTERNAL_ID = 0;

        public const int SCORED__HANDLE = 1;

        public const int SCORED__SCORE = 2;

        public const int SCORED_FEATURE_COUNT = 3;

        public const int SCORED_FACADE = 23;

        public const int SCORED_FACADE_FEATURE_COUNT = 0;

        public const int QUERY_PAGE__INTERNAL_ID = 0;

        public const int QUERY_PAGE__SIZE = 1;

        public const int QUERY_PAGE__RESULT_SIZE = 2;

        public const int QUERY_PAGE__START_POSITION = 3;

        public const int QUERY_PAGE__TOKEN = 4;

        public const int QUERY_PAGE_FEATURE_COUNT = 5;

        public const int TEXT_QUERY_PAGE__INTERNAL_ID = 0;

        public const int TEXT_QUERY_PAGE__SIZE = 1;

        public const int TEXT_QUERY_PAGE__RESULT_SIZE = 2;

        public const int TEXT_QUERY_PAGE__START_POSITION = 3;

        public const int TEXT_QUERY_PAGE__TOKEN = 4;

        public const int TEXT_QUERY_PAGE__SCORED_HANDLES = 5;

        public const int TEXT_QUERY_PAGE_FEATURE_COUNT = 6;

        public const int TEXT_QUERY_PAGE_FACADE = 25;

        public const int TEXT_QUERY_PAGE_FACADE_FEATURE_COUNT = 0;

        public const int BASELINE_COMPARISON_FACADE = 27;

        public const int BASELINE_COMPARISON_FACADE_FEATURE_COUNT = 0;

        public const int BASELINE_COMPARISON__ADDED_ITEMS = 0;

        public const int BASELINE_COMPARISON__REMOVED_ITEMS = 1;

        public const int BASELINE_COMPARISON__IDENTICAL_ITEMS = 2;

        public const int BASELINE_COMPARISON__CHANGED_ITEMS = 3;

        public const int BASELINE_COMPARISON_FEATURE_COUNT = 4;

        public const int BASELINE_MEMBER_COMPARISON_FACADE = 29;

        public const int BASELINE_MEMBER_COMPARISON_FACADE_FEATURE_COUNT = 0;

        public const int BASELINE_MEMBER_COMPARISON__ITEM = 0;

        public const int BASELINE_MEMBER_COMPARISON__PRIOR_STATE_ID = 1;

        public const int BASELINE_MEMBER_COMPARISON__AFTER_STATE_ID = 2;

        public const int BASELINE_MEMBER_COMPARISON_FEATURE_COUNT = 3;

        public const int BASELINE_MEMBER__INTERNAL_ID = 0;

        public const int BASELINE_MEMBER__ITEM = 1;

        public const int BASELINE_MEMBER__STATE_ID = 2;

        public const int BASELINE_MEMBER_FEATURE_COUNT = 3;

        public const int AUDITABLE_BASELINE__STATE_ID = 0;

        public const int AUDITABLE_BASELINE__ITEM_ID = 1;

        public const int AUDITABLE_BASELINE__ORIGIN = 2;

        public const int AUDITABLE_BASELINE__IMMUTABLE = 3;

        public const int AUDITABLE_BASELINE__CONTEXT_ID = 4;

        public const int AUDITABLE_BASELINE__MODIFIED = 5;

        public const int AUDITABLE_BASELINE__MODIFIED_BY = 6;

        public const int AUDITABLE_BASELINE__WORKING_COPY = 7;

        public const int AUDITABLE_BASELINE__STRING_EXTENSIONS = 8;

        public const int AUDITABLE_BASELINE__INT_EXTENSIONS = 9;

        public const int AUDITABLE_BASELINE__BOOLEAN_EXTENSIONS = 10;

        public const int AUDITABLE_BASELINE__TIMESTAMP_EXTENSIONS = 11;

        public const int AUDITABLE_BASELINE__LONG_EXTENSIONS = 12;

        public const int AUDITABLE_BASELINE__LARGE_STRING_EXTENSIONS = 13;

        public const int AUDITABLE_BASELINE__MEDIUM_STRING_EXTENSIONS = 14;

        public const int AUDITABLE_BASELINE__BIG_DECIMAL_EXTENSIONS = 15;

        public const int AUDITABLE_BASELINE__MERGE_PREDECESSOR = 16;

        public const int AUDITABLE_BASELINE__WORKING_COPY_PREDECESSOR = 17;

        public const int AUDITABLE_BASELINE__WORKING_COPY_MERGE_PREDECESSOR = 18;

        public const int AUDITABLE_BASELINE__PREDECESSOR = 19;

        public const int AUDITABLE_BASELINE__NAME = 20;

        public const int AUDITABLE_BASELINE__OWNER = 21;

        public const int AUDITABLE_BASELINE__MEMBERS = 22;

        public const int AUDITABLE_BASELINE_FEATURE_COUNT = 23;

        public const int AUDITABLE_BASELINE_HANDLE__STATE_ID = 0;

        public const int AUDITABLE_BASELINE_HANDLE__ITEM_ID = 1;

        public const int AUDITABLE_BASELINE_HANDLE__ORIGIN = 2;

        public const int AUDITABLE_BASELINE_HANDLE__IMMUTABLE = 3;

        public const int AUDITABLE_BASELINE_HANDLE_FEATURE_COUNT = 4;

        public const int AUDITABLE_BASELINE_HANDLE_FACADE = 33;

        public const int AUDITABLE_BASELINE_HANDLE_FACADE_FEATURE_COUNT = 0;

        public const int AUDITABLE_BASELINE_FACADE = 34;

        public const int AUDITABLE_BASELINE_FACADE_FEATURE_COUNT = 0;

        public const int CONTENT__INTERNAL_ID = 0;

        public const int CONTENT__DELTA_PREDECESSOR = 1;

        public const int CONTENT__CONTENT_ID = 2;

        public const int CONTENT__CONTENT_LENGTH = 3;

        public const int CONTENT__CHARACTER_ENCODING = 4;

        public const int CONTENT__CONTENT_TYPE = 5;

        public const int CONTENT__CHECKSUM = 6;

        public const int CONTENT__LINE_DELIMITER_SETTING = 7;

        public const int CONTENT__LINE_DELIMITER_COUNT = 8;

        public const int CONTENT_FEATURE_COUNT = 9;

        public const int CONTENT_FACADE = 36;

        public const int CONTENT_FACADE_FEATURE_COUNT = 0;

        public const int REPOSITORY_ROOT__STATE_ID = 0;

        public const int REPOSITORY_ROOT__ITEM_ID = 1;

        public const int REPOSITORY_ROOT__ORIGIN = 2;

        public const int REPOSITORY_ROOT__IMMUTABLE = 3;

        public const int REPOSITORY_ROOT__CONTEXT_ID = 4;

        public const int REPOSITORY_ROOT__MODIFIED = 5;

        public const int REPOSITORY_ROOT__MODIFIED_BY = 6;

        public const int REPOSITORY_ROOT__WORKING_COPY = 7;

        public const int REPOSITORY_ROOT__STRING_EXTENSIONS = 8;

        public const int REPOSITORY_ROOT__INT_EXTENSIONS = 9;

        public const int REPOSITORY_ROOT__BOOLEAN_EXTENSIONS = 10;

        public const int REPOSITORY_ROOT__TIMESTAMP_EXTENSIONS = 11;

        public const int REPOSITORY_ROOT__LONG_EXTENSIONS = 12;

        public const int REPOSITORY_ROOT__LARGE_STRING_EXTENSIONS = 13;

        public const int REPOSITORY_ROOT__MEDIUM_STRING_EXTENSIONS = 14;

        public const int REPOSITORY_ROOT__BIG_DECIMAL_EXTENSIONS = 15;

        public const int REPOSITORY_ROOT__MERGE_PREDECESSOR = 16;

        public const int REPOSITORY_ROOT__WORKING_COPY_PREDECESSOR = 17;

        public const int REPOSITORY_ROOT__WORKING_COPY_MERGE_PREDECESSOR = 18;

        public const int REPOSITORY_ROOT__PREDECESSOR = 19;

        public const int REPOSITORY_ROOT__NAME = 20;

        public const int REPOSITORY_ROOT__MODE = 21;

        public const int REPOSITORY_ROOT__RESET_REQUIRED = 22;

        public const int REPOSITORY_ROOT__LICENSE_STATE = 23;

        public const int REPOSITORY_ROOT_FEATURE_COUNT = 24;

        public const int REPOSITORY_ROOT_HANDLE__STATE_ID = 0;

        public const int REPOSITORY_ROOT_HANDLE__ITEM_ID = 1;

        public const int REPOSITORY_ROOT_HANDLE__ORIGIN = 2;

        public const int REPOSITORY_ROOT_HANDLE__IMMUTABLE = 3;

        public const int REPOSITORY_ROOT_HANDLE_FEATURE_COUNT = 4;

        public const int REPOSITORY_ROOT_HANDLE_FACADE = 39;

        public const int REPOSITORY_ROOT_HANDLE_FACADE_FEATURE_COUNT = 0;

        public const int REPOSITORY_ROOT_FACADE = 40;

        public const int REPOSITORY_ROOT_FACADE_FEATURE_COUNT = 0;

        public const int AUDITABLE_HANDLE_FACADE = 43;

        public const int AUDITABLE_HANDLE_FACADE_FEATURE_COUNT = 0;

        public const int AUDITABLE_FACADE = 44;

        public const int AUDITABLE_FACADE_FEATURE_COUNT = 0;

        public const int CONTRIBUTOR__STATE_ID = 0;

        public const int CONTRIBUTOR__ITEM_ID = 1;

        public const int CONTRIBUTOR__ORIGIN = 2;

        public const int CONTRIBUTOR__IMMUTABLE = 3;

        public const int CONTRIBUTOR__CONTEXT_ID = 4;

        public const int CONTRIBUTOR__MODIFIED = 5;

        public const int CONTRIBUTOR__MODIFIED_BY = 6;

        public const int CONTRIBUTOR__WORKING_COPY = 7;

        public const int CONTRIBUTOR__STRING_EXTENSIONS = 8;

        public const int CONTRIBUTOR__INT_EXTENSIONS = 9;

        public const int CONTRIBUTOR__BOOLEAN_EXTENSIONS = 10;

        public const int CONTRIBUTOR__TIMESTAMP_EXTENSIONS = 11;

        public const int CONTRIBUTOR__LONG_EXTENSIONS = 12;

        public const int CONTRIBUTOR__LARGE_STRING_EXTENSIONS = 13;

        public const int CONTRIBUTOR__MEDIUM_STRING_EXTENSIONS = 14;

        public const int CONTRIBUTOR__BIG_DECIMAL_EXTENSIONS = 15;

        public const int CONTRIBUTOR__MERGE_PREDECESSOR = 16;

        public const int CONTRIBUTOR__WORKING_COPY_PREDECESSOR = 17;

        public const int CONTRIBUTOR__WORKING_COPY_MERGE_PREDECESSOR = 18;

        public const int CONTRIBUTOR__PREDECESSOR = 19;

        public const int CONTRIBUTOR__EMAIL_ADDRESS = 20;

        public const int CONTRIBUTOR__USER_ID = 21;

        public const int CONTRIBUTOR__NAME = 22;

        public const int CONTRIBUTOR__DETAILS = 23;

        public const int CONTRIBUTOR__ARCHIVED = 24;

        public const int CONTRIBUTOR_FEATURE_COUNT = 25;

        public const int CONTRIBUTOR_HANDLE__STATE_ID = 0;

        public const int CONTRIBUTOR_HANDLE__ITEM_ID = 1;

        public const int CONTRIBUTOR_HANDLE__ORIGIN = 2;

        public const int CONTRIBUTOR_HANDLE__IMMUTABLE = 3;

        public const int CONTRIBUTOR_HANDLE_FEATURE_COUNT = 4;

        public const int CONTRIBUTOR_HANDLE_FACADE = 47;

        public const int CONTRIBUTOR_HANDLE_FACADE_FEATURE_COUNT = 0;

        public const int CONTRIBUTOR_FACADE = 48;

        public const int CONTRIBUTOR_FACADE_FEATURE_COUNT = 0;

        public const int ITEM_FACADE = 52;

        public const int ITEM_FACADE_FEATURE_COUNT = 0;

        public const int ITEM_TYPE__NAMESPACE_URI = 0;

        public const int ITEM_TYPE__NAME = 1;

        public const int ITEM_TYPE__ABSTRACT = 2;

        public const int ITEM_TYPE_FEATURE_COUNT = 3;

        public const int ITEM_TYPE_FACADE = 54;

        public const int ITEM_TYPE_FACADE_FEATURE_COUNT = 0;

        public const int UNMANAGED_ITEM = 55;

        public const int UNMANAGED_ITEM__STATE_ID = 0;

        public const int UNMANAGED_ITEM__ITEM_ID = 1;

        public const int UNMANAGED_ITEM__ORIGIN = 2;

        public const int UNMANAGED_ITEM__IMMUTABLE = 3;

        public const int UNMANAGED_ITEM__CONTEXT_ID = 4;

        public const int UNMANAGED_ITEM__MODIFIED = 5;

        public const int UNMANAGED_ITEM__MODIFIED_BY = 6;

        public const int UNMANAGED_ITEM__WORKING_COPY = 7;

        public const int UNMANAGED_ITEM__STRING_EXTENSIONS = 8;

        public const int UNMANAGED_ITEM__INT_EXTENSIONS = 9;

        public const int UNMANAGED_ITEM__BOOLEAN_EXTENSIONS = 10;

        public const int UNMANAGED_ITEM__TIMESTAMP_EXTENSIONS = 11;

        public const int UNMANAGED_ITEM__LONG_EXTENSIONS = 12;

        public const int UNMANAGED_ITEM__LARGE_STRING_EXTENSIONS = 13;

        public const int UNMANAGED_ITEM__MEDIUM_STRING_EXTENSIONS = 14;

        public const int UNMANAGED_ITEM__BIG_DECIMAL_EXTENSIONS = 15;

        public const int UNMANAGED_ITEM_FEATURE_COUNT = 16;

        public const int UNMANAGED_ITEM_HANDLE = 56;

        public const int UNMANAGED_ITEM_HANDLE__STATE_ID = 0;

        public const int UNMANAGED_ITEM_HANDLE__ITEM_ID = 1;

        public const int UNMANAGED_ITEM_HANDLE__ORIGIN = 2;

        public const int UNMANAGED_ITEM_HANDLE__IMMUTABLE = 3;

        public const int UNMANAGED_ITEM_HANDLE_FEATURE_COUNT = 4;

        public const int UNMANAGED_ITEM_HANDLE_FACADE = 57;

        public const int UNMANAGED_ITEM_HANDLE_FACADE_FEATURE_COUNT = 0;

        public const int UNMANAGED_ITEM_FACADE = 58;

        public const int UNMANAGED_ITEM_FACADE_FEATURE_COUNT = 0;

        public const int RECONCILE_REPORT_FACADE = 60;

        public const int RECONCILE_REPORT_FACADE_FEATURE_COUNT = 0;

        public const int RECONCILE_REPORT__INTERNAL_KIND = 0;

        public const int RECONCILE_REPORT__INCOMING = 1;

        public const int RECONCILE_REPORT__OUTGOING = 2;

        public const int RECONCILE_REPORT__BASE = 3;

        public const int RECONCILE_REPORT__MERGE_RESULT = 4;

        public const int RECONCILE_REPORT_FEATURE_COUNT = 5;

        public const int PACKAGE_DESCRIPTION__VERSION = 0;

        public const int PACKAGE_DESCRIPTION__NS_URI = 1;

        public const int PACKAGE_DESCRIPTION__JAVA_URI = 2;

        public const int PACKAGE_DESCRIPTION_FEATURE_COUNT = 3;

        public const int SIMPLE_ITEM__STATE_ID = 0;

        public const int SIMPLE_ITEM__ITEM_ID = 1;

        public const int SIMPLE_ITEM__ORIGIN = 2;

        public const int SIMPLE_ITEM__IMMUTABLE = 3;

        public const int SIMPLE_ITEM__CONTEXT_ID = 4;

        public const int SIMPLE_ITEM__MODIFIED = 5;

        public const int SIMPLE_ITEM__MODIFIED_BY = 6;

        public const int SIMPLE_ITEM__WORKING_COPY = 7;

        public const int SIMPLE_ITEM__STRING_EXTENSIONS = 8;

        public const int SIMPLE_ITEM__INT_EXTENSIONS = 9;

        public const int SIMPLE_ITEM__BOOLEAN_EXTENSIONS = 10;

        public const int SIMPLE_ITEM__TIMESTAMP_EXTENSIONS = 11;

        public const int SIMPLE_ITEM__LONG_EXTENSIONS = 12;

        public const int SIMPLE_ITEM__LARGE_STRING_EXTENSIONS = 13;

        public const int SIMPLE_ITEM__MEDIUM_STRING_EXTENSIONS = 14;

        public const int SIMPLE_ITEM__BIG_DECIMAL_EXTENSIONS = 15;

        public const int SIMPLE_ITEM__PREDECESSOR = 16;

        public const int SIMPLE_ITEM_FEATURE_COUNT = 17;

        public const int CHANGE_EVENT__STATE_ID = 0;

        public const int CHANGE_EVENT__ITEM_ID = 1;

        public const int CHANGE_EVENT__ORIGIN = 2;

        public const int CHANGE_EVENT__IMMUTABLE = 3;

        public const int CHANGE_EVENT__CONTEXT_ID = 4;

        public const int CHANGE_EVENT__MODIFIED = 5;

        public const int CHANGE_EVENT__MODIFIED_BY = 6;

        public const int CHANGE_EVENT__WORKING_COPY = 7;

        public const int CHANGE_EVENT__STRING_EXTENSIONS = 8;

        public const int CHANGE_EVENT__INT_EXTENSIONS = 9;

        public const int CHANGE_EVENT__BOOLEAN_EXTENSIONS = 10;

        public const int CHANGE_EVENT__TIMESTAMP_EXTENSIONS = 11;

        public const int CHANGE_EVENT__LONG_EXTENSIONS = 12;

        public const int CHANGE_EVENT__LARGE_STRING_EXTENSIONS = 13;

        public const int CHANGE_EVENT__MEDIUM_STRING_EXTENSIONS = 14;

        public const int CHANGE_EVENT__BIG_DECIMAL_EXTENSIONS = 15;

        public const int CHANGE_EVENT__PREDECESSOR = 16;

        public const int CHANGE_EVENT__EVENT_STATE = 17;

        public const int CHANGE_EVENT__EVENT_OWNER_NS = 18;

        public const int CHANGE_EVENT__EVENT_TIME = 19;

        public const int CHANGE_EVENT__EVENT_AUTHOR = 20;

        public const int CHANGE_EVENT__EVENT_CATEGORY = 21;

        public const int CHANGE_EVENT__EVENT_TITLE = 22;

        public const int CHANGE_EVENT__EVENT_DESCRIPTION = 23;

        public const int CHANGE_EVENT__EVENT_PRIORITY = 24;

        public const int CHANGE_EVENT__EVENT_CONTRIBUTORS = 25;

        public const int CHANGE_EVENT__EVENT_PROCESS_AREA = 26;

        public const int CHANGE_EVENT__EVENT_EXPIRATION = 27;

        public const int CHANGE_EVENT__ITEM = 28;

        public const int CHANGE_EVENT_FEATURE_COUNT = 29;

        public const int SIMPLE_ITEM_HANDLE__STATE_ID = 0;

        public const int SIMPLE_ITEM_HANDLE__ITEM_ID = 1;

        public const int SIMPLE_ITEM_HANDLE__ORIGIN = 2;

        public const int SIMPLE_ITEM_HANDLE__IMMUTABLE = 3;

        public const int SIMPLE_ITEM_HANDLE_FEATURE_COUNT = 4;

        public const int CHANGE_EVENT_HANDLE__STATE_ID = 0;

        public const int CHANGE_EVENT_HANDLE__ITEM_ID = 1;

        public const int CHANGE_EVENT_HANDLE__ORIGIN = 2;

        public const int CHANGE_EVENT_HANDLE__IMMUTABLE = 3;

        public const int CHANGE_EVENT_HANDLE_FEATURE_COUNT = 4;

        public const int CHANGE_EVENT_HANDLE_FACADE = 64;

        public const int CHANGE_EVENT_HANDLE_FACADE_FEATURE_COUNT = 0;

        public const int CHANGE_EVENT_FACADE = 65;

        public const int CHANGE_EVENT_FACADE_FEATURE_COUNT = 0;

        public const int SERVER_VERSION_RECORD__STATE_ID = 0;

        public const int SERVER_VERSION_RECORD__ITEM_ID = 1;

        public const int SERVER_VERSION_RECORD__ORIGIN = 2;

        public const int SERVER_VERSION_RECORD__IMMUTABLE = 3;

        public const int SERVER_VERSION_RECORD__CONTEXT_ID = 4;

        public const int SERVER_VERSION_RECORD__MODIFIED = 5;

        public const int SERVER_VERSION_RECORD__MODIFIED_BY = 6;

        public const int SERVER_VERSION_RECORD__WORKING_COPY = 7;

        public const int SERVER_VERSION_RECORD__STRING_EXTENSIONS = 8;

        public const int SERVER_VERSION_RECORD__INT_EXTENSIONS = 9;

        public const int SERVER_VERSION_RECORD__BOOLEAN_EXTENSIONS = 10;

        public const int SERVER_VERSION_RECORD__TIMESTAMP_EXTENSIONS = 11;

        public const int SERVER_VERSION_RECORD__LONG_EXTENSIONS = 12;

        public const int SERVER_VERSION_RECORD__LARGE_STRING_EXTENSIONS = 13;

        public const int SERVER_VERSION_RECORD__MEDIUM_STRING_EXTENSIONS = 14;

        public const int SERVER_VERSION_RECORD__BIG_DECIMAL_EXTENSIONS = 15;

        public const int SERVER_VERSION_RECORD__MERGE_PREDECESSOR = 16;

        public const int SERVER_VERSION_RECORD__WORKING_COPY_PREDECESSOR = 17;

        public const int SERVER_VERSION_RECORD__WORKING_COPY_MERGE_PREDECESSOR = 18;

        public const int SERVER_VERSION_RECORD__PREDECESSOR = 19;

        public const int SERVER_VERSION_RECORD__VERTICAL_VERSION = 20;

        public const int SERVER_VERSION_RECORD__VERTICAL_ID = 21;

        public const int SERVER_VERSION_RECORD_FEATURE_COUNT = 22;

        public const int SERVER_VERSION_RECORD_HANDLE__STATE_ID = 0;

        public const int SERVER_VERSION_RECORD_HANDLE__ITEM_ID = 1;

        public const int SERVER_VERSION_RECORD_HANDLE__ORIGIN = 2;

        public const int SERVER_VERSION_RECORD_HANDLE__IMMUTABLE = 3;

        public const int SERVER_VERSION_RECORD_HANDLE_FEATURE_COUNT = 4;

        public const int SIMPLE_ITEM_HANDLE_FACADE = 70;

        public const int SIMPLE_ITEM_HANDLE_FACADE_FEATURE_COUNT = 0;

        public const int SIMPLE_ITEM_FACADE = 71;

        public const int SIMPLE_ITEM_FACADE_FEATURE_COUNT = 0;

        public const int SERVER_DESCRIPTION__USER_SERVER = 0;

        public const int SERVER_DESCRIPTION__AUTHENTICATED_CONTRIBUTOR = 1;

        public const int SERVER_DESCRIPTION__REPOSITORY_ROOT = 2;

        public const int SERVER_DESCRIPTION__PACKAGE_DESCRIPTIONS = 3;

        public const int SERVER_DESCRIPTION__PUBLIC_URI_ROOT = 4;

        public const int SERVER_DESCRIPTION__SERVER_STATE = 5;

        public const int SERVER_DESCRIPTION_FEATURE_COUNT = 6;

        public const int FETCH_RESULT_FACADE = 76;

        public const int FETCH_RESULT_FACADE_FEATURE_COUNT = 0;

        public const int FETCH_RESULT__NOT_FOUND_ITEMS = 0;

        public const int FETCH_RESULT__RETRIEVED_ITEMS = 1;

        public const int FETCH_RESULT__PERMISSION_DENIED_ITEMS = 2;

        public const int FETCH_RESULT_FEATURE_COUNT = 3;

        public const int QUERY__INTERNAL_ID = 0;

        public const int QUERY__QUERY_STRING = 1;

        public const int QUERY__INTERNAL_PARM_TYPES = 2;

        public const int QUERY_FEATURE_COUNT = 3;

        public const int QUERY_PAGE_FACADE = 79;

        public const int QUERY_PAGE_FACADE_FEATURE_COUNT = 0;

        public const int ITEM_QUERY_PAGE = 80;

        public const int ITEM_QUERY_PAGE__INTERNAL_ID = 0;

        public const int ITEM_QUERY_PAGE__SIZE = 1;

        public const int ITEM_QUERY_PAGE__RESULT_SIZE = 2;

        public const int ITEM_QUERY_PAGE__START_POSITION = 3;

        public const int ITEM_QUERY_PAGE__TOKEN = 4;

        public const int ITEM_QUERY_PAGE__ITEM_HANDLES = 5;

        public const int ITEM_QUERY_PAGE_FEATURE_COUNT = 6;

        public const int ITEM_QUERY_PAGE_FACADE = 81;

        public const int ITEM_QUERY_PAGE_FACADE_FEATURE_COUNT = 0;

        public const int DATA_QUERY_PAGE = 82;

        public const int DATA_QUERY_PAGE__INTERNAL_ID = 0;

        public const int DATA_QUERY_PAGE__SIZE = 1;

        public const int DATA_QUERY_PAGE__RESULT_SIZE = 2;

        public const int DATA_QUERY_PAGE__START_POSITION = 3;

        public const int DATA_QUERY_PAGE__TOKEN = 4;

        public const int DATA_QUERY_PAGE__DATA_FIELDS = 5;

        public const int DATA_QUERY_PAGE__RAW_DATA = 6;

        public const int DATA_QUERY_PAGE_FEATURE_COUNT = 7;

        public const int DATA_QUERY_PAGE_FACADE = 83;

        public const int DATA_QUERY_PAGE_FACADE_FEATURE_COUNT = 0;

        public const int DATA_FIELD = 84;

        public const int DATA_FIELD__INTERNAL_ID = 0;

        public const int DATA_FIELD__NAME = 1;

        public const int DATA_FIELD__FIELD_TYPE = 2;

        public const int DATA_FIELD_FEATURE_COUNT = 3;

        public const int DATA_FIELD_FACADE = 85;

        public const int DATA_FIELD_FACADE_FEATURE_COUNT = 0;

        public const int ITEM_QUERY = 86;

        public const int ITEM_QUERY__INTERNAL_ID = 0;

        public const int ITEM_QUERY__QUERY_STRING = 1;

        public const int ITEM_QUERY__INTERNAL_PARM_TYPES = 2;

        public const int ITEM_QUERY__RETURN_TYPE = 3;

        public const int ITEM_QUERY_FEATURE_COUNT = 4;

        public const int DATA_QUERY = 87;

        public const int DATA_QUERY__INTERNAL_ID = 0;

        public const int DATA_QUERY__QUERY_STRING = 1;

        public const int DATA_QUERY__INTERNAL_PARM_TYPES = 2;

        public const int DATA_QUERY__RETURN_TYPES = 3;

        public const int DATA_QUERY_FEATURE_COUNT = 4;

        public const int HELPER_TYPE = 90;

        public const int HELPER_TYPE__NAMESPACE_URI = 0;

        public const int HELPER_TYPE__NAME = 1;

        public const int HELPER_TYPE__ABSTRACT = 2;

        public const int HELPER_TYPE_FEATURE_COUNT = 3;

        public const int HELPER_TYPE_FACADE = 91;

        public const int HELPER_TYPE_FACADE_FEATURE_COUNT = 0;

        public const int INT_EXTENSION_ENTRY = 92;

        public const int INT_EXTENSION_ENTRY__INTERNAL_ID = 0;

        public const int INT_EXTENSION_ENTRY__KEY = 1;

        public const int INT_EXTENSION_ENTRY__VALUE = 2;

        public const int INT_EXTENSION_ENTRY_FEATURE_COUNT = 3;

        public const int STRING_EXTENSION_ENTRY = 93;

        public const int STRING_EXTENSION_ENTRY__INTERNAL_ID = 0;

        public const int STRING_EXTENSION_ENTRY__KEY = 1;

        public const int STRING_EXTENSION_ENTRY__VALUE = 2;

        public const int STRING_EXTENSION_ENTRY_FEATURE_COUNT = 3;

        public const int BOOLEAN_EXTENSION_ENTRY = 94;

        public const int BOOLEAN_EXTENSION_ENTRY__INTERNAL_ID = 0;

        public const int BOOLEAN_EXTENSION_ENTRY__KEY = 1;

        public const int BOOLEAN_EXTENSION_ENTRY__VALUE = 2;

        public const int BOOLEAN_EXTENSION_ENTRY_FEATURE_COUNT = 3;

        public const int TIMESTAMP_EXTENSION_ENTRY = 95;

        public const int TIMESTAMP_EXTENSION_ENTRY__INTERNAL_ID = 0;

        public const int TIMESTAMP_EXTENSION_ENTRY__KEY = 1;

        public const int TIMESTAMP_EXTENSION_ENTRY__VALUE = 2;

        public const int TIMESTAMP_EXTENSION_ENTRY_FEATURE_COUNT = 3;

        public const int LONG_EXTENSION_ENTRY = 96;

        public const int LONG_EXTENSION_ENTRY__INTERNAL_ID = 0;

        public const int LONG_EXTENSION_ENTRY__KEY = 1;

        public const int LONG_EXTENSION_ENTRY__VALUE = 2;

        public const int LONG_EXTENSION_ENTRY_FEATURE_COUNT = 3;

        public const int LARGE_STRING_EXTENSION_ENTRY = 97;

        public const int LARGE_STRING_EXTENSION_ENTRY__INTERNAL_ID = 0;

        public const int LARGE_STRING_EXTENSION_ENTRY__KEY = 1;

        public const int LARGE_STRING_EXTENSION_ENTRY__VALUE = 2;

        public const int LARGE_STRING_EXTENSION_ENTRY_FEATURE_COUNT = 3;

        public const int MEDIUM_STRING_EXTENSION_ENTRY = 98;

        public const int MEDIUM_STRING_EXTENSION_ENTRY__INTERNAL_ID = 0;

        public const int MEDIUM_STRING_EXTENSION_ENTRY__KEY = 1;

        public const int MEDIUM_STRING_EXTENSION_ENTRY__VALUE = 2;

        public const int MEDIUM_STRING_EXTENSION_ENTRY_FEATURE_COUNT = 3;

        public const int LICENSE_TYPE = 99;

        public const int LICENSE_TYPE__STATE_ID = 0;

        public const int LICENSE_TYPE__ITEM_ID = 1;

        public const int LICENSE_TYPE__ORIGIN = 2;

        public const int LICENSE_TYPE__IMMUTABLE = 3;

        public const int LICENSE_TYPE__CONTEXT_ID = 4;

        public const int LICENSE_TYPE__MODIFIED = 5;

        public const int LICENSE_TYPE__MODIFIED_BY = 6;

        public const int LICENSE_TYPE__WORKING_COPY = 7;

        public const int LICENSE_TYPE__STRING_EXTENSIONS = 8;

        public const int LICENSE_TYPE__INT_EXTENSIONS = 9;

        public const int LICENSE_TYPE__BOOLEAN_EXTENSIONS = 10;

        public const int LICENSE_TYPE__TIMESTAMP_EXTENSIONS = 11;

        public const int LICENSE_TYPE__LONG_EXTENSIONS = 12;

        public const int LICENSE_TYPE__LARGE_STRING_EXTENSIONS = 13;

        public const int LICENSE_TYPE__MEDIUM_STRING_EXTENSIONS = 14;

        public const int LICENSE_TYPE__BIG_DECIMAL_EXTENSIONS = 15;

        public const int LICENSE_TYPE__PREDECESSOR = 16;

        public const int LICENSE_TYPE__USED = 17;

        public const int LICENSE_TYPE__ID = 18;

        public const int LICENSE_TYPE__PURCHASES = 19;

        public const int LICENSE_TYPE_FEATURE_COUNT = 20;

        public const int LICENSE_TYPE_HANDLE = 100;

        public const int LICENSE_TYPE_HANDLE__STATE_ID = 0;

        public const int LICENSE_TYPE_HANDLE__ITEM_ID = 1;

        public const int LICENSE_TYPE_HANDLE__ORIGIN = 2;

        public const int LICENSE_TYPE_HANDLE__IMMUTABLE = 3;

        public const int LICENSE_TYPE_HANDLE_FEATURE_COUNT = 4;

        public const int LICENSE_ASSIGNMENT = 101;

        public const int LICENSE_ASSIGNMENT__STATE_ID = 0;

        public const int LICENSE_ASSIGNMENT__ITEM_ID = 1;

        public const int LICENSE_ASSIGNMENT__ORIGIN = 2;

        public const int LICENSE_ASSIGNMENT__IMMUTABLE = 3;

        public const int LICENSE_ASSIGNMENT__CONTEXT_ID = 4;

        public const int LICENSE_ASSIGNMENT__MODIFIED = 5;

        public const int LICENSE_ASSIGNMENT__MODIFIED_BY = 6;

        public const int LICENSE_ASSIGNMENT__WORKING_COPY = 7;

        public const int LICENSE_ASSIGNMENT__STRING_EXTENSIONS = 8;

        public const int LICENSE_ASSIGNMENT__INT_EXTENSIONS = 9;

        public const int LICENSE_ASSIGNMENT__BOOLEAN_EXTENSIONS = 10;

        public const int LICENSE_ASSIGNMENT__TIMESTAMP_EXTENSIONS = 11;

        public const int LICENSE_ASSIGNMENT__LONG_EXTENSIONS = 12;

        public const int LICENSE_ASSIGNMENT__LARGE_STRING_EXTENSIONS = 13;

        public const int LICENSE_ASSIGNMENT__MEDIUM_STRING_EXTENSIONS = 14;

        public const int LICENSE_ASSIGNMENT__BIG_DECIMAL_EXTENSIONS = 15;

        public const int LICENSE_ASSIGNMENT__PREDECESSOR = 16;

        public const int LICENSE_ASSIGNMENT__LICENSE = 17;

        public const int LICENSE_ASSIGNMENT__CONTRIBUTOR = 18;

        public const int LICENSE_ASSIGNMENT_FEATURE_COUNT = 19;

        public const int LICENSE_ASSIGNMENT_HANDLE = 102;

        public const int LICENSE_ASSIGNMENT_HANDLE__STATE_ID = 0;

        public const int LICENSE_ASSIGNMENT_HANDLE__ITEM_ID = 1;

        public const int LICENSE_ASSIGNMENT_HANDLE__ORIGIN = 2;

        public const int LICENSE_ASSIGNMENT_HANDLE__IMMUTABLE = 3;

        public const int LICENSE_ASSIGNMENT_HANDLE_FEATURE_COUNT = 4;

        public const int LICENSE_TYPE_DTO = 103;

        public const int LICENSE_TYPE_DTO__DISABLED_REASON = 0;

        public const int LICENSE_TYPE_DTO__ID = 1;

        public const int LICENSE_TYPE_DTO__DESCRIPTION = 2;

        public const int LICENSE_TYPE_DTO__PRODUCT_NAME = 3;

        public const int LICENSE_TYPE_DTO__BUY_URL = 4;

        public const int LICENSE_TYPE_DTO__EDITION_NAME = 5;

        public const int LICENSE_TYPE_DTO__VARIANT_NAME = 6;

        public const int LICENSE_TYPE_DTO__INFO_URL = 7;

        public const int LICENSE_TYPE_DTO__EXPIRATION_TIME = 8;

        public const int LICENSE_TYPE_DTO__TRIAL = 9;

        public const int LICENSE_TYPE_DTO__NOTICES = 10;

        public const int LICENSE_TYPE_DTO__HAS_AGREEMENT = 11;

        public const int LICENSE_TYPE_DTO_FEATURE_COUNT = 12;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO = 104;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__DISABLED_REASON = 0;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__ID = 1;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__DESCRIPTION = 2;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__PRODUCT_NAME = 3;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__BUY_URL = 4;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__EDITION_NAME = 5;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__VARIANT_NAME = 6;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__INFO_URL = 7;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__EXPIRATION_TIME = 8;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__TRIAL = 9;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__NOTICES = 10;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__HAS_AGREEMENT = 11;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__MAX = 12;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__USED = 13;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__TOTAL = 14;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__FREE = 15;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__NAME = 16;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__COUNTED_IN_SERVER_LIMIT = 17;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__FUNCTIONAL = 18;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__FLOATING = 19;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__VERSION = 20;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__HAS_UNACTIVATED_TRIAL = 21;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__UNACTIVATED_TRIAL_EXPIRATION_TIME = 22;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__KEYS = 23;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__PURCHASE_COUNT_LOCKED = 24;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__ACTIVATION_NOTIFICATION_URL = 25;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO__ACTIVATION_NOTIFICATION_MESSAGE = 26;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO_FEATURE_COUNT = 27;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO_FACADE = 105;

        public const int CONTRIBUTOR_LICENSE_TYPE_DTO_FACADE_FEATURE_COUNT = 0;

        public const int SERVER_LICENSE_TYPE_DTO = 106;

        public const int SERVER_LICENSE_TYPE_DTO__DISABLED_REASON = 0;

        public const int SERVER_LICENSE_TYPE_DTO__ID = 1;

        public const int SERVER_LICENSE_TYPE_DTO__DESCRIPTION = 2;

        public const int SERVER_LICENSE_TYPE_DTO__PRODUCT_NAME = 3;

        public const int SERVER_LICENSE_TYPE_DTO__BUY_URL = 4;

        public const int SERVER_LICENSE_TYPE_DTO__EDITION_NAME = 5;

        public const int SERVER_LICENSE_TYPE_DTO__VARIANT_NAME = 6;

        public const int SERVER_LICENSE_TYPE_DTO__INFO_URL = 7;

        public const int SERVER_LICENSE_TYPE_DTO__EXPIRATION_TIME = 8;

        public const int SERVER_LICENSE_TYPE_DTO__TRIAL = 9;

        public const int SERVER_LICENSE_TYPE_DTO__NOTICES = 10;

        public const int SERVER_LICENSE_TYPE_DTO__HAS_AGREEMENT = 11;

        public const int SERVER_LICENSE_TYPE_DTO__MAX_CONTRIBUTORS = 12;

        public const int SERVER_LICENSE_TYPE_DTO__USED_CONTRIBUTORS = 13;

        public const int SERVER_LICENSE_TYPE_DTO_FEATURE_COUNT = 14;

        public const int SERVER_LICENSE_TYPE_DTO_FACADE = 107;

        public const int SERVER_LICENSE_TYPE_DTO_FACADE_FEATURE_COUNT = 0;

        public const int LICENSES_INFO_DTO = 108;

        public const int LICENSES_INFO_DTO_FACADE = 109;

        public const int LICENSES_INFO_DTO_FACADE_FEATURE_COUNT = 0;

        public const int LICENSES_INFO_DTO__SERVER_LICENSE = 0;

        public const int LICENSES_INFO_DTO__TYPES = 1;

        public const int LICENSES_INFO_DTO_FEATURE_COUNT = 2;

        public const int LICENSE_PURCHASE = 110;

        public const int LICENSE_PURCHASE__INTERNAL_ID = 0;

        public const int LICENSE_PURCHASE__PURCHASED = 1;

        public const int LICENSE_PURCHASE__ID = 2;

        public const int LICENSE_PURCHASE_FEATURE_COUNT = 3;

        public const int LICENSES_INFO2_DTO = 111;

        public const int LICENSES_INFO2_DTO__SERVER_LICENSE = 0;

        public const int LICENSES_INFO2_DTO__TYPES = 1;

        public const int LICENSES_INFO2_DTO__FLOATING_SETUP_STATUS = 2;

        public const int LICENSES_INFO2_DTO__FLOATING_LICENSE_TYPES = 3;

        public const int LICENSES_INFO2_DTO__OPERATION_CHECK_RESULTS = 4;

        public const int LICENSES_INFO2_DTO_FEATURE_COUNT = 5;

        public const int LICENSES_INFO2_DTO_FACADE = 112;

        public const int LICENSES_INFO2_DTO_FACADE_FEATURE_COUNT = 0;

        public const int LICENSE_LEASE_DTO = 113;

        public const int LICENSE_LEASE_DTO__INTERNAL_ID = 0;

        public const int LICENSE_LEASE_DTO__USER_ID = 1;

        public const int LICENSE_LEASE_DTO__CONTRIBUTOR_UUID = 2;

        public const int LICENSE_LEASE_DTO__END_DATE = 3;

        public const int LICENSE_LEASE_DTO__USER_NAME = 4;

        public const int LICENSE_LEASE_DTO__LICENSE_ID = 5;

        public const int LICENSE_LEASE_DTO__LICENSE_NAME = 6;

        public const int LICENSE_LEASE_DTO__ID = 7;

        public const int LICENSE_LEASE_DTO__COUNTED = 8;

        public const int LICENSE_LEASE_DTO_FEATURE_COUNT = 9;

        public const int USED_LICENSE_INFO_DTO = 114;

        public const int USED_LICENSE_INFO_DTO__INTERNAL_ID = 0;

        public const int USED_LICENSE_INFO_DTO__TOTAL_USED_COUNT = 1;

        public const int USED_LICENSE_INFO_DTO__ACTIVE_LEASES = 2;

        public const int USED_LICENSE_INFO_DTO__COUNTED_ACTIVE_LEASES = 3;

        public const int USED_LICENSE_INFO_DTO_FEATURE_COUNT = 4;

        public const int LICENSE_OPERATION_CHECK_DTO = 115;

        public const int LICENSE_OPERATION_CHECK_DTO__INTERNAL_ID = 0;

        public const int LICENSE_OPERATION_CHECK_DTO__OPERATION_ID = 1;

        public const int LICENSE_OPERATION_CHECK_DTO__ALLOWED = 2;

        public const int LICENSE_OPERATION_CHECK_DTO_FEATURE_COUNT = 3;

        public const int FLOATING_SETUP_STATUS_DTO = 116;

        public const int FLOATING_SETUP_STATUS_DTO__INTERNAL_ID = 0;

        public const int FLOATING_SETUP_STATUS_DTO__SERVER_URL = 1;

        public const int FLOATING_SETUP_STATUS_DTO__CONNECTION_ERROR = 2;

        public const int FLOATING_SETUP_STATUS_DTO__CLIENT = 3;

        public const int FLOATING_SETUP_STATUS_DTO__SERVER = 4;

        public const int FLOATING_SETUP_STATUS_DTO_FEATURE_COUNT = 5;

        public const int OAUTH_SERVICE_PROVIDER_INFO = 117;

        public const int OAUTH_SERVICE_PROVIDER_INFO__INTERNAL_ID = 0;

        public const int OAUTH_SERVICE_PROVIDER_INFO__REALM = 1;

        public const int OAUTH_SERVICE_PROVIDER_INFO__ACCESS_TOKEN_URL = 2;

        public const int OAUTH_SERVICE_PROVIDER_INFO__REQUEST_TOKEN_URL = 3;

        public const int OAUTH_SERVICE_PROVIDER_INFO__CONSUMER_KEY = 4;

        public const int OAUTH_SERVICE_PROVIDER_INFO__CONSUMER_SECRET = 5;

        public const int OAUTH_SERVICE_PROVIDER_INFO__AUTHORIZE_USER_URL = 6;

        public const int OAUTH_SERVICE_PROVIDER_INFO_FEATURE_COUNT = 7;

        public const int OAUTH_CONSUMER_REGISTRATION = 118;

        public const int OAUTH_CONSUMER_REGISTRATION__STATE_ID = 0;

        public const int OAUTH_CONSUMER_REGISTRATION__ITEM_ID = 1;

        public const int OAUTH_CONSUMER_REGISTRATION__ORIGIN = 2;

        public const int OAUTH_CONSUMER_REGISTRATION__IMMUTABLE = 3;

        public const int OAUTH_CONSUMER_REGISTRATION__CONTEXT_ID = 4;

        public const int OAUTH_CONSUMER_REGISTRATION__MODIFIED = 5;

        public const int OAUTH_CONSUMER_REGISTRATION__MODIFIED_BY = 6;

        public const int OAUTH_CONSUMER_REGISTRATION__WORKING_COPY = 7;

        public const int OAUTH_CONSUMER_REGISTRATION__STRING_EXTENSIONS = 8;

        public const int OAUTH_CONSUMER_REGISTRATION__INT_EXTENSIONS = 9;

        public const int OAUTH_CONSUMER_REGISTRATION__BOOLEAN_EXTENSIONS = 10;

        public const int OAUTH_CONSUMER_REGISTRATION__TIMESTAMP_EXTENSIONS = 11;

        public const int OAUTH_CONSUMER_REGISTRATION__LONG_EXTENSIONS = 12;

        public const int OAUTH_CONSUMER_REGISTRATION__LARGE_STRING_EXTENSIONS = 13;

        public const int OAUTH_CONSUMER_REGISTRATION__MEDIUM_STRING_EXTENSIONS = 14;

        public const int OAUTH_CONSUMER_REGISTRATION__BIG_DECIMAL_EXTENSIONS = 15;

        public const int OAUTH_CONSUMER_REGISTRATION__PREDECESSOR = 16;

        public const int OAUTH_CONSUMER_REGISTRATION__KEY = 17;

        public const int OAUTH_CONSUMER_REGISTRATION__SECRET_TYPE = 18;

        public const int OAUTH_CONSUMER_REGISTRATION__TRUSTED = 19;

        public const int OAUTH_CONSUMER_REGISTRATION__SECRET = 20;

        public const int OAUTH_CONSUMER_REGISTRATION_FEATURE_COUNT = 21;

        public const int OAUTH_CONSUMER_REGISTRATION_HANDLE = 119;

        public const int OAUTH_CONSUMER_REGISTRATION_HANDLE__STATE_ID = 0;

        public const int OAUTH_CONSUMER_REGISTRATION_HANDLE__ITEM_ID = 1;

        public const int OAUTH_CONSUMER_REGISTRATION_HANDLE__ORIGIN = 2;

        public const int OAUTH_CONSUMER_REGISTRATION_HANDLE__IMMUTABLE = 3;

        public const int OAUTH_CONSUMER_REGISTRATION_HANDLE_FEATURE_COUNT = 4;

        public const int LICENSE_KEY = 120;

        public const int LICENSE_KEY__STATE_ID = 0;

        public const int LICENSE_KEY__ITEM_ID = 1;

        public const int LICENSE_KEY__ORIGIN = 2;

        public const int LICENSE_KEY__IMMUTABLE = 3;

        public const int LICENSE_KEY__CONTEXT_ID = 4;

        public const int LICENSE_KEY__MODIFIED = 5;

        public const int LICENSE_KEY__MODIFIED_BY = 6;

        public const int LICENSE_KEY__WORKING_COPY = 7;

        public const int LICENSE_KEY__STRING_EXTENSIONS = 8;

        public const int LICENSE_KEY__INT_EXTENSIONS = 9;

        public const int LICENSE_KEY__BOOLEAN_EXTENSIONS = 10;

        public const int LICENSE_KEY__TIMESTAMP_EXTENSIONS = 11;

        public const int LICENSE_KEY__LONG_EXTENSIONS = 12;

        public const int LICENSE_KEY__LARGE_STRING_EXTENSIONS = 13;

        public const int LICENSE_KEY__MEDIUM_STRING_EXTENSIONS = 14;

        public const int LICENSE_KEY__BIG_DECIMAL_EXTENSIONS = 15;

        public const int LICENSE_KEY__PREDECESSOR = 16;

        public const int LICENSE_KEY__ID = 17;

        public const int LICENSE_KEY__CONTENT = 18;

        public const int LICENSE_KEY__TYPE = 19;

        public const int LICENSE_KEY_FEATURE_COUNT = 20;

        public const int LICENSE_KEY_HANDLE = 121;

        public const int LICENSE_KEY_HANDLE__STATE_ID = 0;

        public const int LICENSE_KEY_HANDLE__ITEM_ID = 1;

        public const int LICENSE_KEY_HANDLE__ORIGIN = 2;

        public const int LICENSE_KEY_HANDLE__IMMUTABLE = 3;

        public const int LICENSE_KEY_HANDLE_FEATURE_COUNT = 4;

        public const int FLOATING_LICENSE_LEASE = 122;

        public const int FLOATING_LICENSE_LEASE__STATE_ID = 0;

        public const int FLOATING_LICENSE_LEASE__ITEM_ID = 1;

        public const int FLOATING_LICENSE_LEASE__ORIGIN = 2;

        public const int FLOATING_LICENSE_LEASE__IMMUTABLE = 3;

        public const int FLOATING_LICENSE_LEASE__CONTEXT_ID = 4;

        public const int FLOATING_LICENSE_LEASE__MODIFIED = 5;

        public const int FLOATING_LICENSE_LEASE__MODIFIED_BY = 6;

        public const int FLOATING_LICENSE_LEASE__WORKING_COPY = 7;

        public const int FLOATING_LICENSE_LEASE__STRING_EXTENSIONS = 8;

        public const int FLOATING_LICENSE_LEASE__INT_EXTENSIONS = 9;

        public const int FLOATING_LICENSE_LEASE__BOOLEAN_EXTENSIONS = 10;

        public const int FLOATING_LICENSE_LEASE__TIMESTAMP_EXTENSIONS = 11;

        public const int FLOATING_LICENSE_LEASE__LONG_EXTENSIONS = 12;

        public const int FLOATING_LICENSE_LEASE__LARGE_STRING_EXTENSIONS = 13;

        public const int FLOATING_LICENSE_LEASE__MEDIUM_STRING_EXTENSIONS = 14;

        public const int FLOATING_LICENSE_LEASE__BIG_DECIMAL_EXTENSIONS = 15;

        public const int FLOATING_LICENSE_LEASE__PREDECESSOR = 16;

        public const int FLOATING_LICENSE_LEASE__SERVER = 17;

        public const int FLOATING_LICENSE_LEASE__REPO_ROOT_ID = 18;

        public const int FLOATING_LICENSE_LEASE__POLICY = 19;

        public const int FLOATING_LICENSE_LEASE__EXPIRATION_DATE = 20;

        public const int FLOATING_LICENSE_LEASE__OPERATION_ID = 21;

        public const int FLOATING_LICENSE_LEASE__USER_ID = 22;

        public const int FLOATING_LICENSE_LEASE__START_DATE = 23;

        public const int FLOATING_LICENSE_LEASE__EXTERNAL_CHECKOUT = 24;

        public const int FLOATING_LICENSE_LEASE__TOKENS = 25;

        public const int FLOATING_LICENSE_LEASE__APPLICATION = 26;

        public const int FLOATING_LICENSE_LEASE_FEATURE_COUNT = 27;

        public const int FLOATING_LICENSE_LEASE_HANDLE = 123;

        public const int FLOATING_LICENSE_LEASE_HANDLE__STATE_ID = 0;

        public const int FLOATING_LICENSE_LEASE_HANDLE__ITEM_ID = 1;

        public const int FLOATING_LICENSE_LEASE_HANDLE__ORIGIN = 2;

        public const int FLOATING_LICENSE_LEASE_HANDLE__IMMUTABLE = 3;

        public const int FLOATING_LICENSE_LEASE_HANDLE_FEATURE_COUNT = 4;

        public const int EXTERNAL_LICENSE_CHECKOUT = 124;

        public const int EXTERNAL_LICENSE_CHECKOUT__INTERNAL_ID = 0;

        public const int EXTERNAL_LICENSE_CHECKOUT__PROVIDER = 1;

        public const int EXTERNAL_LICENSE_CHECKOUT__DATA = 2;

        public const int EXTERNAL_LICENSE_CHECKOUT__EXPIRATION_DATE = 3;

        public const int EXTERNAL_LICENSE_CHECKOUT_FEATURE_COUNT = 4;

        public const int FLOATING_LICENSE_POLICY = 125;

        public const int FLOATING_LICENSE_POLICY__STATE_ID = 0;

        public const int FLOATING_LICENSE_POLICY__ITEM_ID = 1;

        public const int FLOATING_LICENSE_POLICY__ORIGIN = 2;

        public const int FLOATING_LICENSE_POLICY__IMMUTABLE = 3;

        public const int FLOATING_LICENSE_POLICY__CONTEXT_ID = 4;

        public const int FLOATING_LICENSE_POLICY__MODIFIED = 5;

        public const int FLOATING_LICENSE_POLICY__MODIFIED_BY = 6;

        public const int FLOATING_LICENSE_POLICY__WORKING_COPY = 7;

        public const int FLOATING_LICENSE_POLICY__STRING_EXTENSIONS = 8;

        public const int FLOATING_LICENSE_POLICY__INT_EXTENSIONS = 9;

        public const int FLOATING_LICENSE_POLICY__BOOLEAN_EXTENSIONS = 10;

        public const int FLOATING_LICENSE_POLICY__TIMESTAMP_EXTENSIONS = 11;

        public const int FLOATING_LICENSE_POLICY__LONG_EXTENSIONS = 12;

        public const int FLOATING_LICENSE_POLICY__LARGE_STRING_EXTENSIONS = 13;

        public const int FLOATING_LICENSE_POLICY__MEDIUM_STRING_EXTENSIONS = 14;

        public const int FLOATING_LICENSE_POLICY__BIG_DECIMAL_EXTENSIONS = 15;

        public const int FLOATING_LICENSE_POLICY__PREDECESSOR = 16;

        public const int FLOATING_LICENSE_POLICY__POLICY_ID = 17;

        public const int FLOATING_LICENSE_POLICY__ACTIVE_LEASES = 18;

        public const int FLOATING_LICENSE_POLICY_FEATURE_COUNT = 19;

        public const int FLOATING_LICENSE_POLICY_HANDLE = 126;

        public const int FLOATING_LICENSE_POLICY_HANDLE__STATE_ID = 0;

        public const int FLOATING_LICENSE_POLICY_HANDLE__ITEM_ID = 1;

        public const int FLOATING_LICENSE_POLICY_HANDLE__ORIGIN = 2;

        public const int FLOATING_LICENSE_POLICY_HANDLE__IMMUTABLE = 3;

        public const int FLOATING_LICENSE_POLICY_HANDLE_FEATURE_COUNT = 4;

        public const int CONTRIBUTOR_RECORD = 127;

        public const int CONTRIBUTOR_RECORD__STATE_ID = 0;

        public const int CONTRIBUTOR_RECORD__ITEM_ID = 1;

        public const int CONTRIBUTOR_RECORD__ORIGIN = 2;

        public const int CONTRIBUTOR_RECORD__IMMUTABLE = 3;

        public const int CONTRIBUTOR_RECORD__CONTEXT_ID = 4;

        public const int CONTRIBUTOR_RECORD__MODIFIED = 5;

        public const int CONTRIBUTOR_RECORD__MODIFIED_BY = 6;

        public const int CONTRIBUTOR_RECORD__WORKING_COPY = 7;

        public const int CONTRIBUTOR_RECORD__STRING_EXTENSIONS = 8;

        public const int CONTRIBUTOR_RECORD__INT_EXTENSIONS = 9;

        public const int CONTRIBUTOR_RECORD__BOOLEAN_EXTENSIONS = 10;

        public const int CONTRIBUTOR_RECORD__TIMESTAMP_EXTENSIONS = 11;

        public const int CONTRIBUTOR_RECORD__LONG_EXTENSIONS = 12;

        public const int CONTRIBUTOR_RECORD__LARGE_STRING_EXTENSIONS = 13;

        public const int CONTRIBUTOR_RECORD__MEDIUM_STRING_EXTENSIONS = 14;

        public const int CONTRIBUTOR_RECORD__BIG_DECIMAL_EXTENSIONS = 15;

        public const int CONTRIBUTOR_RECORD__MERGE_PREDECESSOR = 16;

        public const int CONTRIBUTOR_RECORD__WORKING_COPY_PREDECESSOR = 17;

        public const int CONTRIBUTOR_RECORD__WORKING_COPY_MERGE_PREDECESSOR = 18;

        public const int CONTRIBUTOR_RECORD__PREDECESSOR = 19;

        public const int CONTRIBUTOR_RECORD__EMAIL_ADDRESS = 20;

        public const int CONTRIBUTOR_RECORD__DETAILS = 21;

        public const int CONTRIBUTOR_RECORD__ARCHIVED = 22;

        public const int CONTRIBUTOR_RECORD__NAME = 23;

        public const int CONTRIBUTOR_RECORD__USER_IDS = 24;

        public const int CONTRIBUTOR_RECORD__IDENTITIES = 25;

        public const int CONTRIBUTOR_RECORD_FEATURE_COUNT = 26;

        public const int CONTRIBUTOR_RECORD_HANDLE = 128;

        public const int CONTRIBUTOR_RECORD_HANDLE__STATE_ID = 0;

        public const int CONTRIBUTOR_RECORD_HANDLE__ITEM_ID = 1;

        public const int CONTRIBUTOR_RECORD_HANDLE__ORIGIN = 2;

        public const int CONTRIBUTOR_RECORD_HANDLE__IMMUTABLE = 3;

        public const int CONTRIBUTOR_RECORD_HANDLE_FEATURE_COUNT = 4;

        public const int CONTRIBUTOR_RECORD_HANDLE_FACADE = 129;

        public const int CONTRIBUTOR_RECORD_HANDLE_FACADE_FEATURE_COUNT = 0;

        public const int CONTRIBUTOR_RECORD_FACADE = 130;

        public const int CONTRIBUTOR_RECORD_FACADE_FEATURE_COUNT = 0;

        public const int CONTRIBUTOR_USER_ID = 131;

        public const int CONTRIBUTOR_USER_ID__INTERNAL_ID = 0;

        public const int CONTRIBUTOR_USER_ID__USER_ID = 1;

        public const int CONTRIBUTOR_USER_ID_FEATURE_COUNT = 2;

        public const int CONTRIBUTOR_USER_ID_FACADE = 132;

        public const int CONTRIBUTOR_USER_ID_FACADE_FEATURE_COUNT = 0;

        public const int CONTRIBUTOR_IDENTITY = 133;

        public const int CONTRIBUTOR_IDENTITY__INTERNAL_ID = 0;

        public const int CONTRIBUTOR_IDENTITY__ID = 1;

        public const int CONTRIBUTOR_IDENTITY__STATE_ID = 2;

        public const int CONTRIBUTOR_IDENTITY_FEATURE_COUNT = 3;

        public const int CONTRIBUTOR_IDENTITY_FACADE = 134;

        public const int CONTRIBUTOR_IDENTITY_FACADE_FEATURE_COUNT = 0;

        public const int LICENSE_NOTICE_DTO = 135;

        public const int LICENSE_NOTICE_DTO__NAME = 0;

        public const int LICENSE_NOTICE_DTO__TEXT = 1;

        public const int LICENSE_NOTICE_DTO_FEATURE_COUNT = 2;

        public const int CONTRIBUTOR_GROUP = 136;

        public const int CONTRIBUTOR_GROUP__STATE_ID = 0;

        public const int CONTRIBUTOR_GROUP__ITEM_ID = 1;

        public const int CONTRIBUTOR_GROUP__ORIGIN = 2;

        public const int CONTRIBUTOR_GROUP__IMMUTABLE = 3;

        public const int CONTRIBUTOR_GROUP__CONTEXT_ID = 4;

        public const int CONTRIBUTOR_GROUP__MODIFIED = 5;

        public const int CONTRIBUTOR_GROUP__MODIFIED_BY = 6;

        public const int CONTRIBUTOR_GROUP__WORKING_COPY = 7;

        public const int CONTRIBUTOR_GROUP__STRING_EXTENSIONS = 8;

        public const int CONTRIBUTOR_GROUP__INT_EXTENSIONS = 9;

        public const int CONTRIBUTOR_GROUP__BOOLEAN_EXTENSIONS = 10;

        public const int CONTRIBUTOR_GROUP__TIMESTAMP_EXTENSIONS = 11;

        public const int CONTRIBUTOR_GROUP__LONG_EXTENSIONS = 12;

        public const int CONTRIBUTOR_GROUP__LARGE_STRING_EXTENSIONS = 13;

        public const int CONTRIBUTOR_GROUP__MEDIUM_STRING_EXTENSIONS = 14;

        public const int CONTRIBUTOR_GROUP__BIG_DECIMAL_EXTENSIONS = 15;

        public const int CONTRIBUTOR_GROUP__MERGE_PREDECESSOR = 16;

        public const int CONTRIBUTOR_GROUP__WORKING_COPY_PREDECESSOR = 17;

        public const int CONTRIBUTOR_GROUP__WORKING_COPY_MERGE_PREDECESSOR = 18;

        public const int CONTRIBUTOR_GROUP__PREDECESSOR = 19;

        public const int CONTRIBUTOR_GROUP__INTERNAL_CONTRIBUTORS = 20;

        public const int CONTRIBUTOR_GROUP__INTERNAL_NAME = 21;

        public const int CONTRIBUTOR_GROUP__INTERNAL_SUMMARY = 22;

        public const int CONTRIBUTOR_GROUP__INTERNAL_DESCRIPTION = 23;

        public const int CONTRIBUTOR_GROUP_FEATURE_COUNT = 24;

        public const int CONTRIBUTOR_GROUP_HANDLE = 137;

        public const int CONTRIBUTOR_GROUP_HANDLE__STATE_ID = 0;

        public const int CONTRIBUTOR_GROUP_HANDLE__ITEM_ID = 1;

        public const int CONTRIBUTOR_GROUP_HANDLE__ORIGIN = 2;

        public const int CONTRIBUTOR_GROUP_HANDLE__IMMUTABLE = 3;

        public const int CONTRIBUTOR_GROUP_HANDLE_FEATURE_COUNT = 4;

        public const int CONTRIBUTOR_GROUP_HANDLE_FACADE = 138;

        public const int CONTRIBUTOR_GROUP_HANDLE_FACADE_FEATURE_COUNT = 0;

        public const int CONTRIBUTOR_GROUP_FACADE = 139;

        public const int CONTRIBUTOR_GROUP_FACADE_FEATURE_COUNT = 0;

        public const int SERVER_VERSION_CHECK_EXCEPTION_DTO = 140;

        public const int SERVER_VERSION_CHECK_EXCEPTION_DTO__INTERNAL_ID = 0;

        public const int SERVER_VERSION_CHECK_EXCEPTION_DTO__URI = 1;

        public const int SERVER_VERSION_CHECK_EXCEPTION_DTO__SERVER_VERSION = 2;

        public const int SERVER_VERSION_CHECK_EXCEPTION_DTO__CLIENT_VERSION = 3;

        public const int SERVER_VERSION_CHECK_EXCEPTION_DTO_FEATURE_COUNT = 4;

        public const int STRING_DTO = 141;

        public const int STRING_DTO__INTERNAL_ID = 0;

        public const int STRING_DTO__STRING = 1;

        public const int STRING_DTO_FEATURE_COUNT = 2;

        public const int JPI_MAPPING = 142;

        public const int JPI_MAPPING__STATE_ID = 0;

        public const int JPI_MAPPING__ITEM_ID = 1;

        public const int JPI_MAPPING__ORIGIN = 2;

        public const int JPI_MAPPING__IMMUTABLE = 3;

        public const int JPI_MAPPING__CONTEXT_ID = 4;

        public const int JPI_MAPPING__MODIFIED = 5;

        public const int JPI_MAPPING__MODIFIED_BY = 6;

        public const int JPI_MAPPING__WORKING_COPY = 7;

        public const int JPI_MAPPING__STRING_EXTENSIONS = 8;

        public const int JPI_MAPPING__INT_EXTENSIONS = 9;

        public const int JPI_MAPPING__BOOLEAN_EXTENSIONS = 10;

        public const int JPI_MAPPING__TIMESTAMP_EXTENSIONS = 11;

        public const int JPI_MAPPING__LONG_EXTENSIONS = 12;

        public const int JPI_MAPPING__LARGE_STRING_EXTENSIONS = 13;

        public const int JPI_MAPPING__MEDIUM_STRING_EXTENSIONS = 14;

        public const int JPI_MAPPING__BIG_DECIMAL_EXTENSIONS = 15;

        public const int JPI_MAPPING__MERGE_PREDECESSOR = 16;

        public const int JPI_MAPPING__WORKING_COPY_PREDECESSOR = 17;

        public const int JPI_MAPPING__WORKING_COPY_MERGE_PREDECESSOR = 18;

        public const int JPI_MAPPING__PREDECESSOR = 19;

        public const int JPI_MAPPING__URL = 20;

        public const int JPI_MAPPING__JPI = 21;

        public const int JPI_MAPPING__MAPPING_EVENT_ID = 22;

        public const int JPI_MAPPING_FEATURE_COUNT = 23;

        public const int JPI_MAPPING_HANDLE = 143;

        public const int JPI_MAPPING_HANDLE__STATE_ID = 0;

        public const int JPI_MAPPING_HANDLE__ITEM_ID = 1;

        public const int JPI_MAPPING_HANDLE__ORIGIN = 2;

        public const int JPI_MAPPING_HANDLE__IMMUTABLE = 3;

        public const int JPI_MAPPING_HANDLE_FEATURE_COUNT = 4;

        public const int DB_TABLE_SIZE_DTO = 144;

        public const int DB_TABLE_SIZE_DTO__INTERNAL_ID = 0;

        public const int DB_TABLE_SIZE_DTO__COMPONENT = 1;

        public const int DB_TABLE_SIZE_DTO__TYPE_NAME = 2;

        public const int DB_TABLE_SIZE_DTO__ITEM_COUNT = 3;

        public const int DB_TABLE_SIZE_DTO__STATE_COUNT = 4;

        public const int DB_TABLE_SIZE_DTO__CONTENT_SIZE = 5;

        public const int DB_TABLE_SIZE_DTO_FEATURE_COUNT = 6;

        public const int MAPPING_EVENT = 145;

        public const int MAPPING_EVENT__STATE_ID = 0;

        public const int MAPPING_EVENT__ITEM_ID = 1;

        public const int MAPPING_EVENT__ORIGIN = 2;

        public const int MAPPING_EVENT__IMMUTABLE = 3;

        public const int MAPPING_EVENT__CONTEXT_ID = 4;

        public const int MAPPING_EVENT__MODIFIED = 5;

        public const int MAPPING_EVENT__MODIFIED_BY = 6;

        public const int MAPPING_EVENT__WORKING_COPY = 7;

        public const int MAPPING_EVENT__STRING_EXTENSIONS = 8;

        public const int MAPPING_EVENT__INT_EXTENSIONS = 9;

        public const int MAPPING_EVENT__BOOLEAN_EXTENSIONS = 10;

        public const int MAPPING_EVENT__TIMESTAMP_EXTENSIONS = 11;

        public const int MAPPING_EVENT__LONG_EXTENSIONS = 12;

        public const int MAPPING_EVENT__LARGE_STRING_EXTENSIONS = 13;

        public const int MAPPING_EVENT__MEDIUM_STRING_EXTENSIONS = 14;

        public const int MAPPING_EVENT__BIG_DECIMAL_EXTENSIONS = 15;

        public const int MAPPING_EVENT__PREDECESSOR = 16;

        public const int MAPPING_EVENT__EVENT_ID = 17;

        public const int MAPPING_EVENT__URL_CHANGES = 18;

        public const int MAPPING_EVENT__APP_RENAME_STATUS = 19;

        public const int MAPPING_EVENT_FEATURE_COUNT = 20;

        public const int MAPPING_EVENT_HANDLE = 146;

        public const int MAPPING_EVENT_HANDLE__STATE_ID = 0;

        public const int MAPPING_EVENT_HANDLE__ITEM_ID = 1;

        public const int MAPPING_EVENT_HANDLE__ORIGIN = 2;

        public const int MAPPING_EVENT_HANDLE__IMMUTABLE = 3;

        public const int MAPPING_EVENT_HANDLE_FEATURE_COUNT = 4;

        public const int URL_CHANGE_EVENT = 147;

        public const int URL_CHANGE_EVENT__INTERNAL_ID = 0;

        public const int URL_CHANGE_EVENT__OLD_URL = 1;

        public const int URL_CHANGE_EVENT__NEW_URL = 2;

        public const int URL_CHANGE_EVENT__DERIVED = 3;

        public const int URL_CHANGE_EVENT_FEATURE_COUNT = 4;

        public const int SERVER_STATE_DTO = 148;

        public const int SERVER_STATE_DTO__INTERNAL_ID = 0;

        public const int SERVER_STATE_DTO__SERVER_STATE_ID = 1;

        public const int SERVER_STATE_DTO__LAST_STATE_CHANGE_MESSAGE = 2;

        public const int SERVER_STATE_DTO_FEATURE_COUNT = 3;

        public const int TOKEN_CHECKOUT = 149;

        public const int TOKEN_CHECKOUT__INTERNAL_ID = 0;

        public const int TOKEN_CHECKOUT__PROVIDER = 1;

        public const int TOKEN_CHECKOUT__DATA = 2;

        public const int TOKEN_CHECKOUT__EXPIRATION_DATE = 3;

        public const int TOKEN_CHECKOUT__COUNT = 4;

        public const int TOKEN_CHECKOUT_FEATURE_COUNT = 5;

        public const int NODE_DIAGNOSTIC_TEST_RESULT_DTO = 150;

        public const int NODE_DIAGNOSTIC_TEST_RESULT_DTO__INTERNAL_ID = 0;

        public const int NODE_DIAGNOSTIC_TEST_RESULT_DTO__ERROR = 1;

        public const int NODE_DIAGNOSTIC_TEST_RESULT_DTO__WARNING = 2;

        public const int NODE_DIAGNOSTIC_TEST_RESULT_DTO__EXECUTION_TIME = 3;

        public const int NODE_DIAGNOSTIC_TEST_RESULT_DTO__EXECUTION_DURATION = 4;

        public const int NODE_DIAGNOSTIC_TEST_RESULT_DTO__STATUS = 5;

        public const int NODE_DIAGNOSTIC_TEST_RESULT_DTO__NODE_ID = 6;

        public const int NODE_DIAGNOSTIC_TEST_RESULT_DTO_FEATURE_COUNT = 7;

        public const int DIAGNOSTIC_TEST_RESULT_DTO = 151;

        public const int DIAGNOSTIC_TEST_RESULT_DTO__INTERNAL_ID = 0;

        public const int DIAGNOSTIC_TEST_RESULT_DTO__ID = 1;

        public const int DIAGNOSTIC_TEST_RESULT_DTO__TITLE = 2;

        public const int DIAGNOSTIC_TEST_RESULT_DTO__DESCRIPTION = 3;

        public const int DIAGNOSTIC_TEST_RESULT_DTO__ERROR = 4;

        public const int DIAGNOSTIC_TEST_RESULT_DTO__WARNING = 5;

        public const int DIAGNOSTIC_TEST_RESULT_DTO__EXECUTION_TIME = 6;

        public const int DIAGNOSTIC_TEST_RESULT_DTO__EXECUTION_DURATION = 7;

        public const int DIAGNOSTIC_TEST_RESULT_DTO__STATUS = 8;

        public const int DIAGNOSTIC_TEST_RESULT_DTO__CURRENT_PROGRESS = 9;

        public const int DIAGNOSTIC_TEST_RESULT_DTO__DISABLED = 10;

        public const int DIAGNOSTIC_TEST_RESULT_DTO__NODES_RESULTS = 11;

        public const int DIAGNOSTIC_TEST_RESULT_DTO__NODE_SCOPED_TEST = 12;

        public const int DIAGNOSTIC_TEST_RESULT_DTO__INVOCATION_PERIOD = 13;

        public const int DIAGNOSTIC_TEST_RESULT_DTO__NEXT_INVOCATION = 14;

        public const int DIAGNOSTIC_TEST_RESULT_DTO_FEATURE_COUNT = 15;

        public const int LICENSE_ASSIGNMENT_RESULT_DTO_FACADE = 153;

        public const int LICENSE_ASSIGNMENT_RESULT_DTO = 152;

        public const int LICENSE_ASSIGNMENT_RESULT_DTO__INTERNAL_ID = 0;

        public const int LICENSE_ASSIGNMENT_RESULT_DTO__MESSAGE = 1;

        public const int LICENSE_ASSIGNMENT_RESULT_DTO__STATUS = 2;

        public const int LICENSE_ASSIGNMENT_RESULT_DTO_FEATURE_COUNT = 3;

        public const int LICENSE_ASSIGNMENT_RESULT_DTO_FACADE_FEATURE_COUNT = 0;

        public const int RECONCILE_KIND = 154;

        public const int REPOSITORY_MODE = 155;

        public const int OAUTH_SECRET_TYPE = 156;

        public const int APP_RENAME_STATUS = 157;

        public const int TIMESTAMP = 158;

        public const int UUID = 159;

        public const int OBJECT = 160;
        private string v;


        public RepositoryPackage(string v, RepositoryPackage eINSTANCE)
        {
            this.v = v;
            RepositoryPackage.eINSTANCE = eINSTANCE;
        }

        public abstract EClass getExternalUserStatus();


        public abstract EAttribute getExternalUserStatus_Message();


        public abstract EAttribute getExternalUserStatus_Valid();


        public abstract EClass getExternalRegistryConfigurationDTO();


        public abstract EAttribute getExternalRegistryConfigurationDTO_Writable();


        public abstract EAttribute getExternalRegistryConfigurationDTO_Queryable();


        public abstract EAttribute getExternalRegistryConfigurationDTO_MaxLimitForUserSearchQuery();


        public abstract EAttribute getExternalRegistryConfigurationDTO_ReadOnlyUserAttributes();


        public abstract EReference getExternalRegistryConfigurationDTO_Groups();


        public abstract EClass getExternalUsersDTO();


        public abstract EAttribute getExternalUsersDTO_MaxLimitOfReturnedUsers();


        public abstract EReference getExternalUsersDTO_ExternalUsers();


        public abstract EClass getFetchUserDTO();


        public abstract EAttribute getFetchUserDTO_ReadOnlyProperties();


        public abstract EReference getFetchUserDTO_Externaluser();


        public abstract EClass getExternalGroup();


        public abstract EAttribute getExternalGroup_Description();


        public abstract EAttribute getExternalGroup_Name();


        public abstract EClass getExternalGroupFacade();


        public abstract EClass getDetailEntry();


        public abstract EAttribute getDetailEntry_Key();


        public abstract EAttribute getDetailEntry_Value();


        public abstract EClass getExternalUser();


        public abstract EAttribute getExternalUser_FullNames();


        public abstract EAttribute getExternalUser_UserIds();


        public abstract EAttribute getExternalUser_EmailAddresses();


        public abstract EReference getExternalUser_DetailFields();


        public abstract EReference getExternalUser_Status();


        public abstract EClass getExternalUserFacade();


        public abstract EClass getBigDecimalExtensionEntry();


        public abstract EAttribute getBigDecimalExtensionEntry_Key();


        public abstract EAttribute getBigDecimalExtensionEntry_Value();


        public abstract EClass getVirtualType();


        public abstract EClass getVirtualTypeFacade();


        public abstract EClass getVirtual();


        public abstract EClass getVirtualFacade();


        public abstract EClass getManagedItem();


        public abstract EClass getManagedItemHandle();


        public abstract EClass getManagedItemHandleFacade();


        public abstract EClass getManagedItemFacade();


        public abstract EClass getContributorDetails();


        public abstract EReference getContributorDetails_Photo();


        public abstract EClass getContributorDetailsHandle();


        public abstract EClass getContributorDetailsHandleFacade();


        public abstract EClass getContributorDetailsFacade();


        public abstract EClass getScored();


        public abstract EReference getScored_Handle();


        public abstract EAttribute getScored_Score();


        public abstract EClass getScoredFacade();


        public abstract EClass getTextQueryPage();


        public abstract EReference getTextQueryPage_ScoredHandles();


        public abstract EClass getTextQueryPageFacade();


        public abstract EClass getBaselineComparison();


        public abstract EReference getBaselineComparison_AddedItems();


        public abstract EReference getBaselineComparison_RemovedItems();


        public abstract EReference getBaselineComparison_IdenticalItems();


        public abstract EReference getBaselineComparison_ChangedItems();


        public abstract EClass getBaselineComparisonFacade();


        public abstract EClass getBaselineMemberComparison();


        public abstract EReference getBaselineMemberComparison_Item();


        public abstract EAttribute getBaselineMemberComparison_PriorStateId();


        public abstract EAttribute getBaselineMemberComparison_AfterStateId();


        public abstract EClass getBaselineMemberComparisonFacade();


        public abstract EClass getBaselineMember();


        public abstract EReference getBaselineMember_Item();


        public abstract EAttribute getBaselineMember_StateId();


        public abstract EClass getAuditableBaseline();


        public abstract EAttribute getAuditableBaseline_Name();


        public abstract EReference getAuditableBaseline_Owner();


        public abstract EReference getAuditableBaseline_Members();


        public abstract EClass getAuditableBaselineHandle();


        public abstract EClass getAuditableBaselineHandleFacade();


        public abstract EClass getAuditableBaselineFacade();


        public abstract EClass getContent();


        public abstract EAttribute getContent_DeltaPredecessor();


        public abstract EAttribute getContent_ContentId();


        public abstract EAttribute getContent_ContentLength();


        public abstract EAttribute getContent_CharacterEncoding();


        public abstract EAttribute getContent_ContentType();


        public abstract EAttribute getContent_Checksum();


        public abstract EAttribute getContent_LineDelimiterSetting();


        public abstract EAttribute getContent_LineDelimiterCount();


        public abstract EClass getContentFacade();


        public abstract EClass getRepositoryRoot();


        public abstract EAttribute getRepositoryRoot_Name();


        public abstract EAttribute getRepositoryRoot_Mode();


        public abstract EAttribute getRepositoryRoot_ResetRequired();


        public abstract EReference getRepositoryRoot_LicenseState();


        public abstract EClass getRepositoryRootHandle();


        public abstract EClass getRepositoryRootHandleFacade();


        public abstract EClass getRepositoryRootFacade();


        public abstract EClass getAuditable();


        public abstract EAttribute getAuditable_MergePredecessor();


        public abstract EAttribute getAuditable_WorkingCopyPredecessor();


        public abstract EAttribute getAuditable_WorkingCopyMergePredecessor();


        public abstract EAttribute getAuditable_Predecessor();


        public abstract EClass getAuditableHandle();


        public abstract EClass getAuditableHandleFacade();


        public abstract EClass getAuditableFacade();


        public abstract EClass getContributor();


        public abstract EAttribute getContributor_EmailAddress();


        public abstract EAttribute getContributor_UserId();


        public abstract EAttribute getContributor_Name();


        public abstract EReference getContributor_Details();


        public abstract EAttribute getContributor_Archived();


        public abstract EClass getContributorHandle();


        public abstract EClass getContributorHandleFacade();


        public abstract EClass getContributorFacade();


        public abstract EClass getItem();


        public abstract EAttribute getItem_ContextId();


        public abstract EAttribute getItem_Modified();


        public abstract EReference getItem_ModifiedBy();


        public abstract EAttribute getItem_WorkingCopy();


        public abstract EReference getItem_StringExtensions();


        public abstract EReference getItem_IntExtensions();


        public abstract EReference getItem_BooleanExtensions();


        public abstract EReference getItem_TimestampExtensions();


        public abstract EReference getItem_LongExtensions();


        public abstract EReference getItem_LargeStringExtensions();


        public abstract EReference getItem_MediumStringExtensions();


        public abstract EReference getItem_BigDecimalExtensions();


        public abstract EClass getItemHandle();


        public abstract EAttribute getItemHandle_StateId();


        public abstract EAttribute getItemHandle_ItemId();


        public abstract EAttribute getItemHandle_Origin();


        public abstract EAttribute getItemHandle_Immutable();


        public abstract EClass getItemHandleFacade();


        public abstract EClass getItemFacade();


        public abstract EClass getItemType();


        public abstract EClass getItemTypeFacade();


        public abstract EClass getUnmanagedItem();


        public abstract EClass getUnmanagedItemHandle();


        public abstract EClass getUnmanagedItemHandleFacade();


        public abstract EClass getUnmanagedItemFacade();


        public abstract EClass getReconcileReport();


        public abstract EAttribute getReconcileReport_InternalKind();


        public abstract EReference getReconcileReport_Incoming();


        public abstract EReference getReconcileReport_Outgoing();


        public abstract EReference getReconcileReport_Base();


        public abstract EReference getReconcileReport_MergeResult();


        public abstract EClass getReconcileReportFacade();


        public abstract EClass getPackageDescription();


        public abstract EAttribute getPackageDescription_Version();


        public abstract EAttribute getPackageDescription_NsURI();


        public abstract EAttribute getPackageDescription_JavaURI();


        public abstract EClass getChangeEvent();


        public abstract EAttribute getChangeEvent_EventState();


        public abstract EAttribute getChangeEvent_EventOwnerNS();


        public abstract EAttribute getChangeEvent_EventTime();


        public abstract EReference getChangeEvent_EventAuthor();


        public abstract EAttribute getChangeEvent_EventCategory();


        public abstract EAttribute getChangeEvent_EventTitle();


        public abstract EAttribute getChangeEvent_EventDescription();


        public abstract EAttribute getChangeEvent_EventPriority();


        public abstract EReference getChangeEvent_EventContributors();


        public abstract EReference getChangeEvent_EventProcessArea();


        public abstract EAttribute getChangeEvent_EventExpiration();


        public abstract EReference getChangeEvent_Item();


        public abstract EClass getChangeEventHandle();


        public abstract EClass getChangeEventHandleFacade();


        public abstract EClass getChangeEventFacade();


        public abstract EClass getServerVersionRecord();


        public abstract EAttribute getServerVersionRecord_VerticalVersion();


        public abstract EAttribute getServerVersionRecord_VerticalId();


        public abstract EClass getServerVersionRecordHandle();


        public abstract EClass getSimpleItem();


        public abstract EAttribute getSimpleItem_Predecessor();


        public abstract EClass getSimpleItemHandle();


        public abstract EClass getSimpleItemHandleFacade();


        public abstract EClass getSimpleItemFacade();


        public abstract EClass getHelper();


        public abstract EAttribute getHelper_InternalId();


        public abstract EClass getHelperFacade();


        public abstract EClass getServerDescription();


        public abstract EAttribute getServerDescription_UserServer();


        public abstract EReference getServerDescription_AuthenticatedContributor();


        public abstract EReference getServerDescription_RepositoryRoot();


        public abstract EReference getServerDescription_PackageDescriptions();


        public abstract EAttribute getServerDescription_PublicUriRoot();


        public abstract EReference getServerDescription_ServerState();


        public abstract EClass getFetchResult();


        public abstract EReference getFetchResult_NotFoundItems();


        public abstract EReference getFetchResult_RetrievedItems();


        public abstract EReference getFetchResult_PermissionDeniedItems();


        public abstract EClass getFetchResultFacade();


        public abstract EClass getQuery();


        public abstract EAttribute getQuery_QueryString();


        public abstract EAttribute getQuery_InternalParmTypes();


        public abstract EClass getQueryPage();


        public abstract EAttribute getQueryPage_Size();


        public abstract EAttribute getQueryPage_ResultSize();


        public abstract EAttribute getQueryPage_StartPosition();


        public abstract EAttribute getQueryPage_Token();


        public abstract EClass getQueryPageFacade();


        public abstract EClass getItemQueryPage();


        public abstract EReference getItemQueryPage_ItemHandles();


        public abstract EClass getItemQueryPageFacade();


        public abstract EClass getDataQueryPage();


        public abstract EReference getDataQueryPage_DataFields();


        public abstract EAttribute getDataQueryPage_RawData();


        public abstract EClass getDataQueryPageFacade();


        public abstract EClass getDataField();


        public abstract EAttribute getDataField_Name();


        public abstract EAttribute getDataField_FieldType();


        public abstract EClass getDataFieldFacade();


        public abstract EClass getItemQuery();


        public abstract EReference getItemQuery_ReturnType();


        public abstract EClass getDataQuery();


        public abstract EAttribute getDataQuery_ReturnTypes();


        public abstract EClass getType();


        public abstract EAttribute getType_NamespaceURI();


        public abstract EAttribute getType_Name();


        public abstract EAttribute getType_Abstract();


        public abstract EClass getTypeFacade();


        public abstract EClass getHelperType();


        public abstract EClass getHelperTypeFacade();


        public abstract EClass getIntExtensionEntry();


        public abstract EAttribute getIntExtensionEntry_Key();


        public abstract EAttribute getIntExtensionEntry_Value();


        public abstract EClass getStringExtensionEntry();


        public abstract EAttribute getStringExtensionEntry_Key();


        public abstract EAttribute getStringExtensionEntry_Value();


        public abstract EClass getBooleanExtensionEntry();


        public abstract EAttribute getBooleanExtensionEntry_Key();


        public abstract EAttribute getBooleanExtensionEntry_Value();


        public abstract EClass getTimestampExtensionEntry();


        public abstract EAttribute getTimestampExtensionEntry_Key();


        public abstract EAttribute getTimestampExtensionEntry_Value();


        public abstract EClass getLongExtensionEntry();


        public abstract EAttribute getLongExtensionEntry_Key();


        public abstract EAttribute getLongExtensionEntry_Value();


        public abstract EClass getLargeStringExtensionEntry();


        public abstract EAttribute getLargeStringExtensionEntry_Key();


        public abstract EAttribute getLargeStringExtensionEntry_Value();


        public abstract EClass getMediumStringExtensionEntry();


        public abstract EAttribute getMediumStringExtensionEntry_Key();


        public abstract EAttribute getMediumStringExtensionEntry_Value();


        public abstract EClass getLicenseType();


        public abstract EAttribute getLicenseType_Used();


        public abstract EAttribute getLicenseType_Id();


        public abstract EReference getLicenseType_Purchases();


        public abstract EClass getLicenseTypeHandle();


        public abstract EClass getLicenseAssignment();


        public abstract EReference getLicenseAssignment_Contributor();


        public abstract EReference getLicenseAssignment_License();


        public abstract EClass getLicenseAssignmentHandle();


        public abstract EClass getLicenseTypeDTO();


        public abstract EAttribute getLicenseTypeDTO_DisabledReason();


        public abstract EAttribute getLicenseTypeDTO_Id();


        public abstract EAttribute getLicenseTypeDTO_Description();


        public abstract EAttribute getLicenseTypeDTO_ProductName();


        public abstract EAttribute getLicenseTypeDTO_BuyURL();


        public abstract EAttribute getLicenseTypeDTO_EditionName();


        public abstract EAttribute getLicenseTypeDTO_VariantName();


        public abstract EAttribute getLicenseTypeDTO_InfoURL();


        public abstract EAttribute getLicenseTypeDTO_ExpirationTime();


        public abstract EAttribute getLicenseTypeDTO_Trial();


        public abstract EReference getLicenseTypeDTO_Notices();


        public abstract EAttribute getLicenseTypeDTO_HasAgreement();


        public abstract EClass getContributorLicenseTypeDTO();


        public abstract EAttribute getContributorLicenseTypeDTO_Max();


        public abstract EAttribute getContributorLicenseTypeDTO_Used();


        public abstract EAttribute getContributorLicenseTypeDTO_Total();


        public abstract EAttribute getContributorLicenseTypeDTO_Free();


        public abstract EAttribute getContributorLicenseTypeDTO_Name();


        public abstract EAttribute getContributorLicenseTypeDTO_CountedInServerLimit();


        public abstract EAttribute getContributorLicenseTypeDTO_Functional();


        public abstract EAttribute getContributorLicenseTypeDTO_Floating();


        public abstract EAttribute getContributorLicenseTypeDTO_Version();


        public abstract EAttribute getContributorLicenseTypeDTO_HasUnactivatedTrial();


        public abstract EAttribute getContributorLicenseTypeDTO_UnactivatedTrialExpirationTime();


        public abstract EReference getContributorLicenseTypeDTO_Keys();


        public abstract EAttribute getContributorLicenseTypeDTO_PurchaseCountLocked();


        public abstract EAttribute getContributorLicenseTypeDTO_ActivationNotificationURL();


        public abstract EAttribute getContributorLicenseTypeDTO_ActivationNotificationMessage();


        public abstract EClass getContributorLicenseTypeDTOFacade();


        public abstract EClass getServerLicenseTypeDTO();


        public abstract EAttribute getServerLicenseTypeDTO_MaxContributors();


        public abstract EAttribute getServerLicenseTypeDTO_UsedContributors();


        public abstract EClass getServerLicenseTypeDTOFacade();


        public abstract EClass getLicensesInfoDTO();


        public abstract EReference getLicensesInfoDTO_ServerLicense();


        public abstract EReference getLicensesInfoDTO_Types();


        public abstract EClass getLicensesInfoDTOFacade();


        public abstract EClass getLicensePurchase();


        public abstract EAttribute getLicensePurchase_Purchased();


        public abstract EAttribute getLicensePurchase_Id();


        public abstract EClass getLicensesInfo2DTO();


        public abstract EReference getLicensesInfo2DTO_FloatingSetupStatus();


        public abstract EReference getLicensesInfo2DTO_FloatingLicenseTypes();


        public abstract EReference getLicensesInfo2DTO_OperationCheckResults();


        public abstract EClass getLicensesInfo2DTOFacade();


        public abstract EClass getLicenseLeaseDTO();


        public abstract EAttribute getLicenseLeaseDTO_UserId();


        public abstract EAttribute getLicenseLeaseDTO_ContributorUUID();


        public abstract EAttribute getLicenseLeaseDTO_EndDate();


        public abstract EAttribute getLicenseLeaseDTO_UserName();


        public abstract EAttribute getLicenseLeaseDTO_LicenseId();


        public abstract EAttribute getLicenseLeaseDTO_LicenseName();


        public abstract EAttribute getLicenseLeaseDTO_Id();


        public abstract EAttribute getLicenseLeaseDTO_Counted();


        public abstract EClass getUsedLicenseInfoDTO();


        public abstract EAttribute getUsedLicenseInfoDTO_TotalUsedCount();


        public abstract EReference getUsedLicenseInfoDTO_ActiveLeases();


        public abstract EAttribute getUsedLicenseInfoDTO_CountedActiveLeases();


        public abstract EClass getLicenseOperationCheckDTO();


        public abstract EAttribute getLicenseOperationCheckDTO_OperationId();


        public abstract EAttribute getLicenseOperationCheckDTO_Allowed();


        public abstract EClass getFloatingSetupStatusDTO();


        public abstract EAttribute getFloatingSetupStatusDTO_ServerURL();


        public abstract EAttribute getFloatingSetupStatusDTO_ConnectionError();


        public abstract EAttribute getFloatingSetupStatusDTO_Client();


        public abstract EAttribute getFloatingSetupStatusDTO_Server();


        public abstract EClass getOAuthServiceProviderInfo();


        public abstract EAttribute getOAuthServiceProviderInfo_Realm();


        public abstract EAttribute getOAuthServiceProviderInfo_AccessTokenURL();


        public abstract EAttribute getOAuthServiceProviderInfo_RequestTokenURL();


        public abstract EAttribute getOAuthServiceProviderInfo_ConsumerKey();


        public abstract EAttribute getOAuthServiceProviderInfo_ConsumerSecret();


        public abstract EAttribute getOAuthServiceProviderInfo_AuthorizeUserURL();


        public abstract EClass getOAuthConsumerRegistration();


        public abstract EAttribute getOAuthConsumerRegistration_Key();


        public abstract EAttribute getOAuthConsumerRegistration_SecretType();


        public abstract EReference getOAuthConsumerRegistration_Secret();


        public abstract EAttribute getOAuthConsumerRegistration_Trusted();


        public abstract EClass getOAuthConsumerRegistrationHandle();


        public abstract EClass getLicenseKey();


        public abstract EAttribute getLicenseKey_Id();


        public abstract EReference getLicenseKey_Content();


        public abstract EAttribute getLicenseKey_Type();


        public abstract EClass getLicenseKeyHandle();


        public abstract EClass getFloatingLicenseLease();


        public abstract EAttribute getFloatingLicenseLease_Server();


        public abstract EAttribute getFloatingLicenseLease_RepoRootId();


        public abstract EReference getFloatingLicenseLease_Policy();


        public abstract EAttribute getFloatingLicenseLease_ExpirationDate();


        public abstract EAttribute getFloatingLicenseLease_OperationId();


        public abstract EAttribute getFloatingLicenseLease_UserId();


        public abstract EAttribute getFloatingLicenseLease_StartDate();


        public abstract EReference getFloatingLicenseLease_ExternalCheckout();


        public abstract EReference getFloatingLicenseLease_Tokens();


        public abstract EAttribute getFloatingLicenseLease_Application();


        public abstract EClass getFloatingLicenseLeaseHandle();


        public abstract EClass getExternalLicenseCheckout();


        public abstract EAttribute getExternalLicenseCheckout_Provider();


        public abstract EAttribute getExternalLicenseCheckout_Data();


        public abstract EAttribute getExternalLicenseCheckout_ExpirationDate();


        public abstract EClass getFloatingLicensePolicy();


        public abstract EAttribute getFloatingLicensePolicy_PolicyId();


        public abstract EAttribute getFloatingLicensePolicy_ActiveLeases();


        public abstract EClass getFloatingLicensePolicyHandle();


        public abstract EClass getContributorRecord();


        public abstract EAttribute getContributorRecord_EmailAddress();


        public abstract EReference getContributorRecord_Details();


        public abstract EAttribute getContributorRecord_Archived();


        public abstract EAttribute getContributorRecord_Name();


        public abstract EReference getContributorRecord_UserIds();


        public abstract EReference getContributorRecord_Identities();


        public abstract EClass getContributorRecordHandle();


        public abstract EClass getContributorRecordHandleFacade();


        public abstract EClass getContributorRecordFacade();


        public abstract EClass getContributorUserId();


        public abstract EAttribute getContributorUserId_UserId();


        public abstract EClass getContributorUserIdFacade();


        public abstract EClass getContributorIdentity();


        public abstract EAttribute getContributorIdentity_Id();


        public abstract EAttribute getContributorIdentity_StateId();


        public abstract EClass getContributorIdentityFacade();


        public abstract EClass getLicenseNoticeDTO();


        public abstract EAttribute getLicenseNoticeDTO_Name();


        public abstract EAttribute getLicenseNoticeDTO_Text();


        public abstract EClass getContributorGroup();


        public abstract EReference getContributorGroup_InternalContributors();


        public abstract EAttribute getContributorGroup_InternalName();


        public abstract EAttribute getContributorGroup_InternalSummary();


        public abstract EAttribute getContributorGroup_InternalDescription();


        public abstract EClass getContributorGroupHandle();


        public abstract EClass getContributorGroupHandleFacade();


        public abstract EClass getContributorGroupFacade();


        public abstract EClass getServerVersionCheckExceptionDTO();


        public abstract EAttribute getServerVersionCheckExceptionDTO_Uri();


        public abstract EAttribute getServerVersionCheckExceptionDTO_ServerVersion();


        public abstract EAttribute getServerVersionCheckExceptionDTO_ClientVersion();


        public abstract EClass getStringDTO();


        public abstract EAttribute getStringDTO_String();


        public abstract EClass getJPIMapping();


        public abstract EAttribute getJPIMapping_Url();


        public abstract EAttribute getJPIMapping_Jpi();


        public abstract EAttribute getJPIMapping_MappingEventId();


        public abstract EClass getJPIMappingHandle();


        public abstract EClass getDBTableSizeDTO();


        public abstract EAttribute getDBTableSizeDTO_Component();


        public abstract EAttribute getDBTableSizeDTO_TypeName();


        public abstract EAttribute getDBTableSizeDTO_ItemCount();


        public abstract EAttribute getDBTableSizeDTO_StateCount();


        public abstract EAttribute getDBTableSizeDTO_ContentSize();


        public abstract EClass getMappingEvent();


        public abstract EAttribute getMappingEvent_EventId();


        public abstract EReference getMappingEvent_URLChanges();


        public abstract EAttribute getMappingEvent_AppRenameStatus();


        public abstract EClass getMappingEventHandle();


        public abstract EClass getURLChangeEvent();


        public abstract EAttribute getURLChangeEvent_OldURL();


        public abstract EAttribute getURLChangeEvent_NewURL();


        public abstract EAttribute getURLChangeEvent_Derived();


        public abstract EClass getServerStateDTO();


        public abstract EAttribute getServerStateDTO_ServerStateId();


        public abstract EAttribute getServerStateDTO_LastStateChangeMessage();


        public abstract EClass getTokenCheckout();


        public abstract EAttribute getTokenCheckout_Count();


        public abstract EClass getNodeDiagnosticTestResultDTO();


        public abstract EAttribute getNodeDiagnosticTestResultDTO_Error();


        public abstract EAttribute getNodeDiagnosticTestResultDTO_Warning();


        public abstract EAttribute getNodeDiagnosticTestResultDTO_ExecutionTime();


        public abstract EAttribute getNodeDiagnosticTestResultDTO_ExecutionDuration();


        public abstract EAttribute getNodeDiagnosticTestResultDTO_Status();


        public abstract EAttribute getNodeDiagnosticTestResultDTO_NodeID();


        public abstract EClass getDiagnosticTestResultDTO();


        public abstract EAttribute getDiagnosticTestResultDTO_Id();


        public abstract EAttribute getDiagnosticTestResultDTO_Title();


        public abstract EAttribute getDiagnosticTestResultDTO_Description();


        public abstract EAttribute getDiagnosticTestResultDTO_Error();


        public abstract EAttribute getDiagnosticTestResultDTO_Warning();


        public abstract EAttribute getDiagnosticTestResultDTO_ExecutionTime();


        public abstract EAttribute getDiagnosticTestResultDTO_ExecutionDuration();


        public abstract EAttribute getDiagnosticTestResultDTO_Status();


        public abstract EAttribute getDiagnosticTestResultDTO_CurrentProgress();


        public abstract EAttribute getDiagnosticTestResultDTO_Disabled();


        public abstract EReference getDiagnosticTestResultDTO_NodesResults();


        public abstract EAttribute getDiagnosticTestResultDTO_NodeScopedTest();


        public abstract EAttribute getDiagnosticTestResultDTO_InvocationPeriod();


        public abstract EAttribute getDiagnosticTestResultDTO_NextInvocation();


        public abstract EClass getLicenseAssignmentResultDTO();


        public abstract EAttribute getLicenseAssignmentResultDTO_Message();


        public abstract EAttribute getLicenseAssignmentResultDTO_Status();


        public abstract EClass getLicenseAssignmentResultDTOFacade();


        public abstract EEnum getReconcileKind();


        public abstract EEnum getRepositoryMode();


        public abstract EEnum getOAuthSecretType();


        public abstract EEnum getAppRenameStatus();


        public abstract EDataType getTimestamp();


        public abstract EDataType getUUID();


        public abstract EDataType getObject();


        public abstract RepositoryFactory getRepositoryFactory();

    }
}
/* Location:           C:\RTC40Dev\installs\PlainJavaAPI\com.ibm.team.repository.common_1.3.3000.v20131022_0156.jar
 * Qualified Name:     com.ibm.team.repository.common.model.RepositoryPackage
 * Java Class Version: 6 (50.0)
 * JD-Core Version:    0.7.1
 */
