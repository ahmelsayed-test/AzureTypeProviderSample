namespace AzureTypeProviderSample

open WebSharper

//type Storage = FSharp.Azure.StorageTypeProvider.AzureTypeProvider<"azuretypeprovidersample", "U8cfZ4au1ISX1aL40eJEJ3sPIWbQI4e7eo08PGPZYwJ6XrqVZYL5y9HVV5NCxYl5le30wViicuiBSE2kZF4k3Q==">

module Remoting =

    [<Remote>]
    let Process input =
        async {
//            let bob = Storage.Tables.CloudTableClient.GetTableReference("Bob")
//            let result = bob.CreateIfNotExists()
//            return "You said: " + input + ", and also bob.CreateIfNotExists() returned " + (result.ToString())
            return "You snaid: " + input
        }
