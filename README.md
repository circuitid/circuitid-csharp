# Com.CircuitID - the C# library for the Circuit ID REST API

# Introduction
Circuit ID&reg; is an innovative cloud communications platform that redefines your connectivity experience. Our cutting-edge AI-powered solution seamlessly integrates calling, meetings, messaging, voicemail, fax, SIP Trunking, mobile broadband, and mobile phone services, accessible wherever you and your devices go.
                
Whether you are a beginner getting started with our API or an experienced developer looking for advanced features, this documentation site will serve as your comprehensive guide. 

We are excited to have you on board and are confident that this documentation site will empower you to leverage the full potential of our REST API.  If you have any questions or require further assistance, please don't hesitate to reach out to our support team.
                
Happy coding!


- API version: 0.47.22
- SDK version: 1.0.0

    For more information, please visit [https://www.circuitid.com/](https://www.circuitid.com/)

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using Com.CircuitID.Api;
using Com.CircuitID.Client;
using Com.CircuitID.Models;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Com.CircuitID.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.CircuitID.Api;
using Com.CircuitID.Client;
using Com.CircuitID.Models;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "https://cloud9.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new AcceptedSendersApi(Configuration.Default);
            var acceptedsendersCreateOrPatch = new AcceptedsendersCreateOrPatch(); // AcceptedsendersCreateOrPatch | The JSON object that will be posted to the REST API endpoint.

            try
            {
                // Create a new object
                GetAcceptedSender200Response result = apiInstance.CreateAcceptedSender(acceptedsendersCreateOrPatch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AcceptedSendersApi.CreateAcceptedSender: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *https://cloud9.circuitid.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AcceptedSendersApi* | [**CreateAcceptedSender**](docs/AcceptedSendersApi.md#createacceptedsender) | **POST** /acceptedsenders | Create a new object
*AcceptedSendersApi* | [**FindAcceptedSenders**](docs/AcceptedSendersApi.md#findacceptedsenders) | **GET** /acceptedsenders | Find multiple objects
*AcceptedSendersApi* | [**GetAcceptedSender**](docs/AcceptedSendersApi.md#getacceptedsender) | **GET** /acceptedsenders/{id} | Get object by id
*AcceptedSendersApi* | [**PatchAcceptedSender**](docs/AcceptedSendersApi.md#patchacceptedsender) | **PATCH** /acceptedsenders/{id} | Patch object's data
*AcceptedSendersApi* | [**RemoveAcceptedSender**](docs/AcceptedSendersApi.md#removeacceptedsender) | **DELETE** /acceptedsenders/{id} | Delete object by id
*AnnouncementsApi* | [**CreateAnnouncement**](docs/AnnouncementsApi.md#createannouncement) | **POST** /announcements | Create a new object
*AnnouncementsApi* | [**FindAnnouncements**](docs/AnnouncementsApi.md#findannouncements) | **GET** /announcements | Find multiple objects
*AnnouncementsApi* | [**GetAnnouncement**](docs/AnnouncementsApi.md#getannouncement) | **GET** /announcements/{id} | Get object by id
*AnnouncementsApi* | [**PatchAnnouncement**](docs/AnnouncementsApi.md#patchannouncement) | **PATCH** /announcements/{id} | Patch object's data
*AnnouncementsApi* | [**RemoveAnnouncement**](docs/AnnouncementsApi.md#removeannouncement) | **DELETE** /announcements/{id} | Delete object by id
*AppMarketplaceApi* | [**FindAppMarketplace**](docs/AppMarketplaceApi.md#findappmarketplace) | **GET** /appmarketplace | Find multiple objects
*AuthenticationApi* | [**CreateAuthentication**](docs/AuthenticationApi.md#createauthentication) | **POST** /authentication | Create a new object
*CallQueueAgentsApi* | [**CreateCallQueueAgent**](docs/CallQueueAgentsApi.md#createcallqueueagent) | **POST** /callqueueagents | Create a new object
*CallQueueAgentsApi* | [**FindCallQueueAgents**](docs/CallQueueAgentsApi.md#findcallqueueagents) | **GET** /callqueueagents | Find multiple objects
*CallQueueAgentsApi* | [**GetCallQueueAgent**](docs/CallQueueAgentsApi.md#getcallqueueagent) | **GET** /callqueueagents/{id} | Get object by id
*CallQueueAgentsApi* | [**PatchCallQueueAgent**](docs/CallQueueAgentsApi.md#patchcallqueueagent) | **PATCH** /callqueueagents/{id} | Patch object's data
*CallQueueAgentsApi* | [**RemoveCallQueueAgent**](docs/CallQueueAgentsApi.md#removecallqueueagent) | **DELETE** /callqueueagents/{id} | Delete object by id
*CallQueuesApi* | [**CreateCallQueue**](docs/CallQueuesApi.md#createcallqueue) | **POST** /callqueues | Create a new object
*CallQueuesApi* | [**FindCallQueues**](docs/CallQueuesApi.md#findcallqueues) | **GET** /callqueues | Find multiple objects
*CallQueuesApi* | [**GetCallQueue**](docs/CallQueuesApi.md#getcallqueue) | **GET** /callqueues/{id} | Get object by id
*CallQueuesApi* | [**PatchCallQueue**](docs/CallQueuesApi.md#patchcallqueue) | **PATCH** /callqueues/{id} | Patch object's data
*CallQueuesApi* | [**RemoveCallQueue**](docs/CallQueuesApi.md#removecallqueue) | **DELETE** /callqueues/{id} | Delete object by id
*ChatRoomsApi* | [**CreateChatRoom**](docs/ChatRoomsApi.md#createchatroom) | **POST** /chatrooms | Create a new object
*ChatRoomsApi* | [**FindChatRooms**](docs/ChatRoomsApi.md#findchatrooms) | **GET** /chatrooms | Find multiple objects
*ChatRoomsApi* | [**GetChatRoom**](docs/ChatRoomsApi.md#getchatroom) | **GET** /chatrooms/{id} | Get object by id
*ChatRoomsApi* | [**PatchChatRoom**](docs/ChatRoomsApi.md#patchchatroom) | **PATCH** /chatrooms/{id} | Patch object's data
*ChatRoomsApi* | [**RemoveChatRoom**](docs/ChatRoomsApi.md#removechatroom) | **DELETE** /chatrooms/{id} | Delete object by id
*ClientsApi* | [**CreateClient**](docs/ClientsApi.md#createclient) | **POST** /clients | Create a new object
*ClientsApi* | [**FindClients**](docs/ClientsApi.md#findclients) | **GET** /clients | Find multiple objects
*ClientsApi* | [**GetClient**](docs/ClientsApi.md#getclient) | **GET** /clients/{id} | Get object by id
*ClientsApi* | [**PatchClient**](docs/ClientsApi.md#patchclient) | **PATCH** /clients/{id} | Patch object's data
*ClientsApi* | [**RemoveClient**](docs/ClientsApi.md#removeclient) | **DELETE** /clients/{id} | Delete object by id
*ConferenceNumbersApi* | [**FindConferenceNumbers**](docs/ConferenceNumbersApi.md#findconferencenumbers) | **GET** /conferencenumbers | Find multiple objects
*ConferenceRoomsApi* | [**CreateConferenceRoom**](docs/ConferenceRoomsApi.md#createconferenceroom) | **POST** /conferencerooms | Create a new object
*ConferenceRoomsApi* | [**FindConferenceRooms**](docs/ConferenceRoomsApi.md#findconferencerooms) | **GET** /conferencerooms | Find multiple objects
*ConferenceRoomsApi* | [**GetConferenceRoom**](docs/ConferenceRoomsApi.md#getconferenceroom) | **GET** /conferencerooms/{id} | Get object by id
*ConferenceRoomsApi* | [**PatchConferenceRoom**](docs/ConferenceRoomsApi.md#patchconferenceroom) | **PATCH** /conferencerooms/{id} | Patch object's data
*ConferenceRoomsApi* | [**RemoveConferenceRoom**](docs/ConferenceRoomsApi.md#removeconferenceroom) | **DELETE** /conferencerooms/{id} | Delete object by id
*ContactsApi* | [**CreateContact**](docs/ContactsApi.md#createcontact) | **POST** /contacts | Create a new object
*ContactsApi* | [**FindContacts**](docs/ContactsApi.md#findcontacts) | **GET** /contacts | Find multiple objects
*ContactsApi* | [**GetContact**](docs/ContactsApi.md#getcontact) | **GET** /contacts/{id} | Get object by id
*ContactsApi* | [**PatchContact**](docs/ContactsApi.md#patchcontact) | **PATCH** /contacts/{id} | Patch object's data
*ContactsApi* | [**RemoveContact**](docs/ContactsApi.md#removecontact) | **DELETE** /contacts/{id} | Delete object by id
*ConversationMessagesApi* | [**CreateConversationMessage**](docs/ConversationMessagesApi.md#createconversationmessage) | **POST** /conversationmessages | Create a new object
*ConversationMessagesApi* | [**FindConversationMessages**](docs/ConversationMessagesApi.md#findconversationmessages) | **GET** /conversationmessages | Find multiple objects
*ConversationMessagesApi* | [**GetConversationMessage**](docs/ConversationMessagesApi.md#getconversationmessage) | **GET** /conversationmessages/{id} | Get object by id
*ConversationMessagesApi* | [**PatchConversationMessage**](docs/ConversationMessagesApi.md#patchconversationmessage) | **PATCH** /conversationmessages/{id} | Patch object's data
*ConversationMessagesApi* | [**RemoveConversationMessage**](docs/ConversationMessagesApi.md#removeconversationmessage) | **DELETE** /conversationmessages/{id} | Delete object by id
*ConversationsApi* | [**CreateConversation**](docs/ConversationsApi.md#createconversation) | **POST** /conversations | Create a new object
*ConversationsApi* | [**FindConversations**](docs/ConversationsApi.md#findconversations) | **GET** /conversations | Find multiple objects
*ConversationsApi* | [**GetConversation**](docs/ConversationsApi.md#getconversation) | **GET** /conversations/{id} | Get object by id
*ConversationsApi* | [**PatchConversation**](docs/ConversationsApi.md#patchconversation) | **PATCH** /conversations/{id} | Patch object's data
*ConversationsApi* | [**RemoveConversation**](docs/ConversationsApi.md#removeconversation) | **DELETE** /conversations/{id} | Delete object by id
*CustomersApi* | [**CreateCustomer**](docs/CustomersApi.md#createcustomer) | **POST** /customers | Create a new object
*CustomersApi* | [**FindCustomers**](docs/CustomersApi.md#findcustomers) | **GET** /customers | Find multiple objects
*CustomersApi* | [**GetCustomer**](docs/CustomersApi.md#getcustomer) | **GET** /customers/{id} | Get object by id
*CustomersApi* | [**PatchCustomer**](docs/CustomersApi.md#patchcustomer) | **PATCH** /customers/{id} | Patch object's data
*CustomersApi* | [**RemoveCustomer**](docs/CustomersApi.md#removecustomer) | **DELETE** /customers/{id} | Delete object by id
*DNSRecordsApi* | [**FindDNSRecords**](docs/DNSRecordsApi.md#finddnsrecords) | **GET** /dnsrecords | Find multiple objects
*DeveloperAppSubscriptionsApi* | [**CreateDeveloperAppSubscription**](docs/DeveloperAppSubscriptionsApi.md#createdeveloperappsubscription) | **POST** /developerappsubscriptions | Create a new object
*DeveloperAppSubscriptionsApi* | [**FindDeveloperAppSubscriptions**](docs/DeveloperAppSubscriptionsApi.md#finddeveloperappsubscriptions) | **GET** /developerappsubscriptions | Find multiple objects
*DeveloperAppSubscriptionsApi* | [**GetDeveloperAppSubscription**](docs/DeveloperAppSubscriptionsApi.md#getdeveloperappsubscription) | **GET** /developerappsubscriptions/{id} | Get object by id
*DeveloperAppSubscriptionsApi* | [**PatchDeveloperAppSubscription**](docs/DeveloperAppSubscriptionsApi.md#patchdeveloperappsubscription) | **PATCH** /developerappsubscriptions/{id} | Patch object's data
*DeveloperAppSubscriptionsApi* | [**RemoveDeveloperAppSubscription**](docs/DeveloperAppSubscriptionsApi.md#removedeveloperappsubscription) | **DELETE** /developerappsubscriptions/{id} | Delete object by id
*DeveloperAppsApi* | [**CreateDeveloperApp**](docs/DeveloperAppsApi.md#createdeveloperapp) | **POST** /developerapps | Create a new object
*DeveloperAppsApi* | [**FindDeveloperApps**](docs/DeveloperAppsApi.md#finddeveloperapps) | **GET** /developerapps | Find multiple objects
*DeveloperAppsApi* | [**GetDeveloperApp**](docs/DeveloperAppsApi.md#getdeveloperapp) | **GET** /developerapps/{id} | Get object by id
*DeveloperAppsApi* | [**PatchDeveloperApp**](docs/DeveloperAppsApi.md#patchdeveloperapp) | **PATCH** /developerapps/{id} | Patch object's data
*DeveloperAppsApi* | [**RemoveDeveloperApp**](docs/DeveloperAppsApi.md#removedeveloperapp) | **DELETE** /developerapps/{id} | Delete object by id
*DirectoriesApi* | [**Createdirectory**](docs/DirectoriesApi.md#createdirectory) | **POST** /directories | Create a new object
*DirectoriesApi* | [**FindDirectories**](docs/DirectoriesApi.md#finddirectories) | **GET** /directories | Find multiple objects
*DirectoriesApi* | [**Getdirectory**](docs/DirectoriesApi.md#getdirectory) | **GET** /directories/{id} | Get object by id
*DirectoriesApi* | [**Patchdirectory**](docs/DirectoriesApi.md#patchdirectory) | **PATCH** /directories/{id} | Patch object's data
*DirectoriesApi* | [**Removedirectory**](docs/DirectoriesApi.md#removedirectory) | **DELETE** /directories/{id} | Delete object by id
*DomainsApi* | [**CreateDomain**](docs/DomainsApi.md#createdomain) | **POST** /domains | Create a new object
*DomainsApi* | [**FindDomains**](docs/DomainsApi.md#finddomains) | **GET** /domains | Find multiple objects
*DomainsApi* | [**GetDomain**](docs/DomainsApi.md#getdomain) | **GET** /domains/{id} | Get object by id
*DomainsApi* | [**PatchDomain**](docs/DomainsApi.md#patchdomain) | **PATCH** /domains/{id} | Patch object's data
*DomainsApi* | [**RemoveDomain**](docs/DomainsApi.md#removedomain) | **DELETE** /domains/{id} | Delete object by id
*FaxAccountsApi* | [**CreateFaxAccount**](docs/FaxAccountsApi.md#createfaxaccount) | **POST** /faxaccounts | Create a new object
*FaxAccountsApi* | [**FindFaxAccounts**](docs/FaxAccountsApi.md#findfaxaccounts) | **GET** /faxaccounts | Find multiple objects
*FaxAccountsApi* | [**GetFaxAccount**](docs/FaxAccountsApi.md#getfaxaccount) | **GET** /faxaccounts/{id} | Get object by id
*FaxAccountsApi* | [**PatchFaxAccount**](docs/FaxAccountsApi.md#patchfaxaccount) | **PATCH** /faxaccounts/{id} | Patch object's data
*FaxAccountsApi* | [**RemoveFaxAccount**](docs/FaxAccountsApi.md#removefaxaccount) | **DELETE** /faxaccounts/{id} | Delete object by id
*FaxesApi* | [**CreateFax**](docs/FaxesApi.md#createfax) | **POST** /faxes | Create a new object
*FaxesApi* | [**FindFaxes**](docs/FaxesApi.md#findfaxes) | **GET** /faxes | Find multiple objects
*FaxesApi* | [**GetFax**](docs/FaxesApi.md#getfax) | **GET** /faxes/{id} | Get object by id
*FaxesApi* | [**RemoveFax**](docs/FaxesApi.md#removefax) | **DELETE** /faxes/{id} | Delete object by id
*FindNumbersApi* | [**FindFindNumbers**](docs/FindNumbersApi.md#findfindnumbers) | **GET** /findnumbers | Find multiple objects
*FirewallApi* | [**CreateFirewall**](docs/FirewallApi.md#createfirewall) | **POST** /firewall | Create a new object
*FirewallApi* | [**FindFirewall**](docs/FirewallApi.md#findfirewall) | **GET** /firewall | Find multiple objects
*FirewallApi* | [**GetFirewall**](docs/FirewallApi.md#getfirewall) | **GET** /firewall/{id} | Get object by id
*FirewallApi* | [**PatchFirewall**](docs/FirewallApi.md#patchfirewall) | **PATCH** /firewall/{id} | Patch object's data
*FirewallApi* | [**RemoveFirewall**](docs/FirewallApi.md#removefirewall) | **DELETE** /firewall/{id} | Delete object by id
*GroupMembersApi* | [**CreateGroupMember**](docs/GroupMembersApi.md#creategroupmember) | **POST** /groupmembers | Create a new object
*GroupMembersApi* | [**FindGroupMembers**](docs/GroupMembersApi.md#findgroupmembers) | **GET** /groupmembers | Find multiple objects
*GroupMembersApi* | [**GetGroupMember**](docs/GroupMembersApi.md#getgroupmember) | **GET** /groupmembers/{id} | Get object by id
*GroupMembersApi* | [**PatchGroupMember**](docs/GroupMembersApi.md#patchgroupmember) | **PATCH** /groupmembers/{id} | Patch object's data
*GroupMembersApi* | [**RemoveGroupMember**](docs/GroupMembersApi.md#removegroupmember) | **DELETE** /groupmembers/{id} | Delete object by id
*GroupsApi* | [**CreateGroup**](docs/GroupsApi.md#creategroup) | **POST** /groups | Create a new object
*GroupsApi* | [**FindGroups**](docs/GroupsApi.md#findgroups) | **GET** /groups | Find multiple objects
*GroupsApi* | [**GetGroup**](docs/GroupsApi.md#getgroup) | **GET** /groups/{id} | Get object by id
*GroupsApi* | [**PatchGroup**](docs/GroupsApi.md#patchgroup) | **PATCH** /groups/{id} | Patch object's data
*GroupsApi* | [**RemoveGroup**](docs/GroupsApi.md#removegroup) | **DELETE** /groups/{id} | Delete object by id
*HolidaysApi* | [**CreateHoliday**](docs/HolidaysApi.md#createholiday) | **POST** /holidays | Create a new object
*HolidaysApi* | [**FindHolidays**](docs/HolidaysApi.md#findholidays) | **GET** /holidays | Find multiple objects
*HolidaysApi* | [**GetHoliday**](docs/HolidaysApi.md#getholiday) | **GET** /holidays/{id} | Get object by id
*HolidaysApi* | [**PatchHoliday**](docs/HolidaysApi.md#patchholiday) | **PATCH** /holidays/{id} | Patch object's data
*HolidaysApi* | [**RemoveHoliday**](docs/HolidaysApi.md#removeholiday) | **DELETE** /holidays/{id} | Delete object by id
*InfoApi* | [**GetInfo**](docs/InfoApi.md#getinfo) | **GET** /info | Get object
*InvoiceItemsApi* | [**FindInvoiceItems**](docs/InvoiceItemsApi.md#findinvoiceitems) | **GET** /invoiceitems | Find multiple objects
*InvoiceItemsApi* | [**GetInvoiceItem**](docs/InvoiceItemsApi.md#getinvoiceitem) | **GET** /invoiceitems/{id} | Get object by id
*InvoicesApi* | [**FindInvoices**](docs/InvoicesApi.md#findinvoices) | **GET** /invoices | Find multiple objects
*InvoicesApi* | [**GetInvoice**](docs/InvoicesApi.md#getinvoice) | **GET** /invoices/{id} | Get object by id
*LicensesApi* | [**CreateLicense**](docs/LicensesApi.md#createlicense) | **POST** /licenses | Create a new object
*LicensesApi* | [**FindLicenses**](docs/LicensesApi.md#findlicenses) | **GET** /licenses | Find multiple objects
*LicensesApi* | [**GetLicense**](docs/LicensesApi.md#getlicense) | **GET** /licenses/{id} | Get object by id
*LicensesApi* | [**PatchLicense**](docs/LicensesApi.md#patchlicense) | **PATCH** /licenses/{id} | Patch object's data
*LicensesApi* | [**RemoveLicense**](docs/LicensesApi.md#removelicense) | **DELETE** /licenses/{id} | Delete object by id
*MenuOptionsApi* | [**CreateMenuOption**](docs/MenuOptionsApi.md#createmenuoption) | **POST** /menuoptions | Create a new object
*MenuOptionsApi* | [**FindMenuOptions**](docs/MenuOptionsApi.md#findmenuoptions) | **GET** /menuoptions | Find multiple objects
*MenuOptionsApi* | [**GetMenuOption**](docs/MenuOptionsApi.md#getmenuoption) | **GET** /menuoptions/{id} | Get object by id
*MenuOptionsApi* | [**PatchMenuOption**](docs/MenuOptionsApi.md#patchmenuoption) | **PATCH** /menuoptions/{id} | Patch object's data
*MenuOptionsApi* | [**RemoveMenuOption**](docs/MenuOptionsApi.md#removemenuoption) | **DELETE** /menuoptions/{id} | Delete object by id
*MenusApi* | [**CreateMenu**](docs/MenusApi.md#createmenu) | **POST** /menus | Create a new object
*MenusApi* | [**FindMenus**](docs/MenusApi.md#findmenus) | **GET** /menus | Find multiple objects
*MenusApi* | [**GetMenu**](docs/MenusApi.md#getmenu) | **GET** /menus/{id} | Get object by id
*MenusApi* | [**PatchMenu**](docs/MenusApi.md#patchmenu) | **PATCH** /menus/{id} | Patch object's data
*MenusApi* | [**RemoveMenu**](docs/MenusApi.md#removemenu) | **DELETE** /menus/{id} | Delete object by id
*MessageBrandsApi* | [**CreateMessageBrand**](docs/MessageBrandsApi.md#createmessagebrand) | **POST** /messagebrands | Create a new object
*MessageBrandsApi* | [**FindMessageBrands**](docs/MessageBrandsApi.md#findmessagebrands) | **GET** /messagebrands | Find multiple objects
*MessageBrandsApi* | [**GetMessageBrand**](docs/MessageBrandsApi.md#getmessagebrand) | **GET** /messagebrands/{id} | Get object by id
*MessageCampaignsApi* | [**CreateMessageCampaign**](docs/MessageCampaignsApi.md#createmessagecampaign) | **POST** /messagecampaigns | Create a new object
*MessageCampaignsApi* | [**FindMessageCampaigns**](docs/MessageCampaignsApi.md#findmessagecampaigns) | **GET** /messagecampaigns | Find multiple objects
*MessageCampaignsApi* | [**GetMessageCampaign**](docs/MessageCampaignsApi.md#getmessagecampaign) | **GET** /messagecampaigns/{id} | Get object by id
*MessageCampaignsApi* | [**PatchMessageCampaign**](docs/MessageCampaignsApi.md#patchmessagecampaign) | **PATCH** /messagecampaigns/{id} | Patch object's data
*MessageCampaignsApi* | [**RemoveMessageCampaign**](docs/MessageCampaignsApi.md#removemessagecampaign) | **DELETE** /messagecampaigns/{id} | Delete object by id
*NumberPortsApi* | [**CreateNumberPort**](docs/NumberPortsApi.md#createnumberport) | **POST** /numberports | Create a new object
*NumberPortsApi* | [**FindNumberPorts**](docs/NumberPortsApi.md#findnumberports) | **GET** /numberports | Find multiple objects
*NumberPortsApi* | [**GetNumberPort**](docs/NumberPortsApi.md#getnumberport) | **GET** /numberports/{id} | Get object by id
*NumbersApi* | [**FindNumbers**](docs/NumbersApi.md#findnumbers) | **GET** /numbers | Find multiple objects
*NumbersApi* | [**GetNumber**](docs/NumbersApi.md#getnumber) | **GET** /numbers/{id} | Get object by id
*NumbersApi* | [**PatchNumber**](docs/NumbersApi.md#patchnumber) | **PATCH** /numbers/{id} | Patch object's data
*OfficesApi* | [**CreateOffice**](docs/OfficesApi.md#createoffice) | **POST** /offices | Create a new object
*OfficesApi* | [**FindOffices**](docs/OfficesApi.md#findoffices) | **GET** /offices | Find multiple objects
*OfficesApi* | [**GetOffice**](docs/OfficesApi.md#getoffice) | **GET** /offices/{id} | Get object by id
*OfficesApi* | [**PatchOffice**](docs/OfficesApi.md#patchoffice) | **PATCH** /offices/{id} | Patch object's data
*OfficesApi* | [**RemoveOffice**](docs/OfficesApi.md#removeoffice) | **DELETE** /offices/{id} | Delete object by id
*PhoneInboundRuleActionsApi* | [**CreatePhoneInboundRuleAction**](docs/PhoneInboundRuleActionsApi.md#createphoneinboundruleaction) | **POST** /phoneinboundruleactions | Create a new object
*PhoneInboundRuleActionsApi* | [**FindPhoneInboundRuleActions**](docs/PhoneInboundRuleActionsApi.md#findphoneinboundruleactions) | **GET** /phoneinboundruleactions | Find multiple objects
*PhoneInboundRuleActionsApi* | [**GetPhoneInboundRuleAction**](docs/PhoneInboundRuleActionsApi.md#getphoneinboundruleaction) | **GET** /phoneinboundruleactions/{id} | Get object by id
*PhoneInboundRuleActionsApi* | [**PatchPhoneInboundRuleAction**](docs/PhoneInboundRuleActionsApi.md#patchphoneinboundruleaction) | **PATCH** /phoneinboundruleactions/{id} | Patch object's data
*PhoneInboundRuleActionsApi* | [**RemovePhoneInboundRuleAction**](docs/PhoneInboundRuleActionsApi.md#removephoneinboundruleaction) | **DELETE** /phoneinboundruleactions/{id} | Delete object by id
*PhoneInboundRulesApi* | [**CreatePhoneInboundRule**](docs/PhoneInboundRulesApi.md#createphoneinboundrule) | **POST** /phoneinboundrules | Create a new object
*PhoneInboundRulesApi* | [**FindPhoneInboundRules**](docs/PhoneInboundRulesApi.md#findphoneinboundrules) | **GET** /phoneinboundrules | Find multiple objects
*PhoneInboundRulesApi* | [**GetPhoneInboundRule**](docs/PhoneInboundRulesApi.md#getphoneinboundrule) | **GET** /phoneinboundrules/{id} | Get object by id
*PhoneInboundRulesApi* | [**PatchPhoneInboundRule**](docs/PhoneInboundRulesApi.md#patchphoneinboundrule) | **PATCH** /phoneinboundrules/{id} | Patch object's data
*PhoneInboundRulesApi* | [**RemovePhoneInboundRule**](docs/PhoneInboundRulesApi.md#removephoneinboundrule) | **DELETE** /phoneinboundrules/{id} | Delete object by id
*PhoneOutboundRuleActionsApi* | [**CreatePhoneOutboundRuleAction**](docs/PhoneOutboundRuleActionsApi.md#createphoneoutboundruleaction) | **POST** /phoneoutboundruleactions | Create a new object
*PhoneOutboundRuleActionsApi* | [**FindPhoneOutboundRuleActions**](docs/PhoneOutboundRuleActionsApi.md#findphoneoutboundruleactions) | **GET** /phoneoutboundruleactions | Find multiple objects
*PhoneOutboundRuleActionsApi* | [**GetPhoneOutboundRuleAction**](docs/PhoneOutboundRuleActionsApi.md#getphoneoutboundruleaction) | **GET** /phoneoutboundruleactions/{id} | Get object by id
*PhoneOutboundRuleActionsApi* | [**PatchPhoneOutboundRuleAction**](docs/PhoneOutboundRuleActionsApi.md#patchphoneoutboundruleaction) | **PATCH** /phoneoutboundruleactions/{id} | Patch object's data
*PhoneOutboundRuleActionsApi* | [**RemovePhoneOutboundRuleAction**](docs/PhoneOutboundRuleActionsApi.md#removephoneoutboundruleaction) | **DELETE** /phoneoutboundruleactions/{id} | Delete object by id
*PhoneOutboundRulesApi* | [**CreatePhoneOutboundRule**](docs/PhoneOutboundRulesApi.md#createphoneoutboundrule) | **POST** /phoneoutboundrules | Create a new object
*PhoneOutboundRulesApi* | [**FindPhoneOutboundRules**](docs/PhoneOutboundRulesApi.md#findphoneoutboundrules) | **GET** /phoneoutboundrules | Find multiple objects
*PhoneOutboundRulesApi* | [**GetPhoneOutboundRule**](docs/PhoneOutboundRulesApi.md#getphoneoutboundrule) | **GET** /phoneoutboundrules/{id} | Get object by id
*PhoneOutboundRulesApi* | [**PatchPhoneOutboundRule**](docs/PhoneOutboundRulesApi.md#patchphoneoutboundrule) | **PATCH** /phoneoutboundrules/{id} | Patch object's data
*PhoneOutboundRulesApi* | [**RemovePhoneOutboundRule**](docs/PhoneOutboundRulesApi.md#removephoneoutboundrule) | **DELETE** /phoneoutboundrules/{id} | Delete object by id
*RateCentersApi* | [**FindRateCenters**](docs/RateCentersApi.md#findratecenters) | **GET** /ratecenters | Find multiple objects
*RateCentersApi* | [**GetRateCenter**](docs/RateCentersApi.md#getratecenter) | **GET** /ratecenters/{id} | Get object by id
*ServersApi* | [**CreateServer**](docs/ServersApi.md#createserver) | **POST** /servers | Create a new object
*ServersApi* | [**FindServers**](docs/ServersApi.md#findservers) | **GET** /servers | Find multiple objects
*ServersApi* | [**GetServer**](docs/ServersApi.md#getserver) | **GET** /servers/{id} | Get object by id
*ServersApi* | [**PatchServer**](docs/ServersApi.md#patchserver) | **PATCH** /servers/{id} | Patch object's data
*ServersApi* | [**RemoveServer**](docs/ServersApi.md#removeserver) | **DELETE** /servers/{id} | Delete object by id
*TimeSchedulesApi* | [**CreateTimeSchedule**](docs/TimeSchedulesApi.md#createtimeschedule) | **POST** /timeschedules | Create a new object
*TimeSchedulesApi* | [**FindTimeSchedules**](docs/TimeSchedulesApi.md#findtimeschedules) | **GET** /timeschedules | Find multiple objects
*TimeSchedulesApi* | [**GetTimeSchedule**](docs/TimeSchedulesApi.md#gettimeschedule) | **GET** /timeschedules/{id} | Get object by id
*TimeSchedulesApi* | [**PatchTimeSchedule**](docs/TimeSchedulesApi.md#patchtimeschedule) | **PATCH** /timeschedules/{id} | Patch object's data
*TimeSchedulesApi* | [**RemoveTimeSchedule**](docs/TimeSchedulesApi.md#removetimeschedule) | **DELETE** /timeschedules/{id} | Delete object by id
*UserTokensApi* | [**CreateUserToken**](docs/UserTokensApi.md#createusertoken) | **POST** /usertokens | Create a new object
*UserTokensApi* | [**FindUserTokens**](docs/UserTokensApi.md#findusertokens) | **GET** /usertokens | Find multiple objects
*UserTokensApi* | [**GetUserToken**](docs/UserTokensApi.md#getusertoken) | **GET** /usertokens/{id} | Get object by id
*UserTokensApi* | [**PatchUserToken**](docs/UserTokensApi.md#patchusertoken) | **PATCH** /usertokens/{id} | Patch object's data
*UserTokensApi* | [**RemoveUserToken**](docs/UserTokensApi.md#removeusertoken) | **DELETE** /usertokens/{id} | Delete object by id
*UsersApi* | [**CreateUser**](docs/UsersApi.md#createuser) | **POST** /users | Create a new object
*UsersApi* | [**FindUsers**](docs/UsersApi.md#findusers) | **GET** /users | Find multiple objects
*UsersApi* | [**GetUser**](docs/UsersApi.md#getuser) | **GET** /users/{id} | Get object by id
*UsersApi* | [**PatchUser**](docs/UsersApi.md#patchuser) | **PATCH** /users/{id} | Patch object's data
*UsersApi* | [**RemoveUser**](docs/UsersApi.md#removeuser) | **DELETE** /users/{id} | Delete object by id
*VirtualExtensionsApi* | [**CreateVirtualExtension**](docs/VirtualExtensionsApi.md#createvirtualextension) | **POST** /virtualextensions | Create a new object
*VirtualExtensionsApi* | [**FindVirtualExtensions**](docs/VirtualExtensionsApi.md#findvirtualextensions) | **GET** /virtualextensions | Find multiple objects
*VirtualExtensionsApi* | [**GetVirtualExtension**](docs/VirtualExtensionsApi.md#getvirtualextension) | **GET** /virtualextensions/{id} | Get object by id
*VirtualExtensionsApi* | [**PatchVirtualExtension**](docs/VirtualExtensionsApi.md#patchvirtualextension) | **PATCH** /virtualextensions/{id} | Patch object's data
*VirtualExtensionsApi* | [**RemoveVirtualExtension**](docs/VirtualExtensionsApi.md#removevirtualextension) | **DELETE** /virtualextensions/{id} | Delete object by id
*VoicemailApi* | [**FindVoicemail**](docs/VoicemailApi.md#findvoicemail) | **GET** /voicemail | Find multiple objects
*VoicemailApi* | [**GetVoicemail**](docs/VoicemailApi.md#getvoicemail) | **GET** /voicemail/{id} | Get object by id


## Documentation for Models

 - [Models.Acceptedsenders](docs/Acceptedsenders.md)
 - [Models.AcceptedsendersCreateOrPatch](docs/AcceptedsendersCreateOrPatch.md)
 - [Models.Announcements](docs/Announcements.md)
 - [Models.AnnouncementsCreateOrPatch](docs/AnnouncementsCreateOrPatch.md)
 - [Models.Authentication](docs/Authentication.md)
 - [Models.AuthenticationCreateOrPatch](docs/AuthenticationCreateOrPatch.md)
 - [Models.Callqueueagents](docs/Callqueueagents.md)
 - [Models.CallqueueagentsCreateOrPatch](docs/CallqueueagentsCreateOrPatch.md)
 - [Models.Callqueues](docs/Callqueues.md)
 - [Models.CallqueuesCreateOrPatch](docs/CallqueuesCreateOrPatch.md)
 - [Models.Chatrooms](docs/Chatrooms.md)
 - [Models.ChatroomsCreateOrPatch](docs/ChatroomsCreateOrPatch.md)
 - [Models.Clients](docs/Clients.md)
 - [Models.ClientsCreateOrPatch](docs/ClientsCreateOrPatch.md)
 - [Models.Conferencerooms](docs/Conferencerooms.md)
 - [Models.ConferenceroomsCreateOrPatch](docs/ConferenceroomsCreateOrPatch.md)
 - [Models.Contacts](docs/Contacts.md)
 - [Models.ContactsCreateOrPatch](docs/ContactsCreateOrPatch.md)
 - [Models.Conversationmessages](docs/Conversationmessages.md)
 - [Models.ConversationmessagesCreateOrPatch](docs/ConversationmessagesCreateOrPatch.md)
 - [Models.Conversations](docs/Conversations.md)
 - [Models.ConversationsCreateOrPatch](docs/ConversationsCreateOrPatch.md)
 - [Models.CreateAuthentication200Response](docs/CreateAuthentication200Response.md)
 - [Models.Customers](docs/Customers.md)
 - [Models.CustomersCreateOrPatch](docs/CustomersCreateOrPatch.md)
 - [Models.Developerapps](docs/Developerapps.md)
 - [Models.DeveloperappsCreateOrPatch](docs/DeveloperappsCreateOrPatch.md)
 - [Models.Developerappsubscriptions](docs/Developerappsubscriptions.md)
 - [Models.DeveloperappsubscriptionsCreateOrPatch](docs/DeveloperappsubscriptionsCreateOrPatch.md)
 - [Models.Directories](docs/Directories.md)
 - [Models.DirectoriesCreateOrPatch](docs/DirectoriesCreateOrPatch.md)
 - [Models.Domains](docs/Domains.md)
 - [Models.DomainsCreateOrPatch](docs/DomainsCreateOrPatch.md)
 - [Models.Faxaccounts](docs/Faxaccounts.md)
 - [Models.FaxaccountsCreateOrPatch](docs/FaxaccountsCreateOrPatch.md)
 - [Models.Faxes](docs/Faxes.md)
 - [Models.FaxesCreateOrPatch](docs/FaxesCreateOrPatch.md)
 - [Models.Find](docs/Find.md)
 - [Models.FindAcceptedSenders200Response](docs/FindAcceptedSenders200Response.md)
 - [Models.FindAnnouncements200Response](docs/FindAnnouncements200Response.md)
 - [Models.FindAppMarketplace200Response](docs/FindAppMarketplace200Response.md)
 - [Models.FindCallQueueAgents200Response](docs/FindCallQueueAgents200Response.md)
 - [Models.FindCallQueues200Response](docs/FindCallQueues200Response.md)
 - [Models.FindChatRooms200Response](docs/FindChatRooms200Response.md)
 - [Models.FindClients200Response](docs/FindClients200Response.md)
 - [Models.FindConferenceRooms200Response](docs/FindConferenceRooms200Response.md)
 - [Models.FindContacts200Response](docs/FindContacts200Response.md)
 - [Models.FindConversationMessages200Response](docs/FindConversationMessages200Response.md)
 - [Models.FindConversations200Response](docs/FindConversations200Response.md)
 - [Models.FindCustomers200Response](docs/FindCustomers200Response.md)
 - [Models.FindDeveloperAppSubscriptions200Response](docs/FindDeveloperAppSubscriptions200Response.md)
 - [Models.FindDeveloperApps200Response](docs/FindDeveloperApps200Response.md)
 - [Models.FindDirectories200Response](docs/FindDirectories200Response.md)
 - [Models.FindDomains200Response](docs/FindDomains200Response.md)
 - [Models.FindFaxAccounts200Response](docs/FindFaxAccounts200Response.md)
 - [Models.FindFaxes200Response](docs/FindFaxes200Response.md)
 - [Models.FindFirewall200Response](docs/FindFirewall200Response.md)
 - [Models.FindGroupMembers200Response](docs/FindGroupMembers200Response.md)
 - [Models.FindGroups200Response](docs/FindGroups200Response.md)
 - [Models.FindHolidays200Response](docs/FindHolidays200Response.md)
 - [Models.FindInvoiceItems200Response](docs/FindInvoiceItems200Response.md)
 - [Models.FindInvoices200Response](docs/FindInvoices200Response.md)
 - [Models.FindLicenses200Response](docs/FindLicenses200Response.md)
 - [Models.FindMenuOptions200Response](docs/FindMenuOptions200Response.md)
 - [Models.FindMenus200Response](docs/FindMenus200Response.md)
 - [Models.FindMessageBrands200Response](docs/FindMessageBrands200Response.md)
 - [Models.FindMessageCampaigns200Response](docs/FindMessageCampaigns200Response.md)
 - [Models.FindNumberPorts200Response](docs/FindNumberPorts200Response.md)
 - [Models.FindNumbers200Response](docs/FindNumbers200Response.md)
 - [Models.FindOffices200Response](docs/FindOffices200Response.md)
 - [Models.FindPhoneInboundRuleActions200Response](docs/FindPhoneInboundRuleActions200Response.md)
 - [Models.FindPhoneInboundRules200Response](docs/FindPhoneInboundRules200Response.md)
 - [Models.FindPhoneOutboundRuleActions200Response](docs/FindPhoneOutboundRuleActions200Response.md)
 - [Models.FindPhoneOutboundRules200Response](docs/FindPhoneOutboundRules200Response.md)
 - [Models.FindRateCenters200Response](docs/FindRateCenters200Response.md)
 - [Models.FindServers200Response](docs/FindServers200Response.md)
 - [Models.FindTimeSchedules200Response](docs/FindTimeSchedules200Response.md)
 - [Models.FindUserTokens200Response](docs/FindUserTokens200Response.md)
 - [Models.FindUsers200Response](docs/FindUsers200Response.md)
 - [Models.FindVirtualExtensions200Response](docs/FindVirtualExtensions200Response.md)
 - [Models.Firewall](docs/Firewall.md)
 - [Models.FirewallCreateOrPatch](docs/FirewallCreateOrPatch.md)
 - [Models.GetAcceptedSender200Response](docs/GetAcceptedSender200Response.md)
 - [Models.GetAnnouncement200Response](docs/GetAnnouncement200Response.md)
 - [Models.GetCallQueue200Response](docs/GetCallQueue200Response.md)
 - [Models.GetCallQueueAgent200Response](docs/GetCallQueueAgent200Response.md)
 - [Models.GetChatRoom200Response](docs/GetChatRoom200Response.md)
 - [Models.GetClient200Response](docs/GetClient200Response.md)
 - [Models.GetConferenceRoom200Response](docs/GetConferenceRoom200Response.md)
 - [Models.GetContact200Response](docs/GetContact200Response.md)
 - [Models.GetConversation200Response](docs/GetConversation200Response.md)
 - [Models.GetConversationMessage200Response](docs/GetConversationMessage200Response.md)
 - [Models.GetCustomer200Response](docs/GetCustomer200Response.md)
 - [Models.GetDeveloperApp200Response](docs/GetDeveloperApp200Response.md)
 - [Models.GetDeveloperAppSubscription200Response](docs/GetDeveloperAppSubscription200Response.md)
 - [Models.GetDomain200Response](docs/GetDomain200Response.md)
 - [Models.GetFax200Response](docs/GetFax200Response.md)
 - [Models.GetFaxAccount200Response](docs/GetFaxAccount200Response.md)
 - [Models.GetFirewall200Response](docs/GetFirewall200Response.md)
 - [Models.GetGroup200Response](docs/GetGroup200Response.md)
 - [Models.GetGroupMember200Response](docs/GetGroupMember200Response.md)
 - [Models.GetHoliday200Response](docs/GetHoliday200Response.md)
 - [Models.GetInvoice200Response](docs/GetInvoice200Response.md)
 - [Models.GetInvoiceItem200Response](docs/GetInvoiceItem200Response.md)
 - [Models.GetLicense200Response](docs/GetLicense200Response.md)
 - [Models.GetMenu200Response](docs/GetMenu200Response.md)
 - [Models.GetMenuOption200Response](docs/GetMenuOption200Response.md)
 - [Models.GetMessageBrand200Response](docs/GetMessageBrand200Response.md)
 - [Models.GetMessageCampaign200Response](docs/GetMessageCampaign200Response.md)
 - [Models.GetNumber200Response](docs/GetNumber200Response.md)
 - [Models.GetNumberPort200Response](docs/GetNumberPort200Response.md)
 - [Models.GetOffice200Response](docs/GetOffice200Response.md)
 - [Models.GetPhoneInboundRule200Response](docs/GetPhoneInboundRule200Response.md)
 - [Models.GetPhoneInboundRuleAction200Response](docs/GetPhoneInboundRuleAction200Response.md)
 - [Models.GetPhoneOutboundRule200Response](docs/GetPhoneOutboundRule200Response.md)
 - [Models.GetPhoneOutboundRuleAction200Response](docs/GetPhoneOutboundRuleAction200Response.md)
 - [Models.GetRateCenter200Response](docs/GetRateCenter200Response.md)
 - [Models.GetServer200Response](docs/GetServer200Response.md)
 - [Models.GetTimeSchedule200Response](docs/GetTimeSchedule200Response.md)
 - [Models.GetUser200Response](docs/GetUser200Response.md)
 - [Models.GetUserToken200Response](docs/GetUserToken200Response.md)
 - [Models.GetVirtualExtension200Response](docs/GetVirtualExtension200Response.md)
 - [Models.Getdirectory200Response](docs/Getdirectory200Response.md)
 - [Models.Groupmembers](docs/Groupmembers.md)
 - [Models.GroupmembersCreateOrPatch](docs/GroupmembersCreateOrPatch.md)
 - [Models.Groups](docs/Groups.md)
 - [Models.GroupsCreateOrPatch](docs/GroupsCreateOrPatch.md)
 - [Models.Holidays](docs/Holidays.md)
 - [Models.HolidaysCreateOrPatch](docs/HolidaysCreateOrPatch.md)
 - [Models.Id](docs/Id.md)
 - [Models.Invoiceitems](docs/Invoiceitems.md)
 - [Models.Invoices](docs/Invoices.md)
 - [Models.Licenses](docs/Licenses.md)
 - [Models.LicensesCreateOrPatch](docs/LicensesCreateOrPatch.md)
 - [Models.Menuoptions](docs/Menuoptions.md)
 - [Models.MenuoptionsCreateOrPatch](docs/MenuoptionsCreateOrPatch.md)
 - [Models.Menus](docs/Menus.md)
 - [Models.MenusCreateOrPatch](docs/MenusCreateOrPatch.md)
 - [Models.Messagebrands](docs/Messagebrands.md)
 - [Models.MessagebrandsCreateOrPatch](docs/MessagebrandsCreateOrPatch.md)
 - [Models.Messagecampaigns](docs/Messagecampaigns.md)
 - [Models.MessagecampaignsCreateOrPatch](docs/MessagecampaignsCreateOrPatch.md)
 - [Models.Numberports](docs/Numberports.md)
 - [Models.NumberportsCreateOrPatch](docs/NumberportsCreateOrPatch.md)
 - [Models.Numbers](docs/Numbers.md)
 - [Models.NumbersCreateOrPatch](docs/NumbersCreateOrPatch.md)
 - [Models.Offices](docs/Offices.md)
 - [Models.OfficesCreateOrPatch](docs/OfficesCreateOrPatch.md)
 - [Models.Phoneinboundruleactions](docs/Phoneinboundruleactions.md)
 - [Models.PhoneinboundruleactionsCreateOrPatch](docs/PhoneinboundruleactionsCreateOrPatch.md)
 - [Models.Phoneinboundrules](docs/Phoneinboundrules.md)
 - [Models.PhoneinboundrulesCreateOrPatch](docs/PhoneinboundrulesCreateOrPatch.md)
 - [Models.Phoneoutboundruleactions](docs/Phoneoutboundruleactions.md)
 - [Models.PhoneoutboundruleactionsCreateOrPatch](docs/PhoneoutboundruleactionsCreateOrPatch.md)
 - [Models.Phoneoutboundrules](docs/Phoneoutboundrules.md)
 - [Models.PhoneoutboundrulesCreateOrPatch](docs/PhoneoutboundrulesCreateOrPatch.md)
 - [Models.Ratecenters](docs/Ratecenters.md)
 - [Models.ResponseDate](docs/ResponseDate.md)
 - [Models.ResponseError](docs/ResponseError.md)
 - [Models.ResponseUsers](docs/ResponseUsers.md)
 - [Models.Servers](docs/Servers.md)
 - [Models.ServersCreateOrPatch](docs/ServersCreateOrPatch.md)
 - [Models.Timeschedules](docs/Timeschedules.md)
 - [Models.TimeschedulesCreateOrPatch](docs/TimeschedulesCreateOrPatch.md)
 - [Models.TimeschedulesSunday](docs/TimeschedulesSunday.md)
 - [Models.TimeschedulesSundaySchedulesInner](docs/TimeschedulesSundaySchedulesInner.md)
 - [Models.Users](docs/Users.md)
 - [Models.UsersCommunication](docs/UsersCommunication.md)
 - [Models.UsersCommunicationNotifications](docs/UsersCommunicationNotifications.md)
 - [Models.UsersCommunicationWeb](docs/UsersCommunicationWeb.md)
 - [Models.UsersCreateOrPatch](docs/UsersCreateOrPatch.md)
 - [Models.Usertokens](docs/Usertokens.md)
 - [Models.UsertokensCreateOrPatch](docs/UsertokensCreateOrPatch.md)
 - [Models.Virtualextensions](docs/Virtualextensions.md)
 - [Models.VirtualextensionsCreateOrPatch](docs/VirtualextensionsCreateOrPatch.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="jwt"></a>
### jwt

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

