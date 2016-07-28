# Overall procedures for using OnDemandManufacturing service (new sibling brand of Quickparts) through APIs.
1. End-user account creation (can be skipped, if it is already created)
2. End-user Authenticate
3. Upload the part files (mesh file format is recommended, because end-user could control the tessellation resolution.)
4. Create Part models corresponding the uploaded
6. Create an empty Quote instance
5. Create LineItem instances corresponding parts into Quote. LineItems is conceptual container to include part information, printing and specification and lead-time requirement.
6. Get the Quote to see the updated such as price
7. Create an Order instance with the shipping methods and additional payment information.

If you are done to the last step, project managers of QP will check the order and assign it to actual facility to produce. If necessary, they will contact the end-user customer.

# PaaS (Printing As A Service)
Though you are likely to use C# SDK rather than call REST API directly, the below information would be helpful to understand how it works inside.

For the developer credential, we are using 3WS (http://stid.dddws.com/) api-user account.
Though all API information is updated at http://paas-working.dddws.com/, there would be missing details. Nevertheless, you can even test with it.
Along the above procedures, you needs to call the following REST APIs.

#### 1. End-user account creation (can be skipped, if it is already created)
```
POST /users (with api_token = API Key of 3WS account)
```
You can get the required options detail and predefined enum via _GET /users/options_ such as _country_id_, _state_id_ and _address_type_id_.
#### 2. End-user Authenticate
```
POST /users/authenticate (with api_token, user email & password)
```
You will get user_token as a response and this user_token needs to be added as query parameters as well as api_token for further request, because all created instances will belong to this end-user.

#### 3. Upload the part files (mesh file format is recommended, because end-user could control the tessellation resolution.)
```
GET /uploads/presign (get the pre-signed URL for uploading end-point.)
```
_upload_id_ in the response will be used for Part creation as _stor_id_.

#### 4. Create Part models corresponding the uploaded
```
POST /parts (with stor_id, name & file size)
```
_part_id_ and analysis result will be in a response.

#### 5. Create an empty Quote instance
```
POST /quotes
```
_quote_id_ will be returned.

#### 6. Create LineItem instances corresponding parts into Quote. LineItems is conceptual container to include part information, printing and specification and lead-time requirement.
```
POST /quotes/{quote_id}/lineitems (with part_id, quantity, build_spec, lead_time_id)
```
Similarly with _/users/options_, you can get the detail possible options via _GET /quotes/options_.

#### 7. Get the Quote to see the updated such as price
```
GET /quotes/{quote_id}
```
You can see the price in a response.

#### 8. Create an Order instance with the shipping methods and additional payment information.
```
POST /orders (with quote_id, addresses, payment, shipping)
```
Similarly with _/users/options_, you can get the detail possible courier options via _GET /order/options_

### Development Environment
Actually we are hosting 3 servers along the development and deployment steps.

1. working (development) - http://paas-working.dddws.com/
2. staging (ready to production and finial QA) - http://paas-staging.dddws.com/
3. production - http://paas.dddws.com/

And you’d better to develop with working environment till your product release, because we don’t have something like sandbox environment for individual developer.

### Tips for Quote Creation with Anonymous User without Authentication
For 3rd party, there is a way to create parts, quote without user login.
With `user_token=none` parameter, you can accomplish this. This special user token is allowed for only 2 methods - `parts#create` and `quotes#create`.

When you request `quotes#create`, the response will include `temporary_user_token` item. For the created quote, you can access with this _temporary_user_token_ in the same way of using normal `user_token`. This _temporary_user_token_ is only valid for the particular quote. This means that you cannot access other quotes and their lineitem or part with this token.

e.g For creating a new lineitem in the quote which is created by anonymous user,
```
POST /quotes?api_token={your api token}&user_token=none
response:
  {
    "quote_id": ...,
    "temporary_user_token": ...,
  }

POST /quotes/{created quote_id}/lineitems?api_token={your api token}&user_token={temporary_user_token} with payload
```
Here is the list of available APIs with the temporary user token.
* `parts#create`, `parts#update`, `parts#update_multiple`
* `quotes#get`, `quotes#update`, `quotes#attachment`
* `lineitems#create`, `lineitems#get`, `lineitems#update`, `lineitems#update_multiple`, `lineitems#delete`, `lineitems#delete_multiple`, `lineitems#copy`, `lineitems#attachment`

As you can see, there is no supported APIs for order creation in the list. For creating order and confirming, either authentication or knwon user-token is required.

# C# SDK
* PaaS SDK is a part of 3WS C# SDK, though it can be used as stand-alone.
* You can download the all source code from https://github.com/workon3d/tws_sdk_windows.
* _TWS_SDK.sln_ consists of 3 projects.

### 1. PaaS
* build C# class library (PaaS.dll) including C# interfaces of the most functionalities described above section (QP PaaS)

### 2. PaaSExample
* PaaSExample project is console application referencing PaaS.dll and showing the basic steps for user authentication, file uploading and create new quote.
* To run sample program correctly, you need to modify some values to use your developer credential and end-user authentication information.
```
\TWS_SDK_CS\PaaSExample\Program.cs
api_token = “your api key from 3WS user account” 
user_email = "end user email";
password = "end user password";
```
And you can create a new customer account for testing. Please visit http://qpe-working.herokuapp.com/ and proceed for Creating an Account. Otherwise, you can try to use SDK interfaces to create new customer.
As a result, you will get URL to reach the created quote on front-end.
The created account will be only valid for working with http://paas-working.dddws.com/, unless you use staging or production.

### 3. TWS_SDK
If you don’t need to handling the cloud file and modeling directly, you don’t have to care about TWS_SDK project.
